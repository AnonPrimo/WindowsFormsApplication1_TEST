using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фунти_кілограми
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double funt;
            double kg;
            try
            {
                funt = double.Parse(textBox1.Text);
                kg = funt * 0.4095;
                label2.Text = kg.ToString("n") + "kg";
            }
            catch
            {
                button1.Focus();
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1)
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
    }
}
