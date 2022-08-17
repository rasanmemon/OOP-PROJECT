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
    public partial class CF_Admin : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");

        public CF_Admin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                if(comboBox1.Text == "")
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    cmd =new SqlCommand("Select s.name ,t.name,c.course_name,cf.q1,cf.q2,cf.q3,cf.q4,cf.q5 from CourseFeedback cf join Student s on s.id=cf.s_id join Teacher t on t.id=cf.t_id join Course c on c.c_id=cf.course_id",con);
                }
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridView1.Rows.Add(dr.ItemArray);
                }

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void CF_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
