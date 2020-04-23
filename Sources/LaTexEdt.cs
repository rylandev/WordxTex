using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WordxTex.Properties;

namespace WordxTex
{
    public partial class LaTexEdt : Form
    {
        public string workPath = Ribbon.settingsBox.workPath + "\\WordxTex";
        public LaTexEdt(bool BatchMode, string Code, int caretStart, int caretEnd)
        {
            InitializeComponent();
            if (BatchMode) //批量模式（测试中）
            {
                btn_prvTex.Enabled = true;
                btn_nxtTeX.Enabled = true;
            }
            else
            {
                btn_nxtTeX.Visible = false;
                btn_prvTex.Visible = false;
            }
            this.TopMost = true;
            this.texCodeBox.Text = Code;
            this.Shown += delegate (object sender, EventArgs evt)
            {
                texCodeBox.ActiveTextAreaControl.Caret.Position = texCodeBox.Document.OffsetToPosition(caretStart);
                texCodeBox.ActiveTextAreaControl.SelectionManager.ClearSelection();
                texCodeBox.ActiveTextAreaControl.SelectionManager.SetSelection(
                    new ICSharpCode.TextEditor.Document.DefaultSelection(
                        texCodeBox.Document, texCodeBox.Document.OffsetToPosition(caretStart),
                        texCodeBox.Document.OffsetToPosition(caretEnd)
                        ));
                texCodeBox.Refresh();
                texCodeBox.Focus();
            };
        }
        string __targetImgFile;
        string __texContent = "";
        public Process Rprocess = new Process();//创建进程对象   

        private void btn_gen_Click(object sender, EventArgs e)
        {
            btn_gen.Enabled = false; //防止按多次
            Cursor = Cursors.AppStarting;
            logsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            logsBox.Clear(); //清空日志框，防溢出
            logsBox.ClearUndo();
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            string occupied_id = "param_" + Guid.NewGuid().ToString();
            if (ThisDoc == null || ThisDoc.ReadOnly) return;
            string workPath = Ribbon.settingsBox.workPath + "\\WordxTex";
            latex_style_gen(workPath);
            string TexFile = workPath + "\\" + occupied_id + ".tex";
            __texContent = texCodeBox.Text;
            System.Text.UTF8Encoding UTF8Enc = new System.Text.UTF8Encoding(false);
            File.WriteAllText(TexFile, texCodeBox.Text, UTF8Enc); //将tex文件写入到磁盘
            latex_compile(Ribbon.settingsBox.program_exec_params, occupied_id); //编译tex
        }
        private void latex_compile(string cp_param, string OccupiedName)
        {
            //命令准备
            string Complier = Ribbon.GetFullPath(Ribbon.get_param_value(cp_param, "complier") + ".exe");
            string Grapher = Ribbon.GetFullPath(Ribbon.get_param_value(cp_param, "grapher") + ".exe");
            string TexFile = workPath + "\\" + OccupiedName + ".tex";
            string OutDviFile = workPath + "\\" + OccupiedName + Ribbon.get_param_value(cp_param, "ctarget");
            string OutImgFile = workPath + "\\" + OccupiedName + Ribbon.get_param_value(cp_param, "gtarget");
            __targetImgFile = OutImgFile;
            string Complier_Args = Ribbon.get_param_value(cp_param, "cp_arg");
            string Grapher_Args = Ribbon.get_param_value(cp_param, "gr_arg");
            Complier_Args = Complier_Args.Replace("%%BlankSpace", " ");
            Complier_Args = Complier_Args.Replace("%%InTexFile", TexFile);
            Complier_Args = Complier_Args.Replace("%%OutDir", workPath);
            Complier_Args = Complier_Args.Replace("%%Equal", "=");
            Complier_Args = Complier_Args.Replace("\\", "/");
            Grapher_Args = Grapher_Args.Replace("%%BlankSpace", " ");
            Grapher_Args = Grapher_Args.Replace("%%OutImgFile", OutImgFile);
            Grapher_Args = Grapher_Args.Replace("%%InDviFile", OutDviFile);
            Grapher_Args = Grapher_Args.Replace("%%Equal", "=");
            Grapher_Args = Grapher_Args.Replace("\\", "/");

            if (false == System.IO.Directory.Exists(workPath)) System.IO.Directory.CreateDirectory(workPath); //检测工作目录是否需要创建

            latex_style_gen(workPath); //生成自动模板
            //准备命令队列
            WordxTex.wTModule.ProgramQueue CpQueue = new WordxTex.wTModule.ProgramQueue(
                new string[] { Complier, Grapher },
                new string[] { Complier_Args, Grapher_Args },
                Ribbon.settingsBox.maxRunTimePerProgram);
            ThreadStart thrdstart = new ThreadStart(CpQueue.Run); //使用另一线程运行
            Thread thrd = new Thread(thrdstart);
            CpQueue.ProgramsRunLogStepRs += CpQueue_ProgramsRunLogStepRs;
            CpQueue.ProgramsRunResult += CpQueue_ProgramsRunResult;
            CpQueue.ProgramsRunCmdLine += CpQueue_ProgramsRunCmdLine;
            thrd.Start();
        }

