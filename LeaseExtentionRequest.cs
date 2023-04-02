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
    public partial class LeaseExtentionRequest : Form
    {
        public LeaseExtentionRequest()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && comboBox4.Text == "" && comboBox5.Text == "" && textBox7.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Please fill mandotory fields");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into LeaseExtentionRequest values (@fullname,@nic,@contactnumber,@alocation,@abuilding,@aclass,@aapartmentid,@aextentionperiod,@astatus)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fullname", textBox1.Text);
                cmd.Parameters.AddWithValue("@nic", textBox2.Text);
                cmd.Parameters.AddWithValue("@contactnumber", textBox7.Text);
                cmd.Parameters.AddWithValue("@alocation", comboBox2.Text);
                cmd.Parameters.AddWithValue("@abuilding", comboBox3.Text);
                cmd.Parameters.AddWithValue("@aclass", comboBox4.Text);
                cmd.Parameters.AddWithValue("@aapartmentid", comboBox5.Text);
                cmd.Parameters.AddWithValue("@aextentionperiod", comboBox1.Text);
                cmd.Parameters.AddWithValue("@astatus", "Pending");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lease Request sent successfully");
                this.Hide();
                Dashboard db = new Dashboard();
                db.Show();
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db1 = new Dashboard();
            db1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
