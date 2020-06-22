namespace SchoolManagementSystem
{
    partial class addMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddressNull = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.ContactNull = new System.Windows.Forms.Label();
            this.LNameNull = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.MemberIDNull = new System.Windows.Forms.Label();
            this.FNameNull = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.memberGroupBox = new System.Windows.Forms.GroupBox();
            this.MemberGridView = new System.Windows.Forms.DataGridView();
            this.memberIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.leftpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.memberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(322, 999);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(941, 999);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(941, 39);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblMain);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.btnAddMembers);
            this.panel6.Controls.Add(this.AddressNull);
            this.panel6.Controls.Add(this.txtAddress);
            this.panel6.Controls.Add(this.lblAddress);
            this.panel6.Controls.Add(this.ContactNull);
            this.panel6.Controls.Add(this.LNameNull);
            this.panel6.Controls.Add(this.txtContact);
            this.panel6.Controls.Add(this.lblContactNo);
            this.panel6.Controls.Add(this.txtLName);
            this.panel6.Controls.Add(this.lblLName);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.AddDate);
            this.panel6.Controls.Add(this.lblAddDate);
            this.panel6.Controls.Add(this.txtMemberID);
            this.panel6.Controls.Add(this.lblMemberID);
            this.panel6.Controls.Add(this.MemberIDNull);
            this.panel6.Controls.Add(this.FNameNull);
            this.panel6.Controls.Add(this.lblFName);
            this.panel6.Controls.Add(this.txtFName);
            this.panel6.Size = new System.Drawing.Size(322, 960);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.memberGroupBox);
            this.panel5.Size = new System.Drawing.Size(941, 960);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.memberGroupBox, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(719, 0);
            this.panel1.Size = new System.Drawing.Size(222, 960);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // AddressNull
            // 
            this.AddressNull.AutoSize = true;
            this.AddressNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressNull.ForeColor = System.Drawing.Color.White;
            this.AddressNull.Location = new System.Drawing.Point(234, 352);
            this.AddressNull.Name = "AddressNull";
            this.AddressNull.Size = new System.Drawing.Size(23, 29);
            this.AddressNull.TabIndex = 129;
            this.AddressNull.Text = "*";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(54, 384);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(207, 22);
            this.txtAddress.TabIndex = 128;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(49, 352);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(102, 29);
            this.lblAddress.TabIndex = 127;
            this.lblAddress.Text = "Address";
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(48, 80);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(81, 32);
            this.lblMain.TabIndex = 126;
            this.lblMain.Text = "View";
            // 
            // ContactNull
            // 
            this.ContactNull.AutoSize = true;
            this.ContactNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNull.ForeColor = System.Drawing.Color.White;
            this.ContactNull.Location = new System.Drawing.Point(237, 434);
            this.ContactNull.Name = "ContactNull";
            this.ContactNull.Size = new System.Drawing.Size(23, 29);
            this.ContactNull.TabIndex = 125;
            this.ContactNull.Text = "*";
            // 
            // LNameNull
            // 
            this.LNameNull.AutoSize = true;
            this.LNameNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameNull.ForeColor = System.Drawing.Color.White;
            this.LNameNull.Location = new System.Drawing.Point(234, 277);
            this.LNameNull.Name = "LNameNull";
            this.LNameNull.Size = new System.Drawing.Size(23, 29);
            this.LNameNull.TabIndex = 124;
            this.LNameNull.Text = "*";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(57, 470);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(207, 22);
            this.txtContact.TabIndex = 123;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.White;
            this.lblContactNo.Location = new System.Drawing.Point(52, 434);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(132, 29);
            this.lblContactNo.TabIndex = 122;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(54, 309);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(207, 22);
            this.txtLName.TabIndex = 121;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.White;
            this.lblLName.Location = new System.Drawing.Point(49, 277);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(128, 29);
            this.lblLName.TabIndex = 120;
            this.lblLName.Text = "Last Name";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(57, 682);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 46);
            this.btnClear.TabIndex = 119;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddDate
            // 
            this.AddDate.Location = new System.Drawing.Point(60, 541);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(204, 22);
            this.AddDate.TabIndex = 117;
            this.AddDate.ValueChanged += new System.EventHandler(this.AddDate_ValueChanged);
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDate.ForeColor = System.Drawing.Color.White;
            this.lblAddDate.Location = new System.Drawing.Point(56, 509);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(140, 29);
            this.lblAddDate.TabIndex = 116;
            this.lblAddDate.Text = "Added Date";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(54, 161);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(207, 22);
            this.txtMemberID.TabIndex = 111;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.Color.White;
            this.lblMemberID.Location = new System.Drawing.Point(53, 132);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(132, 29);
            this.lblMemberID.TabIndex = 110;
            this.lblMemberID.Text = "Member ID";
            // 
            // MemberIDNull
            // 
            this.MemberIDNull.AutoSize = true;
            this.MemberIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDNull.ForeColor = System.Drawing.Color.White;
            this.MemberIDNull.Location = new System.Drawing.Point(234, 129);
            this.MemberIDNull.Name = "MemberIDNull";
            this.MemberIDNull.Size = new System.Drawing.Size(23, 29);
            this.MemberIDNull.TabIndex = 112;
            this.MemberIDNull.Text = "*";
            // 
            // FNameNull
            // 
            this.FNameNull.AutoSize = true;
            this.FNameNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameNull.ForeColor = System.Drawing.Color.White;
            this.FNameNull.Location = new System.Drawing.Point(238, 205);
            this.FNameNull.Name = "FNameNull";
            this.FNameNull.Size = new System.Drawing.Size(23, 29);
            this.FNameNull.TabIndex = 115;
            this.FNameNull.Text = "*";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.White;
            this.lblFName.Location = new System.Drawing.Point(53, 205);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(131, 29);
            this.lblFName.TabIndex = 113;
            this.lblFName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFName.Location = new System.Drawing.Point(54, 238);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(207, 22);
            this.txtFName.TabIndex = 114;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // memberGroupBox
            // 
            this.memberGroupBox.Controls.Add(this.MemberGridView);
            this.memberGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberGroupBox.Location = new System.Drawing.Point(0, 0);
            this.memberGroupBox.Name = "memberGroupBox";
            this.memberGroupBox.Size = new System.Drawing.Size(719, 960);
            this.memberGroupBox.TabIndex = 1;
            this.memberGroupBox.TabStop = false;
            this.memberGroupBox.Text = "Details";
            // 
            // MemberGridView
            // 
            this.MemberGridView.AllowUserToAddRows = false;
            this.MemberGridView.AllowUserToDeleteRows = false;
            this.MemberGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MemberGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MemberGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDGV,
            this.FnameGV,
            this.LnameGV,
            this.addressGV,
            this.contactGV,
            this.dateGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MemberGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberGridView.Location = new System.Drawing.Point(3, 18);
            this.MemberGridView.Name = "MemberGridView";
            this.MemberGridView.ReadOnly = true;
            this.MemberGridView.RowHeadersVisible = false;
            this.MemberGridView.RowTemplate.Height = 24;
            this.MemberGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberGridView.Size = new System.Drawing.Size(713, 939);
            this.MemberGridView.TabIndex = 0;
            this.MemberGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberGridView_CellClick);
            // 
            // memberIDGV
            // 
            this.memberIDGV.HeaderText = "Member ID";
            this.memberIDGV.Name = "memberIDGV";
            this.memberIDGV.ReadOnly = true;
            // 
            // FnameGV
            // 
            this.FnameGV.HeaderText = "First Name ";
            this.FnameGV.Name = "FnameGV";
            this.FnameGV.ReadOnly = true;
            // 
            // LnameGV
            // 
            this.LnameGV.HeaderText = "Last Name";
            this.LnameGV.Name = "LnameGV";
            this.LnameGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // contactGV
            // 
            this.contactGV.HeaderText = "Contact No";
            this.contactGV.Name = "contactGV";
            this.contactGV.ReadOnly = true;
            // 
            // dateGV
            // 
            this.dateGV.HeaderText = "Add Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            // 
            // btnAddMembers
            // 
            this.btnAddMembers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMembers.Location = new System.Drawing.Point(57, 603);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Size = new System.Drawing.Size(200, 46);
            this.btnAddMembers.TabIndex = 130;
            this.btnAddMembers.Text = "Save";
            this.btnAddMembers.UseVisualStyleBackColor = true;
            this.btnAddMembers.Click += new System.EventHandler(this.btnAddMembers_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(322, 46);
            this.panel7.TabIndex = 131;
            // 
            // addMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 999);
            this.Name = "addMembers";
            this.Text = "addMembers";
            this.Load += new System.EventHandler(this.addMembers_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.memberGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemberGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label AddressNull;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.Label lblMain;
        public System.Windows.Forms.Label ContactNull;
        public System.Windows.Forms.Label LNameNull;
        public System.Windows.Forms.TextBox txtContact;
        public System.Windows.Forms.Label lblContactNo;
        public System.Windows.Forms.TextBox txtLName;
        public System.Windows.Forms.Label lblLName;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.DateTimePicker AddDate;
        public System.Windows.Forms.Label lblAddDate;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.Label MemberIDNull;
        public System.Windows.Forms.Label FNameNull;
        public System.Windows.Forms.Label lblFName;
        public System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.GroupBox memberGroupBox;
        private System.Windows.Forms.DataGridView MemberGridView;
        public System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
    }
}