        private void CpQueue_ProgramsRunCmdLine(object pCmdline, EventArgs e)
        {

            if (pCmdline == null) return;
            string oLogs = "";
            try
            {
                oLogs = (string)pCmdline;
            }
            catch (System.NullReferenceException)
            {
                return;
            }
            if (oLogs.Length > 0)
            {
                Control.CheckForIllegalCrossThreadCalls = false; //跨线程操作
                logsBox.AppendText((string)pCmdline);
                logsBox.AppendText("\r\n");
            }
        }

        private void CpQueue_ProgramsRunResult(object reports, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; //跨线程操作
            Object[] execReports = (Object[])reports;
            if (cb_AutoClose.Checked) logsBox.Clear();
            logsBox.AppendText("Runned!\r\n");
            for (int i = 0; i < execReports.Length; i++)
            {
                wTModule.ProgramResult oReport = (wTModule.ProgramResult)execReports[i];
                if (oReport.exitCode != 0)
                {
                    //写入日志框
                    int logsBoxCount = logsBox.Text.Length;
                    string programExecParam = "[" + (i + 1).ToString() + "/" + execReports.Length + "] Error: " + oReport.execName + " " + oReport.execArgs + "\r\n";
                    string programExitCodeParam = "Error With Exit Code: " + oReport.exitCode.ToString() + "\r\n";
                    logsBox.AppendText(programExecParam);
                    logsBox.AppendText(programExitCodeParam);
                    logsBox.AppendText(oReport.execLogs);
                    //错误运行
                    logsBox.Select(logsBoxCount, programExecParam.Length + programExitCodeParam.Length - 4);
                    logsBox.SelectionColor = Color.Red; //标红
                    logsBox.SelectionStart = logsBoxCount;
                    logsBox.ScrollToCaret(); //移动光标到错误位置
                    Cursor = Cursors.Default;
                    btn_gen.Enabled = true;//恢复按钮
                    return; //停止运行
                }
            }
            if (!File.Exists(__targetImgFile))
            {
                for (int i = 0; i < execReports.Length; i++)
                {
                    wTModule.ProgramResult oReport = (wTModule.ProgramResult)execReports[i];
                    //写入日志框
                    int logsBoxCount = logsBox.Text.Length;
                    logsBox.AppendText("[" + (i + 1).ToString() + "/" + execReports.Length + "] Error: " + oReport.execName + " " + oReport.execArgs + "\r\n");
                    logsBox.AppendText("Error With Exit Code: " + oReport.exitCode.ToString() + "\r\n" + oReport.execLogs);
                };
                logsBox.AppendText("Failed! File Not Found: \r\n" + __targetImgFile);
                Cursor = Cursors.Default;
                logsBox.ForeColor = Color.Red; //标红
                btn_gen.Enabled = true;//恢复按钮
                return; //停止运行
            }
            logsBox.Select(logsBox.Text.Length, 0);
            logsBox.ScrollToCaret();
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            //完成运行队列
            int shapePosition = 0;
            InlineShape inDocPic;
            if (ThisDoc.Application.Selection.Type != WdSelectionType.wdSelectionIP)
            {
                shapePosition = ThisDoc.Application.Selection.Font.Position;
                ThisDoc.Application.Selection.Delete(); //删除选中 的数据
            }
            if (Ribbon.get_param_value(Ribbon.settingsBox.program_exec_params, "grapher") == (string)"dvipng")
            {
                //dvipng 产出PNG为72dpi,将生成的png图片转换分辨率
                string pngvRes = Ribbon.get_param_value(Ribbon.settingsBox.program_exec_params, "pngvRes");
                int pngdpi = int.Parse(pngvRes);
                Bitmap bMp = (Bitmap)Image.FromFile(__targetImgFile);
                bMp.SetResolution(pngdpi, pngdpi);
                string R_imgFile = workPath + "\\param" + "_" + pngvRes + ".png";
                bMp.Save(R_imgFile, ImageFormat.Png);
                bMp.Dispose();
                inDocPic = ThisDoc.InlineShapes.AddPicture(R_imgFile);
            }
            else
            {
                inDocPic = ThisDoc.InlineShapes.AddPicture(__targetImgFile);//svg直接插入
            }
            inDocPic.AlternativeText = __texContent; //写入Tex数据
            inDocPic.Select(); //选择新插入的图片
            ThisDoc.Application.Selection.Font.Position = shapePosition; //基线还原
            if (cb_AutoClose.Checked) //检测自动关闭
                this.Close();
            Cursor = Cursors.Default;
            btn_gen.Enabled = true; //复原按钮
            return;
        }

        private void CpQueue_ProgramsRunLogStepRs(object logs, EventArgs e)
        {
            if ((logs == null) || !cb_AutoClose.Checked) return;
            string oLogs = "";
            try
            {
                oLogs = (string)logs;
            }
            catch (System.NullReferenceException)
            {
                return;
            }
            if (oLogs.Length > 0)
            {
                Control.CheckForIllegalCrossThreadCalls = false; //跨线程操作
                logsBox.AppendText("\r\n");
                logsBox.AppendText((string)logs);
            }
        }

