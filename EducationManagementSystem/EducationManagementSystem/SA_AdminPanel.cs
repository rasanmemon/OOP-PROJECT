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

    public partial class SA_AdminPanel : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        public SA_AdminPanel()
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
                cmd = new SqlCommand("SELECT t.s_id,tt.Name,t.Date,t.Attendance from S_Attendance t join Student tt on t.s_id=tt.id where t.t_id= '" + searchValue + "'", con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
