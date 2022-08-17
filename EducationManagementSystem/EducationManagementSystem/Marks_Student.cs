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
    public partial class Marks_Student : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        int stdid, cid;
        string course;
        public Marks_Student()
        {
            InitializeComponent();
        }
        public void getdata(int stdid,int cid,string course)
        {
            this.stdid = stdid;
            this.cid = cid;
            this.course = course;
            label10.Text = course;
            dis();
        }
        public void dis()
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("select m.h1m,m.h2m,m.fm from student s left join marks m on m.s_id=@id  ", con);
            cmd.Parameters.AddWithValue("@id", stdid);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
           
            if (dt.Rows[0][0].ToString() == "")
            {
                dt.Rows[0][0] = 0;
            }
            if (dt.Rows[0][1].ToString() == "")
            {
               dt.Rows[0][1] = 0;
            }
            if (dt.Rows[0][2].ToString() == "")
            {
                dt.Rows[0][2] = 0;
            }
            label2.Text= dt.Rows[0][0].ToString();
            label4.Text = dt.Rows[0][1].ToString();
            label6.Text = dt.Rows[0][2].ToString();
            label8.Text = (Convert.ToInt32(label2.Text)+Convert.ToInt32(label4.Text)+Convert.ToInt32(label6.Text)).ToString();
            con.Close();
        }
        private void Marks_Student_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
