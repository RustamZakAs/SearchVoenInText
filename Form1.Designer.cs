namespace SearchVoenInText
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownLen = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.checkBoxCurrency = new System.Windows.Forms.CheckBox();
            this.checkBoxEVHF = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLen)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(-1, -1);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(258, 289);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(356, -2);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(209, 289);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownLen
            // 
            this.numericUpDownLen.Location = new System.Drawing.Point(262, 12);
            this.numericUpDownLen.Name = "numericUpDownLen";
            this.numericUpDownLen.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownLen.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(-1, 288);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(566, 10);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 4;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(272, 225);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(49, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00:00";
            // 
            // labelCount
            // 
            this.labelCount.Location = new System.Drawing.Point(261, 82);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(91, 138);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "Process...";
            // 
            // checkBoxCurrency
            // 
            this.checkBoxCurrency.AutoSize = true;
            this.checkBoxCurrency.Checked = true;
            this.checkBoxCurrency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCurrency.Location = new System.Drawing.Point(265, 37);
            this.checkBoxCurrency.Name = "checkBoxCurrency";
            this.checkBoxCurrency.Size = new System.Drawing.Size(61, 17);
            this.checkBoxCurrency.TabIndex = 7;
            this.checkBoxCurrency.Text = "Məbləğ";
            this.checkBoxCurrency.UseVisualStyleBackColor = true;
            // 
            // checkBoxEVHF
            // 
            this.checkBoxEVHF.AutoSize = true;
            this.checkBoxEVHF.Checked = true;
            this.checkBoxEVHF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEVHF.Location = new System.Drawing.Point(266, 60);
            this.checkBoxEVHF.Name = "checkBoxEVHF";
            this.checkBoxEVHF.Size = new System.Drawing.Size(54, 17);
            this.checkBoxEVHF.TabIndex = 8;
            this.checkBoxEVHF.Text = "EVHF";
            this.checkBoxEVHF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 298);
            this.Controls.Add(this.checkBoxEVHF);
            this.Controls.Add(this.checkBoxCurrency);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.numericUpDownLen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.rtbText);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(580, 336);
            this.MinimumSize = new System.Drawing.Size(580, 336);
            this.Name = "Form1";
            this.Text = "Find in text number by lenght";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownLen;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.CheckBox checkBoxCurrency;
        private System.Windows.Forms.CheckBox checkBoxEVHF;
    }
}

