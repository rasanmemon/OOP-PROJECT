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
    public partial class TARegister_Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        public TARegister_Admin()
        {
            InitializeComponent();
        }

        private void TARegister_Admin_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,name from teacher",con);
            
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
            {


                int valueid = (int)dataGridView1.Rows[rows].Cells[0].Value;

                string valuef = (string)dataGridView1.Rows[rows].Cells[2].Value;
                MessageBox.Show(valuef);
                DateTime da = dateTimePicker1.Value;
               

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into t_attendance values (@t_id,@date,@atten)", con);
                cmd.Parameters.AddWithValue("@t_id", valueid);
                cmd.Parameters.AddWithValue("@date", da);
                cmd.Parameters.AddWithValue("@atten", valuef);
                

                cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Registered");
            }
            catch
            {
                MessageBox.Show("Dont forget to press Enter ,after attendance");
            }
            finally
            {

                con.Close();
            }


            }

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
