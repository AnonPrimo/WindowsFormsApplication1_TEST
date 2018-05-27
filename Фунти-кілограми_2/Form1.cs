using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фунти_кілограми_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1 || textBox1.Text.Length == 0)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "";

            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double funt;
            double kg;

            funt = Convert.ToDouble(textBox1.Text);

            kg = funt * 0.4095;

            label2.Text = funt.ToString("n") + " ф. = " + kg.ToString("n") + " кг";
        }
    }
}
