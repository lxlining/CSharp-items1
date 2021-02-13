using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        class Create
        {
            Random r = new Random();
            public int a, b, c,x;
            public String s;
            public void CreateRandom()
            {
                a = r.Next(1, 11);
                b = r.Next(1, 11);
                c = r.Next(1, 5);
                if (c == 1)
                    s = "+";
                else if (c == 2)
                    s = "-";
                else if (c == 3)
                    s = "×";
                else
                    s = "÷";
              
            }
            public int clac()
            {
                switch (c)
                {
                    case 1:
                        x = a + b;
                        break;
                    case 2:
                        while (a < b)
                            b = r.Next(1, 11);
                        x = a - b;
                        break;
                    case 3:
                        x = a * b;
                        break;
                    case 4:
                        while (a<b||(a % b) != 0)
                            b = r.Next(1, 11);
                        x = a / b;
                        break;
                }
                return x;
            }
           
        }
       
        int x;
        String s;
        private void Form1_Load(object sender, EventArgs e)
        {
            Create c = new Create();
            c.CreateRandom();
            s = c.s;
            textBox1.Text = c.a.ToString();
            textBox2.Text = s;
            textBox3.Text = c.b.ToString();
            x = c.clac();
        }
        int sum,yes;
        private void button1_Click(object sender, EventArgs e)
        {
            int y = x;
            int n;
            n = Convert.ToInt32(textBox4.Text);
            String ans;
        
         string ValidateAns( int x)
        {
            sum ++;
            if (n == x)
            {
                ans = "正确";
                yes ++;
            }
            else
            {
                ans = "错误";
            }

            return ans;
        }
       
            String str;
            str = textBox1.Text + s + textBox3.Text + "=" + textBox4.Text + "    " + ValidateAns(x);
            listBox1.Items.Add(str);
            Create c = new Create();
            c.CreateRandom();
            s = c.s;
            textBox1.Text = c.a.ToString();
            textBox2.Text = s;
            textBox3.Text = c.b.ToString();
            x = c.clac();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("一共做了" + sum + "题，" + "其中对了" + yes + "题");
        }
    }
}
