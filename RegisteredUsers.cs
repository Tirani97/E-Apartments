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
    public partial class RegisteredUsers : Form
    {
        public RegisteredUsers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");

        private void RegisteredUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet22.User_Login' table. You can move, or remove it, as needed.
            this.user_LoginTableAdapter.Fill(this._E_AppartmentsDataSet22.User_Login);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userLoginBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userLoginBindingSource.EndEdit();
            user_LoginTableAdapter.Update(_E_AppartmentsDataSet22.User_Login);
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            userLoginBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MP mp = new MP();
            mp.Show();
        }
    }
}
