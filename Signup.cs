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

namespace E_Appartments
{
    public partial class Signup : Form
    {
        string connectionString = @"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;";
        
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
                MessageBox.Show("Please fill mandotory fields");
            else if (Password.Text != CPassword.Text)
                MessageBox.Show("Password is not matched");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Name", Name1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", Email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact", Contact.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", Username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", Password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfill");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
