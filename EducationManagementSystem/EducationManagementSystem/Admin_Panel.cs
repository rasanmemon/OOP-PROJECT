using BunifuAnimatorNS;
using EducationManagementSystem.Controller;
using EducationManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }
        bool mnuExpanded = false;
        
        

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            dashboard_AdminPanel1.Show();
            sR_AdminPanel1.Hide();
            tR_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Hide();
            cF_Admin1.Hide();
            marks_Admin1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void MouseDetect_Tick(object sender, EventArgs e)
        {
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
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
     
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void SRecord_Button_Click_1(object sender, EventArgs e)
        {
            sR_AdminPanel1.Show();
            dashboard_AdminPanel1.Hide();
            tR_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Hide();
            cF_Admin1.Hide();
            marks_Admin1.Hide();

        }

        private void Dashboard_Button_Click_1(object sender, EventArgs e)
        {

            dashboard_AdminPanel1.Show();
            tR_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Hide();
            sR_AdminPanel1.Hide();
            cF_Admin1.Hide();
            marks_Admin1.Hide();
        }

        private void dashboard_AdminPanel1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Marks_Button_Click(object sender, EventArgs e)
        {
            tR_AdminPanel1.Hide();
            sR_AdminPanel1.Hide();
            dashboard_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Hide();
            cF_Admin1.Hide();
            marks_Admin1.Show();
        }

        private void CF_Button_Click(object sender, EventArgs e)
        {
            tR_AdminPanel1.Hide();
            sR_AdminPanel1.Hide();
            dashboard_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Hide();
            cF_Admin1.Show();
        }

        private void TAttendance_Button_Click(object sender, EventArgs e)
        {
            tR_AdminPanel1.Hide();
            sR_AdminPanel1.Hide();
            dashboard_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Show();
            cF_Admin1.Hide();
        }

        private void SAttendance_Button_Click(object sender, EventArgs e)
        {
            tR_AdminPanel1.Hide();
            sR_AdminPanel1.Hide();
            dashboard_AdminPanel1.Hide();
            sA_AdminPanel1.Show();
            tA_AdminPanel1.Hide();
            cF_Admin1.Hide();
            marks_Admin1.Hide();
        }

        private void TRecord_Button_Click(object sender, EventArgs e)
        {
            tR_AdminPanel1.Show();
            sR_AdminPanel1.Hide();
            dashboard_AdminPanel1.Hide();
            sA_AdminPanel1.Hide();
            tA_AdminPanel1.Hide();
            cF_Admin1.Hide();
            marks_Admin1.Hide();
        }

        private void sR_AdminPanel1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SRegister sR = new SRegister();
            sR.Show();
        }
    }
}
