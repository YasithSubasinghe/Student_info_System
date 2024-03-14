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
    public partial class Register_Student : Form
    {
        public Register_Student()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string t = @"Data Source=Arrow;Initial Catalog=StudentInfo;Integrated Security=True;";//Sql connection
                SqlConnection con2 = new SqlConnection(t);
                con2.Open();
                string gender = string.Empty;
                if (radioButton1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked)
                {
                    gender = "Female";
                }
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Name");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Please Enter an Email Address");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Please Enter Mobile Number");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Registration Number");
                }
                else if (textBox7.Text == "")
                {
                    MessageBox.Show("Please Enter Address");
                }
            
                else
                {
                    String sql = "INSERT INTO Student(RegisterNum,Name,Gender,DOB,Email,Mobile,Address) VALUES('" + textBox2.Text + "','" + textBox1.Text + "','" + gender + "','" + dateTimePicker1.Text + "','"
                        + textBox5.Text + "','" + textBox4.Text + "','" + textBox7.Text + "')";

                    SqlCommand cmd = new SqlCommand(sql, con2);
                    cmd.ExecuteNonQuery();

                    String sql1 = "Select max(ID) from Student";
                    SqlCommand cmd1 = new SqlCommand(sql1, con2);
                    SqlDataReader dr = cmd1.ExecuteReader();

                    if (dr.Read())
                    {  
                        MessageBox.Show("Student Registration Successfully.. ");
                    }
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox2.Clear();
        }

        private void Register_Student_Load(object sender, EventArgs e)
        {   

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
