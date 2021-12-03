using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2_GavrilenkoSergey
{
    public partial class Zad2 : Form
    {
        public Zad2()
        {
            InitializeComponent();
        }

        int Fact(int n) 
        {
            return n switch { <= 1 => 1, _ => Fact(n - 1) * n};
            //return n <= 1 ? 1 : Fact(n - 1);
            //return Range(1, n).Aggregate(1, (a, b) => a * b);
        }

        decimal F(int k)
        {
            return (decimal)Pow(k, k) / Fact(2 * k - 1);
        }


        decimal CalculateE()
        {
            decimal c = 12345;
            int i = 1;
            decimal rez = 0;
            do
            {
                c = F(i);
                rez += c;
                i++;
            }
            while (c > numericUpDown2.Value);
            return rez;
        }
        decimal CalculateN()
        {
            decimal rez = 0;
            for (int i = 1; i <= numericUpDown1.Value; i++)
            {
                rez += F(i);
            }
            return rez;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            RezNumericUpDown.Value = CalculateN();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            RezNumericUpDown.Value = CalculateE();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
                RezNumericUpDown.Value = CalculateN();
            else
                RezNumericUpDown.Value = CalculateE();
        }
    }
}
