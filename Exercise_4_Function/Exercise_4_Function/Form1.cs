using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4_Function
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double y = 0;
            double x = 0.008;
            double z = 0.005;
            y = (1 + z) * (x + y) / ((z + y / 2) - x);
            textBox1.Text = Convert.ToString(y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "y1 ~= 0,00794488 y2~=2/02394";
        }


    }
}
