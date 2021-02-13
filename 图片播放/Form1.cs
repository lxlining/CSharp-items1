using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string filename;
            filename = Application.StartupPath;
            if (i <= 5)
            {
                pictureBox1.Image = Image.FromFile(filename + "\\images\\" + i + ".jpg");
                i++;
            }
            else
            {
                i = 1;
                pictureBox1.Image = Image.FromFile(filename + "\\images\\" + i + ".jpg");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                MessageBox.Show("已经暂停，这是天空图片！");
            }
            else
                timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string filename;
            filename = Application.StartupPath;
            if (this.i == 1)
            {
                i = 5;
                pictureBox1.Image = Image.FromFile(filename + "\\images\\" + i + ".jpg");
            }else
            {
                i--;
                pictureBox1.Image = Image.FromFile(filename + "\\images\\" + i + ".jpg");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string filename;
            filename = Application.StartupPath;
            if (this.i == 5)
            {
                i = 1;
                pictureBox1.Image = Image.FromFile(filename + "\\images\\" + i + ".jpg");
            }
            else
            {
                i++;
                pictureBox1.Image = Image.FromFile(filename + "\\images\\" + i + ".jpg");
            }
        }
    }
}
