namespace SchoolManagementSystem
{
    partial class reserveBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.BookIDNull = new System.Windows.Forms.Label();
            this.ReserveIDNull = new System.Windows.Forms.Label();
            this.lblReserveID = new System.Windows.Forms.Label();
            this.txtReserveID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.MemberIDNull = new System.Windows.Forms.Label();
            this.ReserveDate = new System.Windows.Forms.DateTimePicker();
            this.lblReserveDate = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ReserveGroupBox = new System.Windows.Forms.GroupBox();
            this.ReserveGridView = new System.Windows.Forms.DataGridView();
            this.reserveIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserveDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.DueDate = new System.Windows.Forms.DateTimePicker();
            this.BookNameNull = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.DueDateNull = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ReserveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReserveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(322, 868);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(1003, 868);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(1003, 39);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DueDateNull);
            this.panel6.Controls.Add(this.BookNameNull);
            this.panel6.Controls.Add(this.lblBookName);
            this.panel6.Controls.Add(this.txtBookName);
            this.panel6.Controls.Add(this.DueDate);
            this.panel6.Controls.Add(this.lblDueDate);
            this.panel6.Controls.Add(this.btnReserve);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.ReserveDate);
            this.panel6.Controls.Add(this.lblReserveDate);
            this.panel6.Controls.Add(this.txtMemberID);
            this.panel6.Controls.Add(this.lblMemberID);
            this.panel6.Controls.Add(this.MemberIDNull);
            this.panel6.Controls.Add(this.ReserveIDNull);
            this.panel6.Controls.Add(this.lblReserveID);
            this.panel6.Controls.Add(this.txtReserveID);
            this.panel6.Controls.Add(this.txtBookID);
            this.panel6.Controls.Add(this.lblBookID);
            this.panel6.Controls.Add(this.BookIDNull);
            this.panel6.Controls.Add(this.lblMain);
            this.panel6.Size = new System.Drawing.Size(322, 829);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ReserveGroupBox);
            this.panel5.Size = new System.Drawing.Size(1003, 829);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.ReserveGroupBox, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(781, 0);
            this.panel1.Size = new System.Drawing.Size(222, 829);
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
            this.lblMain.Location = new System.Drawing.Point(27, 45);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(81, 32);
            this.lblMain.TabIndex = 107;
            this.lblMain.Text = "View";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(58, 239);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(207, 22);
            this.txtBookID.TabIndex = 109;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.White;
            this.lblBookID.Location = new System.Drawing.Point(57, 207);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(98, 29);
            this.lblBookID.TabIndex = 108;
            this.lblBookID.Text = "Book ID";
            // 
            // BookIDNull
            // 
            this.BookIDNull.AutoSize = true;
            this.BookIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDNull.ForeColor = System.Drawing.Color.White;
            this.BookIDNull.Location = new System.Drawing.Point(239, 207);
            this.BookIDNull.Name = "BookIDNull";
            this.BookIDNull.Size = new System.Drawing.Size(23, 29);
            this.BookIDNull.TabIndex = 110;
            this.BookIDNull.Text = "*";
            // 
            // ReserveIDNull
            // 
            this.ReserveIDNull.AutoSize = true;
            this.ReserveIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveIDNull.ForeColor = System.Drawing.Color.White;
            this.ReserveIDNull.Location = new System.Drawing.Point(242, 134);
            this.ReserveIDNull.Name = "ReserveIDNull";
            this.ReserveIDNull.Size = new System.Drawing.Size(23, 29);
            this.ReserveIDNull.TabIndex = 116;
            this.ReserveIDNull.Text = "*";
            // 
            // lblReserveID
            // 
            this.lblReserveID.AutoSize = true;
            this.lblReserveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveID.ForeColor = System.Drawing.Color.White;
            this.lblReserveID.Location = new System.Drawing.Point(57, 134);
            this.lblReserveID.Name = "lblReserveID";
            this.lblReserveID.Size = new System.Drawing.Size(132, 29);
            this.lblReserveID.TabIndex = 114;
            this.lblReserveID.Text = "Reserve ID";
            // 
            // txtReserveID
            // 
            this.txtReserveID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReserveID.Location = new System.Drawing.Point(58, 166);
            this.txtReserveID.Name = "txtReserveID";
            this.txtReserveID.Size = new System.Drawing.Size(207, 22);
            this.txtReserveID.TabIndex = 115;
            this.txtReserveID.TextChanged += new System.EventHandler(this.txtReserveID_TextChanged);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(58, 310);
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
            this.lblMemberID.Location = new System.Drawing.Point(53, 278);
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
            this.MemberIDNull.Location = new System.Drawing.Point(234, 275);
            this.MemberIDNull.Name = "MemberIDNull";
            this.MemberIDNull.Size = new System.Drawing.Size(23, 29);
            this.MemberIDNull.TabIndex = 119;
            this.MemberIDNull.Text = "*";
            // 
            // ReserveDate
            // 
            this.ReserveDate.Location = new System.Drawing.Point(58, 452);
            this.ReserveDate.Name = "ReserveDate";
            this.ReserveDate.Size = new System.Drawing.Size(204, 22);
            this.ReserveDate.TabIndex = 121;
            this.ReserveDate.ValueChanged += new System.EventHandler(this.ReserveDate_ValueChanged);
            // 
            // lblReserveDate
            // 
            this.lblReserveDate.AutoSize = true;
            this.lblReserveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveDate.ForeColor = System.Drawing.Color.White;
            this.lblReserveDate.Location = new System.Drawing.Point(51, 420);
            this.lblReserveDate.Name = "lblReserveDate";
            this.lblReserveDate.Size = new System.Drawing.Size(159, 29);
            this.lblReserveDate.TabIndex = 120;
            this.lblReserveDate.Text = "Reserve Date";
            // 
            // btnReserve
            // 
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(56, 591);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(200, 46);
            this.btnReserve.TabIndex = 132;
            this.btnReserve.Text = "Save";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(56, 672);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 46);
            this.btnClear.TabIndex = 131;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ReserveGroupBox
            // 
            this.ReserveGroupBox.Controls.Add(this.ReserveGridView);
            this.ReserveGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReserveGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ReserveGroupBox.Name = "ReserveGroupBox";
            this.ReserveGroupBox.Size = new System.Drawing.Size(781, 829);
            this.ReserveGroupBox.TabIndex = 1;
            this.ReserveGroupBox.TabStop = false;
            this.ReserveGroupBox.Text = "Details";
            // 
            // ReserveGridView
            // 
            this.ReserveGridView.AllowUserToAddRows = false;
            this.ReserveGridView.AllowUserToDeleteRows = false;
            this.ReserveGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReserveGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReserveGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReserveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReserveGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reserveIDGV,
            this.bookIDGV,
            this.bookNameGV,
            this.memberIDGV,
            this.reserveDateGV,
            this.dueDateGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReserveGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReserveGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReserveGridView.Location = new System.Drawing.Point(3, 18);
            this.ReserveGridView.Name = "ReserveGridView";
            this.ReserveGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReserveGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ReserveGridView.RowHeadersVisible = false;
            this.ReserveGridView.RowTemplate.Height = 24;
            this.ReserveGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReserveGridView.Size = new System.Drawing.Size(775, 808);
            this.ReserveGridView.TabIndex = 0;
            this.ReserveGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReserveGridView_CellClick);
            // 
            // reserveIDGV
            // 
            this.reserveIDGV.HeaderText = "Reserve ID";
            this.reserveIDGV.Name = "reserveIDGV";
            this.reserveIDGV.ReadOnly = true;
            // 
            // bookIDGV
            // 
            this.bookIDGV.HeaderText = "Book ID";
            this.bookIDGV.Name = "bookIDGV";
            this.bookIDGV.ReadOnly = true;
            // 
            // bookNameGV
            // 
            this.bookNameGV.HeaderText = "Book Name";
            this.bookNameGV.Name = "bookNameGV";
            this.bookNameGV.ReadOnly = true;
            // 
            // memberIDGV
            // 
            this.memberIDGV.HeaderText = "Member ID";
            this.memberIDGV.Name = "memberIDGV";
            this.memberIDGV.ReadOnly = true;
            // 
            // reserveDateGV
            // 
            this.reserveDateGV.HeaderText = "Reserve Date";
            this.reserveDateGV.Name = "reserveDateGV";
            this.reserveDateGV.ReadOnly = true;
            // 
            // dueDateGV
            // 
            this.dueDateGV.HeaderText = "Due Date";
            this.dueDateGV.Name = "dueDateGV";
            this.dueDateGV.ReadOnly = true;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.White;
            this.lblDueDate.Location = new System.Drawing.Point(53, 496);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(113, 29);
            this.lblDueDate.TabIndex = 133;
            this.lblDueDate.Text = "Due Date";
            // 
            // DueDate
            // 
            this.DueDate.Location = new System.Drawing.Point(58, 528);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(204, 22);
            this.DueDate.TabIndex = 136;
            this.DueDate.ValueChanged += new System.EventHandler(this.DueDate_ValueChanged);
            // 
            // BookNameNull
            // 
            this.BookNameNull.AutoSize = true;
            this.BookNameNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameNull.ForeColor = System.Drawing.Color.White;
            this.BookNameNull.Location = new System.Drawing.Point(242, 353);
            this.BookNameNull.Name = "BookNameNull";
            this.BookNameNull.Size = new System.Drawing.Size(23, 29);
            this.BookNameNull.TabIndex = 139;
            this.BookNameNull.Text = "*";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(57, 353);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(140, 29);
            this.lblBookName.TabIndex = 137;
            this.lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(58, 385);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 22);
            this.txtBookName.TabIndex = 138;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // DueDateNull
            // 
            this.DueDateNull.AutoSize = true;
            this.DueDateNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateNull.ForeColor = System.Drawing.Color.White;
            this.DueDateNull.Location = new System.Drawing.Point(242, 496);
            this.DueDateNull.Name = "DueDateNull";
            this.DueDateNull.Size = new System.Drawing.Size(23, 29);
            this.DueDateNull.TabIndex = 140;
            this.DueDateNull.Text = "*";
            // 
            // reserveBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 868);
            this.Name = "reserveBooks";
            this.Text = "reserveBooks";
            this.Load += new System.EventHandler(this.reserveBooks_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ReserveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReserveGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMain;
        public System.Windows.Forms.TextBox txtBookID;
        public System.Windows.Forms.Label lblBookID;
        public System.Windows.Forms.Label BookIDNull;
        public System.Windows.Forms.Label ReserveIDNull;
        public System.Windows.Forms.Label lblReserveID;
        public System.Windows.Forms.TextBox txtReserveID;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.Label MemberIDNull;
        public System.Windows.Forms.DateTimePicker ReserveDate;
        public System.Windows.Forms.Label lblReserveDate;
        public System.Windows.Forms.Button btnReserve;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox ReserveGroupBox;
        private System.Windows.Forms.DataGridView ReserveGridView;
        public System.Windows.Forms.DateTimePicker DueDate;
        public System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserveIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserveDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateGV;
        public System.Windows.Forms.Label BookNameNull;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label DueDateNull;
    }
}