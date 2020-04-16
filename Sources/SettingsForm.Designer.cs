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
            ComboTreeNode comboTreeNode22 = new ComboTreeNode();
            ComboTreeNode comboTreeNode23 = new ComboTreeNode();
            ComboTreeNode comboTreeNode24 = new ComboTreeNode();
            ComboTreeNode comboTreeNode26 = new ComboTreeNode();
            ComboTreeNode comboTreeNode27 = new ComboTreeNode();
            ComboTreeNode comboTreeNode28 = new ComboTreeNode();
            ComboTreeNode comboTreeNode29 = new ComboTreeNode();
            ComboTreeNode comboTreeNode30 = new ComboTreeNode();
            ComboTreeNode comboTreeNode32 = new ComboTreeNode();
            ComboTreeNode comboTreeNode33 = new ComboTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            ComboTreeNode comboTreeNode34 = new ComboTreeNode();
            ComboTreeNode comboTreeNode35 = new ComboTreeNode();
            ComboTreeNode comboTreeNode36 = new ComboTreeNode();
            ComboTreeNode comboTreeNode37 = new ComboTreeNode();
            ComboTreeNode comboTreeNode38 = new ComboTreeNode();
            ComboTreeNode comboTreeNode39 = new ComboTreeNode();
            ComboTreeNode comboTreeNode40 = new ComboTreeNode();
            ComboTreeNode comboTreeNode41 = new ComboTreeNode();
            ComboTreeNode comboTreeNode42 = new ComboTreeNode();
            this.ctb_compiler = new ComboTreeBox();
            this.ctb_graphbox = new ComboTreeBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.chb_show_fl = new System.Windows.Forms.CheckBox();
            this.cb_fonts = new ComboTreeBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sb_execPerPrgTime = new System.Windows.Forms.NumericUpDown();
            this.execTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sb_execPerPrgTime)).BeginInit();
            this.SuspendLayout();
            // 
            // ctb_compiler
            // 
            this.ctb_compiler.DroppedDown = false;
            this.ctb_compiler.Location = new System.Drawing.Point(63, 12);
            this.ctb_compiler.Name = "ctb_compiler";
            comboTreeNode22.Expanded = true;
            comboTreeNode22.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode22.Name = "xeLaTeX";
            comboTreeNode23.Expanded = false;
            comboTreeNode23.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode23.Name = "->.xdv";
            comboTreeNode23.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-no-pdf%%BlankS" +
    "pace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.xdv;ctip=.t" +
    "ex->.xdv";
            comboTreeNode23.Text = ".tex-xeLaTeX->.xdv";
            comboTreeNode23.ToolTip = null;
            comboTreeNode24.Expanded = false;
            comboTreeNode24.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode24.Name = "->.pdf";
            comboTreeNode24.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace%%BlankSpace-ou" +
    "tput-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.pdf;ctip=.tex->.pd" +
    "f";
            comboTreeNode24.Text = ".tex-xeLaTeX->.pdf";
            comboTreeNode24.ToolTip = null;
            comboTreeNode22.Nodes.Add(comboTreeNode23);
            comboTreeNode22.Nodes.Add(comboTreeNode24);
            comboTreeNode22.Selectable = false;
            comboTreeNode22.Tag = null;
            comboTreeNode22.Text = "xeLaTeX";
            comboTreeNode22.ToolTip = null;
            comboTreeNode26.Expanded = true;
            comboTreeNode26.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode26.Name = "LaTeX";
            comboTreeNode27.Expanded = false;
            comboTreeNode27.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode27.Name = "->.dvi";
            comboTreeNode27.Tag = "complier=latex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-output-format%%E" +
    "qualdvi%%BlankSpace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarg" +
    "et=.dvi;ctip=.tex->.dvi";
            comboTreeNode27.Text = ".tex-LaTeX->.dvi";
            comboTreeNode27.ToolTip = null;
            comboTreeNode26.Nodes.Add(comboTreeNode27);
            comboTreeNode26.Selectable = false;
            comboTreeNode26.Tag = null;
            comboTreeNode26.Text = "LaTeX";
            comboTreeNode26.ToolTip = null;
            this.ctb_compiler.Nodes.Add(comboTreeNode22);
            this.ctb_compiler.Nodes.Add(comboTreeNode26);
            this.ctb_compiler.Path = "xeLaTeX\\.tex-xeLaTeX->.xdv";
            this.ctb_compiler.SelectedNode = comboTreeNode23;
            this.ctb_compiler.Size = new System.Drawing.Size(209, 23);
            this.ctb_compiler.TabIndex = 0;
            // 
            // ctb_graphbox
            // 
            this.ctb_graphbox.DroppedDown = false;
            this.ctb_graphbox.Location = new System.Drawing.Point(63, 41);
            this.ctb_graphbox.Name = "ctb_graphbox";
            comboTreeNode28.Expanded = true;
            comboTreeNode28.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode28.Name = "dvisvgm";
            comboTreeNode29.Expanded = false;
            comboTreeNode29.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode29.Name = "[.dvi,.xdv]->.svg";
            comboTreeNode29.Tag = "grapher=dvisvgm;gr_arg=--output%%Equal%%OutImgFile%%BlankSpace-n%%BlankSpace%%InD" +
    "viFile;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
            comboTreeNode29.Text = "[.dvi,.xdv]-dvisvgm->.svg";
            comboTreeNode29.ToolTip = null;
            comboTreeNode30.Expanded = false;
            comboTreeNode30.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode30.Name = ".pdf->.svg";
            comboTreeNode30.Tag = "grapher=dvisvgm;gr_arg=--pdf%%BlankSpace--output%%Equal%%OutImgFile%%BlankSpace-n" +
    "%%BlankSpace%%InDviFile;gtarget=.svg;gaccept=.pdf;gtip=->.svg";
            comboTreeNode30.Text = ".pdf-dvisvgm->.svg";
            comboTreeNode30.ToolTip = null;
            comboTreeNode28.Nodes.Add(comboTreeNode29);
            comboTreeNode28.Nodes.Add(comboTreeNode30);
            comboTreeNode28.Selectable = false;
            comboTreeNode28.Tag = null;
            comboTreeNode28.Text = "dvisvgm";
            comboTreeNode28.ToolTip = null;
            comboTreeNode32.Expanded = true;
            comboTreeNode32.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode32.Name = "dvipng";
            comboTreeNode33.Expanded = false;
            comboTreeNode33.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode33.Name = ".dvi-dvipng->(300dpi).png";
            comboTreeNode33.Tag = resources.GetString("comboTreeNode33.Tag");
            comboTreeNode33.Text = ".dvi-dvipng->(300dpi).png";
            comboTreeNode33.ToolTip = null;
            comboTreeNode34.Expanded = false;
            comboTreeNode34.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode34.Name = ".dvi-dvipng->(600dpi).png";
            comboTreeNode34.Tag = resources.GetString("comboTreeNode34.Tag");
            comboTreeNode34.Text = ".dvi-dvipng->(600dpi).png";
            comboTreeNode34.ToolTip = null;
            comboTreeNode35.Expanded = false;
            comboTreeNode35.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode35.Name = ".dvi-dvipng->(900dpi).png";
            comboTreeNode35.Tag = resources.GetString("comboTreeNode35.Tag");
            comboTreeNode35.Text = ".dvi-dvipng->(900dpi).png";
            comboTreeNode35.ToolTip = null;
            comboTreeNode36.Expanded = false;
            comboTreeNode36.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode36.Name = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode36.Tag = resources.GetString("comboTreeNode36.Tag");
            comboTreeNode36.Text = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode36.ToolTip = null;
            comboTreeNode37.Expanded = false;
            comboTreeNode37.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode37.Name = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode37.Tag = resources.GetString("comboTreeNode37.Tag");
            comboTreeNode37.Text = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode37.ToolTip = null;
            comboTreeNode32.Nodes.Add(comboTreeNode33);
            comboTreeNode32.Nodes.Add(comboTreeNode34);
            comboTreeNode32.Nodes.Add(comboTreeNode35);
            comboTreeNode32.Nodes.Add(comboTreeNode36);
            comboTreeNode32.Nodes.Add(comboTreeNode37);
            comboTreeNode32.Selectable = false;
            comboTreeNode32.Tag = null;
            comboTreeNode32.Text = "dvipng";
            comboTreeNode32.ToolTip = null;
            this.ctb_graphbox.Nodes.Add(comboTreeNode28);
            this.ctb_graphbox.Nodes.Add(comboTreeNode32);
            this.ctb_graphbox.Path = "dvisvgm\\[.dvi,.xdv]-dvisvgm->.svg";
            this.ctb_graphbox.SelectedNode = comboTreeNode29;
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
            this.btn_hide.Location = new System.Drawing.Point(197, 151);
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
            this.chb_show_fl.Location = new System.Drawing.Point(9, 146);
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
            comboTreeNode38.Expanded = false;
            comboTreeNode38.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode38.Name = "default";
            comboTreeNode38.Tag = "%%default";
            comboTreeNode38.Text = "default";
            comboTreeNode38.ToolTip = null;
            comboTreeNode39.Expanded = false;
            comboTreeNode39.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode39.Name = "txfonts";
            comboTreeNode39.Tag = "\\usepackage{txfonts}";
            comboTreeNode39.Text = "txfonts";
            comboTreeNode39.ToolTip = "\\usepackage{txfonts}";
            comboTreeNode40.Expanded = false;
            comboTreeNode40.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode40.Name = "fourier";
            comboTreeNode40.Tag = "\\usepackage{fourier}";
            comboTreeNode40.Text = "fourier";
            comboTreeNode40.ToolTip = "\\usepackage{fourier}";
            comboTreeNode41.Expanded = false;
            comboTreeNode41.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode41.Name = "mathptmx";
            comboTreeNode41.Tag = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode41.Text = "mathptmx";
            comboTreeNode41.ToolTip = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode42.Expanded = false;
            comboTreeNode42.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode42.Name = "charter";
            comboTreeNode42.Tag = "\\usepackage[charter]{mathdesign}";
            comboTreeNode42.Text = "charter";
            comboTreeNode42.ToolTip = "\\usepackage[charter]{mathdesign}";
            this.cb_fonts.Nodes.Add(comboTreeNode38);
            this.cb_fonts.Nodes.Add(comboTreeNode39);
            this.cb_fonts.Nodes.Add(comboTreeNode40);
            this.cb_fonts.Nodes.Add(comboTreeNode41);
            this.cb_fonts.Nodes.Add(comboTreeNode42);
            this.cb_fonts.Path = "default";
            this.cb_fonts.SelectedNode = comboTreeNode38;
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
            // sb_execPerPrgTime
            // 
            this.sb_execPerPrgTime.Location = new System.Drawing.Point(210, 113);
            this.sb_execPerPrgTime.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.sb_execPerPrgTime.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sb_execPerPrgTime.Name = "sb_execPerPrgTime";
            this.sb_execPerPrgTime.Size = new System.Drawing.Size(62, 21);
            this.sb_execPerPrgTime.TabIndex = 8;
            this.sb_execPerPrgTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.sb_execPerPrgTime.ValueChanged += new System.EventHandler(this.sb_execPerPrgTime_ValueChanged);
            // 
            // execTime
            // 
            this.execTime.AutoSize = true;
            this.execTime.Location = new System.Drawing.Point(7, 118);
            this.execTime.Name = "execTime";
            this.execTime.Size = new System.Drawing.Size(197, 12);
            this.execTime.TabIndex = 7;
            this.execTime.Text = "Max wait time(per program, sec):";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 186);
            this.Controls.Add(this.sb_execPerPrgTime);
            this.Controls.Add(this.execTime);
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
            ((System.ComponentModel.ISupportInitialize)(this.sb_execPerPrgTime)).EndInit();
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
        private System.Windows.Forms.NumericUpDown sb_execPerPrgTime;
        private System.Windows.Forms.Label execTime;
    }
}