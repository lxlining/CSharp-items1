using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 评委打分
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        int[,] a = new int[100, 7];
        int max, min, sum;
        private void label7_Click(object sender, EventArgs e)
        {

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            sum = 0;
            if (textBox2.Text == "")
                MessageBox.Show("请评委A打分");
            else if (textBox3.Text == "")
            {
                MessageBox.Show("请评委B打分");               
            }           
            else if (textBox4.Text == "")
            {
                MessageBox.Show("请评委C打分");              
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("请评委D打分");               
            }           
            else
            {
                x = Convert.ToInt32(textBox2.Text);
                max = min = x;
                sum += x;
                x = Convert.ToInt32(textBox3.Text);
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;//()<
                sum += x;
                x = Convert.ToInt32(textBox4.Text);
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;//()<
                sum += x;
                x = Convert.ToInt32(textBox5.Text);
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;//()<
                sum += x;
                sum -= max;
                sum -= min;
                a[i - 1, 0] = Convert.ToInt32(textBox2.Text);
                a[i - 1, 1] = Convert.ToInt32(textBox3.Text);
                a[i - 1, 2] = Convert.ToInt32(textBox4.Text);
                a[i - 1, 3] = Convert.ToInt32(textBox5.Text);
                a[i - 1, 4] = max;
                a[i - 1, 5] = min;
                a[i - 1, 6] = sum;                
               // label6.Text = "请评委为"+Convert.ToString(i) + "号参赛人员打分(十分制)";
                i++;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                if (i == Convert.ToInt32(textBox1.Text) + 1)
                {
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    button3.Enabled = false;
                    MessageBox.Show("已经全部打分");
                }
                else
                    label6.Text = "请评委为" + Convert.ToString(i) + "号参赛人员打分(十分制)";
            }
           
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("请输入参赛人数");
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                label6.Text = "请评委为1号参赛人员打分(十分制)";
                int j = 1;
                int s=Convert.ToInt32(textBox1.Text);
                while (j <= s)
                {
                    comboBox1.Items.Add(Convert.ToString(j));
                    j++;
                }
              
            }
            
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int x = comboBox1.SelectedIndex;           
            listBox1.Items.Add("评委A  "+Convert.ToString(a[x,0]));//()
            listBox1.Items.Add("评委B  "+Convert.ToString(a[x,1]));//()
            listBox1.Items.Add("评委C  " + Convert.ToString(a[x, 2]));//()
            listBox1.Items.Add("评委D  " + Convert.ToString(a[x, 3]));//()
            listBox1.Items.Add("去掉最高分  " + Convert.ToString(a[x, 4]));//()
            listBox1.Items.Add("去掉最低分  " + Convert.ToString(a[x, 5]));//()
            listBox1.Items.Add("最后总分  " + Convert.ToString(a[x, 6]));//()
        }

       
    }
}
