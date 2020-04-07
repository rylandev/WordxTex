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
            this.texCodeBox = new ICSharpCode.TextEditor.TextEditorControl();
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
            this.btn_gen.Size = new System.Drawing.Size(584, 22);
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
            this.label1.Location = new System.Drawing.Point(13, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Run Time:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // box_run_max_time
            // 
            this.box_run_max_time.Location = new System.Drawing.Point(102, 415);
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
            // texCodeBox
            // 
            this.texCodeBox.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.texCodeBox.Highlighting = "TeX";
            this.texCodeBox.Location = new System.Drawing.Point(10, 12);
            this.texCodeBox.Name = "texCodeBox";
            this.texCodeBox.ShowTabs = true;
            this.texCodeBox.Size = new System.Drawing.Size(567, 385);
            this.texCodeBox.TabIndex = 6;
            // 
            // LaTexEdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.texCodeBox);
            this.Controls.Add(this.box_run_max_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaTexEdt";
            this.Text = "Code Edit";
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
    }
}