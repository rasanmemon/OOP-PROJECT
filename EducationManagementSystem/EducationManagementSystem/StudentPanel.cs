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
    public partial class StudentPanel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        int stdid,cid,t_id;
        string name,course,teacher;
        public StudentPanel()
        {
           
        }
        public StudentPanel(int stdid)
        {
            InitializeComponent();
            this.stdid = stdid;
            con.Open();
            SqlCommand cmd = new SqlCommand("select s.name,c.c_id,c.course_name,t.id,t.name from student s join course c on s.c_id=c.c_id join teacher t on t.c_id=c.c_id where s.Id=@id", con);
            cmd.Parameters.AddWithValue("@id", stdid);
            SqlDataAdapter sad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sad.Fill(dt);
            this.name=dt.Rows[0][0].ToString();
            this.cid = (int)dt.Rows[0][1];
            this.course = dt.Rows[0][2].ToString();
            this.t_id = (int)dt.Rows[0][3];
            this.teacher = dt.Rows[0][4].ToString();
          //  MessageBox.Show(name+cid.ToString()+course+t_id.ToString()+teacher);
        }
        bool mnuExpanded = false;
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

        private void Logout_Button_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void Dashboard_Button_Click(object sender, EventArgs e)
        {
            dashboard_StudentPanel1.getlabel(stdid);
            dashboard_StudentPanel1.Show();
            cF_StudentPanel1.Hide();
            sA_Student1.Hide();
            marks_Student1.Hide();
        }

        private void StudentPanel_Load(object sender, EventArgs e)
        {
            dashboard_StudentPanel1.getlabel(stdid);
            dashboard_StudentPanel1.Show();
            cF_StudentPanel1.Hide();
            sA_Student1.Hide();
            marks_Student1.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CF_Button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();


            cF_StudentPanel1.getdata(stdid, t_id, cid, teacher, course);
            cF_StudentPanel1.Show();
            dashboard_StudentPanel1.Hide();
            sA_Student1.Hide();
            marks_Student1.Hide();
        }

        private void cF_StudentPanel1_Load(object sender, EventArgs e)
        {
            
        }

        private void marks_Student1_Load(object sender, EventArgs e)
        {

        }

        private void SAttendance_Button_Click(object sender, EventArgs e)
        {
            cF_StudentPanel1.Hide();
            dashboard_StudentPanel1.Hide();
            sA_Student1.Show();
            marks_Student1.Hide();
        }

        private void Marks_Button_Click(object sender, EventArgs e)
        {
            cF_StudentPanel1.Hide();
            dashboard_StudentPanel1.Hide();
            sA_Student1.Hide();
            marks_Student1.getdata(stdid, cid,course);
            marks_Student1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_StudentPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
