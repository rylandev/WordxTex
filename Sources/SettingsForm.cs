using System;
using System.IO;
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
                GetPrivateProfileString("Gener", "Complier", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    ctb_compiler.Path = tempIniValue.ToString();
                GetPrivateProfileString("Gener", "Grapher", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    ctb_graphbox.Path = tempIniValue.ToString();
                GetPrivateProfileString("Style", "Font", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    cb_fonts.Path = tempIniValue.ToString();
                GetPrivateProfileString("Option", "showLabel", "", tempIniValue, 255, iniFile);
                if (tempIniValue.ToString().Length > 1)
                    chb_show_fl.Checked = bool.Parse(tempIniValue.ToString());
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
        public int maxRunTimePerProgram => Convert.ToInt32(sb_execPerPrgTime.Value);
        public string fontFx => (string)cb_fonts.SelectedNode.Tag;
        public string program_exec_params => (string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag;
        private void SettingsBox_Load(object sender, EventArgs e)
        {
            try
            {
                GetPrivateProfileString("Debugging", "DebugMode", "", tempIniValue, 255, iniFile);
                if (bool.Parse(tempIniValue.ToString()) == true)
                {
                    ComboTreeNode comboTreeNode25 = new ComboTreeNode();
                    comboTreeNode25.Expanded = false;
                    comboTreeNode25.ForeColor = System.Drawing.Color.Empty;
                    comboTreeNode25.Name = "winver_test";
                    comboTreeNode25.Text = "winver_test";
                    comboTreeNode25.Tag = "complier=winver;cp_arg=;ctarget=.xdv;ctip=.tex->.xdv";
                    comboTreeNode25.ToolTip = null;
                    ComboTreeNode comboTreeNode31 = new ComboTreeNode();
                    comboTreeNode31.Expanded = false;
                    comboTreeNode31.ForeColor = System.Drawing.Color.Empty;
                    comboTreeNode31.Name = "grapher_tmpe";
                    comboTreeNode31.Text = "grapher_tmpe";
                    comboTreeNode31.Tag = "grapher=winver;gr_arg=;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
                    comboTreeNode31.ToolTip = null;
                    ctb_compiler.Nodes.Add(comboTreeNode25);
                    ctb_graphbox.Nodes.Add(comboTreeNode31);
                }
                else
                {
                    WritePrivateProfileString("Debugging", "DebugMode", "False", iniFile);
                }
            }
            catch (ArgumentException)
            {
                //配置文件出错则删除配置文件
                if (File.Exists(iniFile))
                    File.Delete(iniFile);
            }
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
    }
}
