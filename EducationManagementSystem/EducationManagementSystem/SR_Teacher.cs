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
    public partial class SR_Teacher : UserControl
    {
        public SR_Teacher()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
            SqlCommand cmd = new SqlCommand();
            if (comboBox1.Text == "")
            {
                cmd = new SqlCommand("SELECT * FROM Student", con);
            }
            else if (comboBox1.Text=="Id")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT * FROM Student where [Id] = '" + searchValue + "'", con);
            }
            else if (comboBox1.Text == "Gender")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT * FROM Student where [Gender] = '" + searchValue + "'", con);
            }
            else if (comboBox1.Text == "Course")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT * FROM Student where [Course] = '" + searchValue + "'", con);
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
    }
}
