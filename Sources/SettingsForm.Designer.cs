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
            ComboTreeNode comboTreeNode11 = new ComboTreeNode();
            ComboTreeNode comboTreeNode12 = new ComboTreeNode();
            ComboTreeNode comboTreeNode13 = new ComboTreeNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            ComboTreeNode comboTreeNode14 = new ComboTreeNode();
            ComboTreeNode comboTreeNode15 = new ComboTreeNode();
            ComboTreeNode comboTreeNode16 = new ComboTreeNode();
            ComboTreeNode comboTreeNode17 = new ComboTreeNode();
            ComboTreeNode comboTreeNode18 = new ComboTreeNode();
            ComboTreeNode comboTreeNode19 = new ComboTreeNode();
            ComboTreeNode comboTreeNode20 = new ComboTreeNode();
            ComboTreeNode comboTreeNode21 = new ComboTreeNode();
            ComboTreeNode comboTreeNode22 = new ComboTreeNode();
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
            this.tb_wkdir = new System.Windows.Forms.TextBox();
            this.btn_clean_cache = new System.Windows.Forms.Button();
            this.btn_wkDir_select = new System.Windows.Forms.Button();
            this.ckb_autoclean = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DirSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sb_execPerPrgTime)).BeginInit();
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
            comboTreeNode2.Expanded = true;
            comboTreeNode2.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode2.Name = "->.xdv";
            comboTreeNode2.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-no-pdf%%BlankS" +
    "pace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.xdv;ctip=.t" +
    "ex->.xdv";
            comboTreeNode2.Text = ".tex-xeLaTeX->.xdv";
            comboTreeNode2.ToolTip = null;
            comboTreeNode3.Expanded = true;
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
            comboTreeNode5.Expanded = true;
            comboTreeNode5.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode5.Name = "->.dvi";
            comboTreeNode5.Tag = "complier=latex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-output-format%%E" +
    "qualdvi%%BlankSpace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarg" +
    "et=.dvi;ctip=.tex->.dvi";
            comboTreeNode5.Text = ".tex-LaTeX->.dvi";
            comboTreeNode5.ToolTip = null;
            comboTreeNode4.Nodes.Add(comboTreeNode5);
            comboTreeNode4.Selectable = false;
            comboTreeNode4.Tag = null;
            comboTreeNode4.Text = "LaTeX";
            comboTreeNode4.ToolTip = null;
            comboTreeNode6.Expanded = true;
            comboTreeNode6.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode6.Name = "LuaLaTeX";
            comboTreeNode7.Expanded = false;
            comboTreeNode7.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode7.Name = "->.dvi";
            comboTreeNode7.Tag = "complier=lualatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace--output-forma" +
    "t%%Equaldvi%%BlankSpace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;c" +
    "target=.dvi;ctip=.tex->.dvi";
            comboTreeNode7.Text = ".tex-LuaLaTeX->.dvi";
            comboTreeNode7.ToolTip = null;
            comboTreeNode8.Expanded = true;
            comboTreeNode8.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode8.Name = "->.pdf";
            comboTreeNode8.Tag = "complier=lualatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-output-direct" +
    "ory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.pdf;ctip=.tex->.pdf";
            comboTreeNode8.Text = ".tex-LuaLaTeX->.pdf";
            comboTreeNode8.ToolTip = null;
            comboTreeNode6.Nodes.Add(comboTreeNode7);
            comboTreeNode6.Nodes.Add(comboTreeNode8);
            comboTreeNode6.Selectable = false;
            comboTreeNode6.Tag = null;
            comboTreeNode6.Text = "LuaLaTeX";
            comboTreeNode6.ToolTip = null;
            this.ctb_compiler.Nodes.Add(comboTreeNode1);
            this.ctb_compiler.Nodes.Add(comboTreeNode4);
            this.ctb_compiler.Nodes.Add(comboTreeNode6);
            this.ctb_compiler.Path = "xeLaTeX\\.tex-xeLaTeX->.xdv";
            this.ctb_compiler.SelectedNode = comboTreeNode2;
            this.ctb_compiler.Size = new System.Drawing.Size(209, 23);
            this.ctb_compiler.TabIndex = 0;
            this.ctb_compiler.Click += new System.EventHandler(this.ctb_compiler_Click);
            // 
            // ctb_graphbox
            // 
            this.ctb_graphbox.DroppedDown = false;
            this.ctb_graphbox.Location = new System.Drawing.Point(63, 41);
            this.ctb_graphbox.Name = "ctb_graphbox";
            comboTreeNode9.Expanded = true;
            comboTreeNode9.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode9.Name = "dvisvgm";
            comboTreeNode10.Expanded = true;
            comboTreeNode10.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode10.Name = "[.dvi,.xdv]->.svg";
            comboTreeNode10.Tag = "grapher=dvisvgm;gr_arg=--output%%Equal%%OutImgFile%%BlankSpace-n%%BlankSpace%%InD" +
    "viFile;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
            comboTreeNode10.Text = "[.dvi,.xdv]-dvisvgm->.svg";
            comboTreeNode10.ToolTip = null;
            comboTreeNode11.Expanded = true;
            comboTreeNode11.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode11.Name = ".pdf->.svg";
            comboTreeNode11.Tag = "grapher=dvisvgm;gr_arg=--pdf%%BlankSpace--output%%Equal%%OutImgFile%%BlankSpace-n" +
    "%%BlankSpace%%InDviFile;gtarget=.svg;gaccept=.pdf;gtip=->.svg";
            comboTreeNode11.Text = ".pdf-dvisvgm->.svg";
            comboTreeNode11.ToolTip = null;
            comboTreeNode9.Nodes.Add(comboTreeNode10);
            comboTreeNode9.Nodes.Add(comboTreeNode11);
            comboTreeNode9.Selectable = false;
            comboTreeNode9.Tag = null;
            comboTreeNode9.Text = "dvisvgm";
            comboTreeNode9.ToolTip = null;
            comboTreeNode12.Expanded = true;
            comboTreeNode12.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode12.Name = "dvipng";
            comboTreeNode13.Expanded = true;
            comboTreeNode13.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode13.Name = ".dvi-dvipng->(300dpi).png";
            comboTreeNode13.Tag = resources.GetString("comboTreeNode13.Tag");
            comboTreeNode13.Text = ".dvi-dvipng->(300dpi).png";
            comboTreeNode13.ToolTip = null;
            comboTreeNode14.Expanded = true;
            comboTreeNode14.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode14.Name = ".dvi-dvipng->(600dpi).png";
            comboTreeNode14.Tag = resources.GetString("comboTreeNode14.Tag");
            comboTreeNode14.Text = ".dvi-dvipng->(600dpi).png";
            comboTreeNode14.ToolTip = null;
            comboTreeNode15.Expanded = true;
            comboTreeNode15.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode15.Name = ".dvi-dvipng->(900dpi).png";
            comboTreeNode15.Tag = resources.GetString("comboTreeNode15.Tag");
            comboTreeNode15.Text = ".dvi-dvipng->(900dpi).png";
            comboTreeNode15.ToolTip = null;
            comboTreeNode16.Expanded = true;
            comboTreeNode16.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode16.Name = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode16.Tag = resources.GetString("comboTreeNode16.Tag");
            comboTreeNode16.Text = ".dvi-dvipng->(1200dpi).png";
            comboTreeNode16.ToolTip = null;
            comboTreeNode17.Expanded = true;
            comboTreeNode17.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode17.Name = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode17.Tag = resources.GetString("comboTreeNode17.Tag");
            comboTreeNode17.Text = ".dvi-dvipng->(2400dpi).png";
            comboTreeNode17.ToolTip = null;
            comboTreeNode12.Nodes.Add(comboTreeNode13);
            comboTreeNode12.Nodes.Add(comboTreeNode14);
            comboTreeNode12.Nodes.Add(comboTreeNode15);
            comboTreeNode12.Nodes.Add(comboTreeNode16);
            comboTreeNode12.Nodes.Add(comboTreeNode17);
            comboTreeNode12.Selectable = false;
            comboTreeNode12.Tag = null;
            comboTreeNode12.Text = "dvipng";
            comboTreeNode12.ToolTip = null;
            this.ctb_graphbox.Nodes.Add(comboTreeNode9);
            this.ctb_graphbox.Nodes.Add(comboTreeNode12);
            this.ctb_graphbox.Path = "dvisvgm\\[.dvi,.xdv]-dvisvgm->.svg";
            this.ctb_graphbox.SelectedNode = comboTreeNode10;
            this.ctb_graphbox.Size = new System.Drawing.Size(209, 23);
            this.ctb_graphbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compiler:";
            // 
            // btn_hide
            // 
            this.btn_hide.Location = new System.Drawing.Point(197, 210);
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
            this.chb_show_fl.Location = new System.Drawing.Point(3, 188);
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
            comboTreeNode18.Expanded = true;
            comboTreeNode18.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode18.Name = "default";
            comboTreeNode18.Tag = "%%default";
            comboTreeNode18.Text = "default";
            comboTreeNode18.ToolTip = null;
            comboTreeNode19.Expanded = true;
            comboTreeNode19.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode19.Name = "txfonts";
            comboTreeNode19.Tag = "\\usepackage{txfonts}";
            comboTreeNode19.Text = "txfonts";
            comboTreeNode19.ToolTip = "\\usepackage{txfonts}";
            comboTreeNode20.Expanded = true;
            comboTreeNode20.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode20.Name = "fourier";
            comboTreeNode20.Tag = "\\usepackage{fourier}";
            comboTreeNode20.Text = "fourier";
            comboTreeNode20.ToolTip = "\\usepackage{fourier}";
            comboTreeNode21.Expanded = true;
            comboTreeNode21.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode21.Name = "mathptmx";
            comboTreeNode21.Tag = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode21.Text = "mathptmx";
            comboTreeNode21.ToolTip = "\\usepackage{mathptmx,tgtermes}";
            comboTreeNode22.Expanded = true;
            comboTreeNode22.ForeColor = System.Drawing.Color.Empty;
            comboTreeNode22.Name = "charter";
            comboTreeNode22.Tag = "\\usepackage[charter]{mathdesign}";
            comboTreeNode22.Text = "charter";
            comboTreeNode22.ToolTip = "\\usepackage[charter]{mathdesign}";
            this.cb_fonts.Nodes.Add(comboTreeNode18);
            this.cb_fonts.Nodes.Add(comboTreeNode19);
            this.cb_fonts.Nodes.Add(comboTreeNode20);
            this.cb_fonts.Nodes.Add(comboTreeNode21);
            this.cb_fonts.Nodes.Add(comboTreeNode22);
            this.cb_fonts.Path = "default";
            this.cb_fonts.SelectedNode = comboTreeNode18;
            this.cb_fonts.Size = new System.Drawing.Size(209, 23);
            this.cb_fonts.TabIndex = 6;
            this.cb_fonts.SelectedNodeChanged += new System.EventHandler(this.cb_fonts_Change);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fonts:";
            // 
            // sb_execPerPrgTime
            // 
            this.sb_execPerPrgTime.Location = new System.Drawing.Point(210, 160);
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
            this.execTime.Location = new System.Drawing.Point(2, 163);
            this.execTime.Name = "execTime";
            this.execTime.Size = new System.Drawing.Size(197, 12);
            this.execTime.TabIndex = 7;
            this.execTime.Text = "Max wait time(per program, sec):";
            // 
            // tb_wkdir
            // 
            this.tb_wkdir.Location = new System.Drawing.Point(63, 106);
            this.tb_wkdir.Name = "tb_wkdir";
            this.tb_wkdir.Size = new System.Drawing.Size(165, 21);
            this.tb_wkdir.TabIndex = 9;
            this.tb_wkdir.Text = "C:\\Users\\benter\\AppData\\Local\\Temp";
            this.tb_wkdir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_clean_cache
            // 
            this.btn_clean_cache.Location = new System.Drawing.Point(153, 131);
            this.btn_clean_cache.Name = "btn_clean_cache";
            this.btn_clean_cache.Size = new System.Drawing.Size(119, 23);
            this.btn_clean_cache.TabIndex = 10;
            this.btn_clean_cache.Text = "Clean Files";
            this.btn_clean_cache.UseVisualStyleBackColor = true;
            this.btn_clean_cache.Click += new System.EventHandler(this.btn_clean_cache_Click);
            // 
            // btn_wkDir_select
            // 
            this.btn_wkDir_select.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_wkDir_select.Location = new System.Drawing.Point(234, 106);
            this.btn_wkDir_select.Name = "btn_wkDir_select";
            this.btn_wkDir_select.Size = new System.Drawing.Size(38, 23);
            this.btn_wkDir_select.TabIndex = 11;
            this.btn_wkDir_select.Text = "...";
            this.btn_wkDir_select.UseVisualStyleBackColor = true;
            this.btn_wkDir_select.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckb_autoclean
            // 
            this.ckb_autoclean.AutoSize = true;
            this.ckb_autoclean.Checked = true;
            this.ckb_autoclean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_autoclean.Location = new System.Drawing.Point(63, 135);
            this.ckb_autoclean.Name = "ckb_autoclean";
            this.ckb_autoclean.Size = new System.Drawing.Size(84, 16);
            this.ckb_autoclean.TabIndex = 12;
            this.ckb_autoclean.Text = "Auto clean";
            this.ckb_autoclean.UseVisualStyleBackColor = true;
            this.ckb_autoclean.CheckedChanged += new System.EventHandler(this.ckb_autoclean_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Work Dir:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckb_autoclean);
            this.Controls.Add(this.btn_wkDir_select);
            this.Controls.Add(this.btn_clean_cache);
            this.Controls.Add(this.tb_wkdir);
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
        private System.Windows.Forms.TextBox tb_wkdir;
        private System.Windows.Forms.Button btn_clean_cache;
        private System.Windows.Forms.Button btn_wkDir_select;
        private System.Windows.Forms.CheckBox ckb_autoclean;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog DirSelectDialog;
    }
}