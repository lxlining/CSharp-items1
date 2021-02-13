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

namespace WindowsFormsApp6
{
    public partial class addGrade : Form
    {
       
        public addGrade()
        {
            InitializeComponent();
            
        }
        //成绩
        public int add(string sql)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int x = comm.ExecuteNonQuery();
            return x;

            comm.Dispose();
            conn.Close();
        }


        private void addGrade_Load(object sender, EventArgs e)
        {
            string sno;
            sno = Form1.f1.label1.Text;
            textBox1.Text = sno.Substring(3, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int grade=Convert.ToInt32(textBox2.Text);
            string sql = "update Student set grade+=" + grade + " where sno=N'"+textBox1.Text+"'";
            int i = add(sql);
            if (i > 0)
            {
                MessageBox.Show("success！");
                this.Close();
            }
            else
            {
                MessageBox.Show("defult！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
