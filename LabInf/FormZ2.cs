using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1_GavrilenkoSergey
{
    public partial class FormZ2 : Form
    {
        public FormZ2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        double a = -0.5, b = 1.7, t = 0.44;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                SetVal(b * Sin(a * t * t * Cos(2 * t)) - 1);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                SetVal(Pow(E, -b * t) * Sin(a * t + b) - Sqrt(Abs(b * t + a)));
            }
        }

        private void SetVal(double val)
        {
            if (checkBox1.Checked)
            {
                rezLabel.Text = val.ToString("F3");
            }
            else
            {
                rezLabel.Text = val.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
