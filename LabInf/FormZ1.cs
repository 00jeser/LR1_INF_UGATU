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
    public partial class FormZ1 : Form
    {
        public FormZ1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse((sender as TextBox).Text.Replace('.', ','), out double x))
            {
                double rez = Tan(Sin(x)) + Pow(x, 1d / 3d) - Pow(E, x);
                rezLabel.Text = rez.ToString("F5");
            }
            else
                rezLabel.Text = "Ошибка парсинга строки";
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();
    }
}
