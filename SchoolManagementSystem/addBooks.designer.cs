namespace SchoolManagementSystem
{
    partial class addBooks
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
            this.AuthorNull = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.AddDate = new System.Windows.Forms.DateTimePicker();
            this.lblAddDate = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.BookIDNull = new System.Windows.Forms.Label();
            this.BookNameNull = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.booksGroupBox = new System.Windows.Forms.GroupBox();
            this.BookGridView = new System.Windows.Forms.DataGridView();
            this.BookIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.leftpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.booksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(322, 962);
            // 
            // rightpanel
            // 
            this.rightpanel.Size = new System.Drawing.Size(968, 962);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(968, 39);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.btnAddBooks);
            this.panel6.Controls.Add(this.lblMain);
            this.panel6.Controls.Add(this.AuthorNull);
            this.panel6.Controls.Add(this.txtAuthor);
            this.panel6.Controls.Add(this.lblAuthor);
            this.panel6.Controls.Add(this.btnClear);
            this.panel6.Controls.Add(this.AddDate);
            this.panel6.Controls.Add(this.lblAddDate);
            this.panel6.Controls.Add(this.txtBookID);
            this.panel6.Controls.Add(this.lblBookID);
            this.panel6.Controls.Add(this.BookIDNull);
            this.panel6.Controls.Add(this.BookNameNull);
            this.panel6.Controls.Add(this.lblBookName);
            this.panel6.Controls.Add(this.txtBookName);
            this.panel6.Size = new System.Drawing.Size(322, 923);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.booksGroupBox);
            this.panel5.Size = new System.Drawing.Size(968, 923);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.booksGroupBox, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(746, 0);
            this.panel1.Size = new System.Drawing.Size(222, 923);
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
            this.lblMain.Location = new System.Drawing.Point(47, 96);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(81, 32);
            this.lblMain.TabIndex = 106;
            this.lblMain.Text = "View";
            // 
            // AuthorNull
            // 
            this.AuthorNull.AutoSize = true;
            this.AuthorNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorNull.ForeColor = System.Drawing.Color.White;
            this.AuthorNull.Location = new System.Drawing.Point(229, 300);
            this.AuthorNull.Name = "AuthorNull";
            this.AuthorNull.Size = new System.Drawing.Size(23, 29);
            this.AuthorNull.TabIndex = 104;
            this.AuthorNull.Text = "*";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(49, 332);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(207, 22);
            this.txtAuthor.TabIndex = 101;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(44, 300);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(82, 29);
            this.lblAuthor.TabIndex = 100;
            this.lblAuthor.Text = "Author";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(48, 546);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 46);
            this.btnClear.TabIndex = 99;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddDate
            // 
            this.AddDate.Location = new System.Drawing.Point(48, 403);
            this.AddDate.Name = "AddDate";
            this.AddDate.Size = new System.Drawing.Size(208, 22);
            this.AddDate.TabIndex = 97;
            // 
            // lblAddDate
            // 
            this.lblAddDate.AutoSize = true;
            this.lblAddDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDate.ForeColor = System.Drawing.Color.White;
            this.lblAddDate.Location = new System.Drawing.Point(44, 371);
            this.lblAddDate.Name = "lblAddDate";
            this.lblAddDate.Size = new System.Drawing.Size(140, 29);
            this.lblAddDate.TabIndex = 96;
            this.lblAddDate.Text = "Added Date";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(53, 184);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(203, 22);
            this.txtBookID.TabIndex = 91;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.White;
            this.lblBookID.Location = new System.Drawing.Point(48, 155);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(98, 29);
            this.lblBookID.TabIndex = 90;
            this.lblBookID.Text = "Book ID";
            // 
            // BookIDNull
            // 
            this.BookIDNull.AutoSize = true;
            this.BookIDNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIDNull.ForeColor = System.Drawing.Color.White;
            this.BookIDNull.Location = new System.Drawing.Point(229, 152);
            this.BookIDNull.Name = "BookIDNull";
            this.BookIDNull.Size = new System.Drawing.Size(23, 29);
            this.BookIDNull.TabIndex = 92;
            this.BookIDNull.Text = "*";
            // 
            // BookNameNull
            // 
            this.BookNameNull.AutoSize = true;
            this.BookNameNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameNull.ForeColor = System.Drawing.Color.White;
            this.BookNameNull.Location = new System.Drawing.Point(233, 228);
            this.BookNameNull.Name = "BookNameNull";
            this.BookNameNull.Size = new System.Drawing.Size(23, 29);
            this.BookNameNull.TabIndex = 95;
            this.BookNameNull.Text = "*";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(48, 228);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(140, 29);
            this.lblBookName.TabIndex = 93;
            this.lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(49, 261);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 22);
            this.txtBookName.TabIndex = 94;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // booksGroupBox
            // 
            this.booksGroupBox.Controls.Add(this.BookGridView);
            this.booksGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGroupBox.Location = new System.Drawing.Point(0, 0);
            this.booksGroupBox.Name = "booksGroupBox";
            this.booksGroupBox.Size = new System.Drawing.Size(746, 923);
            this.booksGroupBox.TabIndex = 1;
            this.booksGroupBox.TabStop = false;
            this.booksGroupBox.Text = "Details";
            // 
            // BookGridView
            // 
            this.BookGridView.AllowUserToAddRows = false;
            this.BookGridView.AllowUserToDeleteRows = false;
            this.BookGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookIDGV,
            this.BookNameGV,
            this.AuthorGV,
            this.DateGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BookGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookGridView.Location = new System.Drawing.Point(3, 18);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.ReadOnly = true;
            this.BookGridView.RowHeadersVisible = false;
            this.BookGridView.RowTemplate.Height = 24;
            this.BookGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookGridView.Size = new System.Drawing.Size(740, 902);
            this.BookGridView.TabIndex = 0;
            this.BookGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGridView_CellClick);
            // 
            // BookIDGV
            // 
            this.BookIDGV.HeaderText = "Book ID";
            this.BookIDGV.Name = "BookIDGV";
            this.BookIDGV.ReadOnly = true;
            // 
            // BookNameGV
            // 
            this.BookNameGV.HeaderText = "Book Name";
            this.BookNameGV.Name = "BookNameGV";
            this.BookNameGV.ReadOnly = true;
            // 
            // AuthorGV
            // 
            this.AuthorGV.HeaderText = "Author";
            this.AuthorGV.Name = "AuthorGV";
            this.AuthorGV.ReadOnly = true;
            // 
            // DateGV
            // 
            this.DateGV.HeaderText = "Add Date";
            this.DateGV.Name = "DateGV";
            this.DateGV.ReadOnly = true;
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.Location = new System.Drawing.Point(49, 470);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(207, 46);
            this.btnAddBooks.TabIndex = 107;
            this.btnAddBooks.Text = "Save";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(322, 58);
            this.panel7.TabIndex = 108;
            // 
            // addBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 962);
            this.Name = "addBooks";
            this.Text = "addBooks";
            this.Load += new System.EventHandler(this.addBooks_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.booksGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMain;
        public System.Windows.Forms.Label AuthorNull;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.Label lblAuthor;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.DateTimePicker AddDate;
        public System.Windows.Forms.Label lblAddDate;
        public System.Windows.Forms.TextBox txtBookID;
        public System.Windows.Forms.Label lblBookID;
        public System.Windows.Forms.Label BookIDNull;
        public System.Windows.Forms.Label BookNameNull;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.GroupBox booksGroupBox;
        private System.Windows.Forms.DataGridView BookGridView;
        public System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateGV;
    }
}