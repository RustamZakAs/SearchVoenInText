using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SearchVoenInText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDownLen.Value = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int strNumLen = Convert.ToInt32(numericUpDownLen.Value);
            progressBar.Minimum = 0;
            progressBar.Maximum = rtbText.Text.Length;
            progressBar.Value = 0;
            StringBuilder sb = new StringBuilder(strNumLen);
            for (int i = 0; i < rtbText.Text.Length; i++)
            {
                if (IsNumberContains(rtbText.Text[i].ToString()))
                {
                    sb.Append(rtbText.Text[i].ToString());
                }
                else if (sb.Length == strNumLen)
                {
                    rtbVoen.Text += sb.ToString() + "\n";
                    Clear(sb);
                }
                else if (sb.Length > 0) Clear(sb);
                progressBar.Value += 1; 
            }
        }

        static bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }

        public static void Clear(StringBuilder value)
        {
            value.Length = 0;
            value.Capacity = 0;
        }
    }
}
