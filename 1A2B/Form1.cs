using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class Form1 : Form
    {
        List<int> number;
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            List<int> tmp = new List<int>();
            for(int i = 0;i<4;)
            {
                int num = ran.Next(0, 10);
                if(!tmp.Contains(num))
                {
                    tmp.Add(num);
                    i++;
                }
            }
            number = tmp;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = "";
            foreach (var item in number)
            {
                tmp += item;
            }
            MessageBox.Show(tmp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == number.Count)
            {
                string num = textBox1.Text;
                int A = 0;
                int B = 0;
                for (int i = 0; i < number.Count; i++)
                {
                    if (number[i] == int.Parse(num[i].ToString()))
                    {
                        A += 1;
                    }
                    else
                    {
                        if (number.Contains(int.Parse(num[i].ToString())))
                        {
                            B += 1;
                        }
                    }
                }
                textBox2.Text += num + " : " + A + "A" + B + "B\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox2.Text = "";
            textBox1.Text = "";
            number = new List<int>();
        }
    }
}
