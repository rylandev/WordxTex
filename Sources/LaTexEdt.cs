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
using WordxTex;
using WordxTex.Properties;

namespace WordxTex
{
    public partial class LaTexEdt : Form
    {
        public string workPath = System.Environment.GetEnvironmentVariable("TEMP") + "\\WordxTex";
        public LaTexEdt(bool BatchMode, string Code, int caretStart, int caretEnd)
        {
            InitializeComponent();
            workPath = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.WordxTex";
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
            logsbox.Clear(); //清空日志框，防溢出
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            string occupied_id = "param_" + Guid.NewGuid().ToString();
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            string workPath = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.WordxTex";
            latex_style_gen(workPath);
            string TexFile = workPath + "\\" + occupied_id + ".tex";
            __texContent = texCodeBox.Text;
            System.Text.UTF8Encoding UTF8Enc = new System.Text.UTF8Encoding(false);
            File.WriteAllText(TexFile, texCodeBox.Text, UTF8Enc); //将tex文件写入到磁盘
            latex_compile(Ribbon.compileInfo, occupied_id); //编译tex
        }
        private void latex_compile(string cp_param, string OccupiedName)
        {
            //命令准备
            string Complier = Ribbon.get_param_value(cp_param, "complier") + ".exe";
            string Grapher = Ribbon.get_param_value(cp_param, "grapher") + ".exe";
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

            if (false == System.IO.Directory.Exists(workPath)) //检测工作目录是否需要创建
                System.IO.Directory.CreateDirectory(workPath);
            latex_style_gen(workPath); //生成自动模板
            //准备命令队列
            WordxTex.wTModule.ProgramQueue CpQueue = new WordxTex.wTModule.ProgramQueue(new string[] { Complier, Grapher }, new string[] { Complier_Args, Grapher_Args });
            CpQueue.RunAll = false; //阻止命令队列自动运行下一个
            ThreadStart thrdstart = new ThreadStart(CpQueue.Run); //使用另一线程运行
            Thread thrd = new Thread(thrdstart);
            CpQueue.ProgramsRunLogStepRs += delegate (object logs, EventArgs evt)
            {
                Control.CheckForIllegalCrossThreadCalls = false; //跨线程操作
                logsbox.Text += "\n" + (string)logs;
                if (logsbox.Text.Length > 5)
                {
                    logsbox.Select(logsbox.Text.Length, logsbox.Text.Length);
                    logsbox.ScrollToCaret();
                }
            };
            CpQueue.ProgramsRunResult += delegate (object reports, EventArgs ev) //接收运行结果
            {
                Control.CheckForIllegalCrossThreadCalls = false; //跨线程操作
                Object[] execReports = (Object[])reports;
                logsbox.Clear();
                for (int i = 0; i < execReports.Length; i++)
                {
                    wTModule.ProgramResult oReport = (wTModule.ProgramResult)execReports[i];
                    //写入日志框
                    int logsBoxCount = logsbox.Text.Length;
                    string programExecParam = "[" + (i + 1).ToString() + "/" + execReports.Length + "] " + oReport.execName + " " + oReport.execArgs;
                    logsbox.Text += programExecParam + "\n";
                    logsbox.Text += oReport.execLogs;
                    if (oReport.exitCode != 0)
                    {
                        //错误运行
                        logsbox.Select(logsBoxCount, programExecParam.Length);
                        logsbox.SelectionColor = Color.Red; //标红
                        btn_gen.Enabled = true;//恢复按钮
                        return; //停止运行
                    }
                    if (logsbox.Text.Length > 5)
                    {
                        logsbox.Select(logsbox.Text.Length, logsbox.Text.Length);
                        logsbox.ScrollToCaret();
                    }
                }
                Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
                //完成运行队列
                int shapePosition = 0;
                InlineShape inDocPic;

                if (ThisDoc.Application.Selection.Type != WdSelectionType.wdSelectionIP)
                {
                    shapePosition = ThisDoc.Application.Selection.Font.Position;
                    ThisDoc.Application.Selection.Delete(); //删除选中 的数据
                }
                if (Ribbon.get_param_value(Ribbon.compileInfo, "grapher") == (string)"dvipng")
                {
                    //dvipng 产出PNG分辨率为72dpi,将生成的png图片转换分辨率
                    string pngvRes = Ribbon.get_param_value(WordxTex.Ribbon.compileInfo, "pngvRes");
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
                    //svg直接插入
                    inDocPic = ThisDoc.InlineShapes.AddPicture(__targetImgFile);
                }
                inDocPic.AlternativeText = __texContent; //写入Tex数据
                inDocPic.Select(); //选择新插入的图片
                ThisDoc.Application.Selection.Font.Position = shapePosition; //基线还原
                if (cb_AutoClose.Checked) //检测自动关闭
                    this.Close();
                btn_gen.Enabled = true; //复原按钮
                return;
            };
            thrd.Start();
        }

        private void LaTexEdt_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            if (false == System.IO.Directory.Exists(workPath))
                System.IO.Directory.CreateDirectory(workPath);
            for (int i = 0; i < Directory.GetFiles(workPath).ToList().Count; i++)
                File.Delete(Directory.GetFiles(workPath)[i]); //清空临时目录
            latex_style_gen(workPath); //生成自动模板
            this.FormClosing += LaTexEdt_FormClosing;
            this.Deactivate += LaTexEdt_Deactivate;
            this.Activated += delegate (object RSender, EventArgs me)
            {
                this.Opacity = 1;
            };
        }

        private void LaTexEdt_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            //throw new NotImplementedException();
        }

        private void LaTexEdt_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Deactivate -= LaTexEdt_Deactivate;
            //throw new NotImplementedException();
        }

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
                fullStyle = fullStyle.Replace("%%WordxTex_Equation_Font_Symbal", Ribbon.texFontStyle); //替换为所选字体样式
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
            Range TexItem = null;
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

        private void logsbox_TextChanged(object sender, EventArgs e)
        {
            logsbox.Select(logsbox.Text.Length, 0);
        }
    }
}
