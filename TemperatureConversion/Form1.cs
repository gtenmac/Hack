using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
{
    public partial class Form1 : Form
    {
        private double temp = 0;
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            button2.Click += Button1_Click;
            button3.Click += Button1_Click;
            button4.Click += Button1_Click;
            button5.Click += Button1_Click;
            button6.Click += Button1_Click;
            button7.Click += Button1_Click;
            button8.Click += Button1_Click;
            button9.Click += Button1_Click;
            button10.Click += Button1_Click;
            button11.Click += Button11_Click;
            button12.Click += Button12_Click;
            button13.Click += Button13_Click;
            button14.Click += Button14_Click;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            temp = 0;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                temp = Convert.ToDouble(textBox1.Text);
                label2.Text = "攝氏" + textBox1.Text + " => " + "華氏" + (9 / 5 * temp + 32);
            }
            else
            {
                temp = Convert.ToDouble(textBox1.Text);
                label2.Text = "華氏" + textBox1.Text + " => " + "攝氏" + ((temp - 32) * 5 / 9);
            }
            temp = 0;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (textBox1.Text.Length > 0 && Convert.ToDouble(textBox1.Text) > 0) ? "." : "0.";
            button12.Enabled = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var s = textBox1.Text;
            textBox1.Text = s.Remove(s.Length - 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (((Button)sender).Text);
        }
    }
}
