using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int o,c=0;
        string xx="";

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text+"  /  ";
            xx = textBox2.Text;
            textBox2.Text = "";
            o = 3;
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(c==0)
                textBox2.Text += "1";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "1";
                c = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "2";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "2";
                c = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "3";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "3";
                c = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "4";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "4";
                c = 0;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "5";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "5";
                c = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "6";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "6";
                c = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "7";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "7";
                c = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "8";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "8";
                c = 0;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "9";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "9";
                c = 0;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (c == 0)
                textBox2.Text += "0";
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox2.Text += "0";
                c = 0;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox2.Text += ".";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string t2 = textBox2.Text;
            double x = -Convert.ToDouble(t2);
            textBox2.Text = x.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text+"  +  ";
            xx = textBox2.Text;
            textBox2.Text = "";
            o = 0;
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text + "  -  ";
            xx = textBox2.Text;
            textBox2.Text = "";
            o = 1;
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text + "  *  ";
            xx = textBox2.Text;
            textBox2.Text = "";
            o = 2;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text =((Convert.ToDouble(textBox2.Text))/100).ToString();
            c = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            textBox1.Text = "1/" + x.ToString();
            textBox2.Text = (1 / x).ToString();
            c = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            textBox1.Text = "pow(" + x.ToString()+")";
            textBox2.Text = (x * x).ToString();
            c = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            textBox1.Text = "sqrt(" + x.ToString()+")";
            textBox2.Text = (Math.Sqrt(x)).ToString();
            c = 1;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(xx);
            double y = Convert.ToDouble(textBox2.Text);
            textBox1.Text += textBox2.Text;
            switch (o)
            {
                case 0:
                    textBox2.Text = (x + y).ToString();
                    break;
                case 1:
                    textBox2.Text = (x - y).ToString();
                    break;
                case 2:
                    textBox2.Text = (x * y).ToString();
                    break;
                case 3:
                    textBox2.Text = (x / y).ToString();
                    break;
            }
            c = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text = "";
        }
        int i = 1;
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (i > 1)
            {
                textBox2.Text = "";
                textBox1.Text = "";
            }
            else
                textBox2.Text = "";
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int l = textBox2.Text.Length-1;
            string newstr = textBox2.Text.Substring(0, l);
            textBox2.Text = newstr;
        }
    }
}
