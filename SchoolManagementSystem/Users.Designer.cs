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
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 761);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
    }
}