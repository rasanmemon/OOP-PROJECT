using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationManagementSystem
{
    public partial class Dashboard_TeacherPanel : UserControl
    {
        public Dashboard_TeacherPanel()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_TeacherPanel_Load(object sender, EventArgs e)
        {

        }
        public void getlabel(int a)
        {
            label3.Text = a.ToString();
        }
    }
}
