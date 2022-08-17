using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EducationManagementSystem
{
    public partial class Marks_Admin : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        int stdid, cid;
        public Marks_Admin()
        {
            InitializeComponent();
        }
        public void dis()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select s.id,s.name,m.h1m,m.h2m,m.fm from student s left join marks m on m.s_id=s.id ", con);
            
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
            }
            con.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select s.id,s.name,m.h1m,m.h2m,m.fm from student s left join marks m on m.s_id=s.id  ", con);
             
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            else if (comboBox1.Text == "Id")
            {
                string search = textBox1.Text;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select s.id,s.name,m.h1m,m.h2m,m.fm from student s left join marks m on m.s_id=s.id where m.s_id= '" + search + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            else if (comboBox1.Text == "Name")
            {
                string search = textBox1.Text;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select s.id,s.name,m.h1m,m.h2m,m.fm from student s left join marks m on m.s_id=s.id  where m.s_name= '" + search + "'", con);
                cmd.Parameters.AddWithValue("@c_id", cid);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
            else if(comboBox1.Text == "Course_id")
            {
                string search = textBox1.Text;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                con.Open();
                SqlCommand cmd = new SqlCommand("select s.id,s.name,m.h1m,m.h2m,m.fm from student s left join marks m on m.s_id=s.id  where m.course_id= '" + search + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }
                con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {

                int valueid = (int)dataGridView1.Rows[rows].Cells[0].Value;
                string valuen = (string)dataGridView1.Rows[rows].Cells[1].Value;
                var h1m = dataGridView1.Rows[rows].Cells[2].Value;
                var h2m = dataGridView1.Rows[rows].Cells[3].Value;
                var final = dataGridView1.Rows[rows].Cells[4].Value;


                con.Open();
                try
                {
                    SqlCommand cmd2 = new SqlCommand("select * from marks where s_id=@s_id", con);
                    cmd2.Parameters.AddWithValue("@s_id", valueid);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        SqlCommand cmd = new SqlCommand("update Marks set course_id=@course_id,t_id=@T_id,s_name=@s_name,h1m=@h1m,h2m=@h2m,fm=@fm where s_id=@s_id", con);
                        cmd.Parameters.AddWithValue("@s_id", valueid);
                        cmd.Parameters.AddWithValue("@s_name", valuen);
                        cmd.Parameters.AddWithValue("@course_id", cid);
                        cmd.Parameters.AddWithValue("@T_id", stdid);
                        cmd.Parameters.AddWithValue("@h1m", h1m);
                        cmd.Parameters.AddWithValue("@h2m", h2m);
                        cmd.Parameters.AddWithValue("@fm", final);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into Marks values (@s_id,@course_id,@T_id,@s_name,@h1m,@h2m,@fm)", con);
                        cmd.Parameters.AddWithValue("@s_id", valueid);
                        cmd.Parameters.AddWithValue("@s_name", valuen);
                        cmd.Parameters.AddWithValue("@course_id", cid);
                        cmd.Parameters.AddWithValue("@T_id", stdid);
                        cmd.Parameters.AddWithValue("@h1m", h1m);
                        cmd.Parameters.AddWithValue("@h2m", h2m);
                        cmd.Parameters.AddWithValue("@fm", final);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Marks Registered");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
                finally
                {
                    con.Close();

                }
            }
        }
    }
}
