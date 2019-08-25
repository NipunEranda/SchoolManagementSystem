namespace SchoolManagementSystem
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.actionBtn = new System.Windows.Forms.Button();
            this.operationTxt = new System.Windows.Forms.Label();
            this.rolesDropDown = new System.Windows.Forms.ComboBox();
            this.addUserPanel = new System.Windows.Forms.Panel();
            this.userAddBtn = new System.Windows.Forms.Button();
            this.roleIdDropDown = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.userConPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordChangePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.confirmNewPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.currentPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.changePassPanelV = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.addUserPanel.SuspendLayout();
            this.passwordChangePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(875, 729);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usersGridView);
            this.groupBox1.Size = new System.Drawing.Size(875, 729);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.usersGridView, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(699, 16);
            this.panel2.Size = new System.Drawing.Size(173, 710);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(696, 14);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(689, 30);
            this.panel10.Size = new System.Drawing.Size(10, 696);
            // 
            // panel9
            // 
            this.panel9.Size = new System.Drawing.Size(10, 696);
            // 
            // backBtn
            // 
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // panel13
            // 
            this.panel13.Size = new System.Drawing.Size(875, 32);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(13, 716);
            this.panel11.Size = new System.Drawing.Size(676, 10);
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(0, 700);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(300, 761);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.addUserPanel);
            this.panel5.Controls.Add(this.changePassPanelV);
            this.panel5.Controls.Add(this.rolesDropDown);
            this.panel5.Controls.Add(this.operationTxt);
            this.panel5.Controls.Add(this.actionBtn);
            this.panel5.Controls.Add(this.userNameTxt);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.passwordChangePanel);
            this.panel5.Size = new System.Drawing.Size(300, 729);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(875, 761);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(875, 729);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(875, 32);
            // 
            // usersGridView
            // 
            this.usersGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeRows = false;
            this.usersGridView.BackgroundColor = System.Drawing.Color.White;
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.userName,
            this.roleId});
            this.usersGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridView.Location = new System.Drawing.Point(13, 30);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.usersGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(676, 686);
            this.usersGridView.TabIndex = 5;
            this.usersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGridView_CellClick);
            // 
            // userId
            // 
            this.userId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.userId.HeaderText = "UserId";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userId.Width = 63;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userName.HeaderText = "Username";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // roleId
            // 
            this.roleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleId.HeaderText = "RoleId";
            this.roleId.Name = "roleId";
            this.roleId.ReadOnly = true;
            this.roleId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Role Name";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(17, 86);
            this.userNameTxt.Multiline = true;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(268, 20);
            this.userNameTxt.TabIndex = 2;
            // 
            // actionBtn
            // 
            this.actionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.actionBtn.Location = new System.Drawing.Point(183, 175);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(102, 27);
            this.actionBtn.TabIndex = 4;
            this.actionBtn.Text = "Edit";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // operationTxt
            // 
            this.operationTxt.AutoSize = true;
            this.operationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.operationTxt.Location = new System.Drawing.Point(13, 30);
            this.operationTxt.Name = "operationTxt";
            this.operationTxt.Size = new System.Drawing.Size(47, 20);
            this.operationTxt.TabIndex = 33;
            this.operationTxt.Text = "View";
            // 
            // rolesDropDown
            // 
            this.rolesDropDown.FormattingEnabled = true;
            this.rolesDropDown.Location = new System.Drawing.Point(17, 137);
            this.rolesDropDown.Name = "rolesDropDown";
            this.rolesDropDown.Size = new System.Drawing.Size(268, 21);
            this.rolesDropDown.TabIndex = 34;
            // 
            // addUserPanel
            // 
            this.addUserPanel.Controls.Add(this.userAddBtn);
            this.addUserPanel.Controls.Add(this.roleIdDropDown);
            this.addUserPanel.Controls.Add(this.label17);
            this.addUserPanel.Controls.Add(this.uName);
            this.addUserPanel.Controls.Add(this.label16);
            this.addUserPanel.Controls.Add(this.userConPass);
            this.addUserPanel.Controls.Add(this.label14);
            this.addUserPanel.Controls.Add(this.userPass);
            this.addUserPanel.Controls.Add(this.label13);
            this.addUserPanel.Controls.Add(this.label11);
            this.addUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserPanel.Location = new System.Drawing.Point(0, 0);
            this.addUserPanel.Name = "addUserPanel";
            this.addUserPanel.Size = new System.Drawing.Size(300, 467);
            this.addUserPanel.TabIndex = 35;
            this.addUserPanel.Visible = false;
            // 
            // userAddBtn
            // 
            this.userAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userAddBtn.Location = new System.Drawing.Point(183, 277);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(104, 26);
            this.userAddBtn.TabIndex = 41;
            this.userAddBtn.Text = "Add";
            this.userAddBtn.UseVisualStyleBackColor = true;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // roleIdDropDown
            // 
            this.roleIdDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIdDropDown.FormattingEnabled = true;
            this.roleIdDropDown.Location = new System.Drawing.Point(14, 134);
            this.roleIdDropDown.Name = "roleIdDropDown";
            this.roleIdDropDown.Size = new System.Drawing.Size(273, 21);
            this.roleIdDropDown.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(11, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Role name";
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(14, 83);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(273, 20);
            this.uName.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(14, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Username";
            // 
            // userConPass
            // 
            this.userConPass.Location = new System.Drawing.Point(14, 241);
            this.userConPass.Name = "userConPass";
            this.userConPass.PasswordChar = '*';
            this.userConPass.Size = new System.Drawing.Size(273, 20);
            this.userConPass.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(12, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Confirm Password";
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(14, 188);
            this.userPass.Name = "userPass";
            this.userPass.PasswordChar = '*';
            this.userPass.Size = new System.Drawing.Size(273, 20);
            this.userPass.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(11, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(13, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Add User";
            // 
            // passwordChangePanel
            // 
            this.passwordChangePanel.Controls.Add(this.label9);
            this.passwordChangePanel.Controls.Add(this.confirmNewPassword);
            this.passwordChangePanel.Controls.Add(this.label8);
            this.passwordChangePanel.Controls.Add(this.label7);
            this.passwordChangePanel.Controls.Add(this.label6);
            this.passwordChangePanel.Controls.Add(this.changePasswordBtn);
            this.passwordChangePanel.Controls.Add(this.currentPassword);
            this.passwordChangePanel.Controls.Add(this.newPassword);
            this.passwordChangePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordChangePanel.Location = new System.Drawing.Point(0, 467);
            this.passwordChangePanel.Name = "passwordChangePanel";
            this.passwordChangePanel.Size = new System.Drawing.Size(300, 262);
            this.passwordChangePanel.TabIndex = 35;
            this.passwordChangePanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Confirm Password";
            // 
            // confirmNewPassword
            // 
            this.confirmNewPassword.Location = new System.Drawing.Point(17, 189);
            this.confirmNewPassword.Multiline = true;
            this.confirmNewPassword.Name = "confirmNewPassword";
            this.confirmNewPassword.Size = new System.Drawing.Size(268, 20);
            this.confirmNewPassword.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(13, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Change Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "New Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Current Password";
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordBtn.Location = new System.Drawing.Point(183, 219);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(102, 27);
            this.changePasswordBtn.TabIndex = 36;
            this.changePasswordBtn.Text = "Change";
            this.changePasswordBtn.UseVisualStyleBackColor = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // currentPassword
            // 
            this.currentPassword.Location = new System.Drawing.Point(17, 95);
            this.currentPassword.Multiline = true;
            this.currentPassword.Name = "currentPassword";
            this.currentPassword.Size = new System.Drawing.Size(268, 20);
            this.currentPassword.TabIndex = 36;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(17, 142);
            this.newPassword.Multiline = true;
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(268, 20);
            this.newPassword.TabIndex = 37;
            // 
            // changePassPanelV
            // 
            this.changePassPanelV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassPanelV.Location = new System.Drawing.Point(17, 175);
            this.changePassPanelV.Name = "changePassPanelV";
            this.changePassPanelV.Size = new System.Drawing.Size(160, 27);
            this.changePassPanelV.TabIndex = 36;
            this.changePassPanelV.Text = "Change Password";
            this.changePassPanelV.UseVisualStyleBackColor = true;
            this.changePassPanelV.Click += new System.EventHandler(this.changePassPanelV_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 761);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.addUserPanel.ResumeLayout(false);
            this.addUserPanel.PerformLayout();
            this.passwordChangePanel.ResumeLayout(false);
            this.passwordChangePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label operationTxt;
        private System.Windows.Forms.ComboBox rolesDropDown;
        private System.Windows.Forms.Panel addUserPanel;
        private System.Windows.Forms.Button userAddBtn;
        private System.Windows.Forms.ComboBox roleIdDropDown;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox userConPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel passwordChangePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.TextBox currentPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox confirmNewPassword;
        private System.Windows.Forms.Button changePassPanelV;
    }
}