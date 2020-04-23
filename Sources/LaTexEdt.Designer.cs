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
            this.btn_gen = new System.Windows.Forms.Button();
            this.logsBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_AutoClose = new System.Windows.Forms.CheckBox();
            this.texCodeBox = new ICSharpCode.TextEditor.TextEditorControl();
            this.btn_prvTex = new System.Windows.Forms.Button();
            this.btn_nxtTeX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.AutoSize = true;
            this.btn_gen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_gen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_gen.Location = new System.Drawing.Point(0, 289);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(434, 22);
            this.btn_gen.TabIndex = 6;
            this.btn_gen.Text = "Generation";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // logsBox
            // 
            this.logsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logsBox.DetectUrls = false;
            this.logsBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logsBox.Location = new System.Drawing.Point(47, 157);
            this.logsBox.Name = "logsBox";
            this.logsBox.ReadOnly = true;
            this.logsBox.Size = new System.Drawing.Size(381, 104);
            this.logsBox.TabIndex = 2;
            this.logsBox.TabStop = false;
            this.logsBox.Text = "";
            this.logsBox.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "logs:";
            // 
            // cb_AutoClose
            // 
            this.cb_AutoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_AutoClose.AutoSize = true;
            this.cb_AutoClose.Checked = true;
            this.cb_AutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_AutoClose.Location = new System.Drawing.Point(8, 267);
            this.cb_AutoClose.Name = "cb_AutoClose";
            this.cb_AutoClose.Size = new System.Drawing.Size(204, 16);
            this.cb_AutoClose.TabIndex = 3;
            this.cb_AutoClose.Text = "Close after compiling success.";
            this.cb_AutoClose.UseVisualStyleBackColor = true;
            // 
            // texCodeBox
            // 
            this.texCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.texCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.texCodeBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.texCodeBox.Highlighting = "TeX";
            this.texCodeBox.Location = new System.Drawing.Point(10, 5);
            this.texCodeBox.Name = "texCodeBox";
            this.texCodeBox.ShowTabs = true;
            this.texCodeBox.ShowVRuler = false;
            this.texCodeBox.Size = new System.Drawing.Size(418, 150);
            this.texCodeBox.TabIndent = 1;
            this.texCodeBox.TabIndex = 1;
            // 
            // btn_prvTex
            // 
            this.btn_prvTex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prvTex.Enabled = false;
            this.btn_prvTex.Location = new System.Drawing.Point(292, 263);
            this.btn_prvTex.Name = "btn_prvTex";
            this.btn_prvTex.Size = new System.Drawing.Size(65, 23);
            this.btn_prvTex.TabIndex = 4;
            this.btn_prvTex.Text = "<Previous";
            this.btn_prvTex.UseVisualStyleBackColor = true;
            this.btn_prvTex.Click += new System.EventHandler(this.btn_prvTex_Click);
            // 
            // btn_nxtTeX
            // 
            this.btn_nxtTeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nxtTeX.Enabled = false;
            this.btn_nxtTeX.Location = new System.Drawing.Point(363, 263);
            this.btn_nxtTeX.Name = "btn_nxtTeX";
            this.btn_nxtTeX.Size = new System.Drawing.Size(65, 23);
            this.btn_nxtTeX.TabIndex = 5;
            this.btn_nxtTeX.Text = "Next>";
            this.btn_nxtTeX.UseVisualStyleBackColor = true;
            this.btn_nxtTeX.Click += new System.EventHandler(this.btn_nxtTeX_Click);
            // 
            // LaTexEdt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btn_nxtTeX);
            this.Controls.Add(this.btn_prvTex);
            this.Controls.Add(this.cb_AutoClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logsBox);
            this.Controls.Add(this.texCodeBox);
            this.Controls.Add(this.btn_gen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "LaTexEdt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "TeX Code Editor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LaTexEdt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gen;
        private ICSharpCode.TextEditor.TextEditorControl texCodeBox;
        private System.Windows.Forms.RichTextBox logsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_AutoClose;
        private System.Windows.Forms.Button btn_prvTex;
        private System.Windows.Forms.Button btn_nxtTeX;
    }
}