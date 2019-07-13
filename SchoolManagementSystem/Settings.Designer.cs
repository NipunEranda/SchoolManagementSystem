namespace SchoolManagementSystem
{
    partial class Settings
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
            this.dataSourceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataBaseTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.integratedCheck = new System.Windows.Forms.CheckBox();
            this.settingSaveBtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(244, 450);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.settingSaveBtn);
            this.panel5.Controls.Add(this.integratedCheck);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.passwordTxt);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.userNameTxt);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dataBaseTxt);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dataSourceTxt);
            this.panel5.Size = new System.Drawing.Size(244, 418);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(556, 450);
            // 
            // panel6
            // 
            this.panel6.Size = new System.Drawing.Size(556, 418);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(556, 32);
            // 
            // dataSourceTxt
            // 
            this.dataSourceTxt.Location = new System.Drawing.Point(15, 73);
            this.dataSourceTxt.Name = "dataSourceTxt";
            this.dataSourceTxt.Size = new System.Drawing.Size(213, 20);
            this.dataSourceTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database";
            // 
            // dataBaseTxt
            // 
            this.dataBaseTxt.Location = new System.Drawing.Point(15, 115);
            this.dataBaseTxt.Name = "dataBaseTxt";
            this.dataBaseTxt.Size = new System.Drawing.Size(213, 20);
            this.dataBaseTxt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(15, 159);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(213, 20);
            this.userNameTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(15, 204);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(213, 20);
            this.passwordTxt.TabIndex = 6;
            // 
            // integratedCheck
            // 
            this.integratedCheck.AutoSize = true;
            this.integratedCheck.ForeColor = System.Drawing.Color.White;
            this.integratedCheck.Location = new System.Drawing.Point(15, 231);
            this.integratedCheck.Name = "integratedCheck";
            this.integratedCheck.Size = new System.Drawing.Size(115, 17);
            this.integratedCheck.TabIndex = 8;
            this.integratedCheck.Text = "Integrated Security";
            this.integratedCheck.UseVisualStyleBackColor = true;
            this.integratedCheck.CheckedChanged += new System.EventHandler(this.integratedCheck_CheckedChanged);
            // 
            // settingSaveBtn
            // 
            this.settingSaveBtn.Location = new System.Drawing.Point(15, 254);
            this.settingSaveBtn.Name = "settingSaveBtn";
            this.settingSaveBtn.Size = new System.Drawing.Size(213, 41);
            this.settingSaveBtn.TabIndex = 9;
            this.settingSaveBtn.Text = "Save";
            this.settingSaveBtn.UseVisualStyleBackColor = true;
            this.settingSaveBtn.Click += new System.EventHandler(this.SettingSaveBtn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = true;
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dataSourceTxt;
        private System.Windows.Forms.Button settingSaveBtn;
        private System.Windows.Forms.CheckBox integratedCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dataBaseTxt;
        private System.Windows.Forms.Label label2;
    }
}