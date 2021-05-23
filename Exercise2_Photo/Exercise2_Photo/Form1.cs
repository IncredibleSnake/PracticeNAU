using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2_Photo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cost = 0, sum;
            int n;
            if (radioButton1.Checked)
            {
                cost = 8.5;
                label3.Text = "Ціна: " + Convert.ToString(cost) + " грн";
            }
            if (radioButton2.Checked)
            {
                cost = 10;
                label3.Text = "Ціна: " + Convert.ToString(cost) + " грн";
            }
            if (radioButton3.Checked)
            {
                cost = 15.5;
                label3.Text = "Ціна: " + Convert.ToString(cost) + " грн";
            }
            n = Convert.ToInt32(textBox1.Text);
            sum = n * cost;
            textBox2.Text = "Сумма:" + Convert.ToString(sum) + " грн";
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar >= '9'))
                return;

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    button1.Focus();
                }
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
