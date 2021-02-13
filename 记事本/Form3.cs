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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string find;
                find = textBox1.Text;
                if (n >= 0)
                {
                    n = Form1.f1.richTextBox1.Find(find, n + find.Length, RichTextBoxFinds.None);
                }
                else
                {
                    MessageBox.Show("最后一个！");
                    n = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.f1.richTextBox1.SelectedText = textBox2.Text;
        }
        int intp = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            string strsearch, strreplace;
            strreplace = textBox2.Text;
            strsearch = textBox1.Text;
           
            intp = Form1.f1.richTextBox1.Find(strsearch, intp, RichTextBoxFinds.None);
            while (intp >= 0)
            {
                Form1.f1.richTextBox1.SelectedText = textBox2.Text;
                intp += strsearch.Length;
                if (intp < Form1.f1.richTextBox1.Text.Length)
                {
                    intp = Form1.f1.richTextBox1.Find(strsearch, intp, RichTextBoxFinds.None);
                }


            }
            MessageBox.Show("替换完毕！");
            intp = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
