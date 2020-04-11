namespace WordxTex
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl14 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.WordxTex = this.Factory.CreateRibbonGroup();
            this.btn_insertTex = this.Factory.CreateRibbonButton();
            this.btn_insMath = this.Factory.CreateRibbonButton();
            this.btn_insChemReact = this.Factory.CreateRibbonButton();
            this.btn_insChemStruct = this.Factory.CreateRibbonButton();
            this.btn_ins_symbol = this.Factory.CreateRibbonButton();
            this.btn_insplot = this.Factory.CreateRibbonButton();
            this.separator3 = this.Factory.CreateRibbonSeparator();
            this.btn_edit = this.Factory.CreateRibbonButton();
            this.btn_batchEdit = this.Factory.CreateRibbonButton();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.DD_Complier = this.Factory.CreateRibbonDropDown();
            this.DD_Grapher = this.Factory.CreateRibbonDropDown();
            this.lb_gen_tip = this.Factory.CreateRibbonLabel();
            this.separator2 = this.Factory.CreateRibbonSeparator();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.DD_Font_fx = this.Factory.CreateRibbonDropDown();
            this.btn_about = this.Factory.CreateRibbonButton();
            this.separator4 = this.Factory.CreateRibbonSeparator();
            this.btn_baselineU = this.Factory.CreateRibbonButton();
            this.btn_baselineDn = this.Factory.CreateRibbonButton();
            this.btn_baselineRt = this.Factory.CreateRibbonButton();
            this.btn_settings = this.Factory.CreateRibbonButton();
            this.tab_WordxTex = this.Factory.CreateRibbonTab();
            this.tab1.SuspendLayout();
            this.WordxTex.SuspendLayout();
            this.tab_WordxTex.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.WordxTex);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // WordxTex
            // 
            this.WordxTex.Items.Add(this.btn_insertTex);
            this.WordxTex.Items.Add(this.btn_insMath);
            this.WordxTex.Items.Add(this.btn_insChemReact);
            this.WordxTex.Items.Add(this.btn_insChemStruct);
            this.WordxTex.Items.Add(this.btn_ins_symbol);
            this.WordxTex.Items.Add(this.btn_insplot);
            this.WordxTex.Items.Add(this.separator3);
            this.WordxTex.Items.Add(this.btn_edit);
            this.WordxTex.Items.Add(this.btn_batchEdit);
            this.WordxTex.Items.Add(this.separator1);
            this.WordxTex.Items.Add(this.DD_Complier);
            this.WordxTex.Items.Add(this.DD_Grapher);
            this.WordxTex.Items.Add(this.lb_gen_tip);
            this.WordxTex.Items.Add(this.separator2);
            this.WordxTex.Items.Add(this.label1);
            this.WordxTex.Items.Add(this.DD_Font_fx);
            this.WordxTex.Items.Add(this.btn_about);
            this.WordxTex.Items.Add(this.separator4);
            this.WordxTex.Items.Add(this.btn_baselineU);
            this.WordxTex.Items.Add(this.btn_baselineDn);
            this.WordxTex.Items.Add(this.btn_baselineRt);
            this.WordxTex.Items.Add(this.btn_settings);
            this.WordxTex.Label = "WordxTex";
            this.WordxTex.Name = "WordxTex";
            // 
            // btn_insertTex
            // 
            this.btn_insertTex.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_insertTex.Image = global::WordxTex.Properties.Resources.Button_Insert_Tex;
            this.btn_insertTex.KeyTip = "I";
            this.btn_insertTex.Label = "Insert TeX";
            this.btn_insertTex.Name = "btn_insertTex";
            this.btn_insertTex.ScreenTip = "Insert LaTex Content.";
            this.btn_insertTex.ShowImage = true;
            this.btn_insertTex.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_insertTex_Click);
            // 
            // btn_insMath
            // 
            this.btn_insMath.Image = global::WordxTex.Properties.Resources.Button_Insert_MathEQ;
            this.btn_insMath.Label = "Math Equation";
            this.btn_insMath.Name = "btn_insMath";
            this.btn_insMath.ScreenTip = "Insert Math Equation.";
            this.btn_insMath.ShowImage = true;
            this.btn_insMath.ShowLabel = false;
            this.btn_insMath.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_insMath_Click);
            // 
            // btn_insChemReact
            // 
            this.btn_insChemReact.Image = global::WordxTex.Properties.Resources.Button_Insert_MathChemRea;
            this.btn_insChemReact.Label = "Chemical Reaction";
            this.btn_insChemReact.Name = "btn_insChemReact";
            this.btn_insChemReact.ScreenTip = "Insert Chemical Expression";
            this.btn_insChemReact.ShowImage = true;
            this.btn_insChemReact.ShowLabel = false;
            this.btn_insChemReact.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_insChemReact_Click);
            // 
            // btn_insChemStruct
            // 
            this.btn_insChemStruct.Image = global::WordxTex.Properties.Resources.Button_Insert_MathChemStru;
            this.btn_insChemStruct.Label = "Chemical Structure";
            this.btn_insChemStruct.Name = "btn_insChemStruct";
            this.btn_insChemStruct.ScreenTip = "Insert Chemical Structure";
            this.btn_insChemStruct.ShowImage = true;
            this.btn_insChemStruct.ShowLabel = false;
            this.btn_insChemStruct.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_insChemStruct_Click);
            // 
            // btn_ins_symbol
            // 
            this.btn_ins_symbol.Image = global::WordxTex.Properties.Resources.Button_Insert_symbol;
            this.btn_ins_symbol.Label = "Insert Symbol";
            this.btn_ins_symbol.Name = "btn_ins_symbol";
            this.btn_ins_symbol.ScreenTip = "Insert Awesome Symbol";
            this.btn_ins_symbol.ShowImage = true;
            this.btn_ins_symbol.ShowLabel = false;
            this.btn_ins_symbol.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_ins_symbol_Click);
            // 
            // btn_insplot
            // 
            this.btn_insplot.Image = global::WordxTex.Properties.Resources.Button_Insert_Graph;
            this.btn_insplot.Label = "Plot";
            this.btn_insplot.Name = "btn_insplot";
            this.btn_insplot.ScreenTip = "Insert Plot Graph";
            this.btn_insplot.ShowImage = true;
            this.btn_insplot.ShowLabel = false;
            this.btn_insplot.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_insplot_Click);
            // 
            // separator3
            // 
            this.separator3.Name = "separator3";
            // 
            // btn_edit
            // 
            this.btn_edit.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_edit.Enabled = false;
            this.btn_edit.Image = global::WordxTex.Properties.Resources.Button_Edit;
            this.btn_edit.Label = "Edit";
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShowImage = true;
            this.btn_edit.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_edit_Click);
            // 
            // btn_batchEdit
            // 
            this.btn_batchEdit.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_batchEdit.Label = "Batch Edit";
            this.btn_batchEdit.Name = "btn_batchEdit";
            this.btn_batchEdit.ShowImage = true;
            this.btn_batchEdit.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_batchEdit_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // DD_Complier
            // 
            ribbonDropDownItemImpl1.Label = "xeLaTeX(.xdv)";
            ribbonDropDownItemImpl1.ScreenTip = ".tex to .xdv";
            ribbonDropDownItemImpl1.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace-no-pdf%%BlankS" +
    "pace-output-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.xdv;ctip=.t" +
    "ex->.xdv";
            ribbonDropDownItemImpl2.Label = "LaTeX(.vdi)";
            ribbonDropDownItemImpl2.ScreenTip = ".tex to .dvi";
            ribbonDropDownItemImpl2.Tag = "complier=latex;cp_arg=-output-format%%Equaldvi%%BlankSpace-output-directory%%Equa" +
    "l%%OutDir%%BlankSpace%%InTexFile;ctarget=.dvi;ctip=.tex->.dvi";
            ribbonDropDownItemImpl3.Label = "xeLaTeX(.pdf)";
            ribbonDropDownItemImpl3.ScreenTip = ".tex to .pdf";
            ribbonDropDownItemImpl3.Tag = "complier=xelatex;cp_arg=-interaction%%Equalnonstopmode%%BlankSpace%%BlankSpace-ou" +
    "tput-directory%%Equal%%OutDir%%BlankSpace%%InTexFile;ctarget=.pdf;ctip=.tex->.pd" +
    "f";
            this.DD_Complier.Items.Add(ribbonDropDownItemImpl1);
            this.DD_Complier.Items.Add(ribbonDropDownItemImpl2);
            this.DD_Complier.Items.Add(ribbonDropDownItemImpl3);
            this.DD_Complier.Label = "complier";
            this.DD_Complier.Name = "DD_Complier";
            this.DD_Complier.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DD_Complier_SelectionChanged);
            // 
            // DD_Grapher
            // 
            ribbonDropDownItemImpl4.Label = "dvisvgm(.dvi,.xdv)";
            ribbonDropDownItemImpl4.ScreenTip = ".xdv/.dvi to .svg";
            ribbonDropDownItemImpl4.Tag = "grapher=dvisvgm;gr_arg=--output%%Equal%%OutImgFile%%BlankSpace-n%%BlankSpace%%InD" +
    "viFile;gtarget=.svg;gaccept=.dvi,.xdv;gtip=->.svg";
            ribbonDropDownItemImpl5.Label = "dvipng(1200dpi)";
            ribbonDropDownItemImpl5.Tag = resources.GetString("ribbonDropDownItemImpl5.Tag");
            ribbonDropDownItemImpl6.Label = "dvipng(0900dpi)";
            ribbonDropDownItemImpl6.Tag = resources.GetString("ribbonDropDownItemImpl6.Tag");
            ribbonDropDownItemImpl7.Label = "dvipng(0600dpi)";
            ribbonDropDownItemImpl7.Tag = resources.GetString("ribbonDropDownItemImpl7.Tag");
            ribbonDropDownItemImpl8.Label = "dvipng(0300dpi)";
            ribbonDropDownItemImpl8.Tag = resources.GetString("ribbonDropDownItemImpl8.Tag");
            ribbonDropDownItemImpl9.Label = "dvisvgm(.pdf)";
            ribbonDropDownItemImpl9.ScreenTip = ".pdf to .svg";
            ribbonDropDownItemImpl9.Tag = "grapher=dvisvgm;gr_arg=--pdf%%BlankSpace--output%%Equal%%OutImgFile%%BlankSpace-n" +
    "%%BlankSpace%%InDviFile;gtarget=.svg;gaccept=.pdf;gtip=->.svg";
            this.DD_Grapher.Items.Add(ribbonDropDownItemImpl4);
            this.DD_Grapher.Items.Add(ribbonDropDownItemImpl5);
            this.DD_Grapher.Items.Add(ribbonDropDownItemImpl6);
            this.DD_Grapher.Items.Add(ribbonDropDownItemImpl7);
            this.DD_Grapher.Items.Add(ribbonDropDownItemImpl8);
            this.DD_Grapher.Items.Add(ribbonDropDownItemImpl9);
            this.DD_Grapher.Label = "grapher";
            this.DD_Grapher.Name = "DD_Grapher";
            this.DD_Grapher.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DD_Grapher_SelectionChanged);
            // 
            // lb_gen_tip
            // 
            this.lb_gen_tip.Label = "genTip";
            this.lb_gen_tip.Name = "lb_gen_tip";
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            // 
            // label1
            // 
            this.label1.Label = "Font:";
            this.label1.Name = "label1";
            // 
            // DD_Font_fx
            // 
            ribbonDropDownItemImpl10.Label = "default";
            ribbonDropDownItemImpl10.Tag = "%%default";
            ribbonDropDownItemImpl11.Label = "txfonts";
            ribbonDropDownItemImpl11.ScreenTip = "\\usepackage{txfonts}";
            ribbonDropDownItemImpl11.Tag = "\\usepackage{txfonts}";
            ribbonDropDownItemImpl12.Label = "fourier";
            ribbonDropDownItemImpl12.ScreenTip = "\\usepackage{fourier}";
            ribbonDropDownItemImpl12.Tag = "\\usepackage{fourier}";
            ribbonDropDownItemImpl13.Label = "mathptmx";
            ribbonDropDownItemImpl13.ScreenTip = "\\usepackage{mathptmx,tgtermes}";
            ribbonDropDownItemImpl13.Tag = "\\usepackage{mathptmx,tgtermes}";
            ribbonDropDownItemImpl14.Label = "charter";
            ribbonDropDownItemImpl14.ScreenTip = "\\usepackage[charter]{mathdesign}";
            ribbonDropDownItemImpl14.Tag = "\\usepackage[charter]{mathdesign}";
            this.DD_Font_fx.Items.Add(ribbonDropDownItemImpl10);
            this.DD_Font_fx.Items.Add(ribbonDropDownItemImpl11);
            this.DD_Font_fx.Items.Add(ribbonDropDownItemImpl12);
            this.DD_Font_fx.Items.Add(ribbonDropDownItemImpl13);
            this.DD_Font_fx.Items.Add(ribbonDropDownItemImpl14);
            this.DD_Font_fx.Label = "TexFont";
            this.DD_Font_fx.Name = "DD_Font_fx";
            this.DD_Font_fx.ShowLabel = false;
            this.DD_Font_fx.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DD_Font_fx_SelectionChanged);
            // 
            // btn_about
            // 
            this.btn_about.Image = global::WordxTex.Properties.Resources.Button_About;
            this.btn_about.Label = "About";
            this.btn_about.Name = "btn_about";
            this.btn_about.ShowImage = true;
            this.btn_about.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_about_Click);
            // 
            // separator4
            // 
            this.separator4.Name = "separator4";
            // 
            // btn_baselineU
            // 
            this.btn_baselineU.Image = global::WordxTex.Properties.Resources.Button_Baseline_Up;
            this.btn_baselineU.Label = "Baseline Move Up";
            this.btn_baselineU.Name = "btn_baselineU";
            this.btn_baselineU.ShowImage = true;
            this.btn_baselineU.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_baselineU_Click);
            // 
            // btn_baselineDn
            // 
            this.btn_baselineDn.Image = global::WordxTex.Properties.Resources.Button_Baseline_Down;
            this.btn_baselineDn.Label = "Baseline Move Down";
            this.btn_baselineDn.Name = "btn_baselineDn";
            this.btn_baselineDn.ShowImage = true;
            this.btn_baselineDn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_baselineDn_Click);
            // 
            // btn_baselineRt
            // 
            this.btn_baselineRt.Image = global::WordxTex.Properties.Resources.Button_Baseline_Reset;
            this.btn_baselineRt.Label = "Baseline Reset";
            this.btn_baselineRt.Name = "btn_baselineRt";
            this.btn_baselineRt.ShowImage = true;
            this.btn_baselineRt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_baselineRt_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Image = global::WordxTex.Properties.Resources.Button_Settings;
            this.btn_settings.Label = "Settings";
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.ShowImage = true;
            this.btn_settings.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_settings_Click);
            // 
            // tab_WordxTex
            // 
            this.tab_WordxTex.Label = "WordxTex";
            this.tab_WordxTex.Name = "tab_WordxTex";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.WordxTex.ResumeLayout(false);
            this.WordxTex.PerformLayout();
            this.tab_WordxTex.ResumeLayout(false);
            this.tab_WordxTex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup WordxTex;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_insertTex;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_insMath;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_insChemReact;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_insChemStruct;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_edit;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_baselineU;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_baselineDn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_baselineRt;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_settings;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_about;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab_WordxTex;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_insplot;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator4;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown DD_Font_fx;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown DD_Complier;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown DD_Grapher;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel lb_gen_tip;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_batchEdit;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_ins_symbol;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon1
        {
            get { return this.GetRibbon<Ribbon>(); } 
        }
    } 
}
