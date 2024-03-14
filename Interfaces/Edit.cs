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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string up = @"Data Source=DESKTOP-ADQ7R1U;Initial Catalog=StuInfo;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(up))
            {
                if (textBox10.Text !="")
                {
                    string str = "SELECT Name,Email,Address,Mobile FROM Table4 WHERE RegisterNum = '" + textBox10.Text + "'";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter daa = new SqlDataAdapter(cmd);
                    DataTable dtt = new DataTable();
                    daa.Fill(dtt);

                    dataGridView3.DataSource = new BindingSource(dtt, null);
                }
                else
                {
                    MessageBox.Show("Enter Register Number");
                }
            }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string edit = @"Data Source=DESKTOP-ADQ7R1U;Initial Catalog=StuInfo;Integrated Security=True;";
            SqlConnection con4 = new SqlConnection(edit);
            con4.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Please Enter Name");
                    }
                    else if (textBox5.Text == "")
                    {
                        MessageBox.Show("Please Enter a Email");
                    }
                    else if (textBox4.Text == "")
                    {
                        MessageBox.Show("Please Enter a Phone Number");
                    }
                    else if (textBox7.Text == "")
                    {
                        MessageBox.Show("Please Enter an Address");
                    }
                    else
                    {
                        string str = " update dbo.Table4 set  Name='" + this.textBox2.Text + "', Email='" + this.textBox5.Text + "', Mobile='" + this.textBox4.Text + "'," +
                           "Address='" + this.textBox7.Text + "' where RegisterNum='" + this.textBox1.Text + "';";



                        SqlCommand cmd = new SqlCommand(str, con4);
                        cmd.ExecuteNonQuery();

                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Home obj3 = new Home();
                            obj3.ShowDialog();
                        }
                        MessageBox.Show("Detailes Updated..");
                        this.Close();

                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter Registration number");
            }
            con4.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }

   

  
}
