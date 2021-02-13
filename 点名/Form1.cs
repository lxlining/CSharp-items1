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
    public partial class Form1 : Form
    {
        public static Form1 f1 = new Form1();
        public Form1()
        {
            InitializeComponent();
            f1 = this;
        }

        
        



        struct Student
        {
            public string sno;
            public string sname;
            public string picture;
            public int grade;
        }

        Random r = new Random();

       
        public static int MaxLength=0;

        //查询总共人数
        public int queryLength(String sql)
        {
            int m;
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            m = (int)comm.ExecuteScalar();

            comm.Dispose();
            conn.Close();
            return m;
        }

        string[] s=new string[MaxLength];
        
        //手动点名的数据添加
        public void query(String sql)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            //string[] s = new string[MaxLength];
            //int i = 0;
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0).ToString());
            }
           
            comm.Dispose();
           
            conn.Close();
        }

        //手动点名，数据库查询  姓名-》info
        public string query1(String sql)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            string s = "";
            while (dr.Read())
            {
                s = dr.GetString(0).ToString();
            }
            
            comm.Dispose();
            conn.Close();
            return s;
        }
        //随机点名 图片查询
        public string[] query2(String sql)
        {
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            string[] s = new string[MaxLength];
            int i = 0;
            while (dr.Read())
            {
                s[i] = dr.GetString(0).ToString();
                i++;
            }
           
            comm.Dispose();
            conn.Close();
            return s;
        }
        string[] ss = new string[MaxLength];

        //随机点名 信息展示
        public void query3(String sql)
        {
            Student s;
            string strconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr;
            dr = comm.ExecuteReader();
            string sno1="";
            string sname1 = "";
            while (dr.Read())
            {
                s.sname = dr.GetString(0).ToString();
                s.sno = dr.GetString(1).ToString();
                sno1 = dr.GetString(1);
                sname1 = dr.GetString(0);
                
            }
            label1.Text = "";

            label1.Text = "学号：" + sno1 + "  姓名：" + sname1;
            comm.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string sql = "select picture from student";
            ss = query2(sql);
           
           
        }
        int i = 0;
        int count = 0;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            string pic = "";
            timer1.Interval = 100;
            label1.Text = "";
            if (i < ss.Length)
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + ss[i] );
                i++;
                pic = ss[i-1];
            }
            else
            {
                i = 0;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + ss[i] );
                pic = ss[i];
            }

            count++;
            if (count > r.Next(100,150))
            {
                count = 0;
                timer1.Enabled = false;
                string sql="select sname,sno from Student where picture=N'"+pic+"'";
                query3(sql);
                addGrade ag = new addGrade();
                ag.Show();
            }
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string sql = "select picture from Student where sname=N'" + comboBox1.SelectedItem.ToString() + "'";
            string s = query1(sql);
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\images\\" + s);
            string sql1 = "select sname,sno from Student where picture=N'" + s + "'";
            query3(sql1);

            addGrade ag = new addGrade();
            ag.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "select sname from Student";
            query(s);
            string s1 = "select count(*) from Student";
            MaxLength=queryLength(s1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addStudent addStudent = new addStudent();
            addStudent.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gradeShow gs = new gradeShow();
            gs.Show();
        }
    }
}
