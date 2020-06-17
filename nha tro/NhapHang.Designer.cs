namespace nha_tro
{
    partial class MH000000000000000004
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
            this.themToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cT_Nhap_dkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nghiepVu = new nha_tro.NghiepVu();
            this.thongTinChung_NhapHang1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinChung_NhapHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.cT_Nhap_dkTableAdapter = new nha_tro.NghiepVuTableAdapters.CT_Nhap_dkTableAdapter();
            this.thongTinChung_NhapHangTableAdapter = new nha_tro.NghiepVuTableAdapters.ThongTinChung_NhapHangTableAdapter();
            this.thongTinChung_NhapHang1TableAdapter = new nha_tro.NghiepVuTableAdapters.ThongTinChung_NhapHang1TableAdapter();
            this.ttcBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttcTableAdapter = new nha_tro.NghiepVuTableAdapters.ttcTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_Nhap_dkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinChung_NhapHang1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinChung_NhapHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // themToolStripMenuItem
            // 
            this.themToolStripMenuItem.Checked = true;
            this.themToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.themToolStripMenuItem.Name = "themToolStripMenuItem";
            this.themToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.themToolStripMenuItem.Text = "Tạo phiếu nhập";
            this.themToolStripMenuItem.Click += new System.EventHandler(this.themToolStripMenuItem_Click_1);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.nhậpHàngToolStripMenuItem.Text = "Lưu hàng vào kho";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1331, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cT_Nhap_dkBindingSource
            // 
            this.cT_Nhap_dkBindingSource.DataMember = "CT_Nhap_dk";
            this.cT_Nhap_dkBindingSource.DataSource = this.nghiepVu;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinChung_NhapHang1BindingSource
            // 
            this.thongTinChung_NhapHang1BindingSource.DataMember = "ThongTinChung_NhapHang1";
            this.thongTinChung_NhapHang1BindingSource.DataSource = this.nghiepVu;
            // 
            // thongTinChung_NhapHangBindingSource
            // 
            this.thongTinChung_NhapHangBindingSource.DataMember = "ThongTinChung_NhapHang";
            this.thongTinChung_NhapHangBindingSource.DataSource = this.nghiepVu;
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
            // cT_Nhap_dkTableAdapter
            // 
            this.cT_Nhap_dkTableAdapter.ClearBeforeFill = true;
            // 
            // thongTinChung_NhapHangTableAdapter
            // 
            this.thongTinChung_NhapHangTableAdapter.ClearBeforeFill = true;
            // 
            // thongTinChung_NhapHang1TableAdapter
            // 
            this.thongTinChung_NhapHang1TableAdapter.ClearBeforeFill = true;
            // 
            // ttcBindingSource
            // 
            this.ttcBindingSource.DataMember = "ttc";
            this.ttcBindingSource.DataSource = this.nghiepVu;
            // 
            // ttcTableAdapter
            // 
            this.ttcTableAdapter.ClearBeforeFill = true;
            // 
            // MH000000000000000004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 717);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MH000000000000000004";
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.MH000000000000000004_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cT_Nhap_dkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinChung_NhapHang1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinChung_NhapHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttcBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cT_Nhap_dkBindingSource;
        private NghiepVuTableAdapters.CT_Nhap_dkTableAdapter cT_Nhap_dkTableAdapter;
        private System.Windows.Forms.BindingSource thongTinChung_NhapHangBindingSource;
        private NghiepVuTableAdapters.ThongTinChung_NhapHangTableAdapter thongTinChung_NhapHangTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem themToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource thongTinChung_NhapHang1BindingSource;
        private NghiepVuTableAdapters.ThongTinChung_NhapHang1TableAdapter thongTinChung_NhapHang1TableAdapter;
        private System.Windows.Forms.BindingSource ttcBindingSource;
        private NghiepVuTableAdapters.ttcTableAdapter ttcTableAdapter;
    }
}