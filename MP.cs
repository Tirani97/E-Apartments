using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Appartments
{
    public partial class MP : Form
    {
        public MP()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void users_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisteredUsers RegUsers = new RegisteredUsers();
            RegUsers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC1 mpc1 = new MPC1();
            mpc1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC2 mpc2 = new MPC2();
            mpc2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC3 mpc3 = new MPC3();
            mpc3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPC4 mpc4 = new MPC4();
            mpc4.Show();
        }

        private void MP_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLeaseRequest MLR = new ManagerLeaseRequest();
            MLR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseUserReport LUR = new LeaseUserReport();
            LUR.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MPLeaseExtentionRequest MPLER = new MPLeaseExtentionRequest();
            MPLER.Show();
        }
    }
}
