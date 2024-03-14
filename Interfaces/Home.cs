using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit obj3 = new Edit();
            obj3.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report obj4 = new Report();
            obj4.ShowDialog();
        }

        private void newAdmissionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Register_Student obj1 = new Register_Student();
            obj1.ShowDialog();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Student obj2 = new Remove_Student();
            obj2.ShowDialog();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
       
    }
}
