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
    public partial class CF_TeacherPanel : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        string coursename;
        int cid,stdid;
        public CF_TeacherPanel()
        {
            InitializeComponent();
        }

        public void getdata(int cid,int tid,string coursename)
        {
            stdid = tid;
            this.cid = cid;
            this.coursename = coursename;
            label7.Text = coursename;
            dis();
        }
        public void dis()
        {
            try
            {
                con.Open();
                SqlCommand c11 = new SqlCommand("select count(q1) from CourseFeedback where t_id=@id and q1=1", con);
                c11.Parameters.AddWithValue("@id", stdid);
                label18.Text = c11.ExecuteScalar().ToString();
                SqlCommand c12 = new SqlCommand("select count(q1) from CourseFeedback where t_id=@id and q1=2", con);
                c12.Parameters.AddWithValue("@id", stdid);
                label19.Text = c12.ExecuteScalar().ToString();

                SqlCommand c21 = new SqlCommand("select count(q2) from CourseFeedback where t_id=@id and q2=1", con);
                c21.Parameters.AddWithValue("@id", stdid);
                label20.Text = c21.ExecuteScalar().ToString();
                SqlCommand c22 = new SqlCommand("select count(q2) from CourseFeedback where t_id=@id and q2=2", con);
                c22.Parameters.AddWithValue("@id", stdid);
                label21.Text = c22.ExecuteScalar().ToString();

                SqlCommand c31 = new SqlCommand("select count(q3) from CourseFeedback where t_id=@id and q3=1", con);
                c31.Parameters.AddWithValue("@id", stdid);
                label22.Text = c31.ExecuteScalar().ToString();
                SqlCommand c32 = new SqlCommand("select count(q3) from CourseFeedback where t_id=@id and q3=2", con);
                c32.Parameters.AddWithValue("@id", stdid);
                label23.Text = c32.ExecuteScalar().ToString();

                SqlCommand c41 = new SqlCommand("select count(q4) from CourseFeedback where t_id=@id and q4=1", con);
                c41.Parameters.AddWithValue("@id", stdid);
                label24.Text = c41.ExecuteScalar().ToString();
                SqlCommand c42 = new SqlCommand("select count(q4) from CourseFeedback where t_id=@id and q4=2", con);
                c42.Parameters.AddWithValue("@id", stdid);
                label25.Text = c42.ExecuteScalar().ToString();

                SqlCommand c51 = new SqlCommand("select count(q5) from CourseFeedback where t_id=@id and q5=1", con);
                c51.Parameters.AddWithValue("@id", stdid);
                label26.Text = c51.ExecuteScalar().ToString();
                SqlCommand c52 = new SqlCommand("select count(q5) from CourseFeedback where t_id=@id and q5=2", con);
                c52.Parameters.AddWithValue("@id", stdid);
                label27.Text = c52.ExecuteScalar().ToString();

               
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void CF_TeacherPanel_Load(object sender, EventArgs e)
        {
            
            

        }
    }
}
