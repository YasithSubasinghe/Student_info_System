using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interfaces
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rp = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";//Sql connection
            using (SqlConnection con = new SqlConnection(rp))
            {
                if (textBox1.Text != "")
                {
                    string str = "SELECT Name,RegisterNum,Gender,DOB,Address,Email,Mobile FROM Student WHERE RegisterNum = '" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter daa = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable();
                    daa.Fill(dtt);

                    dataGridView1.DataSource = new BindingSource(dtt, null);
                }
                else
                {
                    MessageBox.Show("Enter Register Number");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}