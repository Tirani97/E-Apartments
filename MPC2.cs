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
    public partial class MPC2 : Form
    {
        public MPC2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EQ55Q8H\SQLEXPRESS;Initial Catalog=E-Appartments;Integrated Security=True;");
        int id;

        private void MPC2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet21.Colombo_2' table. You can move, or remove it, as needed.
            this.colombo_2TableAdapter.Fill(this._E_AppartmentsDataSet21.Colombo_2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MP mp = new MP();
            mp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("update Colombo_2 set Status=@Status where ParkingID=@id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Status", comboBox1.Text);
                cmd.Parameters.AddWithValue("@id", this.id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Status is Updated");

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        
    }
}
