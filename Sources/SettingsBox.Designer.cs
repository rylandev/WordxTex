namespace WordxTex
{
    partial class SettingsBox
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
            ComboTreeNode comboTreeNode20 = new ComboTreeNode();
            ComboTreeNode comboTreeNode21 = new ComboTreeNode();
            ComboTreeNode comboTreeNode22 = new ComboTreeNode();
            ComboTreeNode comboTreeNode23 = new ComboTreeNode();
            ComboTreeNode comboTreeNode24 = new ComboTreeNode();
            ComboTreeNode comboTreeNode25 = new ComboTreeNode();
            ComboTreeNode comboTreeNode26 = new ComboTreeNode();
            ComboTreeNode comboTreeNode27 = new ComboTreeNode();
            ComboTreeNode comboTreeNode28 = new ComboTreeNode();
            ComboTreeNode comboTreeNode29 = new ComboTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsBox));
            ComboTreeNode comboTreeNode30 = new ComboTreeNode();
            ComboTreeNode comboTreeNode31 = new ComboTreeNode();
            ComboTreeNode comboTreeNode32 = new ComboTreeNode();
            ComboTreeNode comboTreeNode33 = new ComboTreeNode();
            ComboTreeNode comboTreeNode34 = new ComboTreeNode();
            ComboTreeNode comboTreeNode35 = new ComboTreeNode();
            ComboTreeNode comboTreeNode36 = new ComboTreeNode();
            ComboTreeNode comboTreeNode37 = new ComboTreeNode();
            ComboTreeNode comboTreeNode38 = new ComboTreeNode();
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
            this.ctb_compiler.Location = new System.Drawing.Point(66, 12);
            this.ctb_compiler.Name = "ctb_compiler";
            comboTreeNode20.Expanded = true;
            comboTreeNode20.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode20.Name = "xeLaTeX";
            comboTreeNode21.Expanded = false;
            comboTreeNode21.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode21.Name = "->.xdv";
            comboTreeNode21.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-no-pdf%%BlankS" +
    "pace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.xdv;ctip=.t" +
    "ex->.xdv";
            comboTreeNode21.Text = ".tex-xeLaTeX->.xdv";
            comboTreeNode21.ToolTip = null;
            comboTreeNode22.Expanded = false;
            comboTreeNode22.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode22.Name = "->.pdf";
            comboTreeNode22.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace%%BlankSpace-ou" +
    "tput-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.pdf;ctip=.tex->.pd" +
    "f";
            comboTreeNode22.Text = ".tex-xeLaTeX->.pdf";
            comboTreeNode22.ToolTip = null;
            comboTreeNode20.Nodes.Add(comboTreeNode21);
            comboTreeNode20.Nodes.Add(comboTreeNode22);
            comboTreeNode20.Selectable = false;
            comboTreeNode20.Tag = null;
            comboTreeNode20.Text = "xeLaTeX";
            comboTreeNode20.ToolTip = null;
            comboTreeNode23.Expanded = true;
            comboTreeNode23.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode23.Name = "LaTeX";
            comboTreeNode24.Expanded = false;
            comboTreeNode24.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode24.Name = "->.dvi";
            comboTreeNode24.Tag = "complier=latex;cp_arg=-output-format%%Equaldvi%%BlankSpace-output-directory%%Equa" +
    "l%%OutDir%%BlankSpace%%InTexFile;ctarget=.dvi;ctip=.tex->.dvi";
            comboTreeNode24.Text = ".tex-LaTeX->.dvi";
            comboTreeNode24.ToolTip = null;
            comboTreeNode23.Nodes.Add(comboTreeNode24);
            comboTreeNode23.Selectable = false;
            comboTreeNode23.Tag = null;
            comboTreeNode23.Text = "LaTeX";
            comboTreeNode23.ToolTip = null;
            this.ctb_compiler.Nodes.Add(comboTreeNode20);
            this.ctb_compiler.Nodes.Add(comboTreeNode23);
            this.ctb_compiler.Path = "xeLaTeX\\.tex-xeLaTeX->.xdv";
            this.ctb_compiler.SelectedNode = comboTreeNode21;
            this.ctb_compiler.Size = new System.Drawing.Size(184, 23);
            this.ctb_compiler.TabIndex = 0;
            // 
            // ctb_graphbox
            // 
            this.ctb_graphbox.DroppedDown = false;
            this.ctb_graphbox.Location = new System.Drawing.Point(66, 46);
            this.ctb_graphbox.Name = "ctb_graphbox";
            comboTreeNode25.Expanded = true;
            comboTreeNode25.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode25.Name = "dvisvgm";
            comboTreeNode26.Expanded = false;
            comboTreeNode26.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode26.Name = "[.dvi,.xdv]->.svg";
            comboTreeNode26.Tag = "grapher=dvisvgm;gr_arg=--output%%Equal%%OutImgFile%%BlankSpace-n%%BlankSpace%%InD" +
    "viFile;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
            comboTreeNode26.Text = "[.dvi,.xdv]-dvisvgm->.svg";
            comboTreeNode26.ToolTip = null;
            comboTreeNode27.Expanded = false;
            comboTreeNode27.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode27.Name = ".pdf->.svg";
            comboTreeNode27.Tag = "grapher=dvisvgm;gr_arg=--pdf%%BlankSpace--output%%Equal%%OutImgFile%%BlankSpace-n" +
    "%%BlankSpace%%InDviFile;gtarget=.svg;gaccept=.pdf;gtip=->.svg";
            comboTreeNode27.Text = ".pdf-dvisvgm->.svg";
            comboTreeNode27.ToolTip = null;
            comboTreeNode25.Nodes.Add(comboTreeNode26);
            comboTreeNode25.Nodes.Add(comboTreeNode27);
            comboTreeNode25.Selectable = false;
            comboTreeNode25.Tag = null;
            comboTreeNode25.Text = "dvisvgm";
            comboTreeNode25.ToolTip = null;
            comboTreeNode28.Expanded = true;
            comboTreeNode28.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode28.Name = "dvipng";
            comboTreeNode29.Expanded = false;
            comboTreeNode29.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode29.Name = ".dvi-dvipng->(300dpi).png";
            comboTreeNode29.Tag = resources.GetString("comboTreeNode29.Tag");
            comboTreeNode29.Text = ".dvi-dvipng->(300dpi).png";
            comboTreeNode29.ToolTip = null;
            comboTreeNode30.Expanded = false;
            comboTreeNode30.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode30.Name = ".dvi-dvipng->(600dpi).png";
            comboTreeNode30.Tag = resources.GetString("comboTreeNode30.Tag");
            comboTreeNode30.Text = ".dvi-dvipng->(600dpi).png";
            comboTreeNode30.ToolTip = null;
            comboTreeNode31.Expanded = false;
            comboTreeNode31.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode31.Name = ".dvi-dvipng->(900dpi).png";
            comboTreeNode31.Tag = resources.GetString("comboTreeNode31.Tag");
            comboTreeNode31.Text = ".dvi-dvipng->(900dpi).png";
            comboTreeNode31.ToolTip = null;
            comboTreeNode32.Expanded = false;
            comboTreeNode32.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode32.Name = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode32.Tag = resources.GetString("comboTreeNode32.Tag");
            comboTreeNode32.Text = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode32.ToolTip = null;
            comboTreeNode33.Expanded = false;
            comboTreeNode33.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode33.Name = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode33.Tag = resources.GetString("comboTreeNode33.Tag");
            comboTreeNode33.Text = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode33.ToolTip = null;
            comboTreeNode28.Nodes.Add(comboTreeNode29);
            comboTreeNode28.Nodes.Add(comboTreeNode30);
            comboTreeNode28.Nodes.Add(comboTreeNode31);
            comboTreeNode28.Nodes.Add(comboTreeNode32);
            comboTreeNode28.Nodes.Add(comboTreeNode33);
            comboTreeNode28.Selectable = false;
            comboTreeNode28.Tag = null;
            comboTreeNode28.Text = "dvipng";
            comboTreeNode28.ToolTip = null;
            this.ctb_graphbox.Nodes.Add(comboTreeNode25);
            this.ctb_graphbox.Nodes.Add(comboTreeNode28);
            this.ctb_graphbox.Path = "dvisvgm\\[.dvi,.xdv]-dvisvgm->.svg";
            this.ctb_graphbox.SelectedNode = comboTreeNode26;
            this.ctb_graphbox.Size = new System.Drawing.Size(184, 23);
            this.ctb_graphbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 52);
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
            this.btn_hide.Location = new System.Drawing.Point(175, 138);
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
            this.chb_show_fl.Location = new System.Drawing.Point(12, 122);
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
            this.cb_fonts.Location = new System.Drawing.Point(66, 84);
            this.cb_fonts.Name = "cb_fonts";
            comboTreeNode34.Expanded = false;
            comboTreeNode34.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode34.Name = "default";
            comboTreeNode34.Tag = "%%default";
            comboTreeNode34.Text = "default";
            comboTreeNode34.ToolTip = null;
            comboTreeNode35.Expanded = false;
            comboTreeNode35.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode35.Name = "txfonts";
            comboTreeNode35.Tag = "\\usepackage{txfonts}";
            comboTreeNode35.Text = "txfonts";
            comboTreeNode35.ToolTip = "\\usepackage{txfonts}";
            comboTreeNode36.Expanded = false;
            comboTreeNode36.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode36.Name = "fourier";
            comboTreeNode36.Tag = "\\usepackage{fourier}";
            comboTreeNode36.Text = "fourier";
            comboTreeNode36.ToolTip = "\\usepackage{fourier}";
            comboTreeNode37.Expanded = false;
            comboTreeNode37.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode37.Name = "mathptmx";
            comboTreeNode37.Tag = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode37.Text = "mathptmx";
            comboTreeNode37.ToolTip = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode38.Expanded = false;
            comboTreeNode38.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode38.Name = "charter";
            comboTreeNode38.Tag = "\\usepackage[charter]{mathdesign}";
            comboTreeNode38.Text = "charter";
            comboTreeNode38.ToolTip = "\\usepackage[charter]{mathdesign}";
            this.cb_fonts.Nodes.Add(comboTreeNode34);
            this.cb_fonts.Nodes.Add(comboTreeNode35);
            this.cb_fonts.Nodes.Add(comboTreeNode36);
            this.cb_fonts.Nodes.Add(comboTreeNode37);
            this.cb_fonts.Nodes.Add(comboTreeNode38);
            this.cb_fonts.Path = "default";
            this.cb_fonts.SelectedNode = comboTreeNode34;
            this.cb_fonts.Size = new System.Drawing.Size(184, 23);
            this.cb_fonts.TabIndex = 6;
            this.cb_fonts.SelectedNodeChanged += new System.EventHandler(this.cb_fonts_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fonts:";
            // 
            // SettingsBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 170);
            this.ControlBox = false;
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
            this.Name = "SettingsBox";
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