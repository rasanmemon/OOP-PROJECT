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
    public partial class TRegister : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
        public TRegister()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string fname = textBoxFname.Text;
            DateTime dob = dateTimePicker1.Value;
            string gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string phone = textBoxPhone.Text;
            string cnic = CnicBox.Text;
            string address = textBoxAddress.Text;
            string qualification = QualiBox.Text;
            int cid = (int)comboBox1.SelectedValue;
            try
            {
                
                con.Open();
                // SqlCommand cmd = new SqlCommand("INSERT INTO Teacher (Name,Father_Name,Phone,Age,Gender,Cnic,Address,Qualification,c_id) output INSERTED.ID Values('" + name + "','" + fname + "','" + phone + "','" + dob + "','" + gender + "','" + cnic + "','" + address + "','" + qualification + "')", con);
                SqlCommand cmd = new SqlCommand("insert into teacher values(@name,@fname,@phone,@age,@gender,@cnic,@address,@qualification,@cid)", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@age", dob);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@qualification", qualification);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@address", address);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("registered!");
                }


                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            this.Hide();
            
        }

        private void TRegister_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from course", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember="course_name";
                comboBox1.ValueMember="c_id";
                    }
            catch (Exception ex)
            {

            }
            finally {
                con.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
