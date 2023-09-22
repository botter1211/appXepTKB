namespace QLTKB
{
    partial class frmbaocaok
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
            this.QLTKBDataSet = new QLTKB.QLTKBDataSet();
            this.tblKhoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblKhoaTableAdapter = new QLTKB.QLTKBDataSetTableAdapters.tblKhoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLTKBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetKhoa";
            reportDataSource1.Value = this.tblKhoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTKB.rptKhoa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(746, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLTKBDataSet
            // 
            this.QLTKBDataSet.DataSetName = "QLTKBDataSet";
            this.QLTKBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblKhoaBindingSource
            // 
            this.tblKhoaBindingSource.DataMember = "tblKhoa";
            this.tblKhoaBindingSource.DataSource = this.QLTKBDataSet;
            // 
            // tblKhoaTableAdapter
            // 
            this.tblKhoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmbaocaok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 497);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmbaocaok";
            this.Text = "Báo cáo khoa";
            this.Load += new System.EventHandler(this.frmbaocaok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLTKBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKhoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblKhoaBindingSource;
        private QLTKBDataSet QLTKBDataSet;
        private QLTKBDataSetTableAdapters.tblKhoaTableAdapter tblKhoaTableAdapter;
    }
}