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
    public partial class TA_Teacher : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");

        public TA_Teacher()
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
                cmd = new SqlCommand("SELECT t.t_id,tt.Name,t.Date,t.Attendance from T_Attendance t join Teacher tt on t.t_id=tt.id ", con);
            }
            else if (comboBox1.Text == "Date")
            {
                string searchValue = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd = new SqlCommand("SELECT t.t_id,tt.Name,t.Date,t.Attendance from T_Attendance t join Teacher tt on t.t_id=tt.id where t.Date= '" + searchValue + "'", con);
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
