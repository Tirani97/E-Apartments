
namespace E_Appartments
{
    partial class LeaseUserReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaseUserReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eContactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servantCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBuildingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aClassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aAppartmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aReqiredRentalPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiefOccupantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._E_AppartmentsDataSet26 = new E_Appartments._E_AppartmentsDataSet26();
            this.chiefOccupantTableAdapter = new E_Appartments._E_AppartmentsDataSet26TableAdapters.ChiefOccupantTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefOccupantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_AppartmentsDataSet26)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.nICDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.eContactNumberDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.childrenCountDataGridViewTextBoxColumn,
            this.servantCountDataGridViewTextBoxColumn,
            this.aLocationDataGridViewTextBoxColumn,
            this.aBuildingDataGridViewTextBoxColumn,
            this.aClassDataGridViewTextBoxColumn,
            this.aAppartmentIDDataGridViewTextBoxColumn,
            this.aReqiredRentalPeriodDataGridViewTextBoxColumn,
            this.apartmentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.chiefOccupantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1104, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // nICDataGridViewTextBoxColumn
            // 
            this.nICDataGridViewTextBoxColumn.DataPropertyName = "NIC";
            this.nICDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nICDataGridViewTextBoxColumn.Name = "nICDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // eContactNumberDataGridViewTextBoxColumn
            // 
            this.eContactNumberDataGridViewTextBoxColumn.DataPropertyName = "E_ContactNumber";
            this.eContactNumberDataGridViewTextBoxColumn.HeaderText = "E_ContactNumber";
            this.eContactNumberDataGridViewTextBoxColumn.Name = "eContactNumberDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // childrenCountDataGridViewTextBoxColumn
            // 
            this.childrenCountDataGridViewTextBoxColumn.DataPropertyName = "Children_Count";
            this.childrenCountDataGridViewTextBoxColumn.HeaderText = "Children_Count";
            this.childrenCountDataGridViewTextBoxColumn.Name = "childrenCountDataGridViewTextBoxColumn";
            // 
            // servantCountDataGridViewTextBoxColumn
            // 
            this.servantCountDataGridViewTextBoxColumn.DataPropertyName = "Servant_Count";
            this.servantCountDataGridViewTextBoxColumn.HeaderText = "Servant_Count";
            this.servantCountDataGridViewTextBoxColumn.Name = "servantCountDataGridViewTextBoxColumn";
            // 
            // aLocationDataGridViewTextBoxColumn
            // 
            this.aLocationDataGridViewTextBoxColumn.DataPropertyName = "A_Location";
            this.aLocationDataGridViewTextBoxColumn.HeaderText = "A_Location";
            this.aLocationDataGridViewTextBoxColumn.Name = "aLocationDataGridViewTextBoxColumn";
            // 
            // aBuildingDataGridViewTextBoxColumn
            // 
            this.aBuildingDataGridViewTextBoxColumn.DataPropertyName = "A_Building";
            this.aBuildingDataGridViewTextBoxColumn.HeaderText = "A_Building";
            this.aBuildingDataGridViewTextBoxColumn.Name = "aBuildingDataGridViewTextBoxColumn";
            // 
            // aClassDataGridViewTextBoxColumn
            // 
            this.aClassDataGridViewTextBoxColumn.DataPropertyName = "A_Class";
            this.aClassDataGridViewTextBoxColumn.HeaderText = "A_Class";
            this.aClassDataGridViewTextBoxColumn.Name = "aClassDataGridViewTextBoxColumn";
            // 
            // aAppartmentIDDataGridViewTextBoxColumn
            // 
            this.aAppartmentIDDataGridViewTextBoxColumn.DataPropertyName = "A_AppartmentID";
            this.aAppartmentIDDataGridViewTextBoxColumn.HeaderText = "A_AppartmentID";
            this.aAppartmentIDDataGridViewTextBoxColumn.Name = "aAppartmentIDDataGridViewTextBoxColumn";
            // 
            // aReqiredRentalPeriodDataGridViewTextBoxColumn
            // 
            this.aReqiredRentalPeriodDataGridViewTextBoxColumn.DataPropertyName = "A_ReqiredRentalPeriod";
            this.aReqiredRentalPeriodDataGridViewTextBoxColumn.HeaderText = "A_ReqiredRentalPeriod";
            this.aReqiredRentalPeriodDataGridViewTextBoxColumn.Name = "aReqiredRentalPeriodDataGridViewTextBoxColumn";
            // 
            // apartmentStatusDataGridViewTextBoxColumn
            // 
            this.apartmentStatusDataGridViewTextBoxColumn.DataPropertyName = "ApartmentStatus";
            this.apartmentStatusDataGridViewTextBoxColumn.HeaderText = "ApartmentStatus";
            this.apartmentStatusDataGridViewTextBoxColumn.Name = "apartmentStatusDataGridViewTextBoxColumn";
            // 
            // chiefOccupantBindingSource
            // 
            this.chiefOccupantBindingSource.DataMember = "ChiefOccupant";
            this.chiefOccupantBindingSource.DataSource = this._E_AppartmentsDataSet26;
            // 
            // _E_AppartmentsDataSet26
            // 
            this._E_AppartmentsDataSet26.DataSetName = "_E_AppartmentsDataSet26";
            this._E_AppartmentsDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiefOccupantTableAdapter
            // 
            this.chiefOccupantTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1025, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(542, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel8.Controls.Add(this.label27);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.label28);
            this.panel8.Location = new System.Drawing.Point(12, 12);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1159, 120);
            this.panel8.TabIndex = 30;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(462, 69);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(210, 22);
            this.label27.TabIndex = 3;
            this.label27.Text = "Find Your Dream Home...";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(454, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(203, 36);
            this.label28.TabIndex = 0;
            this.label28.Text = "E-Apartments";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeaseUserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Name = "LeaseUserReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaseUserReport";
            this.Load += new System.EventHandler(this.LeaseUserReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiefOccupantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_AppartmentsDataSet26)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private _E_AppartmentsDataSet26 _E_AppartmentsDataSet26;
        private System.Windows.Forms.BindingSource chiefOccupantBindingSource;
        private _E_AppartmentsDataSet26TableAdapters.ChiefOccupantTableAdapter chiefOccupantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eContactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servantCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBuildingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aClassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aAppartmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aReqiredRentalPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label28;
    }
}