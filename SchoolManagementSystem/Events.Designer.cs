namespace SchoolManagementSystem
{
    partial class Events
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
            this.ename = new System.Windows.Forms.Label();
            this.enameTxt = new System.Windows.Forms.TextBox();
            this.edate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.evenue = new System.Windows.Forms.Label();
            this.evenueTxt = new System.Windows.Forms.TextBox();
            this.etime = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.eventGridView = new System.Windows.Forms.DataGridView();
            this.eventIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edateGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evenueGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eId = new System.Windows.Forms.Label();
            this.eIdTxt = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthlyCalendarGB = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).BeginInit();
            this.monthlyCalendarGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(875, 729);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eventGridView);
            this.groupBox1.Size = new System.Drawing.Size(875, 729);
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Controls.SetChildIndex(this.panel2, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel8, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel9, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel10, 0);
            this.groupBox1.Controls.SetChildIndex(this.panel11, 0);
            this.groupBox1.Controls.SetChildIndex(this.eventGridView, 0);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 11);
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
            // panel12
            // 
            this.panel12.Location = new System.Drawing.Point(0, 660);
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
            this.panel5.Controls.Add(this.eIdTxt);
            this.panel5.Controls.Add(this.monthlyCalendarGB);
            this.panel5.Controls.Add(this.eId);
            this.panel5.Controls.Add(this.dateTimePicker2);
            this.panel5.Controls.Add(this.etime);
            this.panel5.Controls.Add(this.evenueTxt);
            this.panel5.Controls.Add(this.evenue);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.edate);
            this.panel5.Controls.Add(this.enameTxt);
            this.panel5.Controls.Add(this.ename);
            this.panel5.Size = new System.Drawing.Size(300, 712);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(300, 49);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(300, 0);
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
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ename.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ename.Location = new System.Drawing.Point(16, 108);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(82, 16);
            this.ename.TabIndex = 1;
            this.ename.Text = "Event Name";
            this.ename.Click += new System.EventHandler(this.ename_Click);
            // 
            // enameTxt
            // 
            this.enameTxt.Location = new System.Drawing.Point(19, 127);
            this.enameTxt.Name = "enameTxt";
            this.enameTxt.Size = new System.Drawing.Size(200, 20);
            this.enameTxt.TabIndex = 2;
            // 
            // edate
            // 
            this.edate.AutoSize = true;
            this.edate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.edate.Location = new System.Drawing.Point(16, 150);
            this.edate.Name = "edate";
            this.edate.Size = new System.Drawing.Size(37, 16);
            this.edate.TabIndex = 3;
            this.edate.Text = "Date";
            this.edate.Click += new System.EventHandler(this.edate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // evenue
            // 
            this.evenue.AutoSize = true;
            this.evenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evenue.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.evenue.Location = new System.Drawing.Point(16, 192);
            this.evenue.Name = "evenue";
            this.evenue.Size = new System.Drawing.Size(47, 16);
            this.evenue.TabIndex = 5;
            this.evenue.Text = "Venue";
            this.evenue.Click += new System.EventHandler(this.evenue_Click);
            // 
            // evenueTxt
            // 
            this.evenueTxt.Location = new System.Drawing.Point(19, 211);
            this.evenueTxt.Name = "evenueTxt";
            this.evenueTxt.Size = new System.Drawing.Size(200, 20);
            this.evenueTxt.TabIndex = 6;
            // 
            // etime
            // 
            this.etime.AutoSize = true;
            this.etime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etime.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.etime.Location = new System.Drawing.Point(16, 234);
            this.etime.Name = "etime";
            this.etime.Size = new System.Drawing.Size(39, 16);
            this.etime.TabIndex = 7;
            this.etime.Text = "Time";
            this.etime.Click += new System.EventHandler(this.etime_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(19, 253);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // eventGridView
            // 
            this.eventGridView.AllowUserToAddRows = false;
            this.eventGridView.AllowUserToDeleteRows = false;
            this.eventGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventGridView.BackgroundColor = System.Drawing.Color.White;
            this.eventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventIDGV,
            this.eventNameGV,
            this.edateGv,
            this.evenueGV,
            this.etimeGV});
            this.eventGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventGridView.Location = new System.Drawing.Point(13, 30);
            this.eventGridView.Name = "eventGridView";
            this.eventGridView.ReadOnly = true;
            this.eventGridView.RowHeadersVisible = false;
            this.eventGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGridView.Size = new System.Drawing.Size(676, 686);
            this.eventGridView.TabIndex = 5;
            this.eventGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGridView_CellContentClick);
            // 
            // eventIDGV
            // 
            this.eventIDGV.FillWeight = 83.59366F;
            this.eventIDGV.HeaderText = "eventID";
            this.eventIDGV.Name = "eventIDGV";
            this.eventIDGV.ReadOnly = true;
            // 
            // eventNameGV
            // 
            this.eventNameGV.FillWeight = 94.71403F;
            this.eventNameGV.HeaderText = "eventName";
            this.eventNameGV.Name = "eventNameGV";
            this.eventNameGV.ReadOnly = true;
            // 
            // edateGv
            // 
            this.edateGv.FillWeight = 107.6985F;
            this.edateGv.HeaderText = "date";
            this.edateGv.Name = "edateGv";
            this.edateGv.ReadOnly = true;
            // 
            // evenueGV
            // 
            this.evenueGV.FillWeight = 122.5285F;
            this.evenueGV.HeaderText = "venue";
            this.evenueGV.Name = "evenueGV";
            this.evenueGV.ReadOnly = true;
            // 
            // etimeGV
            // 
            this.etimeGV.FillWeight = 138.9574F;
            this.etimeGV.HeaderText = "time";
            this.etimeGV.Name = "etimeGV";
            this.etimeGV.ReadOnly = true;
            // 
            // eId
            // 
            this.eId.AutoSize = true;
            this.eId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eId.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.eId.Location = new System.Drawing.Point(16, 64);
            this.eId.Name = "eId";
            this.eId.Size = new System.Drawing.Size(56, 16);
            this.eId.TabIndex = 10;
            this.eId.Text = "Event Id";
            // 
            // eIdTxt
            // 
            this.eIdTxt.Location = new System.Drawing.Point(19, 84);
            this.eIdTxt.Name = "eIdTxt";
            this.eIdTxt.Size = new System.Drawing.Size(200, 20);
            this.eIdTxt.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(21, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // monthlyCalendarGB
            // 
            this.monthlyCalendarGB.Controls.Add(this.monthCalendar1);
            this.monthlyCalendarGB.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthlyCalendarGB.Location = new System.Drawing.Point(19, 293);
            this.monthlyCalendarGB.Name = "monthlyCalendarGB";
            this.monthlyCalendarGB.Size = new System.Drawing.Size(260, 203);
            this.monthlyCalendarGB.TabIndex = 6;
            this.monthlyCalendarGB.TabStop = false;
            this.monthlyCalendarGB.Text = "MONTHLY CALENDAR";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 761);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Event_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.eventGridView)).EndInit();
            this.monthlyCalendarGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ename;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label etime;
        private System.Windows.Forms.TextBox evenueTxt;
        private System.Windows.Forms.Label evenue;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label edate;
        private System.Windows.Forms.TextBox enameTxt;
        private System.Windows.Forms.DataGridView eventGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn edateGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn evenueGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn etimeGV;
        private System.Windows.Forms.TextBox eIdTxt;
        private System.Windows.Forms.Label eId;
        private System.Windows.Forms.GroupBox monthlyCalendarGB;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}