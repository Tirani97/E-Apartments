using ClosedXML.Excel;
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
    public partial class LeaseUserReport : Form
    {
        public LeaseUserReport()
        {
            InitializeComponent();
        }

        private void LeaseUserReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_AppartmentsDataSet26.ChiefOccupant' table. You can move, or remove it, as needed.
            this.chiefOccupantTableAdapter.Fill(this._E_AppartmentsDataSet26.ChiefOccupant);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MP mp = new MP();
            mp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter="Excel Workbook|*.xlsx"})
            {
                if(sfd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(this._E_AppartmentsDataSet26.ChiefOccupant.CopyToDataTable(), "ChiefOccupant");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have sucessfully exported data", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
