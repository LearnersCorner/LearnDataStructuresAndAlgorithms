using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;

namespace LearnDataStructuresAndAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reverse(int.Parse(textBox1.Text));
        }

        public int Reverse(int x)
        {

            int result = 0;

            while (x != 0)
            {
                try
                {
                    result = checked((result * 10) + x % 10);
                    x /= 10;
                }
                catch (System.OverflowException ex)
                {
                    return 0;
                }
            }

            return result;
        }

        private void btnIsMatch_Click(object sender, EventArgs e)
        {
            //txtIsMatch.Text = IsMatch(txtString.Text, txtPattern.Text).ToString();
            //txtIsMatch.Text = Sum(int.Parse(txtString.Text)).ToString();
            //txtIsMatch.Text = IsArrayInSequence(txtString.Text.Split(',').Select(a => int.Parse(a)).ToArray()).ToString();
            Algorithms.BackTracking oBackTracking = new BackTracking();
            txtIsMatch.Text = String.Join("\r\n", oBackTracking.GetCominationsAlternate(txtString.Text.Split(',').Select(a => a).ToArray(), int.Parse(txtPattern.Text)).Select(a => a.Select(b => b.ToString()).Aggregate((c,d) => c + "," + d)));
        }

        private bool IsArrayInSequence(int[] input, int Index = 0)
        {
            if (Index == input.Length - 1)
                return true;
            else
                return input[Index] + 1 == input[Index + 1] && IsArrayInSequence(input, Index + 1);
        }

        private int Sum(int x)
        {
            if (x / 10 == 0)
                return x % 10;
            else
                return Sum(x / 10) + x % 10;
        }


        private bool IsMatch(string strString, string strPattern)
        {
            bool[,] dp = new bool[strString.Length + 1, strPattern.Length + 1];
            dp[strString.Length, strPattern.Length] = true;

            for(int i = strString.Length - 1; i >= 0; i--)
            {
                for(int j = strPattern.Length - 1; j >= 0; j--)
                {
                    bool firstMatch = i < strString.Length && (strString[i] == strPattern[j] || strPattern[j] == '.');

                    if (j + 1 < strPattern.Length && strPattern[j + 1] == '*')
                        dp[i, j] = dp[i, j + 2] || (firstMatch && dp[i + 1, j]);
                    else
                        dp[i, j] = dp[i + 1, j+1];
                }
            }
            return dp[0, 0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
