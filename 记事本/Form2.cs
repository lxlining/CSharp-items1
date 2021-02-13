using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 记事本
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int n = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            if (textBox1.Text=="")
            {
                textBox1.Text = Form1.f1.richTextBox1.SelectedText;
            }
            str = textBox1.Text;

            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.MatchCase);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            n = 0;
                        }
                    }
                    else
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.MatchCase);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            MessageBox.Show("已经查找到文件尾！", "查找结束");
                            n = 0;
                        }
                    }
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.None);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            n = 0;
                        }
                    }
                    else
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.MatchCase);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            MessageBox.Show("已经查找到文件尾！", "查找结束");
                            n = 0;
                        }
                    }
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    if (checkBox2.Checked)
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.MatchCase);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            n = 0;
                        }
                    }
                    else
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.MatchCase);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            MessageBox.Show("已经查找到文件尾！", "查找结束");
                            n = 0;
                        }
                    }
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.None);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            n = 0;
                        }
                    }
                    else
                    {
                        n = Form1.f1.richTextBox1.Find(str, n, RichTextBoxFinds.MatchCase);
                        if (n >= 0)
                        {
                            n -= str.Length;
                        }
                        else
                        {
                            MessageBox.Show("已经查找到文件尾！", "查找结束");
                            n = 0;
                        }
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
