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
    public partial class Zad3 : Form
    {
        public Zad3()
        {
            InitializeComponent();
        }

        private void Zad3_Load(object sender, EventArgs e)
        {
            label1.Text = string.Join('\n', Range(10, 89).Where(x => x * 2 % 10 == 8 && x * 3 % 10 == 7));
        }
    }
}
