namespace MelisaYuksek_OOP_Proje
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.lblTC = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblService = new System.Windows.Forms.Label();
            this.cboService = new System.Windows.Forms.ComboBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStylist = new System.Windows.Forms.Label();
            this.cboStylist = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.Label();
            this.btnCalculateTotalPrice = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(41, 178);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(46, 16);
            this.lblTC.TabIndex = 20;
            this.lblTC.Tag = "";
            this.lblTC.Text = "TC No";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(41, 127);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 19;
            this.lblPhone.Text = "Phone";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(132, 175);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(148, 22);
            this.txtIDNumber.TabIndex = 16;
            this.txtIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 122);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 22);
            this.txtPhoneNumber.TabIndex = 15;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 22);
            this.txtName.TabIndex = 13;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(529, 57);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(60, 16);
            this.lblService.TabIndex = 22;
            this.lblService.Text = "Services";
            // 
            // cboService
            // 
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(612, 54);
            this.cboService.Name = "cboService";
            this.cboService.Size = new System.Drawing.Size(200, 24);
            this.cboService.TabIndex = 21;
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(12, 330);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1047, 273);
            this.dgvClients.TabIndex = 26;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(651, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 51);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(522, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 51);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(393, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 52);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStylist
            // 
            this.lblStylist.AutoSize = true;
            this.lblStylist.Location = new System.Drawing.Point(529, 107);
            this.lblStylist.Name = "lblStylist";
            this.lblStylist.Size = new System.Drawing.Size(49, 16);
            this.lblStylist.TabIndex = 28;
            this.lblStylist.Text = "Stylists";
            // 
            // cboStylist
            // 
            this.cboStylist.FormattingEnabled = true;
            this.cboStylist.Location = new System.Drawing.Point(612, 107);
            this.cboStylist.Name = "cboStylist";
            this.cboStylist.Size = new System.Drawing.Size(200, 24);
            this.cboStylist.TabIndex = 27;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(612, 162);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentDate.TabIndex = 29;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(529, 162);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(36, 16);
            this.txtDate.TabIndex = 30;
            this.txtDate.Text = "Date";
            // 
            // btnCalculateTotalPrice
            // 
            this.btnCalculateTotalPrice.Location = new System.Drawing.Point(770, 250);
            this.btnCalculateTotalPrice.Name = "btnCalculateTotalPrice";
            this.btnCalculateTotalPrice.Size = new System.Drawing.Size(113, 50);
            this.btnCalculateTotalPrice.TabIndex = 31;
            this.btnCalculateTotalPrice.Text = "Total Price";
            this.btnCalculateTotalPrice.UseVisualStyleBackColor = true;
            this.btnCalculateTotalPrice.Click += new System.EventHandler(this.btnCalculateTotalPrice_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(914, 267);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(38, 16);
            this.lblTotalPrice.TabIndex = 32;
            this.lblTotalPrice.Text = "Price";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 615);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnCalculateTotalPrice);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblStylist);
            this.Controls.Add(this.cboStylist);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.cboService);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStylist;
        private System.Windows.Forms.ComboBox cboStylist;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Button btnCalculateTotalPrice;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}