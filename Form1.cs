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
        public string str { get; set; }
        public Form1()
        {
            InitializeComponent();
            numericUpDownLen.Value = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.Now;
            int strNumLen = Convert.ToInt32(numericUpDownLen.Value);
            str = rtbText.Text;
            progressBar.Minimum = 0;
            progressBar.Maximum = str.Length;
            progressBar.Value = 0;
            StringBuilder sbInfo = new StringBuilder(strNumLen);
            bool isVoenFind = false;
            bool isCurrency = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (!isVoenFind)
                {
                    if (Char.IsNumber((char)str[i]))
                    {
                        sbInfo.Append((char)str[i]);
                    }
                    else if (sbInfo.Length == strNumLen)
                    {
                        rtbInfo.Text += sbInfo.ToString() + "|";
                        isVoenFind = true;
                        sbInfo.Length = 0;
                        sbInfo.Capacity = 0;
                    }
                    else if (sbInfo.Length > 0)
                    {
                        sbInfo.Length = 0;
                        sbInfo.Capacity = 0;
                    }
                }
                if (isVoenFind)
                {
                    if (Char.IsNumber((char)str[i]) || str[i] == '.')
                    {
                        sbInfo.Append((char)str[i]);
                        isCurrency = true;
                    }
                    else if ((char)str[i] == ' ' & isCurrency)
                    {
                        rtbInfo.Text += sbInfo.ToString() + "|\n";

                        isVoenFind = false;
                        isCurrency = false;

                        sbInfo.Length = 0;
                        sbInfo.Capacity = 0;
                    }
                    else if (sbInfo.Length > 0)
                    {
                        sbInfo.Length = 0;
                        sbInfo.Capacity = 0;
                    }
                }
                progressBar.Value += 1;
            }
            DateTime endTime = DateTime.Now;
            double time = (endTime - startTime).TotalSeconds;
            labelTime.Text = TimeToSrting((int)time);
        }

        static bool IsNumberContains(char input)
        {
            //foreach (char c in input)
            //if (Char.IsNumber(c))
            if (Char.IsNumber(input))
                return true;
            return false;
        }

        static bool IsNumberOrPointContains(char input)
        {
            //foreach (char c in input)
            //if (Char.IsNumber(c) || c == '.')
            if (Char.IsNumber(input) || input == '.')
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

        private int CountCharA()
        {
            int count = 0;
            //string str = this.rtbText.Text;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }
            return count;
        }

        private int[] CountChar()
        {
            int countDigit = 0;
            int countSymbol = 0;
            //string str = rtbText.Text;
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
            int[] counts = new int[2];
            counts[0] = countDigit;
            counts[1] = countSymbol;
            return counts;
        }

        private async void rtbText_TextChanged(object sender, EventArgs e)
        {
            str = this.rtbText.Text;
            TextChangedFunction();
            /*
            Task<int> task = new Task<int>(CountCharA);
            task.Start();

            labelCount.Text = "Process...";
            int count = await task;

            labelCount.Text = "Char: " + count.ToString();
            */
            /*
            int[] count = CountChar();
            labelCount.Text = "Char: " + rtbText.Text.Length;
            labelCount.Text += "\n";
            labelCount.Text += "Digit: "+ count[0].ToString();
            labelCount.Text += "\n";
            labelCount.Text += "Symbol: "+ count[1].ToString();
            */
        }

        private async void TextChangedFunction()
        {
            Task<int> task = new Task<int>(CountCharA);
            task.Start(TaskScheduler.Default);

            labelCount.Text = "Process...";
            int count = await task;

            labelCount.Text = "Char: " + count.ToString();
        }
    }
}
