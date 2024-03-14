using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//new

namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            //string stu = @"Data Source=DESKTOP-ADQ7R1U;Initial Catalog=StuInfo;Integrated Security=True;";
            string stu = @"Data Source=Arrow;Initial Catalog=StuInfo;Integrated Security=True;";
            SqlConnection con = new SqlConnection(stu);
            string query = "Select * from [Table4] Where RegisterNum = '" + textBox3.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                this.Visible = false;
                Stu_Home obj1 = new Stu_Home();
                obj1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Register Number.");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string hg = @"Data Source=DESKTOP-ADQ7R1U;Initial Catalog=StuInfo;Integrated Security=True;";//Sql connection
            string hg = @"Data Source=Arrow;Initial Catalog=StuInfo;Integrated Security=True;";//Sql connection
            SqlConnection con = new SqlConnection(hg);
            string query = "Select * from [logging] Where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);//make connection between SQL and query and assign to the sda variable
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)//if username and password correct?
            {
                this.Visible = false;
                Home obj4 = new Home();
                obj4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or Password.");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
