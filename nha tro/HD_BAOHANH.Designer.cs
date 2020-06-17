namespace nha_tro
{
    partial class HD_BAOHANH
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
            this.hd_baohanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hd_baohanhTableAdapter = new nha_tro.ttTableAdapters.hd_baohanhTableAdapter();
            this.THONGKE_LOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THONGKE_LOAISPTableAdapter = new nha_tro.ttTableAdapters.THONGKE_LOAISPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hd_baohanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGKE_LOAISPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hd_baohanhBindingSource
            // 
            this.hd_baohanhBindingSource.DataMember = "hd_baohanh";
            this.hd_baohanhBindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "hoadon_baohanh";
            reportDataSource1.Value = this.hd_baohanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report2_baohanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(640, 417);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // hd_baohanhTableAdapter
            // 
            this.hd_baohanhTableAdapter.ClearBeforeFill = true;
            // 
            // THONGKE_LOAISPBindingSource
            // 
            this.THONGKE_LOAISPBindingSource.DataMember = "THONGKE_LOAISP";
            this.THONGKE_LOAISPBindingSource.DataSource = this.tt;
            // 
            // THONGKE_LOAISPTableAdapter
            // 
            this.THONGKE_LOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // HD_BAOHANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 417);
            this.Controls.Add(this.reportViewer1);
            this.Name = "HD_BAOHANH";
            this.Text = "HD_BAOHANH";
            this.Load += new System.EventHandler(this.HD_BAOHANH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hd_baohanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGKE_LOAISPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tt tt;
        private System.Windows.Forms.BindingSource hd_baohanhBindingSource;
        private ttTableAdapters.hd_baohanhTableAdapter hd_baohanhTableAdapter;
        private System.Windows.Forms.BindingSource THONGKE_LOAISPBindingSource;
        private ttTableAdapters.THONGKE_LOAISPTableAdapter THONGKE_LOAISPTableAdapter;
    }
}