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
    public partial class C4C1 : Form
    {
        public C4C1()
        {
            InitializeComponent();

            con.Open();
            SqlCommand Com1 = new SqlCommand("select * from Colombo_4 where ParkingID=1", con);
            SqlDataReader reader = Com1.ExecuteReader();
            reader.Read();
            label1.Text = reader["Status"].ToString();
            reader.Close();
            con.Close();

            con.Open();
            SqlCommand Com2 = new SqlCommand("select * from Colombo_4 where ParkingID=5", con);
            SqlDataReader reader2 = Com2.ExecuteReader();
            reader2.Read();
            label2.Text = reader2["Status"].ToString();
            reader2.Close();
            con.Close();

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard db = new Dashboard();
            db.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseRequestForm LRF = new LeaseRequestForm();
            LRF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseRequestForm LRF2 = new LeaseRequestForm();
            LRF2.Show();
        }
    }
}
