namespace DoAnThucTap
{
    partial class FormReportHDX
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetHDX = new DoAnThucTap.DataSetHDX();
            this.selectReportXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectReportXuatTableAdapter = new DoAnThucTap.DataSetHDXTableAdapters.selectReportXuatTableAdapter();
            this.selectReportTongTienXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectReportTongTienXuatTableAdapter = new DoAnThucTap.DataSetHDXTableAdapters.selectReportTongTienXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectReportXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectReportTongTienXuatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectReportXuatBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.selectReportTongTienXuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnThucTap.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetHDX
            // 
            this.DataSetHDX.DataSetName = "DataSetHDX";
            this.DataSetHDX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectReportXuatBindingSource
            // 
            this.selectReportXuatBindingSource.DataMember = "selectReportXuat";
            this.selectReportXuatBindingSource.DataSource = this.DataSetHDX;
            // 
            // selectReportXuatTableAdapter
            // 
            this.selectReportXuatTableAdapter.ClearBeforeFill = true;
            // 
            // selectReportTongTienXuatBindingSource
            // 
            this.selectReportTongTienXuatBindingSource.DataMember = "selectReportTongTienXuat";
            this.selectReportTongTienXuatBindingSource.DataSource = this.DataSetHDX;
            // 
            // selectReportTongTienXuatTableAdapter
            // 
            this.selectReportTongTienXuatTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportHDX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportHDX";
            this.Text = "FormReportHDX";
            this.Load += new System.EventHandler(this.FormReportHDX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectReportXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectReportTongTienXuatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectReportXuatBindingSource;
        private DataSetHDX DataSetHDX;
        private System.Windows.Forms.BindingSource selectReportTongTienXuatBindingSource;
        private DataSetHDXTableAdapters.selectReportXuatTableAdapter selectReportXuatTableAdapter;
        private DataSetHDXTableAdapters.selectReportTongTienXuatTableAdapter selectReportTongTienXuatTableAdapter;
    }
}