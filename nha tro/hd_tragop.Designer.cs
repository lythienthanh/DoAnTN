namespace nha_tro
{
    partial class hd_tragop
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
            this.TraGop1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TraGop1TableAdapter = new nha_tro.ttTableAdapters.TraGop1TableAdapter();
            this.nghiepVu = new nha_tro.NghiepVu();
            this.ct_mua_sp_lkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_mua_sp_lkTableAdapter = new nha_tro.NghiepVuTableAdapters.ct_mua_sp_lkTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.TraGop1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_mua_sp_lkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TraGop1BindingSource
            // 
            this.TraGop1BindingSource.DataMember = "TraGop1";
            this.TraGop1BindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "hdtragop";
            reportDataSource1.Value = this.TraGop1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(576, 452);
            this.reportViewer1.TabIndex = 0;
            // 
            // TraGop1TableAdapter
            // 
            this.TraGop1TableAdapter.ClearBeforeFill = true;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ct_mua_sp_lkBindingSource
            // 
            this.ct_mua_sp_lkBindingSource.DataMember = "ct_mua_sp_lk";
            this.ct_mua_sp_lkBindingSource.DataSource = this.nghiepVu;
            // 
            // ct_mua_sp_lkTableAdapter
            // 
            this.ct_mua_sp_lkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_HOADON_LINHKIENTableAdapter = null;
            this.tableAdapterManager.Ct_mua_SPTableAdapter = null;
            this.tableAdapterManager.CT_NHAP_LK_sreach_lk_manhapTableAdapter = null;
            this.tableAdapterManager.CT_NHAP_SP_DK_LUUKHOTableAdapter = null;
            this.tableAdapterManager.CT_NHAP_SPTableAdapter = null;
            this.tableAdapterManager.HOADON1TableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANG_dkTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHO1TableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.KHUYENMAI_DKTableAdapter = null;
            this.tableAdapterManager.KHUYENMAI_lk_malkTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LAY_MANVbangTENDNTableAdapter = null;
            this.tableAdapterManager.LINHKIENTableAdapter = null;
            this.tableAdapterManager.LOAIHOADONTableAdapter = null;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.LOIDONGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.LOIDONHASXTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANG1TableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hd_tragop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 452);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hd_tragop";
            this.Text = "hd_tragop";
            this.Load += new System.EventHandler(this.hd_tragop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TraGop1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_mua_sp_lkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TraGop1BindingSource;
        private tt tt;
        private ttTableAdapters.TraGop1TableAdapter TraGop1TableAdapter;
        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource ct_mua_sp_lkBindingSource;
        private NghiepVuTableAdapters.ct_mua_sp_lkTableAdapter ct_mua_sp_lkTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
    }
}