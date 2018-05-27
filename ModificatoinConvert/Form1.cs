using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModificatoinConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (sender.Equals(textBox1))
                        textBox4.Focus();
                    else
                        button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = "";

            if (textBox1.Text.Length == 0 || textBox4.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }


        private void textBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (textBox2.Text.IndexOf(',') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    if (sender.Equals(textBox2))
                        textBox5.Focus();
                    else
                        button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox_TextChanged_1(object sender, EventArgs e)
        {
            textBox8.Text = "";

            if (textBox2.Text.Length == 0 || textBox5.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }


        private void textBox_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;

            if (e.KeyChar == '.')
                e.KeyChar = ',';

            if (e.KeyChar == ',')
            {
                if (textBox3.Text.IndexOf(',') != -1)
                    e.Handled = true;
                return;
            }

            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                    if (sender.Equals(textBox3))
                        textBox6.Focus();
                    else
                        button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void textBox_TextChanged_2(object sender, EventArgs e)
        {
            textBox9.Text = "";

            if (textBox3.Text.Length == 0 || textBox6.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double usd;
            double k1;
            double eur;
            double k2;
            double rub;
            double k3;
            double uan;


            if (textBox1.Text.Length != 0 || textBox4.Text.Length != 0)
            {
                usd = Convert.ToDouble(textBox1.Text);
                k1 = Convert.ToDouble(textBox4.Text);

                uan = usd * k1;

                textBox7.Text = uan.ToString("c");
            }

            if (textBox2.Text.Length != 0 || textBox5.Text.Length != 0)
            {
                eur = Convert.ToDouble(textBox2.Text);
                k2 = Convert.ToDouble(textBox5.Text);

                uan = eur * k2;

                textBox8.Text = uan.ToString("c");
            }

            if (textBox3.Text.Length != 0 || textBox6.Text.Length != 0)
            {
                rub = Convert.ToDouble(textBox3.Text);
                k3 = Convert.ToDouble(textBox6.Text);

                uan = rub * k3;

                textBox9.Text = uan.ToString("c");
            }
        }
    }
}
