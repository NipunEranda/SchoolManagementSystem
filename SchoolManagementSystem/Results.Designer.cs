namespace SchoolManagementSystem
{
    partial class Results
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.Label();
            this.subid = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.Label();
            this.textsid = new System.Windows.Forms.TextBox();
            this.textsubid = new System.Windows.Forms.TextBox();
            this.textmark = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(323, 300);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(75, 23);
            this.btnCansel.TabIndex = 2;
            this.btnCansel.Text = "Reset";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResult.BackgroundColor = System.Drawing.Color.White;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(519, 82);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(625, 427);
            this.dgvResult.TabIndex = 3;
            this.dgvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellClick);
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.ForeColor = System.Drawing.Color.White;
            this.sid.Location = new System.Drawing.Point(129, 123);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(58, 13);
            this.sid.TabIndex = 4;
            this.sid.Text = "Student ID";
            // 
            // subid
            // 
            this.subid.AutoSize = true;
            this.subid.ForeColor = System.Drawing.Color.White;
            this.subid.Location = new System.Drawing.Point(129, 168);
            this.subid.Name = "subid";
            this.subid.Size = new System.Drawing.Size(43, 13);
            this.subid.TabIndex = 5;
            this.subid.Text = "Subject";
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.ForeColor = System.Drawing.Color.White;
            this.mark.Location = new System.Drawing.Point(129, 211);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(31, 13);
            this.mark.TabIndex = 6;
            this.mark.Text = "Mark";
            // 
            // textsid
            // 
            this.textsid.Location = new System.Drawing.Point(255, 120);
            this.textsid.Name = "textsid";
            this.textsid.Size = new System.Drawing.Size(100, 20);
            this.textsid.TabIndex = 7;
            // 
            // textsubid
            // 
            this.textsubid.Location = new System.Drawing.Point(255, 165);
            this.textsubid.Name = "textsubid";
            this.textsubid.Size = new System.Drawing.Size(100, 20);
            this.textsubid.TabIndex = 8;
            // 
            // textmark
            // 
            this.textmark.Location = new System.Drawing.Point(255, 208);
            this.textmark.Name = "textmark";
            this.textmark.Size = new System.Drawing.Size(100, 20);
            this.textmark.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(939, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Student ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(594, 35);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(304, 20);
            this.textSearch.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(159, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(240, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(183, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Results Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1156, 521);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textmark);
            this.Controls.Add(this.textsubid);
            this.Controls.Add(this.textsid);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.subid);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnSave);
            this.Name = "Results";
            this.Text = "$safeprojectname$";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Label subid;
        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.TextBox textsid;
        private System.Windows.Forms.TextBox textsubid;
        private System.Windows.Forms.TextBox textmark;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}

