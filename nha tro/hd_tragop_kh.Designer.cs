namespace nha_tro
{
    partial class hd_tragop_kh
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
            this.tt = new nha_tro.tt();
            this.hoa_tragop_khBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoa_tragop_khTableAdapter = new nha_tro.ttTableAdapters.hoa_tragop_khTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoa_tragop_khBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HD_TRAGOP_KHACHHANG";
            reportDataSource1.Value = this.hoa_tragop_khBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report_hd_tragop_kh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(889, 474);
            this.reportViewer1.TabIndex = 0;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoa_tragop_khBindingSource
            // 
            this.hoa_tragop_khBindingSource.DataMember = "hoa_tragop_kh";
            this.hoa_tragop_khBindingSource.DataSource = this.tt;
            // 
            // hoa_tragop_khTableAdapter
            // 
            this.hoa_tragop_khTableAdapter.ClearBeforeFill = true;
            // 
            // hd_tragop_kh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 474);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hd_tragop_kh";
            this.Text = "hd_tragop_kh";
            this.Load += new System.EventHandler(this.hd_tragop_kh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoa_tragop_khBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hoa_tragop_khBindingSource;
        private tt tt;
        private ttTableAdapters.hoa_tragop_khTableAdapter hoa_tragop_khTableAdapter;
    }
}