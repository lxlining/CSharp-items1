using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp6
{
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public int insert(String sql)
        {

            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int x=comm.ExecuteNonQuery();
            comm.Dispose();
            conn.Close();
            return x;
        }
            

            private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片文件(*.jpg)|*.jpg|图片文件(*.png)|*.png|所有文件(*.*)|*.*";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                if (fileName != "")
                {
                    pictureBox1.Image = Image.FromFile(fileName);
                    string movename = Application.StartupPath + "\\images\\" + textBox1.Text + ".jpg";
                    
                    File.Copy(fileName, movename);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string lastname = textBox1.Text + ".jpg";
            string sql = "insert into Student(sno,sname,picture) values(N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + lastname + "')";
            int x = insert(sql);
            if (x > 0)
            {
                MessageBox.Show("success!");
                this.Close();
                Form1 f2 = new Form1();
                f2.Show();
            }
            else
                MessageBox.Show("defult!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
