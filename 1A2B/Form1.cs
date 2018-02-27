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
        string number = "";
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
            for(int i = 0;i<4;)
            {
                int num = ran.Next(0, 10);
                if(!number.Contains(Convert.ToString(num)))
                {
                    number += num.ToString();
                    i++;
                }
            }
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
            int A = 0, B = 0;
            var s = textBox1.Text;
            var compare = s.Intersect(number).ToList();
            A = compare.Where(x => number.IndexOf(x) == s.IndexOf(x)).Count();
            B = compare.Count - A;
            textBox2.Text += s + " : " + A + "A" + B + "B\n";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox2.Text = "";
            textBox1.Text = "";
            number = "";
        }
    }
}
