namespace SchoolManagementSystem
{
    partial class libraryOverDuePayments
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
            this.lblMain = new System.Windows.Forms.Label();
            this.txtOverDueID = new System.Windows.Forms.TextBox();
            this.lblOverDueID = new System.Windows.Forms.Label();
            this.OverDueIDNull = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.MemberIDNull = new System.Windows.Forms.Label();
            this.txtDueDays = new System.Windows.Forms.TextBox();
            this.lblDueDays = new System.Windows.Forms.Label();
            this.DueDaysNull = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculateAndSubmit = new System.Windows.Forms.Button();
            this.overdueGroupBox = new System.Windows.Forms.GroupBox();
            this.overdueGridView = new System.Windows.Forms.DataGridView();
            this.DueDateNull = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.PerDayAmountNull = new System.Windows.Forms.Label();
            this.txtPerDayAmount = new System.Windows.Forms.TextBox();
            this.lblPerDayAmount = new System.Windows.Forms.Label();
            this.overDueIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfDueDaysGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.overdueGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overdueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(322, 1055);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1058, 1055);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1058, 39);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.PerDayAmountNull);
            this.panel6.Controls.Add(this.txtPerDayAmount);
            this.panel6.Controls.Add(this.lblPerDayAmount);
            this.panel6.Controls.Add(this.totalAmount);
            this.panel6.Controls.Add(this.DueDateNull);
            this.panel6.Controls.Add(this.DueDate);
            this.panel6.Controls.Add(this.lblDueDate);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.btnCalculateAndSubmit);
            this.panel6.Controls.Add(this.lblTotalAmount);
            this.panel6.Controls.Add(this.txtDueDays);
            this.panel6.Controls.Add(this.lblDueDays);
            this.panel6.Controls.Add(this.DueDaysNull);
            this.panel6.Controls.Add(this.txtMemberID);
            this.panel6.Controls.Add(this.lblMemberID);
            this.panel6.Controls.Add(this.MemberIDNull);
            this.panel6.Controls.Add(this.txtOverDueID);
            this.panel6.Controls.Add(this.lblOverDueID);
            this.panel6.Controls.Add(this.OverDueIDNull);
            this.panel6.Controls.Add(this.lblMain);
            this.panel6.Size = new System.Drawing.Size(322, 1016);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.overdueGroupBox);
            this.panel5.Size = new System.Drawing.Size(1058, 1016);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.overdueGroupBox, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(836, 0);
            this.panel1.Size = new System.Drawing.Size(222, 1016);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(3, 67);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(89, 32);
            this.lblMain.TabIndex = 111;
            this.lblMain.Text = "View ";
            // 
            // txtOverDueID
            // 
            this.txtOverDueID.Location = new System.Drawing.Point(39, 183);
            this.txtOverDueID.Name = "txtOverDueID";
            this.txtOverDueID.Size = new System.Drawing.Size(203, 22);
            this.txtOverDueID.TabIndex = 113;
            this.txtOverDueID.TextChanged += new System.EventHandler(this.txtOverDueID_TextChanged);
            // 
            // lblOverDueID
            // 
            this.lblOverDueID.AutoSize = true;
            this.lblOverDueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverDueID.ForeColor = System.Drawing.Color.White;
            this.lblOverDueID.Location = new System.Drawing.Point(34, 151);
            this.lblOverDueID.Name = "lblOverDueID";
            this.lblOverDueID.Size = new System.Drawing.Size(135, 29);
            this.lblOverDueID.TabIndex = 112;
            this.lblOverDueID.Text = "Overdue ID";
            // 
            // OverDueIDNull
            // 
            this.OverDueIDNull.AutoSize = true;
            this.OverDueIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverDueIDNull.ForeColor = System.Drawing.Color.White;
            this.OverDueIDNull.Location = new System.Drawing.Point(215, 148);
            this.OverDueIDNull.Name = "OverDueIDNull";
            this.OverDueIDNull.Size = new System.Drawing.Size(23, 29);
            this.OverDueIDNull.TabIndex = 114;
            this.OverDueIDNull.Text = "*";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(39, 256);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(207, 22);
            this.txtMemberID.TabIndex = 118;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.Color.White;
            this.lblMemberID.Location = new System.Drawing.Point(34, 224);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(132, 29);
            this.lblMemberID.TabIndex = 117;
            this.lblMemberID.Text = "Member ID";
            // 
            // MemberIDNull
            // 
            this.MemberIDNull.AutoSize = true;
            this.MemberIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDNull.ForeColor = System.Drawing.Color.White;
            this.MemberIDNull.Location = new System.Drawing.Point(215, 221);
            this.MemberIDNull.Name = "MemberIDNull";
            this.MemberIDNull.Size = new System.Drawing.Size(23, 29);
            this.MemberIDNull.TabIndex = 119;
            this.MemberIDNull.Text = "*";
            // 
            // txtDueDays
            // 
            this.txtDueDays.Location = new System.Drawing.Point(39, 423);
            this.txtDueDays.Name = "txtDueDays";
            this.txtDueDays.Size = new System.Drawing.Size(207, 22);
            this.txtDueDays.TabIndex = 121;
            this.txtDueDays.TextChanged += new System.EventHandler(this.txtDueDays_TextChanged);
            // 
            // lblDueDays
            // 
            this.lblDueDays.AutoSize = true;
            this.lblDueDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDays.ForeColor = System.Drawing.Color.White;
            this.lblDueDays.Location = new System.Drawing.Point(34, 377);
            this.lblDueDays.Name = "lblDueDays";
            this.lblDueDays.Size = new System.Drawing.Size(180, 29);
            this.lblDueDays.TabIndex = 120;
            this.lblDueDays.Text = "No of Due Days";
            // 
            // DueDaysNull
            // 
            this.DueDaysNull.AutoSize = true;
            this.DueDaysNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDaysNull.ForeColor = System.Drawing.Color.White;
            this.DueDaysNull.Location = new System.Drawing.Point(215, 374);
            this.DueDaysNull.Name = "DueDaysNull";
            this.DueDaysNull.Size = new System.Drawing.Size(23, 29);
            this.DueDaysNull.TabIndex = 122;
            this.DueDaysNull.Text = "*";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(34, 562);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(155, 29);
            this.lblTotalAmount.TabIndex = 123;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(39, 791);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 46);
            this.btnClear.TabIndex = 127;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculateAndSubmit
            // 
            this.btnCalculateAndSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateAndSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAndSubmit.Location = new System.Drawing.Point(39, 696);
            this.btnCalculateAndSubmit.Name = "btnCalculateAndSubmit";
            this.btnCalculateAndSubmit.Size = new System.Drawing.Size(200, 66);
            this.btnCalculateAndSubmit.TabIndex = 126;
            this.btnCalculateAndSubmit.Text = "Calculate and Submit";
            this.btnCalculateAndSubmit.UseVisualStyleBackColor = true;
            this.btnCalculateAndSubmit.Click += new System.EventHandler(this.btnCalculateAndSubmit_Click);
            // 
            // overdueGroupBox
            // 
            this.overdueGroupBox.Controls.Add(this.overdueGridView);
            this.overdueGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overdueGroupBox.Location = new System.Drawing.Point(0, 0);
            this.overdueGroupBox.Name = "overdueGroupBox";
            this.overdueGroupBox.Size = new System.Drawing.Size(836, 1016);
            this.overdueGroupBox.TabIndex = 1;
            this.overdueGroupBox.TabStop = false;
            this.overdueGroupBox.Text = "Details";
            // 
            // overdueGridView
            // 
            this.overdueGridView.AllowUserToAddRows = false;
            this.overdueGridView.AllowUserToDeleteRows = false;
            this.overdueGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.overdueGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.overdueGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.overdueGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overdueGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.overDueIDGV,
            this.memberIDGV,
            this.dueDateGV,
            this.noOfDueDaysGV,
            this.totalAmountGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.overdueGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.overdueGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overdueGridView.Location = new System.Drawing.Point(3, 18);
            this.overdueGridView.Name = "overdueGridView";
            this.overdueGridView.ReadOnly = true;
            this.overdueGridView.RowHeadersVisible = false;
            this.overdueGridView.RowTemplate.Height = 24;
            this.overdueGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.overdueGridView.Size = new System.Drawing.Size(830, 995);
            this.overdueGridView.TabIndex = 0;
            this.overdueGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.overdueGridView_CellClick);
            // 
            // DueDateNull
            // 
            this.DueDateNull.AutoSize = true;
            this.DueDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateNull.ForeColor = System.Drawing.Color.White;
            this.DueDateNull.Location = new System.Drawing.Point(220, 299);
            this.DueDateNull.Name = "DueDateNull";
            this.DueDateNull.Size = new System.Drawing.Size(23, 29);
            this.DueDateNull.TabIndex = 130;
            this.DueDateNull.Text = "*";
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(39, 331);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(204, 22);
            this.DueDate.TabIndex = 129;
            this.DueDate.ValueChanged += new System.EventHandler(this.DueDate_ValueChanged);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(34, 299);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(113, 29);
            this.lblDueDate.TabIndex = 128;
            this.lblDueDate.Text = "Due Date";
            // 
            // totalAmount
            // 
            this.totalAmount.BackColor = System.Drawing.Color.White;
            this.totalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.ForeColor = System.Drawing.Color.Black;
            this.totalAmount.Location = new System.Drawing.Point(39, 615);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(207, 30);
            this.totalAmount.TabIndex = 134;
            // 
            // PerDayAmountNull
            // 
            this.PerDayAmountNull.AutoSize = true;
            this.PerDayAmountNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerDayAmountNull.ForeColor = System.Drawing.Color.White;
            this.PerDayAmountNull.Location = new System.Drawing.Point(219, 471);
            this.PerDayAmountNull.Name = "PerDayAmountNull";
            this.PerDayAmountNull.Size = new System.Drawing.Size(23, 29);
            this.PerDayAmountNull.TabIndex = 137;
            this.PerDayAmountNull.Text = "*";
            // 
            // txtPerDayAmount
            // 
            this.txtPerDayAmount.Location = new System.Drawing.Point(39, 507);
            this.txtPerDayAmount.Name = "txtPerDayAmount";
            this.txtPerDayAmount.Size = new System.Drawing.Size(207, 22);
            this.txtPerDayAmount.TabIndex = 136;
            this.txtPerDayAmount.TextChanged += new System.EventHandler(this.txtPerDayAmount_TextChanged);
            // 
            // lblPerDayAmount
            // 
            this.lblPerDayAmount.AutoSize = true;
            this.lblPerDayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerDayAmount.ForeColor = System.Drawing.Color.White;
            this.lblPerDayAmount.Location = new System.Drawing.Point(34, 471);
            this.lblPerDayAmount.Name = "lblPerDayAmount";
            this.lblPerDayAmount.Size = new System.Drawing.Size(180, 29);
            this.lblPerDayAmount.TabIndex = 135;
            this.lblPerDayAmount.Text = "Per day amount";
            // 
            // overDueIDGV
            // 
            this.overDueIDGV.HeaderText = "Overdue ID";
            this.overDueIDGV.Name = "overDueIDGV";
            this.overDueIDGV.ReadOnly = true;
            // 
            // memberIDGV
            // 
            this.memberIDGV.HeaderText = "Member ID";
            this.memberIDGV.Name = "memberIDGV";
            this.memberIDGV.ReadOnly = true;
            // 
            // dueDateGV
            // 
            this.dueDateGV.HeaderText = "Due Date";
            this.dueDateGV.Name = "dueDateGV";
            this.dueDateGV.ReadOnly = true;
            // 
            // noOfDueDaysGV
            // 
            this.noOfDueDaysGV.HeaderText = "No of Due Days";
            this.noOfDueDaysGV.Name = "noOfDueDaysGV";
            this.noOfDueDaysGV.ReadOnly = true;
            // 
            // totalAmountGV
            // 
            this.totalAmountGV.HeaderText = "Total Amount";
            this.totalAmountGV.Name = "totalAmountGV";
            this.totalAmountGV.ReadOnly = true;
            // 
            // overDuePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 1055);
            this.Name = "overDuePayments";
            this.Text = "overDuePayments";
            this.Load += new System.EventHandler(this.overDuePayments_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.overdueGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overdueGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMain;
        public System.Windows.Forms.TextBox txtOverDueID;
        public System.Windows.Forms.Label lblOverDueID;
        public System.Windows.Forms.Label OverDueIDNull;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.Label MemberIDNull;
        public System.Windows.Forms.Label lblTotalAmount;
        public System.Windows.Forms.TextBox txtDueDays;
        public System.Windows.Forms.Label lblDueDays;
        public System.Windows.Forms.Label DueDaysNull;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnCalculateAndSubmit;
        private System.Windows.Forms.GroupBox overdueGroupBox;
        private System.Windows.Forms.DataGridView overdueGridView;
        public System.Windows.Forms.Label DueDateNull;
        public System.Windows.Forms.DateTimePicker DueDate;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label totalAmount;
        public System.Windows.Forms.Label PerDayAmountNull;
        public System.Windows.Forms.TextBox txtPerDayAmount;
        public System.Windows.Forms.Label lblPerDayAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn overDueIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfDueDaysGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountGV;
    }
}