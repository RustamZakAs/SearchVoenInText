﻿namespace SearchVoenInText
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
            this.rtbInfo.Location = new System.Drawing.Point(336, -2);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(229, 289);
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
            this.numericUpDownLen.Location = new System.Drawing.Point(263, 12);
            this.numericUpDownLen.Name = "numericUpDownLen";
            this.numericUpDownLen.Size = new System.Drawing.Size(67, 20);
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
            this.labelTime.Location = new System.Drawing.Point(272, 221);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(49, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "00:00:00";
            // 
            // labelCount
            // 
            this.labelCount.Location = new System.Drawing.Point(259, 138);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(71, 48);
            this.labelCount.TabIndex = 6;
            this.labelCount.Text = "Process...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 298);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.numericUpDownLen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.rtbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}

