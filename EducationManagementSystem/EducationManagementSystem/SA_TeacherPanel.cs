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
    public partial class SA_TeacherPanel : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        int cid,tid;
        public SA_TeacherPanel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            if (comboBox1.Text == "")
            {
                cmd = new SqlCommand("SELECT t.s_id,tt.Name,t.Date,t.Attendance from S_Attendance t join Student tt on t.s_id=tt.id ", con);
            }
            else if (comboBox1.Text == "Id")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT t.s_id,tt.Name,t.Date,t.Attendance from S_Attendance t join Student tt on t.s_id=tt.id where t.s_id= '" + searchValue + "'", con);
            }
            else if (comboBox1.Text == "Date")
            {
                string searchValue = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd = new SqlCommand("SELECT t.s_id,tt.Name,t.Date,t.Attendance from S_Attendance t join Student tt on t.s_id=tt.id where t.Date= '" + searchValue + "'", con);
            }

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
            }
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SARegister_Teacher sart = new SARegister_Teacher();
            sart.getdata(cid,tid);
            sart.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void getdata(int cid,int tid)
        {
            this.cid = cid;
            this.tid = tid;

        }
    }
}
