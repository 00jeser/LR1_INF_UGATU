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
    public partial class FormZ3 : Form
    {
        public FormZ3()
        {
            InitializeComponent();
        }
        string input1 = "", input2 = "", action = "";

        private void Equalse(object sender, EventArgs e)
        {
            double rez = action switch
            {
                "-" => double.Parse(input1) - double.Parse(input2),
                "+" => double.Parse(input1) + double.Parse(input2),
                "*" => double.Parse(input1) * double.Parse(input2),
                "/" => double.Parse(input1) / double.Parse(input2),
                "_" => double.NaN
            };
            Clear(null, null);
            label1.Text = rez.ToString();
        }

        private void Clear(object sender, EventArgs e)
        {
            input2 = "";
            action = "";
            input1 = "";
            label1.Text = "";
        }

        private void NumInput(object sender, EventArgs e)
        {
            if (action == "")
            {
                if (!((sender as Button).Text == "," && input1.Contains(',')))
                    input1 += (sender as Button).Text;
                label1.Text = input1;
            }
            else
            {
                if (!((sender as Button).Text == "," && input2.Contains(',')))
                    input2 += (sender as Button).Text;
                label1.Text = $"{input1} {action} {input2}";
            }
        }
        private void ActionInput(object sender, EventArgs e)
        {
            if (input2 == "")
            {
                action = (sender as Button).Text;
                label1.Text = $"{input1} {action}";
            }
        }
    }
}
