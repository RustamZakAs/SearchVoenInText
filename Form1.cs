using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
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
            DateTime startTime = DateTime.Now;
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
            DateTime endTime = DateTime.Now;
            double time = (endTime - startTime).TotalSeconds;
            labelTime.Text = TimeToSrting((int)time);
        }

        static bool IsNumberContains(string input)
        {
            foreach (char c in input)
                if (Char.IsNumber(c))
                    return true;
            return false;
        }

        static void Clear(StringBuilder value)
        {
            value.Length = 0;
            value.Capacity = 0;
        }

        static string TimeToSrting(int seconds)
        {
            StringBuilder time = new StringBuilder(8);
            if (seconds / 3600 < 10) time.Append("0" + (seconds / 3600).ToString());
            else time.Append((seconds / 3600).ToString());
            time.Append(":");
            seconds -= (seconds / 3600) * 3600;
            if (seconds / 60 < 10) time.Append("0" + (seconds / 60).ToString());
            else time.Append((seconds / 60).ToString());
            time.Append(":");
            seconds -= (seconds / 60) * 60;
            if (seconds < 10) time.Append("0" + (seconds).ToString());
            else time.Append((seconds).ToString());
            return time.ToString();
        }

        private int[] CountChar()
        {
            int countDigit = 0;
            int countSymbol = 0;
            string str = rtbText.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    countDigit++;
                }
                else if (Char.IsSymbol(str[i]))
                {
                    countSymbol++;
                }
            }
            //Thread.Sleep(5000);
            int[] vs = new int[2];
            vs[0] = countDigit;
            vs[1] = countSymbol;
            return vs;
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            //Task<int> task = new Task<int>(CountChar);
            //task.Start();

            labelCount.Text = "Process...";
            //int count = await task;
            int[] count = CountChar();
            labelCount.Text = "Char: " + rtbText.Text.Length;
            labelCount.Text += "\n";
            labelCount.Text += "Digit: "+ count[0].ToString();
            labelCount.Text += "\n";
            labelCount.Text += "Symbol: "+ count[1].ToString();
        }
    }
}
