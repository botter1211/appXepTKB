namespace QLTKB
{
    partial class frmbaocaomh
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
            this.QLTKB1 = new QLTKB.QLTKB1();
            this.tblMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMonHocTableAdapter = new QLTKB.QLTKB1TableAdapters.tblMonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLTKB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetMonHoc";
            reportDataSource1.Value = this.tblMonHocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTKB.rptMonhoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 533);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLTKB1
            // 
            this.QLTKB1.DataSetName = "QLTKB1";
            this.QLTKB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMonHocBindingSource
            // 
            this.tblMonHocBindingSource.DataMember = "tblMonHoc";
            this.tblMonHocBindingSource.DataSource = this.QLTKB1;
            // 
            // tblMonHocTableAdapter
            // 
            this.tblMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmbaocaomh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmbaocaomh";
            this.Text = "Báo cáo môn học";
            this.Load += new System.EventHandler(this.frmbaocaomh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLTKB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource;
        private QLTKB1 QLTKB1;
        private QLTKB1TableAdapters.tblMonHocTableAdapter tblMonHocTableAdapter;
    }
}