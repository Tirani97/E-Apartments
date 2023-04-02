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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signup2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup ss = new Signup();
            ss.Show();
        }

        private void logina_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");
            SqlDataAdapter usda = new SqlDataAdapter("Select Count(*) from User_Login where Username='" + Username.Text + "' and Password = '" + Password.Text + "'", con);
            SqlDataAdapter msda = new SqlDataAdapter("Select Count(*) from Manager_Login where ManagerUsername='" + Username.Text + "' and ManagerPassword = '" + Password.Text + "'", con);

            DataTable udt = new DataTable();
            usda.Fill(udt);

            DataTable mdt = new DataTable();
            msda.Fill(mdt);
            
            if (mdt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MP mpdb = new MP();
                mpdb.Show();
            }
            else if (udt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Dashboard ss = new Dashboard();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please check your Username and Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
