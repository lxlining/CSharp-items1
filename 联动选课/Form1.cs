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

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                listBox2.Items.Add(listBox1.SelectedItems[0]);
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            for (i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.Items[i]);
                listBox2.Items.Remove(listBox2.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = listBox1.Items.Count-1; i >=0; i--)
            {
                listBox2.Items.Add(listBox1.Items[i]);
                listBox1.Items.Remove(listBox1.Items[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < listBox2.SelectedItems.Count; i++)
            {
                listBox1.Items.Add(listBox2.SelectedItems[0]);
                listBox2.Items.Remove(listBox2.SelectedItems[0]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("计算机学院");
            comboBox1.Items.Add("数学学院");
            comboBox1.Items.Add("文学学院");
            comboBox1.Items.Add("物理学院");
            comboBox1.Items.Add("化学学院");
            comboBox1.Items.Add("艺术学院");
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex + 1;
            switch (index)
            {
                case 1:
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox1.Items.Add("计算机科学与技术");
                    listBox1.Items.Add("软件工程");
                    listBox1.Items.Add("信息管理");
                    listBox1.Items.Add("智能科学");
                    break;
                case 2:
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox1.Items.Add("应用数学");
                    listBox1.Items.Add("代数");
                    listBox1.Items.Add("统计");
                    listBox1.Items.Add("数学师范");
                    break;
                case 3:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("文学1");
                    listBox1.Items.Add("文学2");
                    listBox1.Items.Add("文学3");
                    listBox1.Items.Add("文学4");
                    break;
                case 4:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("物理1");
                    listBox1.Items.Add("物理2");
                    listBox1.Items.Add("物理3");
                    listBox1.Items.Add("物理4");
                    break;
                case 5:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("化学1");
                    listBox1.Items.Add("化学2");
                    listBox1.Items.Add("化学3");
                    listBox1.Items.Add("化学4");
                    break;
                case 6:
                    listBox1.Items.Clear();
                    listBox1.Items.Add("艺术1");
                    listBox1.Items.Add("艺术2");
                    listBox1.Items.Add("艺术3");
                    listBox1.Items.Add("艺术4");
                    break;
            }
        }
    }
}
