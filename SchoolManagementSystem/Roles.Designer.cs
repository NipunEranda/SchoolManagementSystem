namespace SchoolManagementSystem
{
    partial class Roles
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
            this.roleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.rolesDGV = new System.Windows.Forms.DataGridView();
            this.RolesIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolesGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusTxt = new System.Windows.Forms.ComboBox();
            this.rolesErrorLabel = new System.Windows.Forms.Label();
            this.statusErrorLabel = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rolesDGV);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.rolesDGV, 0);
            // 
            // backBtn
            // 
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.operation);
            this.panel5.Controls.Add(this.statusErrorLabel);
            this.panel5.Controls.Add(this.rolesErrorLabel);
            this.panel5.Controls.Add(this.statusTxt);
            this.panel5.Controls.Add(this.acceptBtn);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.roleTxt);
            // 
            // roleTxt
            // 
            this.roleTxt.Location = new System.Drawing.Point(12, 101);
            this.roleTxt.Name = "roleTxt";
            this.roleTxt.Size = new System.Drawing.Size(275, 20);
            this.roleTxt.TabIndex = 0;
            this.roleTxt.TextChanged += new System.EventHandler(this.roleTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(172, 184);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(116, 30);
            this.acceptBtn.TabIndex = 4;
            this.acceptBtn.Text = "Done";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // rolesDGV
            // 
            this.rolesDGV.AllowUserToAddRows = false;
            this.rolesDGV.AllowUserToDeleteRows = false;
            this.rolesDGV.AllowUserToResizeRows = false;
            this.rolesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesDGV.BackgroundColor = System.Drawing.Color.White;
            this.rolesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rolesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.rolesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RolesIdGV,
            this.RolesGv,
            this.statusGv});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.rolesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.rolesDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolesDGV.Location = new System.Drawing.Point(13, 30);
            this.rolesDGV.Name = "rolesDGV";
            this.rolesDGV.ReadOnly = true;
            this.rolesDGV.RowHeadersVisible = false;
            this.rolesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesDGV.Size = new System.Drawing.Size(498, 437);
            this.rolesDGV.TabIndex = 5;
            this.rolesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesDGV_CellClick);
            // 
            // RolesIdGV
            // 
            this.RolesIdGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RolesIdGV.HeaderText = "Role ID";
            this.RolesIdGV.Name = "RolesIdGV";
            this.RolesIdGV.ReadOnly = true;
            this.RolesIdGV.Width = 68;
            // 
            // RolesGv
            // 
            this.RolesGv.HeaderText = "Role";
            this.RolesGv.Name = "RolesGv";
            this.RolesGv.ReadOnly = true;
            // 
            // statusGv
            // 
            this.statusGv.HeaderText = "Status";
            this.statusGv.Name = "statusGv";
            this.statusGv.ReadOnly = true;
            // 
            // statusTxt
            // 
            this.statusTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusTxt.FormattingEnabled = true;
            this.statusTxt.Items.AddRange(new object[] {
            "Active",
            "In-active"});
            this.statusTxt.Location = new System.Drawing.Point(12, 146);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(275, 21);
            this.statusTxt.TabIndex = 5;
            this.statusTxt.SelectedIndexChanged += new System.EventHandler(this.statusTxt_SelectedIndexChanged);
            // 
            // rolesErrorLabel
            // 
            this.rolesErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolesErrorLabel.ForeColor = System.Drawing.Color.White;
            this.rolesErrorLabel.Location = new System.Drawing.Point(274, 82);
            this.rolesErrorLabel.Name = "rolesErrorLabel";
            this.rolesErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.rolesErrorLabel.TabIndex = 6;
            this.rolesErrorLabel.Text = "*";
            // 
            // statusErrorLabel
            // 
            this.statusErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusErrorLabel.ForeColor = System.Drawing.Color.White;
            this.statusErrorLabel.Location = new System.Drawing.Point(274, 127);
            this.statusErrorLabel.Name = "statusErrorLabel";
            this.statusErrorLabel.Size = new System.Drawing.Size(14, 16);
            this.statusErrorLabel.TabIndex = 7;
            this.statusErrorLabel.Text = "*";
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.ForeColor = System.Drawing.SystemColors.Control;
            this.operation.Location = new System.Drawing.Point(7, 33);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(47, 20);
            this.operation.TabIndex = 23;
            this.operation.Text = "View";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 512);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "Roles";
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView rolesDGV;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label label4;
        new private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roleTxt;
        private System.Windows.Forms.ComboBox statusTxt;
        private System.Windows.Forms.Label rolesErrorLabel;
        private System.Windows.Forms.Label statusErrorLabel;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolesIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolesGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGv;
    }
}