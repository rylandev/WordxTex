namespace WordxTex
{
    partial class LaTexEdt
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
            this.components = new System.ComponentModel.Container();
            this.btn_gen = new System.Windows.Forms.Button();
            this.Process_Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.box_run_max_time = new System.Windows.Forms.NumericUpDown();
            this.logsbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_AutoClose = new System.Windows.Forms.CheckBox();
            this.texCodeBox = new ICSharpCode.TextEditor.TextEditorControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_prvTex = new System.Windows.Forms.Button();
            this.btn_nxtTeX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box_run_max_time)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.AutoSize = true;
            this.btn_gen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_gen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_gen.Location = new System.Drawing.Point(0, 439);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(684, 22);
            this.btn_gen.TabIndex = 1;
            this.btn_gen.Text = "Generation";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // Process_Timer
            // 
            this.Process_Timer.Interval = 30000;
            this.Process_Timer.Tick += new System.EventHandler(this.Process_Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Run Time:";
            // 
            // box_run_max_time
            // 
            this.box_run_max_time.Location = new System.Drawing.Point(101, 394);
            this.box_run_max_time.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.box_run_max_time.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.box_run_max_time.Name = "box_run_max_time";
            this.box_run_max_time.Size = new System.Drawing.Size(120, 21);
            this.box_run_max_time.TabIndex = 5;
            this.box_run_max_time.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.box_run_max_time.ValueChanged += new System.EventHandler(this.box_run_max_time_ValueChanged);
            // 
            // logsbox
            // 
            this.logsbox.DetectUrls = false;
            this.logsbox.Location = new System.Drawing.Point(55, 318);
            this.logsbox.Name = "logsbox";
            this.logsbox.ReadOnly = true;
            this.logsbox.Size = new System.Drawing.Size(623, 70);
            this.logsbox.TabIndex = 7;
            this.logsbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "logs:";
            // 
            // cb_AutoClose
            // 
            this.cb_AutoClose.AutoSize = true;
            this.cb_AutoClose.Checked = true;
            this.cb_AutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AutoClose.Location = new System.Drawing.Point(10, 417);
            this.cb_AutoClose.Name = "cb_AutoClose";
            this.cb_AutoClose.Size = new System.Drawing.Size(234, 16);
            this.cb_AutoClose.TabIndex = 9;
            this.cb_AutoClose.Text = "Auto close after compiling success.";
            this.cb_AutoClose.UseVisualStyleBackColor = true;
            // 
            // texCodeBox
            // 
            this.texCodeBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.texCodeBox.Highlighting = "TeX";
            this.texCodeBox.Location = new System.Drawing.Point(10, 10);
            this.texCodeBox.Name = "texCodeBox";
            this.texCodeBox.ShowTabs = true;
            this.texCodeBox.ShowVRuler = false;
            this.texCodeBox.Size = new System.Drawing.Size(668, 302);
            this.texCodeBox.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 439);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // btn_prvTex
            // 
            this.btn_prvTex.Enabled = false;
            this.btn_prvTex.Location = new System.Drawing.Point(416, 410);
            this.btn_prvTex.Name = "btn_prvTex";
            this.btn_prvTex.Size = new System.Drawing.Size(125, 23);
            this.btn_prvTex.TabIndex = 11;
            this.btn_prvTex.Text = "<PrevTeXGraphic";
            this.btn_prvTex.UseVisualStyleBackColor = true;
            // 
            // btn_nxtTeX
            // 
            this.btn_nxtTeX.Enabled = false;
            this.btn_nxtTeX.Location = new System.Drawing.Point(547, 410);
            this.btn_nxtTeX.Name = "btn_nxtTeX";
            this.btn_nxtTeX.Size = new System.Drawing.Size(125, 23);
            this.btn_nxtTeX.TabIndex = 12;
            this.btn_nxtTeX.Text = "NextTeXGraphic>";
            this.btn_nxtTeX.UseVisualStyleBackColor = true;
            this.btn_nxtTeX.Click += new System.EventHandler(this.btn_nxtTeX_Click);
            // 
            // LaTexEdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btn_nxtTeX);
            this.Controls.Add(this.btn_prvTex);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cb_AutoClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logsbox);
            this.Controls.Add(this.texCodeBox);
            this.Controls.Add(this.box_run_max_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaTexEdt";
            this.Text = "Code Editor";
            this.Load += new System.EventHandler(this.LaTexEdt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box_run_max_time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void updateSRC(string Code)
        {
            this.texCodeBox.Text = Code;
        }
        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.Timer Process_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown box_run_max_time;
        private ICSharpCode.TextEditor.TextEditorControl texCodeBox;
        private System.Windows.Forms.RichTextBox logsbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_AutoClose;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_prvTex;
        private System.Windows.Forms.Button btn_nxtTeX;
    }
}