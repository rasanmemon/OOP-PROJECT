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
    public partial class CF_StudentPanel : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        int stdid,tid,cid;
        string tname,coursename;
        public CF_StudentPanel()
        {
            InitializeComponent();
            
            
        }
        public void getdata(int stdid, int tid, int cid, string tname, string coursename)
        {
            this.stdid = stdid;
            this.tid = tid;
            this.cid=cid;
            this.tname = tname;
            this.coursename = coursename;
            label7.Text = coursename;
            label8.Text = tname;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int q1 = radioButton1.Checked ? 1 :2;
            int q2 = radioButton4.Checked ? 1 : 2;
            int q3 = radioButton5.Checked ? 1 : 2;
            int q4 = radioButton7.Checked ? 1 : 2;
            int q5 = radioButton9.Checked ? 1 : 2;

           
            try
            {
                con.Open();
                SqlCommand c = new SqlCommand("select * from CourseFeedback where s_id=@id", con);
                c.Parameters.AddWithValue("@id", stdid);
                var i2 = c.ExecuteReader();
                if (!i2.Read())
                {
                    SqlCommand cmd = new SqlCommand("insert into CourseFeedback values(@s_id,@T_id,@Course_id,@q1,@q2,@q3,@q4,@q5,1)", con);
                    cmd.Parameters.AddWithValue("@s_id", stdid);
                    cmd.Parameters.AddWithValue("@T_id", tid);
                    cmd.Parameters.AddWithValue("@Course_id", cid);
                    cmd.Parameters.AddWithValue("@q1", q1);
                    cmd.Parameters.AddWithValue("@q2", q2);
                    cmd.Parameters.AddWithValue("@q3", q3);
                    cmd.Parameters.AddWithValue("@q4", q4);
                    cmd.Parameters.AddWithValue("@q5", q5);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("registered!");
                    }
                }
                else
                {
                    MessageBox.Show("your feedback is already recorded");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void CF_StudentPanel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
