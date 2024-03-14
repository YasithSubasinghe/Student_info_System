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
    public partial class Remove_Student : Form
    {
        public Remove_Student()
        {
            InitializeComponent();

            //Start level-show the all student data in data grid view

            string rem = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";//Sql connection
            using (SqlConnection con = new SqlConnection(rem))
               {

                   string str = "SELECT Name,RegisterNum,Gender,DOB,Address,Email,Mobile FROM Student";
                   SqlCommand cmd = new SqlCommand(str, con);
                   SqlDataAdapter da = new SqlDataAdapter(cmd);
                   DataTable dt = new DataTable();
                   da.Fill(dt);

                   dataGridView1.DataSource = new BindingSource(dt, null);
               }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox8.Text == "")
            {
                MessageBox.Show("Please Enter Registration number");
            }
            else
            {
                string re = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";//Sql connection
                using (SqlConnection con = new SqlConnection(re))
                {

                    string str = "DELETE FROM Student WHERE RegisterNum = '" + textBox8.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);

                }
                textBox8.Text = "";

                string rem = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";//Sql connection
                using (SqlConnection con = new SqlConnection(rem))
                {

                    string str = "SELECT Name,RegisterNum,Gender,DOB,Address,Email,Mobile FROM Student";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);

                    MessageBox.Show("Student Remove Successfully");
                }
            }
            
        }

        private void Remove_Student_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
