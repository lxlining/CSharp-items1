using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string user;
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Random r = new Random();

        int[] a = new int[6];
        int b;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            for (int i = 0; i < 6; i++)
                a[i] = r.Next(1, 34);
            for (int i = 0; i < 6; i++)
                for (int j = i+1; j < 6; j++)
                    while (a[i] == a[j])
                        a[j] = r.Next(1, 34);
            b = r.Next(1, 17);
            textBox1.Text = "";
            for (int i = 0; i < 6; i++)
            {
                if (a[i] == 1)
                    textBox1.Text += "01  ";
                if (a[i] == 2)
                    textBox1.Text += "02  ";
                if (a[i] == 3)
                    textBox1.Text += "03  ";
                if (a[i] == 4)
                    textBox1.Text += "04  ";
                if (a[i] == 5)
                    textBox1.Text += "05  ";
                if (a[i] == 6)
                    textBox1.Text += "06  ";
                if (a[i] == 7)
                    textBox1.Text += "07  ";
                if (a[i] == 8)
                    textBox1.Text += "08  ";
                if (a[i] == 9)
                    textBox1.Text += "09  ";
               if(a[i]>9)
                    textBox1.Text += a[i].ToString()+"  ";
            }
            textBox2.Text = "";
            if (b == 1)
                textBox2.Text += "01  ";
            else if (b == 2)
                textBox2.Text += "02  ";
            else if (b == 3)
                textBox2.Text += "03  ";
            else if (b == 4)
                textBox2.Text += "04  ";
            else if (b == 5)
                textBox2.Text += "05  ";
            else if (b == 6)
                textBox2.Text += "06  ";
            else if (b == 7)
                textBox2.Text += "07  ";
            else if (b == 8)
                textBox2.Text += "08  ";
            else if (b == 9)
                textBox2.Text += "09  ";
            else
                textBox2.Text += b.ToString() + "  ";
        }
        String str;
        private void button2_Click(object sender, EventArgs e)
        {
            str = textBox1.Text;
            panel1.Visible = true;
            panel2.Visible = true;

            if (str.Length !=6||textBox2.Text.Length!=1)
            {
                MessageBox.Show("需满足要求，红球数为6、蓝球数1");
            }
            else
            {
               
                String[] arrStr = str.Split(' ');
                //string[] str = "1,2,3,11,12,13".Split(',')
                int[] a = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    a[i] = int.Parse(arrStr[i]);
                }

                b = int.Parse(textBox2.Text);
            }
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        //红球，蓝球中的个数
        int sum;
        
        private void button3_Click(object sender, EventArgs e)
        {
           
            int[] aa = new int[6];
            int bb;
            sum = 0;
            int a2 = a[5];
            aa[0] = r.Next(1, 34);
            aa[1] = a[1];
            aa[2] = r.Next(1, 34);
            aa[3] = a[3];
            aa[4] = r.Next(1, 34);
            aa[5] = a2;
            bb = r.Next(1, 17);
            string num1,num2="";
            num1 = textBox1.Text + " " + textBox2.Text;
            for(int i = 0; i < 6; i++)
            {
                num2 = aa[i].ToString()+" ";
             }
            num2 += bb.ToString();
            textBox3.Text = "";
            for (int i = 0; i < 6; i++)
            {
                if (aa[i] == 1)
                    textBox3.Text += "01  ";
                if (aa[i] == 2)
                    textBox3.Text += "02  ";
                if (aa[i] == 3)
                    textBox3.Text += "03  ";
                if (aa[i] == 4)
                    textBox3.Text += "04  ";
                if (aa[i] == 5)
                    textBox3.Text += "05  ";
                if (aa[i] == 6)
                    textBox3.Text += "06  ";
                if (aa[i] == 7)
                    textBox3.Text += "07  ";
                if (aa[i] == 8)
                    textBox3.Text += "08  ";
                if (aa[i] == 9)
                    textBox3.Text += "09  ";
                if(aa[i]>=10)
                    textBox3.Text += aa[i].ToString() + "  ";

            }
            textBox4.Text = "";
            if (bb == 1)
                textBox4.Text += "01  ";
            else if (bb == 2)
                textBox4.Text += "02  ";
            else if (bb == 3)
                textBox4.Text += "03  ";
            else if (bb == 4)
                textBox4.Text += "04  ";
            else if (bb == 5)
                textBox4.Text += "05  ";
            else if (bb == 6)
                textBox4.Text += "06  ";
            else if (bb == 7)
                textBox4.Text += "07  ";
            else if (bb == 8)
                textBox4.Text += "08  ";
            else if (bb == 9)
                textBox4.Text += "09  ";
            else
                textBox4.Text += bb.ToString() + "  ";

            
            for (int i = 0; i < 6; i++)
            {
                if (aa[i] == a[i])
                    sum += 1;
            }
            listBox1.Items.Clear();
            int zj=2;
            int price=0;
            switch (sum)
            {
                case 0:
                case 1:
                case 2:
                    {
                        if (bb == b)
                        {
                            listBox1.Items.Add("恭喜你中了六等奖，5元");
                            zj = 1;
                            price = 5;
                        }else
                        {
                            listBox1.Items.Add("很遗憾，你未中奖！");
                        }
                        break;
                    }
                case 3:
                    {
                        if (bb == b)
                        {
                            listBox1.Items.Add("恭喜你中了五等奖，10元");
                            zj = 1;
                            price = 10;
                        }
                        else
                        {
                            listBox1.Items.Add("很遗憾，你未中奖！");
                        }
                        break;
                    }
                case 4:
                    {
                        if (bb == b)
                        {
                            listBox1.Items.Add("恭喜你中了四等奖，200元");
                            zj = 1;
                            price = 20;
                        }
                        else
                        {
                            listBox1.Items.Add("恭喜你中了五等奖，10元");
                            zj = 1;
                            price = 10;
                        }
                        break;
                    }
                case 5:
                    {
                        if (bb == b)
                        {
                            listBox1.Items.Add("恭喜你中了三等奖，3000元");
                            zj = 1;
                            price = 3000;
                        }
                        else
                        {
                            listBox1.Items.Add("恭喜你中了四等奖，200元");
                            zj = 1;
                            price = 200;
                        }
                        break;
                    }
                case 6:
                    {
                        if (bb == b)
                        {
                            listBox1.Items.Add("恭喜你中了一等奖，5000000元");
                            zj = 1;
                            price = 5000000;
                        }
                        else
                        {
                            listBox1.Items.Add("恭喜你中了二等奖，100000元");
                            zj = 1;
                            price = 100000;
                        }
                        break;
                    }
                default:
                    listBox1.Items.Add("很遗憾，你未中奖！");
                    break;
            }
            string name = textBox5.Text;
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string sql = "insert into T_info(username,price,number) values(N'"+name+"',"+price+",N'"+ textBox1.Text +" "+ textBox2.Text + "')";
            SqlCommand comm = new SqlCommand(sql,conn);
           
            comm.ExecuteNonQuery();

            MessageBox.Show("success");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text+" ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text + " ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text + " ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text + " ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text + " ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text + " ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text + " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text + " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text + " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text + " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text + " ";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += button26.Text + " ";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += button25.Text + " ";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += button24.Text + " ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += button23.Text + " ";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += button22.Text + " ";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += button21.Text + " ";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += button20.Text + " ";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += button19.Text + " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text + " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += button17.Text + " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += button16.Text + " ";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += button37.Text + " ";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += button36.Text + " ";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text += button35.Text + " ";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            textBox1.Text += button34.Text + " ";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text += button33.Text + " ";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += button32.Text + " ";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += button31.Text + " ";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += button30.Text + " ";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += button29.Text + " ";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += button28.Text + " ";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += button27.Text + " ";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox2.Text += button38.Text;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox2.Text += button39.Text;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox2.Text += button40.Text;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox2.Text += button41.Text ;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Text += button45.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox2.Text += button44.Text ;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox2.Text += button43.Text;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox2.Text += button42.Text;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox2.Text += button49.Text ;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox2.Text += button48.Text ;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox2.Text += button47.Text ;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox2.Text += button46.Text ;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox2.Text += button53.Text ;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox2.Text += button52.Text ;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox2.Text += button51.Text;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox2.Text += button50.Text;
        }

        private void textBox1_SizeChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 6)
            {
                textBox2.Focus();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            ShowData s = new ShowData();
            s.Show(); ;
            this.Hide();
        }
    }
}