        private void LaTexEdt_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            this.FormClosed += ((sndr, ev) => Globals.ThisAddIn.Application.Activate());
            if (false == System.IO.Directory.Exists(workPath))
                System.IO.Directory.CreateDirectory(workPath);
            if (Ribbon.settingsBox.workPathAutoClean)
            {
                try
                {
                    System.Collections.Generic.List<string> FileList = Directory.GetFiles(workPath).ToList();
                    for (int i = 0; i < FileList.ToList().Count; i++) File.Delete(FileList[i]);
                }
                catch (IOException)
                {
                    MessageBox.Show("Some files in " + workPath + " were ocuupied, result may unsatisfy.", "Warning!!");
                };
            }
            latex_style_gen(workPath); //生成自动模板
            this.Deactivate += LaTexEdt_Deactivate;
            this.FormClosing += ((RSender, me) => this.Deactivate -= LaTexEdt_Deactivate);
            this.Activated += ((RSender, me) => this.Opacity = 1);
        }

        private void LaTexEdt_Deactivate(object sender, EventArgs e) => this.Opacity = 0.5;

        private void latex_style_gen(string destDir)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            string TexStyFile = workPath + "\\param.sty"; //自动模板途径
            string colorMode = "rgb";
            string colorParam = "0,0,0";
            switch (ThisDoc.Application.Selection.Font.TextColor.Type)
            {
                case MsoColorType.msoColorTypeRGB:
                    System.Drawing.Color unCorcSelectedColor = System.Drawing.Color.FromArgb(ThisDoc.Application.Selection.Font.TextColor.RGB);
                    System.Drawing.Color selectedColor = System.Drawing.Color.FromArgb(unCorcSelectedColor.B, unCorcSelectedColor.G, unCorcSelectedColor.R);
                    colorMode = "rgb";
                    colorParam =
                        selectedColor.R.ToString() + "," +
                        selectedColor.G.ToString() + "," +
                        selectedColor.B.ToString();
                    break;
                case MsoColorType.msoColorTypeScheme:
                    colorMode = "gray";
                    colorParam = "0";
                    if (ThisDoc.Application.Selection.Font.TextColor.Brightness >= 0 && ThisDoc.Application.Selection.Font.TextColor.Brightness <= 1)
                        colorParam = ThisDoc.Application.Selection.Font.TextColor.Brightness.ToString();
                    break;
                case MsoColorType.msoColorTypeCMYK:
                    colorMode = "cmyk";
                    colorParam =
                    ThisDoc.Application.Selection.Font.TextColor.Cyan.ToString() + "," +
                    ThisDoc.Application.Selection.Font.TextColor.Yellow.ToString() + "," +
                    ThisDoc.Application.Selection.Font.TextColor.Magenta.ToString() + "," +
                    ThisDoc.Application.Selection.Font.TextColor.Black.ToString();
                    break;

                default:
                    break;
            }

            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            using (FileStream fs = new FileStream(TexStyFile, FileMode.Create))
            {
                string fullStyle = Resources.tex_fontsize_style;
                string texFontSize = ThisDoc.Application.Selection.Font.Size.ToString(); //当前应用设置的字体大小
                fullStyle = fullStyle.Replace("%%WordxTex_Font_Symbol", texFontSize); //将模板内的通配符替换为字体大小
                fullStyle = fullStyle.Replace("%%WordxTex_Equation_Font_Symbal", Ribbon.settingsBox.fontFx); //替换为所选字体样式
                fullStyle = fullStyle.Replace("%%cMode", colorMode);
                fullStyle = fullStyle.Replace("%%cParam", colorParam);
                byte[] TexContent = System.Text.Encoding.Default.GetBytes(fullStyle);
                fs.Write(TexContent, 0, TexContent.Length); //写入style文件
                fs.Flush();
                fs.Close();
            };
        }
        //批量模式按钮 VVV
        private void btn_nxtTeX_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            Microsoft.Office.Interop.Word.Range TexItem = null;
            ThisDoc.Application.Selection.SetRange(ThisDoc.Application.Selection.Start, ThisDoc.Application.Selection.End + 1);
            TexItem = ThisDoc.Application.Selection.GoToNext(WdGoToItem.wdGoToGraphic);
            TexItem.SetRange(TexItem.Start, TexItem.End + 1);
            TexItem.Select();
            InlineShapes SelectedObj = ThisDoc.Application.Selection.InlineShapes;
            InlineShape SelectedObjFirst = SelectedObj[1];
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            if (SelectedObj.Count == 0)
                return;
            if (!SelectedObjFirst.AlternativeText.Contains("WordxTex_TexContent"))
                return;
            texCodeBox.Clear();
            texCodeBox.Text = SelectedObjFirst.AlternativeText;
        }

        private void btn_prvTex_Click(object sender, EventArgs e)
        {

        }

        private void logsBox_TextChanged(object sender, EventArgs e)
        {
            logsBox.Select(logsBox.Text.Length, 0);
        }


    }
}
