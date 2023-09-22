namespace QLTKB
{
    partial class frmbaocaotkb
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxem = new System.Windows.Forms.Button();
            this.tblTKBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTKBDataSet = new QLTKB.QLTKBDataSet();
            this.tblTKBTableAdapter = new QLTKB.QLTKBDataSetTableAdapters.tblTKBTableAdapter();
            this.txttn = new System.Windows.Forms.DateTimePicker();
            this.txtdn = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tblTKBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTKBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSetTKB";
            reportDataSource2.Value = this.tblTKBBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLTKB.rptTKB.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(805, 468);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(691, 8);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(101, 26);
            this.btnxem.TabIndex = 5;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // tblTKBBindingSource
            // 
            this.tblTKBBindingSource.DataMember = "tblTKB";
            this.tblTKBBindingSource.DataSource = this.QLTKBDataSet;
            // 
            // QLTKBDataSet
            // 
            this.QLTKBDataSet.DataSetName = "QLTKBDataSet";
            this.QLTKBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTKBTableAdapter
            // 
            this.tblTKBTableAdapter.ClearBeforeFill = true;
            // 
            // txttn
            // 
            this.txttn.CustomFormat = "dd/MM/yyyy";
            this.txttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txttn.Location = new System.Drawing.Point(154, 9);
            this.txttn.Name = "txttn";
            this.txttn.Size = new System.Drawing.Size(200, 26);
            this.txttn.TabIndex = 13;
            // 
            // txtdn
            // 
            this.txtdn.CustomFormat = "dd/MM/yyyy";
            this.txtdn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdn.Location = new System.Drawing.Point(465, 9);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(200, 26);
            this.txtdn.TabIndex = 15;
            // 
            // frmbaocaotkb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 513);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.txttn);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmbaocaotkb";
            this.Text = "frmbaocaotkb";
            this.Load += new System.EventHandler(this.frmbaocaotkb_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTKBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTKBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblTKBBindingSource;
        private QLTKBDataSet QLTKBDataSet;
        private QLTKBDataSetTableAdapters.tblTKBTableAdapter tblTKBTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DateTimePicker txttn;
        private System.Windows.Forms.DateTimePicker txtdn;
    }
}