using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WordxTex
{
    public partial class SettingsForm : Form
    {
        // 配置文件写操作函数 WritePrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        // 配置文件读操作函数 GetPrivateProfileString()
        [System.Runtime.InteropServices.DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal, int size, string filePath);

        System.Text.StringBuilder tempIniValue = new System.Text.StringBuilder(255);

        string iniFile = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.WordxTex.ini";

        public event EventHandler generChangeEventHandler;
        public event EventHandler maxRunTimePerProgramChangeEventHandler;
        public event EventHandler showLabelOptionChangeEventHandler;

        public SettingsForm()
        {
            InitializeComponent();
            string tmpPath = System.Environment.GetEnvironmentVariable("TEMP");
            //防止终止该窗口
            this.FormClosing += delegate (object sender, FormClosingEventArgs e)
            {
                e.Cancel = true;
                this.Hide();
            };
            //防止EventHandle返回null
            generChangeEventHandler += delegate (object tmpo, EventArgs tmpe) { };
            maxRunTimePerProgramChangeEventHandler += delegate (object tmpo, EventArgs tmpe) { };
            showLabelOptionChangeEventHandler += delegate (object tmpo, EventArgs tmpe) { };
            //读出配置文件
            try
            {
                GetPrivateProfileString("Debugging", "debugMode", "", tempIniValue, 255, iniFile);
                if ((tempIniValue.Length != 0) && (bool.Parse(tempIniValue.ToString())) == true)
                {
                    ComboTreeNode comboTreeNodeCpTest = new ComboTreeNode();
                    comboTreeNodeCpTest.Expanded = false;
                    comboTreeNodeCpTest.ForeColor = System.Drawing.Color.Empty;
                    comboTreeNodeCpTest.Name = "winver_test";
                    comboTreeNodeCpTest.Text = "winver_test";
                    comboTreeNodeCpTest.Tag = "complier=winver;cp_arg=;ctarget=.xdv;ctip=.tex->.xdv";
                    comboTreeNodeCpTest.ToolTip = null;
                    ComboTreeNode comboTreeNodeGrTest = new ComboTreeNode();
                    comboTreeNodeGrTest.Expanded = false;
                    comboTreeNodeGrTest.ForeColor = System.Drawing.Color.Empty;
                    comboTreeNodeGrTest.Name = "grapher_tmpe";
                    comboTreeNodeGrTest.Text = "grapher_tmpe";
                    comboTreeNodeGrTest.Tag = "grapher=winver;gr_arg=;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
                    comboTreeNodeGrTest.ToolTip = null;
                    ctb_compiler.Nodes.Add(comboTreeNodeCpTest);
                    ctb_graphbox.Nodes.Add(comboTreeNodeGrTest);
                }
                else
                {
                    WritePrivateProfileString("Debugging", "debugMode", "False", iniFile);
                }
                GetPrivateProfileString("Gener", "Complier", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    ctb_compiler.Path = tempIniValue.ToString();
                GetPrivateProfileString("Gener", "Grapher", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    ctb_graphbox.Path = tempIniValue.ToString();
                GetPrivateProfileString("Style", "Font", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    cb_fonts.Path = tempIniValue.ToString();
                GetPrivateProfileString("Option", "autoClean", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    ckb_autoclean.Checked = bool.Parse(tempIniValue.ToString());
                GetPrivateProfileString("Option", "showLabel", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    chb_show_fl.Checked = bool.Parse(tempIniValue.ToString());
                GetPrivateProfileString("Option", "workPath", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1 && Directory.Exists(tempIniValue.ToString()))
                {
                    tb_wkdir.Text = tempIniValue.ToString();
                }

                GetPrivateProfileString("Gener", "Time", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    sb_execPerPrgTime.Value = int.Parse(tempIniValue.ToString());
            }
            catch (ArgumentException)
            {
                //配置文件出错则删除配置文件
                if (File.Exists(iniFile))
                    File.Delete(iniFile);
            }
        }
        public bool showLabel => chb_show_fl.Checked;
        public string workPath => tb_wkdir.Text;
        public bool workPathAutoClean => ckb_autoclean.Checked;
        public int maxRunTimePerProgram => Convert.ToInt32(sb_execPerPrgTime.Value);
        public string fontFx => (string)cb_fonts.SelectedNode.Tag;
        public string program_exec_params => (string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag;
        private void SettingsBox_Load(object sender, EventArgs e)
        {
            ctb_compiler.SelectedNodeChanged += ctb_gener_SelectedNodeChanged;
            ctb_graphbox.SelectedNodeChanged += ctb_gener_SelectedNodeChanged;
            generChangeEventHandler((string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag, new EventArgs());
        }
        private void ctb_gener_SelectedNodeChanged(object sender, EventArgs e)
        {
            generChangeEventHandler((string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag, new EventArgs());
            WritePrivateProfileString("Gener", "Complier", ctb_compiler.Path, iniFile);
            WritePrivateProfileString("Gener", "Grapher", ctb_graphbox.Path, iniFile);
        }

        private void btn_hide_Click(object sender, EventArgs e) => this.Hide();

        private void chb_show_fl_CheckedChanged(object sender, EventArgs e)
        {
            showLabelOptionChangeEventHandler(chb_show_fl.Checked, new EventArgs());
            WritePrivateProfileString("Option", "showLabel", chb_show_fl.Checked.ToString(), iniFile);
        }

        private void cb_fonts_Change(object sender, EventArgs e) => WritePrivateProfileString("Style", "Font", cb_fonts.Path, iniFile);

        private void sb_execPerPrgTime_ValueChanged(object sender, EventArgs e)
        {
            maxRunTimePerProgramChangeEventHandler(sb_execPerPrgTime.Value, new EventArgs());
            WritePrivateProfileString("Gener", "Time", sb_execPerPrgTime.Value.ToString(), iniFile);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(tb_wkdir.Text))
                WritePrivateProfileString("Option", "workPath", tb_wkdir.Text, iniFile);
        }

        private void ckb_autoclean_CheckedChanged(object sender, EventArgs e)
        {
            WritePrivateProfileString("Option", "autoClean", ckb_autoclean.Checked.ToString(), iniFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DirSelectDialog.Reset();
            DirSelectDialog.SelectedPath = tb_wkdir.Text;
            DirSelectDialog.ShowDialog();
            if (DirSelectDialog.SelectedPath.Length > 0)
                tb_wkdir.Text = DirSelectDialog.SelectedPath;
        }

        private void btn_clean_cache_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all files in: " + tb_wkdir.Text + "\\WordxTex", "confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    System.Collections.Generic.List<string> FileList = Directory.GetFiles(tb_wkdir.Text + "\\WordxTex").ToList();
                    for (int i = 0; i < FileList.ToList().Count; i++) File.Delete(FileList[i]);
                }
                catch (IOException)
                {
                    MessageBox.Show("Some files in " + workPath + " were ocuupied, result may unsatisfy.", "Warning!!");
                };
            }
        }

        private void ctb_compiler_Click(object sender, EventArgs e)
        {

        }
    }
}
