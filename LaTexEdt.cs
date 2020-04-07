using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordxTex.Properties;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;
using ICSharpCode.TextEditor;
using System.Drawing;
using System.Drawing.Imaging;

namespace WordxTex
{
    public partial class LaTexEdt : Form
    {
        public LaTexEdt()
        {
            InitializeComponent();
        }
        public Process Rprocess = new Process();//创建进程对象   
        public int StartProcess(string runFilePath, string args)
        {
            args = args.Trim();
            ProcessStartInfo startInfo = new ProcessStartInfo(runFilePath, args); // 括号里是(程序名,参数)
            Rprocess.StartInfo = startInfo;
            if (Rprocess.Start() == false)
                return -1;
            Rprocess.WaitForExit();
            return Rprocess.ExitCode;
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            string occupied_id = "param";
            if (ThisDoc == null || ThisDoc.ReadOnly)
                return;
            Process_Timer.Start();
            string tempDir = System.Environment.GetEnvironmentVariable("TEMP") + "\\WordxTex";
            latex_style_gen(tempDir);
            string imgFile = latex_compile(WordxTex.Ribbon.Compile_Info, texCodeBox.Text, tempDir, occupied_id);
            if (imgFile.Length == 0)
                return;
            if (ThisDoc.Application.Selection.Type != WdSelectionType.wdSelectionIP)
                ThisDoc.Application.Selection.Delete();
            InlineShape inDocPic;
            if (Ribbon.get_param_value(WordxTex.Ribbon.Compile_Info, "grapher") == (string)"dvipng")
            {
                string pngvRes = Ribbon.get_param_value(WordxTex.Ribbon.Compile_Info, "pngvRes");
                //Image pngDocLocal = Image.FromFile(imgFile);
                //float docAwidth = pngDocLocal.Width / float.Parse(pngvRes);
                //float docAheight = pngDocLocal.Height / float.Parse(pngvRes);
                int pngdpi = int.Parse(pngvRes);
                //inDocPic.Width = 72 * docAwidth;
                //inDocPic.Height = 72 * docAheight;
                //pngDocLocal.Dispose();
                Bitmap bMp = (Bitmap)Image.FromFile(imgFile);
                bMp.SetResolution(pngdpi, pngdpi);
                string R_imgFile = tempDir + "\\" + occupied_id + "_" + pngvRes + ".png";
                bMp.Save(R_imgFile, ImageFormat.Png);
                bMp.Dispose();
                inDocPic = ThisDoc.InlineShapes.AddPicture(R_imgFile);
            }
            else
            {
                inDocPic = ThisDoc.InlineShapes.AddPicture(imgFile);
            }
            inDocPic.AlternativeText = texCodeBox.Text;
            inDocPic.Select();
            //ThisDoc.Application.Mo
            this.Close();
        }
        private string latex_compile(string cp_param, string texContent, string WkDir, string OccupiedName)
        {
            //string TexFile = tempDir + "\\param.tex";
            string Complier = Ribbon.get_param_value(cp_param, "complier") + ".exe";
            string Grapher = Ribbon.get_param_value(cp_param, "grapher") + ".exe";
            string TexFile = WkDir + "\\" + OccupiedName + ".tex";
            string OutDviFile = WkDir + "\\" + OccupiedName + Ribbon.get_param_value(cp_param, "ctarget");
            string OutImgFile = WkDir + "\\" + OccupiedName + Ribbon.get_param_value(cp_param, "gtarget");
            string Complier_Args = Ribbon.get_param_value(cp_param, "cp_arg");
            string Grapher_Args = Ribbon.get_param_value(cp_param, "gr_arg");
            Grapher_Args = Grapher_Args.Replace("%%BlankSpace", " ");
            Complier_Args = Complier_Args.Replace("%%BlankSpace", " ");
            Complier_Args = Complier_Args.Replace("%%InTexFile", TexFile);
            Complier_Args = Complier_Args.Replace("%%OutDir", WkDir);
            Complier_Args = Complier_Args.Replace("%%Equal", "=");
            Grapher_Args = Grapher_Args.Replace("%%OutImgFile", OutImgFile);
            Grapher_Args = Grapher_Args.Replace("%%InDviFile", OutDviFile);
            Grapher_Args = Grapher_Args.Replace("%%Equal", "=");

            if (false == System.IO.Directory.Exists(WkDir))
                System.IO.Directory.CreateDirectory(WkDir);
            FileStream fs = new FileStream(TexFile, FileMode.Create);
            byte[] byTexContent = System.Text.Encoding.Default.GetBytes(texContent);
            fs.Write(byTexContent, 0, byTexContent.Length);
            //srcBox.Text = TexFile;
            fs.Flush();
            fs.Close();
            if (StartProcess(Complier, Complier_Args) != 0)
            {
                MessageBox.Show("Log:" + WkDir + "\\param.log", "ERROR!!!");
                return "";
            }
            StartProcess(Grapher, Grapher_Args);
            if (Rprocess.HasExited)
                Process_Timer.Stop();
            return OutImgFile;
        }

        private void srcBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaTexEdt_Load(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            box_run_max_time.Value = Process_Timer.Interval / 1000;
            string tempDir = System.Environment.GetEnvironmentVariable("TEMP") + "\\WordxTex";
            for (int i = 0; i < Directory.GetFiles(tempDir).ToList().Count; i++)
                File.Delete(Directory.GetFiles(tempDir)[i]);
            if (false == System.IO.Directory.Exists(tempDir))
                System.IO.Directory.CreateDirectory(tempDir);
            latex_style_gen(tempDir);
        }

        private void latex_style_gen(string destDir)
        {
            Microsoft.Office.Interop.Word.Document ThisDoc = Globals.ThisAddIn.Application.ActiveDocument;
            string TexStyFile = destDir + "\\param.sty";
            FileStream fs = new FileStream(TexStyFile, FileMode.Create);
            string FullStyle = Resources.tex_fontsize_style;
            string FontSize = ThisDoc.Application.Selection.Font.Size.ToString();
            FullStyle = FullStyle.Replace("%%WordxTex_Font_Symbol", FontSize);
            FullStyle = FullStyle.Replace("%%WordxTex_Equation_Font_Symbal", WordxTex.Ribbon.Box_Font_Fx);
            byte[] TexContent = System.Text.Encoding.Default.GetBytes(FullStyle);
            fs.Write(TexContent, 0, TexContent.Length);
            //srcBox.Text = TexFile;
            fs.Flush();
            fs.Close();
        }

        private void Process_Timer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("iii");
            Process_Timer.Stop();
            if (Rprocess.HasExited)
                return;
            Rprocess.Kill();
            //MessageBox.Show("Log:" + WkDir + "\\param.log", "ERROR!!!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void box_run_max_time_ValueChanged(object sender, EventArgs e)
        {
            Process_Timer.Interval = (int)box_run_max_time.Value * 1000;
        }
    }
}
