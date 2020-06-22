namespace SchoolManagementSystem
{
    partial class paymentSub_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentSub_window));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.empPay_Btn = new System.Windows.Forms.Button();
            this.std_payBtn = new System.Windows.Forms.Button();
            this.Mainlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(300, 749);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Mainlabel);
            this.panel5.Location = new System.Drawing.Point(0, 49);
            this.panel5.Size = new System.Drawing.Size(300, 700);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.backBtn);
            this.panel4.Size = new System.Drawing.Size(300, 49);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(300, 0);
            this.rightPanel.Size = new System.Drawing.Size(875, 749);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Size = new System.Drawing.Size(875, 717);
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(875, 32);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.empPay_Btn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.std_payBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(42, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // empPay_Btn
            // 
            this.empPay_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.empPay_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.empPay_Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empPay_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.empPay_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empPay_Btn.Location = new System.Drawing.Point(6, 127);
            this.empPay_Btn.Margin = new System.Windows.Forms.Padding(6);
            this.empPay_Btn.Name = "empPay_Btn";
            this.empPay_Btn.Size = new System.Drawing.Size(381, 109);
            this.empPay_Btn.TabIndex = 1;
            this.empPay_Btn.Text = "Employee Payments";
            this.empPay_Btn.UseVisualStyleBackColor = false;
            this.empPay_Btn.Click += new System.EventHandler(this.empPay_Btn_Click);
            // 
            // std_payBtn
            // 
            this.std_payBtn.BackColor = System.Drawing.Color.Cyan;
            this.std_payBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.std_payBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.std_payBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.std_payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_payBtn.Location = new System.Drawing.Point(6, 6);
            this.std_payBtn.Margin = new System.Windows.Forms.Padding(6);
            this.std_payBtn.Name = "std_payBtn";
            this.std_payBtn.Size = new System.Drawing.Size(381, 109);
            this.std_payBtn.TabIndex = 0;
            this.std_payBtn.Text = "Student Payments";
            this.std_payBtn.UseVisualStyleBackColor = false;
            this.std_payBtn.Click += new System.EventHandler(this.std_payBtn_Click);
            // 
            // Mainlabel
            // 
            this.Mainlabel.AutoSize = true;
            this.Mainlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mainlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.Mainlabel.Location = new System.Drawing.Point(53, 216);
            this.Mainlabel.Name = "Mainlabel";
            this.Mainlabel.Size = new System.Drawing.Size(174, 25);
            this.Mainlabel.TabIndex = 34;
            this.Mainlabel.Text = "Payment Types";
            this.Mainlabel.Click += new System.EventHandler(this.Mainlabel_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 717);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 717);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(675, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 717);
            this.panel7.TabIndex = 1;
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(8, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(34, 29);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 0;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Back";
            // 
            // paymentSub_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 749);
            this.Name = "paymentSub_window";
            this.Text = "paymentSub_window";
            this.leftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button std_payBtn;
        private System.Windows.Forms.Button empPay_Btn;
        private System.Windows.Forms.Label Mainlabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Label label1;
    }
}