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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Colombo 01" && comboBox2.SelectedItem == "Class 01")
            {
                this.Hide();
                C1C1 c1c1 = new C1C1();
                c1c1.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 01" && comboBox2.SelectedItem == "Class 02")
            {
                this.Hide();
                C1C2 c1c2 = new C1C2();
                c1c2.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 01" && comboBox2.SelectedItem == "Class 03")
            {
                this.Hide();
                C1C3 c1c3 = new C1C3();
                c1c3.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 01" && comboBox2.SelectedItem == "Suite")
            {
                this.Hide();
                C1C4 c1c4 = new C1C4();
                c1c4.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 02" && comboBox2.SelectedItem == "Class 01")
            {
                this.Hide();
                C2C1 c2c1 = new C2C1();
                c2c1.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 02" && comboBox2.SelectedItem == "Class 02")
            {
                this.Hide();
                C2C2 c2c2 = new C2C2();
                c2c2.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 02" && comboBox2.SelectedItem == "Class 03")
            {
                this.Hide();
                C2C3 c2c3 = new C2C3();
                c2c3.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 02" && comboBox2.SelectedItem == "Suite")
            {
                this.Hide();
                C2C4 c2c4 = new C2C4();
                c2c4.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 03" && comboBox2.SelectedItem == "Class 01")
            {
                this.Hide();
                C3C1 c3c1 = new C3C1();
                c3c1.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 03" && comboBox2.SelectedItem == "Class 02")
            {
                this.Hide();
                C3C2 c3c2 = new C3C2();
                c3c2.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 03" && comboBox2.SelectedItem == "Class 03")
            {
                this.Hide();
                C3C3 c3c3 = new C3C3();
                c3c3.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 03" && comboBox2.SelectedItem == "Suite")
            {
                this.Hide();
                C3C4 c3c4 = new C3C4();
                c3c4.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 04" && comboBox2.SelectedItem == "Class 01")
            {
                this.Hide();
                C4C1 c4c1 = new C4C1();
                c4c1.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 04" && comboBox2.SelectedItem == "Class 02")
            {
                this.Hide();
                C4C2 c4c2 = new C4C2();
                c4c2.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 04" && comboBox2.SelectedItem == "Class 03")
            {
                this.Hide();
                C4C3 c4c3 = new C4C3();
                c4c3.Show();
            }
            else if (comboBox1.SelectedItem == "Colombo 04" && comboBox2.SelectedItem == "Suite")
            {
                this.Hide();
                C4C4 c4c4 = new C4C4();
                c4c4.Show();
            }
            else
            {
                //this.Refresh();
                MessageBox.Show("Please choose a location & a class");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LeaseExtentionRequest LER = new LeaseExtentionRequest();
            LER.Show();
        }
    }
}
