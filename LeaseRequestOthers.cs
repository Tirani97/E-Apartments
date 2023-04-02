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
    public partial class LeaseRequestOthers : Form
    {
        public LeaseRequestOthers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseRequestForm LR = new LeaseRequestForm();
            LR.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text==String.Empty)
            {
                MessageBox.Show("Please enter Chief Occupant NIC");
            }
            else if(comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Please select the Relationship");
            }
            else if(textBox1.Text==String.Empty)
            {
                MessageBox.Show("Please enter the Full Name");
            }
            else if(comboBox2.Text==String.Empty)
            {
                MessageBox.Show("Please select the Gender");
            }
            else if(textBox3.Text==String.Empty)
            {
                MessageBox.Show("Please enter Contact Number");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Insert into Occupant values (@conic,@fullname,@nic,@contactnumber,@gender,@relationship)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@conic",textBox4.Text);
                cmd.Parameters.AddWithValue("@relationship",comboBox1.Text);
                cmd.Parameters.AddWithValue("@fullname",textBox1.Text);
                cmd.Parameters.AddWithValue("@gender",comboBox2.Text);
                cmd.Parameters.AddWithValue("@nic",textBox2.Text);
                cmd.Parameters.AddWithValue("@contactnumber",textBox3.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("Record Added Successfully");
                this.Hide();
                AddOccupant AO = new AddOccupant();
                AO.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            //LeaseRequestForm LRF = new LeaseRequestForm();
            //LRF.Show();
        }
    }
}
