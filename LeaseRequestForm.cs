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
    public partial class LeaseRequestForm : Form
    {
        public LeaseRequestForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            LeaseRequestOthers LRO = new LeaseRequestOthers();
            LRO.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Please enter Full Name");
            }
            else if (textBox2.Text == String.Empty)
            {
                MessageBox.Show("Please enter NIC");
            }
            else if (textBox3.Text == String.Empty)
            {
                MessageBox.Show("Please enter Address");
            }
            else if (textBox4.Text == String.Empty)
            {
                MessageBox.Show("Please enter Contact Number");
            }
            else if (textBox5.Text == String.Empty)
            {
                MessageBox.Show("Please enter Emergency Contact Number");
            }
            else if (comboBox5.Text == String.Empty)
            {
                MessageBox.Show("Please select the Gender");
            }
            else if (comboBox6.Text == String.Empty)
            {
                MessageBox.Show("Please select the Status");
            }
            else if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Please select the Apartment Location");
            }
            else if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Please select the Building ID");
            }
            else if (comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Please select the Class");
            }
            else if (comboBox4.Text == String.Empty)
            {
                MessageBox.Show("Please select the Apartment ID");
            }
            else if (comboBox7.Text == String.Empty)
            {
                MessageBox.Show("Please select the Required Rental Period");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into ChiefOccupant values (@fullname,@nic,@address,@contactnumber,@econtactnumber,@gender,@status,@childrencount,@servantcount,@alocation,@abuilding,@aclass,@aapartmentid,@arequiredrentalperiod,@astatus)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fullname", textBox1.Text);
                cmd.Parameters.AddWithValue("@nic", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox3.Text);
                cmd.Parameters.AddWithValue("@contactnumber", textBox4.Text);
                cmd.Parameters.AddWithValue("@econtactnumber", textBox5.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox5.Text);
                cmd.Parameters.AddWithValue("@status", comboBox6.Text);
                cmd.Parameters.AddWithValue("@childrencount", textBox6.Text);
                cmd.Parameters.AddWithValue("@servantcount", textBox7.Text);
                cmd.Parameters.AddWithValue("@alocation", comboBox1.Text);
                cmd.Parameters.AddWithValue("@abuilding", comboBox2.Text);
                cmd.Parameters.AddWithValue("@aclass", comboBox3.Text);
                cmd.Parameters.AddWithValue("@aapartmentid", comboBox4.Text);
                cmd.Parameters.AddWithValue("@arequiredrentalperiod", comboBox7.Text);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
