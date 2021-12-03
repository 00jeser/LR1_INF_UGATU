using System;
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
    public partial class Zad1 : Form
    {
        public Zad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) => Close();

        private async void button2_Click(object sender, EventArgs e)
        {
            RezTextBox.Clear();
            StringBuilder rez = new();
            await Task.Run(() =>
            {
                double b = (double)numericUpDown1.Value;
                for (double x = (double)numericUpDown2.Value; x <= (double)numericUpDown3.Value + (double)numericUpDown4.Value; x += (double)numericUpDown4.Value)
                {
                    rez.AppendLine($@"{x:F3} - {b * x switch
                    {
                        < 0.6 => Sin(b * x) + Cos(b * x),
                        < 0.9 => 1,
                        _ => b * Pow(x, 3) + Pow(E, b + Pow(x, 5))
                    }}");

                }
            });
            RezTextBox.Text = rez.ToString();
        }
    }
}
