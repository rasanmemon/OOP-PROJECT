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
    public partial class Dashboard_StudentPanel : UserControl
    {
        public Dashboard_StudentPanel()
        {
            InitializeComponent();
        }

        private void Dashboard_StudentPanel_Load(object sender, EventArgs e)
        {

        }
        public void getlabel(int a)
        {
            label3.Text = a.ToString();
        }
    }
}
