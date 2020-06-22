namespace SchoolManagementSystem
{
    partial class studentPayments
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
            this.Mainlabel = new System.Windows.Forms.Label();
            this.StdIDTxt = new System.Windows.Forms.TextBox();
            this.payStdID = new System.Windows.Forms.Label();
            this.stdAmount = new System.Windows.Forms.TextBox();
            this.payStdAmt = new System.Windows.Forms.Label();
            this.PaidDate = new System.Windows.Forms.DateTimePicker();
            this.payDate = new System.Windows.Forms.Label();
            this.stdAcceptBtn = new System.Windows.Forms.Button();
            this.StudentDetails = new System.Windows.Forms.DataGridView();
            this.pay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.panel12.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(697, 506);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentDetails);
            this.groupBox1.Size = new System.Drawing.Size(697, 506);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.StudentDetails, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(521, 16);
            this.panel2.Size = new System.Drawing.Size(173, 487);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(518, 14);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(511, 30);
            this.panel10.Size = new System.Drawing.Size(10, 473);
            // 
            // panel9
            // 
            this.panel9.Size = new System.Drawing.Size(10, 473);
            // 
            // backBtn
            // 
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // panel13
            // 
            this.panel13.Size = new System.Drawing.Size(697, 32);
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(13, 493);
            this.panel11.Size = new System.Drawing.Size(498, 10);
            // 
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(0, 437);
            // 
            // panel14
            // 
            this.panel14.Location = new System.Drawing.Point(0, 477);
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(300, 538);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnReport);
            this.panel5.Controls.Add(this.operation);
            this.panel5.Controls.Add(this.stdAcceptBtn);
            this.panel5.Controls.Add(this.payDate);
            this.panel5.Controls.Add(this.PaidDate);
            this.panel5.Controls.Add(this.payStdAmt);
            this.panel5.Controls.Add(this.stdAmount);
            this.panel5.Controls.Add(this.payStdID);
            this.panel5.Controls.Add(this.StdIDTxt);
            this.panel5.Controls.Add(this.Mainlabel);
            this.panel5.Size = new System.Drawing.Size(300, 489);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(300, 49);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(300, 0);
            this.rightPanel.Size = new System.Drawing.Size(697, 538);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(697, 506);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(697, 32);
            // 
            // Mainlabel
            // 
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Mainlabel.Location = new System.Drawing.Point(12, 39);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(156, 20);
            this.Mainlabel.TabIndex = 33;
            this.Mainlabel.Text = "Student Payments\r\n";
            this.Mainlabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // StdIDTxt
            // 
            this.StdIDTxt.Location = new System.Drawing.Point(16, 134);
            this.StdIDTxt.Name = "StdIDTxt";
            this.StdIDTxt.Size = new System.Drawing.Size(268, 20);
            this.StdIDTxt.TabIndex = 38;
            // 
            // payStdID
            // 
            this.payStdID.AutoSize = true;
            this.payStdID.ForeColor = System.Drawing.SystemColors.Control;
            this.payStdID.Location = new System.Drawing.Point(17, 118);
            this.payStdID.Name = "payStdID";
            this.payStdID.Size = new System.Drawing.Size(58, 13);
            this.payStdID.TabIndex = 39;
            this.payStdID.Text = "Student ID";
            this.payStdID.Click += new System.EventHandler(this.label16_Click);
            // 
            // stdAmount
            // 
            this.stdAmount.Location = new System.Drawing.Point(17, 188);
            this.stdAmount.Name = "stdAmount";
            this.stdAmount.Size = new System.Drawing.Size(269, 20);
            this.stdAmount.TabIndex = 42;
            this.stdAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // payStdAmt
            // 
            this.payStdAmt.AutoSize = true;
            this.payStdAmt.ForeColor = System.Drawing.SystemColors.Control;
            this.payStdAmt.Location = new System.Drawing.Point(14, 172);
            this.payStdAmt.Name = "payStdAmt";
            this.payStdAmt.Size = new System.Drawing.Size(88, 13);
            this.payStdAmt.TabIndex = 43;
            this.payStdAmt.Text = "Monthly Payment";
            // 
            // PaidDate
            // 
            this.PaidDate.Location = new System.Drawing.Point(17, 248);
            this.PaidDate.Margin = new System.Windows.Forms.Padding(2);
            this.PaidDate.Name = "PaidDate";
            this.PaidDate.Size = new System.Drawing.Size(268, 20);
            this.PaidDate.TabIndex = 97;
            this.PaidDate.ValueChanged += new System.EventHandler(this.PaidDate_ValueChanged);
            // 
            // payDate
            // 
            this.payDate.AutoSize = true;
            this.payDate.ForeColor = System.Drawing.SystemColors.Control;
            this.payDate.Location = new System.Drawing.Point(17, 233);
            this.payDate.Name = "payDate";
            this.payDate.Size = new System.Drawing.Size(54, 13);
            this.payDate.TabIndex = 98;
            this.payDate.Text = "Paid Date";
            this.payDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // stdAcceptBtn
            // 
            this.stdAcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stdAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdAcceptBtn.Location = new System.Drawing.Point(61, 331);
            this.stdAcceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.stdAcceptBtn.Name = "stdAcceptBtn";
            this.stdAcceptBtn.Size = new System.Drawing.Size(150, 37);
            this.stdAcceptBtn.TabIndex = 99;
            this.stdAcceptBtn.Text = "Accept";
            this.stdAcceptBtn.UseVisualStyleBackColor = true;
            this.stdAcceptBtn.Click += new System.EventHandler(this.StdbtnPay_Click);
            // 
            // StudentDetails
            // 
            this.StudentDetails.AllowUserToAddRows = false;
            this.StudentDetails.AllowUserToDeleteRows = false;
            this.StudentDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pay_id,
            this.StdID,
            this.StdName,
            this.datePaid,
            this.stuPayment});
            this.StudentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentDetails.Location = new System.Drawing.Point(13, 30);
            this.StudentDetails.Name = "StudentDetails";
            this.StudentDetails.ReadOnly = true;
            this.StudentDetails.RowHeadersVisible = false;
            this.StudentDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDetails.Size = new System.Drawing.Size(498, 463);
            this.StudentDetails.TabIndex = 5;
            this.StudentDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDetails_CellClick);
            this.StudentDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pay_id
            // 
            this.pay_id.HeaderText = "Payment ID";
            this.pay_id.Name = "pay_id";
            this.pay_id.ReadOnly = true;
            // 
            // StdID
            // 
            this.StdID.HeaderText = "Student ID";
            this.StdID.Name = "StdID";
            this.StdID.ReadOnly = true;
            // 
            // StdName
            // 
            this.StdName.HeaderText = "Student Name";
            this.StdName.Name = "StdName";
            this.StdName.ReadOnly = true;
            // 
            // datePaid
            // 
            this.datePaid.HeaderText = "Date Paid";
            this.datePaid.Name = "datePaid";
            this.datePaid.ReadOnly = true;
            // 
            // stuPayment
            // 
            this.stuPayment.HeaderText = "Monthly Fee";
            this.stuPayment.Name = "stuPayment";
            this.stuPayment.ReadOnly = true;
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.ForeColor = System.Drawing.SystemColors.Control;
            this.operation.Location = new System.Drawing.Point(17, 78);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(47, 20);
            this.operation.TabIndex = 100;
            this.operation.Text = "View";
            this.operation.Click += new System.EventHandler(this.operation_Click);
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(61, 400);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(150, 37);
            this.btnReport.TabIndex = 101;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // studentPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 538);
            this.Name = "studentPayments";
            this.Text = "studentPayments";
            this.Load += new System.EventHandler(this.studentPayments_Load_1);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.panel12.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.TextBox StdIDTxt;
        private System.Windows.Forms.Label payStdID;
        private System.Windows.Forms.TextBox stdAmount;
        private System.Windows.Forms.Label payStdAmt;
        public System.Windows.Forms.DateTimePicker PaidDate;
        private System.Windows.Forms.Label payDate;
        public System.Windows.Forms.Button stdAcceptBtn;
        public System.Windows.Forms.DataGridView StudentDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuPayment;
        private System.Windows.Forms.Label operation;
        public System.Windows.Forms.Button btnReport;
    }
}