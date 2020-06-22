namespace SchoolManagementSystem
{
    partial class returnBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.returnGridView = new System.Windows.Forms.DataGridView();
            this.reserveIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserveDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.MemberIDNull = new System.Windows.Forms.Label();
            this.lblReserveID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.ReserveIDText = new System.Windows.Forms.Label();
            this.BookIDText = new System.Windows.Forms.Label();
            this.BookNameText = new System.Windows.Forms.Label();
            this.lblMain = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(322, 723);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(975, 723);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(975, 39);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblMain);
            this.panel6.Controls.Add(this.BookNameText);
            this.panel6.Controls.Add(this.BookIDText);
            this.panel6.Controls.Add(this.ReserveIDText);
            this.panel6.Controls.Add(this.btnReturnBooks);
            this.panel6.Controls.Add(this.lblBookName);
            this.panel6.Controls.Add(this.lblBookID);
            this.panel6.Controls.Add(this.lblReserveID);
            this.panel6.Controls.Add(this.txtMemberID);
            this.panel6.Controls.Add(this.lblMemberID);
            this.panel6.Controls.Add(this.MemberIDNull);
            this.panel6.Size = new System.Drawing.Size(322, 684);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.returnGridView);
            this.panel5.Size = new System.Drawing.Size(975, 684);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.returnGridView, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(753, 0);
            this.panel1.Size = new System.Drawing.Size(222, 684);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // returnGridView
            // 
            this.returnGridView.AllowUserToAddRows = false;
            this.returnGridView.AllowUserToDeleteRows = false;
            this.returnGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.returnGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.returnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reserveIDGV,
            this.bookIDGV,
            this.bookNameGV,
            this.memberIDGV,
            this.reserveDateGV,
            this.dueDateGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.returnGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.returnGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnGridView.Location = new System.Drawing.Point(0, 0);
            this.returnGridView.Name = "returnGridView";
            this.returnGridView.ReadOnly = true;
            this.returnGridView.RowHeadersVisible = false;
            this.returnGridView.RowTemplate.Height = 24;
            this.returnGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnGridView.Size = new System.Drawing.Size(753, 684);
            this.returnGridView.TabIndex = 1;
            this.returnGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.returnGridView_CellClick);
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
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(42, 206);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(207, 22);
            this.txtMemberID.TabIndex = 114;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.ForeColor = System.Drawing.Color.White;
            this.lblMemberID.Location = new System.Drawing.Point(41, 177);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(132, 29);
            this.lblMemberID.TabIndex = 113;
            this.lblMemberID.Text = "Member ID";
            // 
            // MemberIDNull
            // 
            this.MemberIDNull.AutoSize = true;
            this.MemberIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberIDNull.ForeColor = System.Drawing.Color.White;
            this.MemberIDNull.Location = new System.Drawing.Point(222, 174);
            this.MemberIDNull.Name = "MemberIDNull";
            this.MemberIDNull.Size = new System.Drawing.Size(23, 29);
            this.MemberIDNull.TabIndex = 115;
            this.MemberIDNull.Text = "*";
            // 
            // lblReserveID
            // 
            this.lblReserveID.AutoSize = true;
            this.lblReserveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReserveID.ForeColor = System.Drawing.Color.White;
            this.lblReserveID.Location = new System.Drawing.Point(41, 246);
            this.lblReserveID.Name = "lblReserveID";
            this.lblReserveID.Size = new System.Drawing.Size(132, 29);
            this.lblReserveID.TabIndex = 116;
            this.lblReserveID.Text = "Reserve ID";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.White;
            this.lblBookID.Location = new System.Drawing.Point(41, 332);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(98, 29);
            this.lblBookID.TabIndex = 117;
            this.lblBookID.Text = "Book ID";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(37, 395);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(140, 29);
            this.lblBookName.TabIndex = 118;
            this.lblBookName.Text = "Book Name";
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooks.Location = new System.Drawing.Point(46, 495);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(200, 46);
            this.btnReturnBooks.TabIndex = 131;
            this.btnReturnBooks.Text = "Return books";
            this.btnReturnBooks.UseVisualStyleBackColor = true;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // ReserveIDText
            // 
            this.ReserveIDText.BackColor = System.Drawing.Color.White;
            this.ReserveIDText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReserveIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveIDText.ForeColor = System.Drawing.Color.Black;
            this.ReserveIDText.Location = new System.Drawing.Point(46, 286);
            this.ReserveIDText.Name = "ReserveIDText";
            this.ReserveIDText.Size = new System.Drawing.Size(207, 30);
            this.ReserveIDText.TabIndex = 135;
            // 
            // BookIDText
            // 
            this.BookIDText.BackColor = System.Drawing.Color.White;
            this.BookIDText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDText.ForeColor = System.Drawing.Color.Black;
            this.BookIDText.Location = new System.Drawing.Point(42, 365);
            this.BookIDText.Name = "BookIDText";
            this.BookIDText.Size = new System.Drawing.Size(207, 30);
            this.BookIDText.TabIndex = 136;
            // 
            // BookNameText
            // 
            this.BookNameText.BackColor = System.Drawing.Color.White;
            this.BookNameText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BookNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameText.ForeColor = System.Drawing.Color.Black;
            this.BookNameText.Location = new System.Drawing.Point(42, 434);
            this.BookNameText.Name = "BookNameText";
            this.BookNameText.Size = new System.Drawing.Size(207, 30);
            this.BookNameText.TabIndex = 137;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(40, 105);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(183, 32);
            this.lblMain.TabIndex = 138;
            this.lblMain.Text = "Return Book";
            // 
            // returnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 723);
            this.Name = "returnBooks";
            this.Text = "returnBooks";
            this.Load += new System.EventHandler(this.returnBooks_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView returnGridView;
        public System.Windows.Forms.TextBox txtMemberID;
        public System.Windows.Forms.Label lblMemberID;
        public System.Windows.Forms.Label MemberIDNull;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.Label lblBookID;
        public System.Windows.Forms.Label lblReserveID;
        public System.Windows.Forms.Button btnReturnBooks;
        public System.Windows.Forms.Label BookNameText;
        public System.Windows.Forms.Label BookIDText;
        public System.Windows.Forms.Label ReserveIDText;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserveIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserveDateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateGV;
        public System.Windows.Forms.Label lblMain;
    }
}