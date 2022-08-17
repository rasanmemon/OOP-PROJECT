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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Load_Form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void Login_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K8AHF02\SQLEXPRESS01;database=OOPProject;UID=helloworld;password=hello");
            SqlCommand cmd = new SqlCommand();
            string choice = "";

            if (radioButton1.Checked)
            {
                choice = "Admin";
                Console.Out.WriteLine(choice);
            }
            else if ( radioButton2.Checked)
            {
                choice = "Teacher";
            }
            else if ( radioButton3.Checked)
            {
                choice = "Student";
                Console.Out.WriteLine(choice);
            }
            
            if (choice == "Admin")
            {
                if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("Username or Password empty"); }
                else
                {
                    if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                    {
                        Admin_Panel ap = new Admin_Panel();
                        ap.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Id and Password");
                    }
                }
            }
            else if (choice == "Teacher")
            {
                try
                {
                    if (textBox1.Text == "" || textBox2.Text == "") { MessageBox.Show("Username or Password empty"); }
                    else
                    {

                        con.Open();
                        cmd = new SqlCommand("SELECT * FROM Teacher where [Id]  = '" + textBox1.Text + "' and [Cnic]= '" + textBox2.Text + "'", con);
                        //int i = (int)cmd.ExecuteNonQuery();
                        SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        //Console.WriteLine(i);
                        if (dt.Rows.Count == 1)
                        {
                            TeacherPanel tp = new TeacherPanel(Convert.ToInt32(textBox1.Text));
                            tp.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Wrong Id and Password");
                        }
                        con.Close();
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }

             
            }
            else if (choice == "Student" )
            {
                
                try
                {
                    if (textBox1.Text=="" || textBox2.Text=="") { MessageBox.Show("Username or Password empty"); }
                    else
                    {

                    con.Open();
                    cmd = new SqlCommand("SELECT * FROM Student where [Id]  = '" + textBox1.Text + "' and [Cnic]= '"+ textBox2.Text+"'", con);
                    //int i = (int)cmd.ExecuteNonQuery();
                     SqlDataAdapter adpt =new SqlDataAdapter(cmd) ;
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        //Console.WriteLine(i);
                    if( dt.Rows.Count == 1 )
                    {
                        StudentPanel sp = new StudentPanel(Convert.ToInt32(textBox1.Text));
                        sp.Show();
                        this.Hide();
                    }
                    
                    else
                    {
                        MessageBox.Show("Wrong Id and Password");
                    }
                    con.Close();
                    }
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Wrong Id and Password");
            }
            //View.UserDetails.ID = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
