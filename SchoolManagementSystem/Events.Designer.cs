namespace SchoolManagementSystem
{
    partial class Events
    {
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
            this.seaBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.repoBtn = new System.Windows.Forms.Button();
            this.ename = new System.Windows.Forms.Label();
            this.enameTxt = new System.Windows.Forms.TextBox();
            this.venue = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.venueTxt = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.EventgroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.EventGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.EventgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // seaBtn
            // 
            this.seaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seaBtn.Location = new System.Drawing.Point(243, 8);
            this.seaBtn.Name = "seaBtn";
            this.seaBtn.Size = new System.Drawing.Size(151, 26);
            this.seaBtn.TabIndex = 0;
            this.seaBtn.Text = "search";
            this.seaBtn.UseVisualStyleBackColor = true;
            this.seaBtn.Click += new System.EventHandler(this.seaBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 8);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 26);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.hideBtn);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MONTH";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(266, 204);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 32);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // hideBtn
            // 
            this.hideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideBtn.Location = new System.Drawing.Point(114, 204);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(70, 32);
            this.hideBtn.TabIndex = 1;
            this.hideBtn.Text = "Hide";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(114, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(6, 142);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(87, 142);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(168, 142);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(249, 142);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // repoBtn
            // 
            this.repoBtn.Location = new System.Drawing.Point(179, 377);
            this.repoBtn.Name = "repoBtn";
            this.repoBtn.Size = new System.Drawing.Size(75, 23);
            this.repoBtn.TabIndex = 7;
            this.repoBtn.Text = "REPORT";
            this.repoBtn.UseVisualStyleBackColor = true;
            // 
            // ename
            // 
            this.ename.AutoSize = true;
            this.ename.Location = new System.Drawing.Point(6, 25);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(65, 13);
            this.ename.TabIndex = 10;
            this.ename.Text = "eventName:";
            // 
            // enameTxt
            // 
            this.enameTxt.Location = new System.Drawing.Point(152, 25);
            this.enameTxt.Name = "enameTxt";
            this.enameTxt.Size = new System.Drawing.Size(200, 20);
            this.enameTxt.TabIndex = 11;
            this.enameTxt.TextChanged += new System.EventHandler(this.enameTxt_TextChanged);
            // 
            // venue
            // 
            this.venue.AutoSize = true;
            this.venue.Location = new System.Drawing.Point(6, 77);
            this.venue.Name = "venue";
            this.venue.Size = new System.Drawing.Size(40, 13);
            this.venue.TabIndex = 14;
            this.venue.Text = "venue:";
            this.venue.Click += new System.EventHandler(this.venue_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(3, 51);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(31, 13);
            this.date.TabIndex = 15;
            this.date.Text = "date:";
            // 
            // venueTxt
            // 
            this.venueTxt.Location = new System.Drawing.Point(152, 77);
            this.venueTxt.Name = "venueTxt";
            this.venueTxt.Size = new System.Drawing.Size(200, 20);
            this.venueTxt.TabIndex = 19;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(8, 103);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(29, 13);
            this.time.TabIndex = 20;
            this.time.Text = "time:";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // EventgroupBox
            // 
            this.EventgroupBox.Controls.Add(this.dateTimePicker2);
            this.EventgroupBox.Controls.Add(this.ename);
            this.EventgroupBox.Controls.Add(this.dateTimePicker1);
            this.EventgroupBox.Controls.Add(this.enameTxt);
            this.EventgroupBox.Controls.Add(this.deleteBtn);
            this.EventgroupBox.Controls.Add(this.date);
            this.EventgroupBox.Controls.Add(this.updateBtn);
            this.EventgroupBox.Controls.Add(this.time);
            this.EventgroupBox.Controls.Add(this.resetBtn);
            this.EventgroupBox.Controls.Add(this.venueTxt);
            this.EventgroupBox.Controls.Add(this.addBtn);
            this.EventgroupBox.Controls.Add(this.venue);
            this.EventgroupBox.Location = new System.Drawing.Point(473, 8);
            this.EventgroupBox.Name = "EventgroupBox";
            this.EventgroupBox.Size = new System.Drawing.Size(352, 171);
            this.EventgroupBox.TabIndex = 24;
            this.EventgroupBox.TabStop = false;
            this.EventgroupBox.Text = "Event_Details";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "Time";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(152, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 24;
            this.dateTimePicker2.Value = new System.DateTime(2019, 8, 12, 3, 39, 0, 0);
            // 
            // EventGridView
            // 
            this.EventGridView.AllowUserToOrderColumns = true;
            this.EventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventGridView.Location = new System.Drawing.Point(473, 211);
            this.EventGridView.Name = "EventGridView";
            this.EventGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EventGridView.Size = new System.Drawing.Size(352, 189);
            this.EventGridView.TabIndex = 25;
            this.EventGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventGridView_CellClick);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.ControlBox = false;
            this.Controls.Add(this.EventGridView);
            this.Controls.Add(this.EventgroupBox);
            this.Controls.Add(this.seaBtn);
            this.Controls.Add(this.repoBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Events";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeftLayout = true;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.EventgroupBox.ResumeLayout(false);
            this.EventgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seaBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button repoBtn;
        private System.Windows.Forms.Label ename;
        private System.Windows.Forms.TextBox enameTxt;
        private System.Windows.Forms.Label venue;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox venueTxt;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox EventgroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView EventGridView;
    }
}