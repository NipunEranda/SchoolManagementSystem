namespace SchoolManagementSystem
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.smsDataSet = new SchoolManagementSystem.smsDataSet();
            this.ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResultTableAdapter = new SchoolManagementSystem.smsDataSetTableAdapters.ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolManagementSystem.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(793, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // smsDataSet
            // 
            this.smsDataSet.DataSetName = "smsDataSet";
            this.smsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResultBindingSource
            // 
            this.ResultBindingSource.DataMember = "Result";
            this.ResultBindingSource.DataSource = this.smsDataSet;
            // 
            // ResultTableAdapter
            // 
            this.ResultTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ResultBindingSource;
        private smsDataSet smsDataSet;
        private smsDataSetTableAdapters.ResultTableAdapter ResultTableAdapter;
    }
}