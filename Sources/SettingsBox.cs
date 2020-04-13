using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordxTex
{
    public partial class SettingsBox : Form
    {
        public event EventHandler GenerChange;
        public event EventHandler showLableChange;
        public event EventHandler fontFxChange;
        public SettingsBox()
        {
            InitializeComponent();
        }
        public bool showLable
        {
            get { return chb_show_fl.Checked; }
        }
        public string fontFx
        {
            get { return (string)cb_fonts.SelectedNode.Tag; }
        }
        public string program_exec_params
        {
            get { return (string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag; }
        }
        private void SettingsBox_Load(object sender, EventArgs e)
        {
            ctb_compiler.SelectedNodeChanged += Ctb_gener_SelectedNodeChanged;
            ctb_graphbox.SelectedNodeChanged += Ctb_gener_SelectedNodeChanged;
            GenerChange((string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag, new EventArgs());

        }
        private void Ctb_gener_SelectedNodeChanged(object sender, EventArgs e)
        {
            GenerChange((string)ctb_compiler.SelectedNode.Tag + ";" + (string)ctb_graphbox.SelectedNode.Tag, new EventArgs());
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chb_show_fl_CheckedChanged(object sender, EventArgs e)
        {
            showLableChange(chb_show_fl.Checked, new EventArgs());
        }

        private void cb_fonts_Change(object sender, EventArgs e)
        {
            fontFxChange((string)cb_fonts.SelectedNode.Tag, new EventArgs());
        }
    }
}
