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
    public partial class SR_AdminPanel : UserControl
    {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        public SR_AdminPanel()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SRegister SR = new SRegister();
            SR.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            if (comboBox1.Text == "")
            {
                cmd = new SqlCommand("SELECT t.Id,t.Name,t.Father_Name,t.Phone,t.Age,t.Gender,t.Cnic,t.Address,c.course_name from Student t join Course c on t.c_id=c.c_id", con);
            }
            else if (comboBox1.Text=="Id")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT t.Id,t.Name,t.Father_Name,t.Phone,t.Age,t.Gender,t.Cnic,t.Address,c.course_name from Student t join Course c on t.c_id=c.c_id where t.Id = '" + searchValue + "'", con);
            }
            else if (comboBox1.Text == "Gender")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT t.Id,t.Name,t.Father_Name,t.Phone,t.Age,t.Gender,t.Cnic,t.Address,c.course_name from Student t join Course c on t.c_id=c.c_id where t.Gender = '" + searchValue + "'", con);
            }
            else if (comboBox1.Text == "Course")
            {
                string searchValue = textBox1.Text;
                cmd = new SqlCommand("SELECT t.Id,t.Name,t.Father_Name,t.Phone,t.Age,t.Gender,t.Cnic,t.Address,c.course_name from Student t join Course c on t.c_id=c.c_id where c.Course_name = '" + searchValue + "'", con);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SR_AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello"))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    cmd.CommandText = "Delete from Student where id='" + id + "'";

                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    cmd.ExecuteNonQuery();
                    con.Close();
                 //   MessageBox.Show("fhsaf");
                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
         
            for (int rows = 0; rows < dataGridView1.Rows.Count-1; rows++)
            {
               

                    int valueid = (int)dataGridView1.Rows[rows].Cells[0].Value;
               

                    string valuen = dataGridView1.Rows[rows].Cells[1].Value.ToString();
                // MessageBox.Show(valuen);
                    string valuef = dataGridView1.Rows[rows].Cells[2].Value.ToString();
                    string valuep = dataGridView1.Rows[rows].Cells[3].Value.ToString();
                    string valuea = dataGridView1.Rows[rows].Cells[4].Value.ToString();
                    string valueg = dataGridView1.Rows[rows].Cells[5].Value.ToString();
                    string valuec = dataGridView1.Rows[rows].Cells[6].Value.ToString();
                    string valuead = dataGridView1.Rows[rows].Cells[7].Value.ToString();

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Student SET Name=@n , Father_Name = @f ,Phone = @p, Age = @ag , Gender = @g , CNIC = @cn, Address = @add  Where Id = @id", con);
                    cmd.Parameters.AddWithValue("@n", valuen);
                    cmd.Parameters.AddWithValue("@f", valuef);
                    cmd.Parameters.AddWithValue("@p", valuep);
                    cmd.Parameters.AddWithValue("@ag", valuea);
                    cmd.Parameters.AddWithValue("@g", valueg);
                    cmd.Parameters.AddWithValue("@cn", valuec);
                    cmd.Parameters.AddWithValue("@add", valuead);
                    cmd.Parameters.AddWithValue("@id", valueid);


                    cmd.ExecuteNonQuery();

                    con.Close();

                
                }
        
        }
    }
}
