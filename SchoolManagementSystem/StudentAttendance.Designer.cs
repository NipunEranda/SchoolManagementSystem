namespace SchoolManagementSystem
{
    partial class StudentAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.selectDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.selectClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectGrade = new System.Windows.Forms.ComboBox();
            this.studentAttendanceGridView = new System.Windows.Forms.DataGridView();
            this.actionBtn = new System.Windows.Forms.Button();
            this.operationLabel = new System.Windows.Forms.Label();
            this.attendDate = new System.Windows.Forms.DateTimePicker();
            this.dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.firstNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentAttendanceGridView);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.studentAttendanceGridView, 0);
            // 
            // backBtn
            // 
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.attendDate);
            this.panel5.Controls.Add(this.operationLabel);
            this.panel5.Controls.Add(this.actionBtn);
            this.panel5.Controls.Add(this.selectGrade);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.selectClass);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.selectDate);
            // 
            // selectDate
            // 
            this.selectDate.AutoSize = true;
            this.selectDate.ForeColor = System.Drawing.Color.White;
            this.selectDate.Location = new System.Drawing.Point(9, 59);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(63, 13);
            this.selectDate.TabIndex = 0;
            this.selectDate.Text = "Select Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Grade";
            // 
            // selectClass
            // 
            this.selectClass.FormattingEnabled = true;
            this.selectClass.Location = new System.Drawing.Point(12, 174);
            this.selectClass.Name = "selectClass";
            this.selectClass.Size = new System.Drawing.Size(323, 21);
            this.selectClass.TabIndex = 4;
            this.selectClass.SelectedIndexChanged += new System.EventHandler(this.selectClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Class";
            // 
            // selectGrade
            // 
            this.selectGrade.FormattingEnabled = true;
            this.selectGrade.Location = new System.Drawing.Point(12, 123);
            this.selectGrade.Name = "selectGrade";
            this.selectGrade.Size = new System.Drawing.Size(323, 21);
            this.selectGrade.TabIndex = 6;
            this.selectGrade.SelectedIndexChanged += new System.EventHandler(this.selectGrade_SelectedIndexChanged);
            // 
            // studentAttendanceGridView
            // 
            this.studentAttendanceGridView.AllowUserToAddRows = false;
            this.studentAttendanceGridView.AllowUserToDeleteRows = false;
            this.studentAttendanceGridView.AllowUserToResizeRows = false;
            this.studentAttendanceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentAttendanceGridView.BackgroundColor = System.Drawing.Color.White;
            this.studentAttendanceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentAttendanceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentAttendanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentAttendanceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateGV,
            this.sidGV,
            this.statusGV,
            this.firstNameGV,
            this.gradeGV,
            this.classGV});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.studentAttendanceGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.studentAttendanceGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentAttendanceGridView.Location = new System.Drawing.Point(13, 30);
            this.studentAttendanceGridView.MultiSelect = false;
            this.studentAttendanceGridView.Name = "studentAttendanceGridView";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentAttendanceGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.studentAttendanceGridView.RowHeadersVisible = false;
            this.studentAttendanceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentAttendanceGridView.Size = new System.Drawing.Size(448, 437);
            this.studentAttendanceGridView.TabIndex = 6;
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(192, 212);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(143, 35);
            this.actionBtn.TabIndex = 7;
            this.actionBtn.Text = "View All";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.BackColor = System.Drawing.Color.Transparent;
            this.operationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.ForeColor = System.Drawing.Color.White;
            this.operationLabel.Location = new System.Drawing.Point(12, 13);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(58, 24);
            this.operationLabel.TabIndex = 8;
            this.operationLabel.Text = "VIEW";
            // 
            // attendDate
            // 
            this.attendDate.Location = new System.Drawing.Point(12, 76);
            this.attendDate.Name = "attendDate";
            this.attendDate.Size = new System.Drawing.Size(323, 20);
            this.attendDate.TabIndex = 9;
            this.attendDate.ValueChanged += new System.EventHandler(this.attendDate_ValueChanged_1);
            // 
            // dateGV
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateGV.HeaderText = "Date";
            this.dateGV.Name = "dateGV";
            this.dateGV.ReadOnly = true;
            // 
            // sidGV
            // 
            this.sidGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sidGV.DataPropertyName = "sid";
            this.sidGV.HeaderText = "SID";
            this.sidGV.Name = "sidGV";
            this.sidGV.ReadOnly = true;
            this.sidGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sidGV.Width = 50;
            // 
            // statusGV
            // 
            this.statusGV.DataPropertyName = "status";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.statusGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.statusGV.HeaderText = "Status";
            this.statusGV.Items.AddRange(new object[] {
            "",
            "Present",
            "Absent"});
            this.statusGV.Name = "statusGV";
            this.statusGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // firstNameGV
            // 
            this.firstNameGV.DataPropertyName = "firstName";
            this.firstNameGV.HeaderText = "Firstname";
            this.firstNameGV.Name = "firstNameGV";
            this.firstNameGV.ReadOnly = true;
            this.firstNameGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gradeGV
            // 
            this.gradeGV.HeaderText = "Grade";
            this.gradeGV.Name = "gradeGV";
            this.gradeGV.ReadOnly = true;
            // 
            // classGV
            // 
            this.classGV.HeaderText = "Class";
            this.classGV.Name = "classGV";
            this.classGV.ReadOnly = true;
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 512);
            this.Name = "StudentAttendance";
            this.Text = "StudentAttendance";
            this.Load += new System.EventHandler(this.StudentAttendance_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentAttendanceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectDate;
        private System.Windows.Forms.ComboBox selectGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectClass;
        private System.Windows.Forms.DataGridView studentAttendanceGridView;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.DateTimePicker attendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn classGV;
    }
}