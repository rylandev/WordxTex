namespace WordxTex
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboTreeNode comboTreeNode1 = new ComboTreeNode();
            ComboTreeNode comboTreeNode2 = new ComboTreeNode();
            ComboTreeNode comboTreeNode3 = new ComboTreeNode();
            ComboTreeNode comboTreeNode4 = new ComboTreeNode();
            ComboTreeNode comboTreeNode5 = new ComboTreeNode();
            ComboTreeNode comboTreeNode6 = new ComboTreeNode();
            ComboTreeNode comboTreeNode7 = new ComboTreeNode();
            ComboTreeNode comboTreeNode8 = new ComboTreeNode();
            ComboTreeNode comboTreeNode9 = new ComboTreeNode();
            ComboTreeNode comboTreeNode10 = new ComboTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            ComboTreeNode comboTreeNode11 = new ComboTreeNode();
            ComboTreeNode comboTreeNode12 = new ComboTreeNode();
            ComboTreeNode comboTreeNode13 = new ComboTreeNode();
            ComboTreeNode comboTreeNode14 = new ComboTreeNode();
            ComboTreeNode comboTreeNode15 = new ComboTreeNode();
            ComboTreeNode comboTreeNode16 = new ComboTreeNode();
            ComboTreeNode comboTreeNode17 = new ComboTreeNode();
            ComboTreeNode comboTreeNode18 = new ComboTreeNode();
            ComboTreeNode comboTreeNode19 = new ComboTreeNode();
            this.ctb_compiler = new ComboTreeBox();
            this.ctb_graphbox = new ComboTreeBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.chb_show_fl = new System.Windows.Forms.CheckBox();
            this.cb_fonts = new ComboTreeBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctb_compiler
            // 
            this.ctb_compiler.DroppedDown = false;
            this.ctb_compiler.Location = new System.Drawing.Point(63, 12);
            this.ctb_compiler.Name = "ctb_compiler";
            comboTreeNode1.Expanded = true;
            comboTreeNode1.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode1.Name = "xeLaTeX";
            comboTreeNode2.Expanded = false;
            comboTreeNode2.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode2.Name = "->.xdv";
            comboTreeNode2.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-no-pdf%%BlankS" +
    "pace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.xdv;ctip=.t" +
    "ex->.xdv";
            comboTreeNode2.Text = ".tex-xeLaTeX->.xdv";
            comboTreeNode2.ToolTip = null;
            comboTreeNode3.Expanded = false;
            comboTreeNode3.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode3.Name = "->.pdf";
            comboTreeNode3.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace%%BlankSpace-ou" +
    "tput-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.pdf;ctip=.tex->.pd" +
    "f";
            comboTreeNode3.Text = ".tex-xeLaTeX->.pdf";
            comboTreeNode3.ToolTip = null;
            comboTreeNode1.Nodes.Add(comboTreeNode2);
            comboTreeNode1.Nodes.Add(comboTreeNode3);
            comboTreeNode1.Selectable = false;
            comboTreeNode1.Tag = null;
            comboTreeNode1.Text = "xeLaTeX";
            comboTreeNode1.ToolTip = null;
            comboTreeNode4.Expanded = true;
            comboTreeNode4.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode4.Name = "LaTeX";
            comboTreeNode5.Expanded = false;
            comboTreeNode5.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode5.Name = "->.dvi";
            comboTreeNode5.Tag = "complier=latex;cp_arg=-output-format%%Equaldvi%%BlankSpace-output-directory%%Equa" +
    "l%%OutDir%%BlankSpace%%InTexFile;ctarget=.dvi;ctip=.tex->.dvi";
            comboTreeNode5.Text = ".tex-LaTeX->.dvi";
            comboTreeNode5.ToolTip = null;
            comboTreeNode4.Nodes.Add(comboTreeNode5);
            comboTreeNode4.Selectable = false;
            comboTreeNode4.Tag = null;
            comboTreeNode4.Text = "LaTeX";
            comboTreeNode4.ToolTip = null;
            this.ctb_compiler.Nodes.Add(comboTreeNode1);
            this.ctb_compiler.Nodes.Add(comboTreeNode4);
            this.ctb_compiler.Path = "xeLaTeX\\.tex-xeLaTeX->.xdv";
            this.ctb_compiler.SelectedNode = comboTreeNode2;
            this.ctb_compiler.Size = new System.Drawing.Size(209, 23);
            this.ctb_compiler.TabIndex = 0;
            // 
            // ctb_graphbox
            // 
            this.ctb_graphbox.DroppedDown = false;
            this.ctb_graphbox.Location = new System.Drawing.Point(63, 41);
            this.ctb_graphbox.Name = "ctb_graphbox";
            comboTreeNode6.Expanded = true;
            comboTreeNode6.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode6.Name = "dvisvgm";
            comboTreeNode7.Expanded = false;
            comboTreeNode7.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode7.Name = "[.dvi,.xdv]->.svg";
            comboTreeNode7.Tag = "grapher=dvisvgm;gr_arg=--output%%Equal%%OutImgFile%%BlankSpace-n%%BlankSpace%%InD" +
    "viFile;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
            comboTreeNode7.Text = "[.dvi,.xdv]-dvisvgm->.svg";
            comboTreeNode7.ToolTip = null;
            comboTreeNode8.Expanded = false;
            comboTreeNode8.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode8.Name = ".pdf->.svg";
            comboTreeNode8.Tag = "grapher=dvisvgm;gr_arg=--pdf%%BlankSpace--output%%Equal%%OutImgFile%%BlankSpace-n" +
    "%%BlankSpace%%InDviFile;gtarget=.svg;gaccept=.pdf;gtip=->.svg";
            comboTreeNode8.Text = ".pdf-dvisvgm->.svg";
            comboTreeNode8.ToolTip = null;
            comboTreeNode6.Nodes.Add(comboTreeNode7);
            comboTreeNode6.Nodes.Add(comboTreeNode8);
            comboTreeNode6.Selectable = false;
            comboTreeNode6.Tag = null;
            comboTreeNode6.Text = "dvisvgm";
            comboTreeNode6.ToolTip = null;
            comboTreeNode9.Expanded = true;
            comboTreeNode9.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode9.Name = "dvipng";
            comboTreeNode10.Expanded = false;
            comboTreeNode10.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode10.Name = ".dvi-dvipng->(300dpi).png";
            comboTreeNode10.Tag = resources.GetString("comboTreeNode10.Tag");
            comboTreeNode10.Text = ".dvi-dvipng->(300dpi).png";
            comboTreeNode10.ToolTip = null;
            comboTreeNode11.Expanded = false;
            comboTreeNode11.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode11.Name = ".dvi-dvipng->(600dpi).png";
            comboTreeNode11.Tag = resources.GetString("comboTreeNode11.Tag");
            comboTreeNode11.Text = ".dvi-dvipng->(600dpi).png";
            comboTreeNode11.ToolTip = null;
            comboTreeNode12.Expanded = false;
            comboTreeNode12.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode12.Name = ".dvi-dvipng->(900dpi).png";
            comboTreeNode12.Tag = resources.GetString("comboTreeNode12.Tag");
            comboTreeNode12.Text = ".dvi-dvipng->(900dpi).png";
            comboTreeNode12.ToolTip = null;
            comboTreeNode13.Expanded = false;
            comboTreeNode13.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode13.Name = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode13.Tag = resources.GetString("comboTreeNode13.Tag");
            comboTreeNode13.Text = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode13.ToolTip = null;
            comboTreeNode14.Expanded = false;
            comboTreeNode14.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode14.Name = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode14.Tag = resources.GetString("comboTreeNode14.Tag");
            comboTreeNode14.Text = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode14.ToolTip = null;
            comboTreeNode9.Nodes.Add(comboTreeNode10);
            comboTreeNode9.Nodes.Add(comboTreeNode11);
            comboTreeNode9.Nodes.Add(comboTreeNode12);
            comboTreeNode9.Nodes.Add(comboTreeNode13);
            comboTreeNode9.Nodes.Add(comboTreeNode14);
            comboTreeNode9.Selectable = false;
            comboTreeNode9.Tag = null;
            comboTreeNode9.Text = "dvipng";
            comboTreeNode9.ToolTip = null;
            this.ctb_graphbox.Nodes.Add(comboTreeNode6);
            this.ctb_graphbox.Nodes.Add(comboTreeNode9);
            this.ctb_graphbox.Path = "dvisvgm\\[.dvi,.xdv]-dvisvgm->.svg";
            this.ctb_graphbox.SelectedNode = comboTreeNode7;
            this.ctb_graphbox.Size = new System.Drawing.Size(209, 23);
            this.ctb_graphbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compile:";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(197, 126);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(75, 23);
            this.btn_hide.TabIndex = 4;
            this.btn_hide.Text = "hide";
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // chb_show_fl
            // 
            this.chb_show_fl.AutoSize = true;
            this.chb_show_fl.Location = new System.Drawing.Point(9, 106);
            this.chb_show_fl.Name = "chb_show_fl";
            this.chb_show_fl.Size = new System.Drawing.Size(138, 16);
            this.chb_show_fl.TabIndex = 5;
            this.chb_show_fl.Text = "Show function label";
            this.chb_show_fl.UseVisualStyleBackColor = true;
            this.chb_show_fl.CheckedChanged += new System.EventHandler(this.chb_show_fl_CheckedChanged);
            // 
            // cb_fonts
            // 
            this.cb_fonts.DroppedDown = false;
            this.cb_fonts.Location = new System.Drawing.Point(63, 77);
            this.cb_fonts.Name = "cb_fonts";
            comboTreeNode15.Expanded = false;
            comboTreeNode15.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode15.Name = "default";
            comboTreeNode15.Tag = "%%default";
            comboTreeNode15.Text = "default";
            comboTreeNode15.ToolTip = null;
            comboTreeNode16.Expanded = false;
            comboTreeNode16.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode16.Name = "txfonts";
            comboTreeNode16.Tag = "\\usepackage{txfonts}";
            comboTreeNode16.Text = "txfonts";
            comboTreeNode16.ToolTip = "\\usepackage{txfonts}";
            comboTreeNode17.Expanded = false;
            comboTreeNode17.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode17.Name = "fourier";
            comboTreeNode17.Tag = "\\usepackage{fourier}";
            comboTreeNode17.Text = "fourier";
            comboTreeNode17.ToolTip = "\\usepackage{fourier}";
            comboTreeNode18.Expanded = false;
            comboTreeNode18.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode18.Name = "mathptmx";
            comboTreeNode18.Tag = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode18.Text = "mathptmx";
            comboTreeNode18.ToolTip = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode19.Expanded = false;
            comboTreeNode19.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode19.Name = "charter";
            comboTreeNode19.Tag = "\\usepackage[charter]{mathdesign}";
            comboTreeNode19.Text = "charter";
            comboTreeNode19.ToolTip = "\\usepackage[charter]{mathdesign}";
            this.cb_fonts.Nodes.Add(comboTreeNode15);
            this.cb_fonts.Nodes.Add(comboTreeNode16);
            this.cb_fonts.Nodes.Add(comboTreeNode17);
            this.cb_fonts.Nodes.Add(comboTreeNode18);
            this.cb_fonts.Nodes.Add(comboTreeNode19);
            this.cb_fonts.Path = "default";
            this.cb_fonts.SelectedNode = comboTreeNode15;
            this.cb_fonts.Size = new System.Drawing.Size(209, 23);
            this.cb_fonts.TabIndex = 6;
            this.cb_fonts.SelectedNodeChanged += new System.EventHandler(this.cb_fonts_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fonts:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_fonts);
            this.Controls.Add(this.chb_show_fl);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctb_graphbox);
            this.Controls.Add(this.ctb_compiler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "WordxTex - Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private ComboTreeBox ctb_compiler;
        private ComboTreeBox ctb_graphbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.CheckBox chb_show_fl;
        private ComboTreeBox cb_fonts;
        private System.Windows.Forms.Label label3;
    }
}