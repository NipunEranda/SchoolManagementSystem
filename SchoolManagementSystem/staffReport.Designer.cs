namespace SchoolManagementSystem
{
    partial class staffReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffReport));
            this.staffLoadBtn = new System.Windows.Forms.Button();
            this.staffReportpanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staffCrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sReportBack = new System.Windows.Forms.Label();
            this.backBtnSreport = new System.Windows.Forms.PictureBox();
            this.staffReportpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtnSreport)).BeginInit();
            this.SuspendLayout();
            // 
            // staffLoadBtn
            // 
            this.staffLoadBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.staffLoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.980198F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLoadBtn.Location = new System.Drawing.Point(835, 0);
            this.staffLoadBtn.Name = "staffLoadBtn";
            this.staffLoadBtn.Size = new System.Drawing.Size(123, 38);
            this.staffLoadBtn.TabIndex = 0;
            this.staffLoadBtn.Text = "Generate Report";
            this.staffLoadBtn.UseVisualStyleBackColor = true;
            this.staffLoadBtn.Click += new System.EventHandler(this.staffLoadBtn_Click);
            // 
            // staffReportpanel
            // 
            this.staffReportpanel.Controls.Add(this.panel2);
            this.staffReportpanel.Controls.Add(this.panel1);
            this.staffReportpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffReportpanel.Location = new System.Drawing.Point(0, 0);
            this.staffReportpanel.Name = "staffReportpanel";
            this.staffReportpanel.Size = new System.Drawing.Size(958, 537);
            this.staffReportpanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.staffCrystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 499);
            this.panel2.TabIndex = 3;
            // 
            // staffCrystalReportViewer1
            // 
            this.staffCrystalReportViewer1.ActiveViewIndex = -1;
            this.staffCrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffCrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.staffCrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffCrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.staffCrystalReportViewer1.Name = "staffCrystalReportViewer1";
            this.staffCrystalReportViewer1.Size = new System.Drawing.Size(958, 499);
            this.staffCrystalReportViewer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sReportBack);
            this.panel1.Controls.Add(this.backBtnSreport);
            this.panel1.Controls.Add(this.staffLoadBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 38);
            this.panel1.TabIndex = 2;
            // 
            // sReportBack
            // 
            this.sReportBack.AutoSize = true;
            this.sReportBack.Location = new System.Drawing.Point(54, 13);
            this.sReportBack.Name = "sReportBack";
            this.sReportBack.Size = new System.Drawing.Size(32, 13);
            this.sReportBack.TabIndex = 2;
            this.sReportBack.Text = "Back";
            // 
            // backBtnSreport
            // 
            this.backBtnSreport.Image = ((System.Drawing.Image)(resources.GetObject("backBtnSreport.Image")));
            this.backBtnSreport.Location = new System.Drawing.Point(12, 3);
            this.backBtnSreport.Name = "backBtnSreport";
            this.backBtnSreport.Size = new System.Drawing.Size(35, 28);
            this.backBtnSreport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtnSreport.TabIndex = 1;
            this.backBtnSreport.TabStop = false;
            this.backBtnSreport.Click += new System.EventHandler(this.backBtnSreport_Click);
            // 
            // staffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 537);
            this.ControlBox = false;
            this.Controls.Add(this.staffReportpanel);
            this.Name = "staffReport";
            this.Text = "staffReport";
            this.Load += new System.EventHandler(this.staffReport_Load);
            this.staffReportpanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtnSreport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staffLoadBtn;
        private System.Windows.Forms.Panel staffReportpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backBtnSreport;
        private System.Windows.Forms.Label sReportBack;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer staffCrystalReportViewer1;
    }
}