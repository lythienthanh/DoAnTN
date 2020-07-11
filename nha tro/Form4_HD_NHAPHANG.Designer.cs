namespace nha_tro
{
    partial class Form4_HD_NHAPHANG
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
            this.NghiepVu = new nha_tro.NghiepVu();
            this.XUAT_HD_NHAPHANG_SPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.XUAT_HD_NHAPHANG_SPTableAdapter = new nha_tro.NghiepVuTableAdapters.XUAT_HD_NHAPHANG_SPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUAT_HD_NHAPHANG_SPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.XUAT_HD_NHAPHANG_SPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report5_HD_NHAPHANG.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // NghiepVu
            // 
            this.NghiepVu.DataSetName = "NghiepVu";
            this.NghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // XUAT_HD_NHAPHANG_SPBindingSource
            // 
            this.XUAT_HD_NHAPHANG_SPBindingSource.DataMember = "XUAT_HD_NHAPHANG_SP";
            this.XUAT_HD_NHAPHANG_SPBindingSource.DataSource = this.NghiepVu;
            // 
            // XUAT_HD_NHAPHANG_SPTableAdapter
            // 
            this.XUAT_HD_NHAPHANG_SPTableAdapter.ClearBeforeFill = true;
            // 
            // Form4_HD_NHAPHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4_HD_NHAPHANG";
            this.Text = "Form4_HD_NHAPHANG";
            this.Load += new System.EventHandler(this.Form4_HD_NHAPHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XUAT_HD_NHAPHANG_SPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource XUAT_HD_NHAPHANG_SPBindingSource;
        private NghiepVu NghiepVu;
        private NghiepVuTableAdapters.XUAT_HD_NHAPHANG_SPTableAdapter XUAT_HD_NHAPHANG_SPTableAdapter;
    }
}