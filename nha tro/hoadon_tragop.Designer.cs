namespace nha_tro
{
    partial class hoadon_tragop
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
            this.NghiepVu = new nha_tro.NghiepVu();
            this.ct_mua_sp_lkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_mua_sp_lkTableAdapter = new nha_tro.NghiepVuTableAdapters.ct_mua_sp_lkTableAdapter();
            this.tt = new nha_tro.tt();
            this.TraGop1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TraGop1TableAdapter = new nha_tro.ttTableAdapters.TraGop1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_mua_sp_lkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraGop1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ct_mua_sp_lkBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TraGop1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report5_hd_tragop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(236, 124);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // NghiepVu
            // 
            this.NghiepVu.DataSetName = "NghiepVu";
            this.NghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ct_mua_sp_lkBindingSource
            // 
            this.ct_mua_sp_lkBindingSource.DataMember = "ct_mua_sp_lk";
            this.ct_mua_sp_lkBindingSource.DataSource = this.NghiepVu;
            // 
            // ct_mua_sp_lkTableAdapter
            // 
            this.ct_mua_sp_lkTableAdapter.ClearBeforeFill = true;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TraGop1BindingSource
            // 
            this.TraGop1BindingSource.DataMember = "TraGop1";
            this.TraGop1BindingSource.DataSource = this.tt;
            // 
            // TraGop1TableAdapter
            // 
            this.TraGop1TableAdapter.ClearBeforeFill = true;
            // 
            // hoadon_tragop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hoadon_tragop";
            this.Text = "hoadon_tragop";
            this.Load += new System.EventHandler(this.hoadon_tragop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_mua_sp_lkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TraGop1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ct_mua_sp_lkBindingSource;
        private NghiepVu NghiepVu;
        private System.Windows.Forms.BindingSource TraGop1BindingSource;
        private tt tt;
        private NghiepVuTableAdapters.ct_mua_sp_lkTableAdapter ct_mua_sp_lkTableAdapter;
        private ttTableAdapters.TraGop1TableAdapter TraGop1TableAdapter;
    }
}