namespace SchoolManagementSystem
{
    partial class checkAvailability
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
            this.lblMain = new System.Windows.Forms.Label();
            this.BookNameNull = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.bookName = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Size = new System.Drawing.Size(413, 559);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(413, 39);
            // 
            // rightpanel
            // 
            this.rightpanel.Location = new System.Drawing.Point(413, 0);
            this.rightpanel.Size = new System.Drawing.Size(778, 559);
            // 
            // panel4
            // 
            this.panel4.Size = new System.Drawing.Size(778, 39);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(413, 520);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bookName);
            this.panel5.Controls.Add(this.btnCheck);
            this.panel5.Controls.Add(this.BookNameNull);
            this.panel5.Controls.Add(this.lblBookName);
            this.panel5.Controls.Add(this.txtBookName);
            this.panel5.Controls.Add(this.lblMain);
            this.panel5.Size = new System.Drawing.Size(778, 520);
            this.panel5.Controls.SetChildIndex(this.panel1, 0);
            this.panel5.Controls.SetChildIndex(this.lblMain, 0);
            this.panel5.Controls.SetChildIndex(this.txtBookName, 0);
            this.panel5.Controls.SetChildIndex(this.lblBookName, 0);
            this.panel5.Controls.SetChildIndex(this.BookNameNull, 0);
            this.panel5.Controls.SetChildIndex(this.btnCheck, 0);
            this.panel5.Controls.SetChildIndex(this.bookName, 0);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(556, 0);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.Black;
            this.lblMain.Location = new System.Drawing.Point(58, 67);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(450, 32);
            this.lblMain.TabIndex = 111;
            this.lblMain.Text = "Check Available Books Quantity";
            // 
            // BookNameNull
            // 
            this.BookNameNull.AutoSize = true;
            this.BookNameNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameNull.ForeColor = System.Drawing.Color.Black;
            this.BookNameNull.Location = new System.Drawing.Point(325, 177);
            this.BookNameNull.Name = "BookNameNull";
            this.BookNameNull.Size = new System.Drawing.Size(23, 29);
            this.BookNameNull.TabIndex = 114;
            this.BookNameNull.Text = "*";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.ForeColor = System.Drawing.Color.Black;
            this.lblBookName.Location = new System.Drawing.Point(140, 177);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(140, 29);
            this.lblBookName.TabIndex = 112;
            this.lblBookName.Text = "Book Name";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.Location = new System.Drawing.Point(141, 210);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(207, 22);
            this.txtBookName.TabIndex = 113;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(145, 400);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(207, 45);
            this.btnCheck.TabIndex = 121;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // bookName
            // 
            this.bookName.BackColor = System.Drawing.Color.White;
            this.bookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.ForeColor = System.Drawing.Color.Black;
            this.bookName.Location = new System.Drawing.Point(145, 307);
            this.bookName.Name = "bookName";
            this.bookName.Size = new System.Drawing.Size(207, 30);
            this.bookName.TabIndex = 135;
            // 
            // checkAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 559);
            this.Name = "checkAvailability";
            this.Text = "checkAvailability";
            this.Load += new System.EventHandler(this.checkAvailability_Load);
            this.leftpanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.rightpanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblMain;
        public System.Windows.Forms.Label BookNameNull;
        public System.Windows.Forms.Label lblBookName;
        public System.Windows.Forms.TextBox txtBookName;
        public System.Windows.Forms.Button btnCheck;
        public System.Windows.Forms.Label bookName;
    }
}