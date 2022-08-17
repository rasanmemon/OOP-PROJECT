using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class TeacherPanel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        int stdid, cid;
        string name, course ;
        public TeacherPanel(int stdid)
        {
            InitializeComponent();
            this.stdid = stdid;
            con.Open();
            SqlCommand cmd = new SqlCommand("select s.name,c.c_id,c.course_name from teacher s join course c on s.c_id=c.c_id  where s.Id=@id", con);
            cmd.Parameters.AddWithValue("@id", stdid);
            SqlDataAdapter sad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            this.name = dt.Rows[0][0].ToString();
            this.cid = (int)dt.Rows[0][1];
            this.course = dt.Rows[0][2].ToString();
          
        }
        bool mnuExpanded = false;
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!bunifuTransition1.IsCompleted) return;
            if (panel1.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!mnuExpanded)
                {
                    mnuExpanded = true;
                    panel1.Visible = false;
                    panel1.Width = 200;
                    bunifuTransition1.Show(panel1);
                }
            }
            else
            {
                if (mnuExpanded)
                {
                    mnuExpanded = false;
                    panel1.Visible = false;
                    panel1.Width = 52;
                    bunifuTransition1.Show(panel1);
                }
            }
        }

        private void TeacherPanel_Load(object sender, EventArgs e)
        {
            dashboard_TeacherPanel1.getlabel(stdid);
            dashboard_TeacherPanel1.Show();
            sR_Teacher1.Hide();
            sA_TeacherPanel1.Hide();
            cF_TeacherPanel1.getdata(cid,stdid,course);
            cF_TeacherPanel1.Hide();
            tA_Teacher1.Hide();
            marks_Teacher1.Hide();
        }


        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SRecord_Button_Click(object sender, EventArgs e)
        {
            dashboard_TeacherPanel1.Hide();
            sR_Teacher1.Show();
            sA_TeacherPanel1.Hide();
            cF_TeacherPanel1.Hide();
            tA_Teacher1.Hide();
            marks_Teacher1.Hide();
        }

        private void CF_Button_Click(object sender, EventArgs e)
        {
            
            dashboard_TeacherPanel1.Hide();
            sR_Teacher1.Hide();
            sA_TeacherPanel1.Hide();
            tA_Teacher1.Hide();
            marks_Teacher1.Hide();
            cF_TeacherPanel1.getdata(cid, stdid, course);
            cF_TeacherPanel1.Show();
        }

        private void TAttendance_Button_Click(object sender, EventArgs e)
        {
            dashboard_TeacherPanel1.Hide();
            sR_Teacher1.Hide();
            sA_TeacherPanel1.Hide();
            cF_TeacherPanel1.Hide();
            tA_Teacher1.Show();
            marks_Teacher1.Hide();
        }

        private void Marks_Button_Click(object sender, EventArgs e)
        {
            dashboard_TeacherPanel1.Hide();
            sR_Teacher1.Hide();
            sA_TeacherPanel1.Hide();
            cF_TeacherPanel1.Hide();
            tA_Teacher1.Hide();
            marks_Teacher1.getdata(stdid, cid);
            marks_Teacher1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Button1_Click(object sender, EventArgs e)
        {
            dashboard_TeacherPanel1.getlabel(stdid);
            dashboard_TeacherPanel1.Show();
            sR_Teacher1.Hide();
            sA_TeacherPanel1.Hide();
            cF_TeacherPanel1.Hide();
            tA_Teacher1.Hide();
            marks_Teacher1.Hide();

        }

        private void sR_Teacher1_Load(object sender, EventArgs e)
        {

        }

        private void SAttendance_Button_Click(object sender, EventArgs e)
        {
            dashboard_TeacherPanel1.Hide();
            sR_Teacher1.Hide();
            sA_TeacherPanel1.getdata(cid,stdid);
            sA_TeacherPanel1.Show();
            cF_TeacherPanel1.Hide();
            tA_Teacher1.Hide();
            marks_Teacher1.Hide();
        }

        private void sA_TeacherPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
