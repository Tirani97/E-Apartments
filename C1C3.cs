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
    public partial class C1C3 : Form
    {
        public C1C3()
        {
            InitializeComponent();

            con.Open();
            SqlCommand Com1 = new SqlCommand("select * from Colombo_1 where ParkingID=3", con);
            SqlDataReader reader = Com1.ExecuteReader();
            reader.Read();
            label1.Text = reader["Status"].ToString();
            reader.Close();
            con.Close();

            con.Open();
            SqlCommand Com2 = new SqlCommand("select * from Colombo_1 where ParkingID=7", con);
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

        private void C1C3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseRequestForm LR1 = new LeaseRequestForm();
            LR1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseRequestForm LR2 = new LeaseRequestForm();
            LR2.Show();
        }
    }
}
