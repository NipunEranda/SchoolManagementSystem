﻿namespace SchoolManagementSystem
{
    partial class Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        new private System.ComponentModel.IContainer components = null;

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
        new private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.NIC_txt = new System.Windows.Forms.TextBox();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.lastName_txt = new System.Windows.Forms.TextBox();
            this.telephone_txt = new System.Windows.Forms.TextBox();
            this.address_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthDay_txt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.image_browse = new System.Windows.Forms.Button();
            this.mand_nic = new System.Windows.Forms.Label();
            this.mand_firstName = new System.Windows.Forms.Label();
            this.mand_lastName = new System.Windows.Forms.Label();
            this.mand_birthDate = new System.Windows.Forms.Label();
            this.mand_telephone = new System.Windows.Forms.Label();
            this.mand_address = new System.Windows.Forms.Label();
            this.mand_gender = new System.Windows.Forms.Label();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.Label();
            this.studentImage = new System.Windows.Forms.PictureBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studentgetStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderDropDown = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentgetStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(931, 717);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentGridView);
            this.groupBox1.Size = new System.Drawing.Size(931, 717);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.studentGridView, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(755, 16);
            this.panel2.Size = new System.Drawing.Size(173, 698);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(752, 10);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(13, 704);
            this.panel11.Size = new System.Drawing.Size(732, 10);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(745, 26);
            this.panel10.Size = new System.Drawing.Size(10, 688);
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 26);
            this.panel9.Size = new System.Drawing.Size(10, 688);
            // 
            // panel13
            // 
            this.panel13.Size = new System.Drawing.Size(918, 32);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(244, 749);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.genderDropDown);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.imagePath);
            this.panel5.Controls.Add(this.studentImage);
            this.panel5.Controls.Add(this.acceptBtn);
            this.panel5.Controls.Add(this.operation);
            this.panel5.Controls.Add(this.mand_gender);
            this.panel5.Controls.Add(this.mand_address);
            this.panel5.Controls.Add(this.mand_telephone);
            this.panel5.Controls.Add(this.mand_birthDate);
            this.panel5.Controls.Add(this.mand_lastName);
            this.panel5.Controls.Add(this.mand_firstName);
            this.panel5.Controls.Add(this.mand_nic);
            this.panel5.Controls.Add(this.image_browse);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.birthDay_txt);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.address_txt);
            this.panel5.Controls.Add(this.telephone_txt);
            this.panel5.Controls.Add(this.lastName_txt);
            this.panel5.Controls.Add(this.firstName_txt);
            this.panel5.Controls.Add(this.NIC_txt);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Size = new System.Drawing.Size(244, 717);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(931, 749);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(931, 717);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(931, 32);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "NIC";
            // 
            // NIC_txt
            // 
            this.NIC_txt.Location = new System.Drawing.Point(15, 89);
            this.NIC_txt.Name = "NIC_txt";
            this.NIC_txt.Size = new System.Drawing.Size(213, 20);
            this.NIC_txt.TabIndex = 1;
            this.NIC_txt.TextChanged += new System.EventHandler(this.NIC_txt_TextChanged);
            // 
            // firstName_txt
            // 
            this.firstName_txt.Location = new System.Drawing.Point(15, 133);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(213, 20);
            this.firstName_txt.TabIndex = 2;
            this.firstName_txt.TextChanged += new System.EventHandler(this.FirstName_txt_TextChanged);
            // 
            // lastName_txt
            // 
            this.lastName_txt.Location = new System.Drawing.Point(16, 178);
            this.lastName_txt.Name = "lastName_txt";
            this.lastName_txt.Size = new System.Drawing.Size(213, 20);
            this.lastName_txt.TabIndex = 3;
            this.lastName_txt.TextChanged += new System.EventHandler(this.LastName_txt_TextChanged);
            // 
            // telephone_txt
            // 
            this.telephone_txt.Location = new System.Drawing.Point(16, 270);
            this.telephone_txt.Name = "telephone_txt";
            this.telephone_txt.Size = new System.Drawing.Size(213, 20);
            this.telephone_txt.TabIndex = 5;
            this.telephone_txt.TextChanged += new System.EventHandler(this.Telephone_txt_TextChanged);
            // 
            // address_txt
            // 
            this.address_txt.Location = new System.Drawing.Point(16, 317);
            this.address_txt.Name = "address_txt";
            this.address_txt.Size = new System.Drawing.Size(213, 20);
            this.address_txt.TabIndex = 6;
            this.address_txt.TextChanged += new System.EventHandler(this.Address_txt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(13, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Birthdate";
            // 
            // birthDay_txt
            // 
            this.birthDay_txt.Enabled = false;
            this.birthDay_txt.Location = new System.Drawing.Point(16, 224);
            this.birthDay_txt.Name = "birthDay_txt";
            this.birthDay_txt.Size = new System.Drawing.Size(213, 20);
            this.birthDay_txt.TabIndex = 11;
            this.birthDay_txt.Value = new System.DateTime(2019, 7, 3, 0, 0, 0, 0);
            this.birthDay_txt.ValueChanged += new System.EventHandler(this.BirthDay_txt_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(13, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(13, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(14, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Gender";
            // 
            // image_browse
            // 
            this.image_browse.Location = new System.Drawing.Point(173, 404);
            this.image_browse.Name = "image_browse";
            this.image_browse.Size = new System.Drawing.Size(56, 20);
            this.image_browse.TabIndex = 15;
            this.image_browse.Text = "Browse";
            this.image_browse.UseVisualStyleBackColor = true;
            this.image_browse.Click += new System.EventHandler(this.image_browse_Click);
            // 
            // mand_nic
            // 
            this.mand_nic.BackColor = System.Drawing.Color.Transparent;
            this.mand_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_nic.ForeColor = System.Drawing.Color.White;
            this.mand_nic.Location = new System.Drawing.Point(214, 73);
            this.mand_nic.Name = "mand_nic";
            this.mand_nic.Size = new System.Drawing.Size(14, 16);
            this.mand_nic.TabIndex = 16;
            this.mand_nic.Text = "*";
            this.mand_nic.Visible = false;
            // 
            // mand_firstName
            // 
            this.mand_firstName.BackColor = System.Drawing.Color.Transparent;
            this.mand_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_firstName.ForeColor = System.Drawing.Color.White;
            this.mand_firstName.Location = new System.Drawing.Point(214, 117);
            this.mand_firstName.Name = "mand_firstName";
            this.mand_firstName.Size = new System.Drawing.Size(14, 16);
            this.mand_firstName.TabIndex = 17;
            this.mand_firstName.Text = "*";
            this.mand_firstName.Visible = false;
            // 
            // mand_lastName
            // 
            this.mand_lastName.BackColor = System.Drawing.Color.Transparent;
            this.mand_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_lastName.ForeColor = System.Drawing.Color.White;
            this.mand_lastName.Location = new System.Drawing.Point(214, 162);
            this.mand_lastName.Name = "mand_lastName";
            this.mand_lastName.Size = new System.Drawing.Size(14, 16);
            this.mand_lastName.TabIndex = 18;
            this.mand_lastName.Text = "*";
            this.mand_lastName.Visible = false;
            // 
            // mand_birthDate
            // 
            this.mand_birthDate.BackColor = System.Drawing.Color.Transparent;
            this.mand_birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_birthDate.ForeColor = System.Drawing.Color.White;
            this.mand_birthDate.Location = new System.Drawing.Point(215, 208);
            this.mand_birthDate.Name = "mand_birthDate";
            this.mand_birthDate.Size = new System.Drawing.Size(14, 16);
            this.mand_birthDate.TabIndex = 17;
            this.mand_birthDate.Text = "*";
            this.mand_birthDate.Visible = false;
            // 
            // mand_telephone
            // 
            this.mand_telephone.BackColor = System.Drawing.Color.Transparent;
            this.mand_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_telephone.ForeColor = System.Drawing.Color.White;
            this.mand_telephone.Location = new System.Drawing.Point(214, 254);
            this.mand_telephone.Name = "mand_telephone";
            this.mand_telephone.Size = new System.Drawing.Size(14, 16);
            this.mand_telephone.TabIndex = 19;
            this.mand_telephone.Text = "*";
            this.mand_telephone.Visible = false;
            // 
            // mand_address
            // 
            this.mand_address.BackColor = System.Drawing.Color.Transparent;
            this.mand_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_address.ForeColor = System.Drawing.Color.White;
            this.mand_address.Location = new System.Drawing.Point(215, 301);
            this.mand_address.Name = "mand_address";
            this.mand_address.Size = new System.Drawing.Size(14, 16);
            this.mand_address.TabIndex = 20;
            this.mand_address.Text = "*";
            this.mand_address.Visible = false;
            // 
            // mand_gender
            // 
            this.mand_gender.BackColor = System.Drawing.Color.Transparent;
            this.mand_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mand_gender.ForeColor = System.Drawing.Color.White;
            this.mand_gender.Location = new System.Drawing.Point(214, 347);
            this.mand_gender.Name = "mand_gender";
            this.mand_gender.Size = new System.Drawing.Size(14, 16);
            this.mand_gender.TabIndex = 21;
            this.mand_gender.Text = "*";
            this.mand_gender.Visible = false;
            // 
            // studentGridView
            // 
            this.studentGridView.AllowUserToAddRows = false;
            this.studentGridView.AllowUserToDeleteRows = false;
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nicId,
            this.fName,
            this.lName,
            this.birthDate,
            this.address,
            this.telephone,
            this.gender});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.studentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridView.Location = new System.Drawing.Point(13, 26);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.ReadOnly = true;
            this.studentGridView.RowHeadersVisible = false;
            this.studentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentGridView.Size = new System.Drawing.Size(732, 678);
            this.studentGridView.TabIndex = 5;
            this.studentGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "sid";
            this.id.HeaderText = "SID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // nicId
            // 
            this.nicId.DataPropertyName = "NIC";
            this.nicId.HeaderText = "NIC";
            this.nicId.Name = "nicId";
            this.nicId.ReadOnly = true;
            // 
            // fName
            // 
            this.fName.DataPropertyName = "firstName";
            this.fName.HeaderText = "Firstname";
            this.fName.Name = "fName";
            this.fName.ReadOnly = true;
            // 
            // lName
            // 
            this.lName.DataPropertyName = "lastName";
            this.lName.HeaderText = "Lastname";
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            // 
            // birthDate
            // 
            this.birthDate.DataPropertyName = "birthdate";
            this.birthDate.HeaderText = "Birthdate";
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "telephone";
            this.telephone.HeaderText = "Telephone";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.ForeColor = System.Drawing.SystemColors.Control;
            this.operation.Location = new System.Drawing.Point(12, 39);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(47, 20);
            this.operation.TabIndex = 22;
            this.operation.Text = "View";
            // 
            // studentImage
            // 
            this.studentImage.Location = new System.Drawing.Point(48, 467);
            this.studentImage.Name = "studentImage";
            this.studentImage.Size = new System.Drawing.Size(150, 150);
            this.studentImage.TabIndex = 23;
            this.studentImage.TabStop = false;
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(13, 430);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(216, 31);
            this.acceptBtn.TabIndex = 27;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openImage";
            // 
            // imagePath
            // 
            this.imagePath.Location = new System.Drawing.Point(13, 404);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(154, 20);
            this.imagePath.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(12, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Image";
            // 
            // studentgetStudentBindingSource
            // 
            this.studentgetStudentBindingSource.DataMember = "student_getStudent";
            // 
            // genderDropDown
            // 
            this.genderDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderDropDown.FormattingEnabled = true;
            this.genderDropDown.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderDropDown.Location = new System.Drawing.Point(15, 363);
            this.genderDropDown.Name = "genderDropDown";
            this.genderDropDown.Size = new System.Drawing.Size(214, 21);
            this.genderDropDown.TabIndex = 30;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 749);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentgetStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button image_browse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker birthDay_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address_txt;
        private System.Windows.Forms.TextBox telephone_txt;
        private System.Windows.Forms.TextBox lastName_txt;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.TextBox NIC_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mand_nic;
        private System.Windows.Forms.Label mand_gender;
        private System.Windows.Forms.Label mand_address;
        private System.Windows.Forms.Label mand_telephone;
        private System.Windows.Forms.Label mand_birthDate;
        private System.Windows.Forms.Label mand_lastName;
        private System.Windows.Forms.Label mand_firstName;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.PictureBox studentImage;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.BindingSource studentgetStudentBindingSource;
        private System.Windows.Forms.ComboBox genderDropDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
    }
}