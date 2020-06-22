namespace SchoolManagementSystem
{
    partial class employee_payments
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
            this.operation = new System.Windows.Forms.Label();
            this.payEmpID = new System.Windows.Forms.Label();
            this.EmpIDTxt = new System.Windows.Forms.TextBox();
            this.payEmpAmt = new System.Windows.Forms.Label();
            this.empAmount = new System.Windows.Forms.TextBox();
            this.EmpPayDate = new System.Windows.Forms.Label();
            this.EmpPaidDate = new System.Windows.Forms.DateTimePicker();
            this.EmployeeDetails = new System.Windows.Forms.DataGridView();
            this.emp_pay_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_datePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empAcceptBtn = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmployeeDetails);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.EmployeeDetails, 0);
            // 
            // backBtn
            // 
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.empAcceptBtn);
            this.panel5.Controls.Add(this.EmpPaidDate);
            this.panel5.Controls.Add(this.EmpPayDate);
            this.panel5.Controls.Add(this.empAmount);
            this.panel5.Controls.Add(this.payEmpAmt);
            this.panel5.Controls.Add(this.EmpIDTxt);
            this.panel5.Controls.Add(this.payEmpID);
            this.panel5.Controls.Add(this.operation);
            this.panel5.Controls.Add(this.Mainlabel);
            // 
            // Mainlabel
            // 
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Mainlabel.Location = new System.Drawing.Point(22, 39);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(170, 20);
            this.Mainlabel.TabIndex = 34;
            this.Mainlabel.Text = "Employee Payments\r\n";
            // 
            // operation
            // 
            this.operation.AutoSize = true;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.ForeColor = System.Drawing.SystemColors.Control;
            this.operation.Location = new System.Drawing.Point(22, 88);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(47, 20);
            this.operation.TabIndex = 101;
            this.operation.Text = "View";
            // 
            // payEmpID
            // 
            this.payEmpID.AutoSize = true;
            this.payEmpID.ForeColor = System.Drawing.SystemColors.Control;
            this.payEmpID.Location = new System.Drawing.Point(23, 127);
            this.payEmpID.Name = "payEmpID";
            this.payEmpID.Size = new System.Drawing.Size(67, 13);
            this.payEmpID.TabIndex = 102;
            this.payEmpID.Text = "Employee ID";
            // 
            // EmpIDTxt
            // 
            this.EmpIDTxt.Location = new System.Drawing.Point(25, 143);
            this.EmpIDTxt.Name = "EmpIDTxt";
            this.EmpIDTxt.Size = new System.Drawing.Size(268, 20);
            this.EmpIDTxt.TabIndex = 103;
            // 
            // payEmpAmt
            // 
            this.payEmpAmt.AutoSize = true;
            this.payEmpAmt.ForeColor = System.Drawing.SystemColors.Control;
            this.payEmpAmt.Location = new System.Drawing.Point(23, 191);
            this.payEmpAmt.Name = "payEmpAmt";
            this.payEmpAmt.Size = new System.Drawing.Size(76, 13);
            this.payEmpAmt.TabIndex = 104;
            this.payEmpAmt.Text = "Monthly Salary";
            // 
            // empAmount
            // 
            this.empAmount.Location = new System.Drawing.Point(26, 207);
            this.empAmount.Name = "empAmount";
            this.empAmount.Size = new System.Drawing.Size(269, 20);
            this.empAmount.TabIndex = 105;
            // 
            // EmpPayDate
            // 
            this.EmpPayDate.AutoSize = true;
            this.EmpPayDate.ForeColor = System.Drawing.SystemColors.Control;
            this.EmpPayDate.Location = new System.Drawing.Point(23, 255);
            this.EmpPayDate.Name = "EmpPayDate";
            this.EmpPayDate.Size = new System.Drawing.Size(54, 13);
            this.EmpPayDate.TabIndex = 106;
            this.EmpPayDate.Text = "Paid Date";
            // 
            // EmpPaidDate
            // 
            this.EmpPaidDate.Location = new System.Drawing.Point(25, 270);
            this.EmpPaidDate.Margin = new System.Windows.Forms.Padding(2);
            this.EmpPaidDate.Name = "EmpPaidDate";
            this.EmpPaidDate.Size = new System.Drawing.Size(268, 20);
            this.EmpPaidDate.TabIndex = 107;
            // 
            // EmployeeDetails
            // 
            this.EmployeeDetails.AllowUserToAddRows = false;
            this.EmployeeDetails.AllowUserToDeleteRows = false;
            this.EmployeeDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emp_pay_id,
            this.EmpID,
            this.EmpName,
            this.emp_datePaid,
            this.emp_salary});
            this.EmployeeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeeDetails.Location = new System.Drawing.Point(13, 30);
            this.EmployeeDetails.Name = "EmployeeDetails";
            this.EmployeeDetails.ReadOnly = true;
            this.EmployeeDetails.RowHeadersVisible = false;
            this.EmployeeDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDetails.Size = new System.Drawing.Size(448, 437);
            this.EmployeeDetails.TabIndex = 6;
            this.EmployeeDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeDetails_CellClick_1);
            // 
            // emp_pay_id
            // 
            this.emp_pay_id.HeaderText = "Payment ID";
            this.emp_pay_id.Name = "emp_pay_id";
            this.emp_pay_id.ReadOnly = true;
            // 
            // EmpID
            // 
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // emp_datePaid
            // 
            this.emp_datePaid.HeaderText = "Date Paid";
            this.emp_datePaid.Name = "emp_datePaid";
            this.emp_datePaid.ReadOnly = true;
            // 
            // emp_salary
            // 
            this.emp_salary.HeaderText = "Salary";
            this.emp_salary.Name = "emp_salary";
            this.emp_salary.ReadOnly = true;
            // 
            // empAcceptBtn
            // 
            this.empAcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.empAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empAcceptBtn.Location = new System.Drawing.Point(62, 346);
            this.empAcceptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.empAcceptBtn.Name = "empAcceptBtn";
            this.empAcceptBtn.Size = new System.Drawing.Size(150, 37);
            this.empAcceptBtn.TabIndex = 108;
            this.empAcceptBtn.Text = "Accept";
            this.empAcceptBtn.UseVisualStyleBackColor = true;
            this.empAcceptBtn.Click += new System.EventHandler(this.empAcceptBtn_Click);
            // 
            // employee_payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 512);
            this.Name = "employee_payments";
            this.Text = "employee_payments";
            this.Load += new System.EventHandler(this.employee_payments_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.Label operation;
        private System.Windows.Forms.Label payEmpID;
        private System.Windows.Forms.TextBox EmpIDTxt;
        private System.Windows.Forms.Label payEmpAmt;
        private System.Windows.Forms.TextBox empAmount;
        private System.Windows.Forms.Label EmpPayDate;
        public System.Windows.Forms.DateTimePicker EmpPaidDate;
        public System.Windows.Forms.DataGridView EmployeeDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_pay_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_datePaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_salary;
        public System.Windows.Forms.Button empAcceptBtn;
    }
}