namespace nha_tro
{
    partial class ThemNguoiDung
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
            System.Windows.Forms.Label tENDANGNHAPLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mATKHAULabel;
            System.Windows.Forms.Label hOATDONGLabel;
            this.Thêm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dS_DangNhap = new nha_tro.DS_DangNhap();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new nha_tro.DS_DangNhapTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new nha_tro.DS_DangNhapTableAdapters.TableAdapterManager();
            this.tENDANGNHAPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mATKHAUTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOATDONGCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.tAIKHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new nha_tro.DS_DangNhapTableAdapters.NHANVIENTableAdapter();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nghiepVu = new nha_tro.NghiepVu();
            this.nHANVIENBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter1 = new nha_tro.NghiepVuTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager1 = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.nHANVIENComboBox = new System.Windows.Forms.ComboBox();
            tENDANGNHAPLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            hOATDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATKHAUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tENDANGNHAPLabel
            // 
            tENDANGNHAPLabel.AutoSize = true;
            tENDANGNHAPLabel.Location = new System.Drawing.Point(160, 52);
            tENDANGNHAPLabel.Name = "tENDANGNHAPLabel";
            tENDANGNHAPLabel.Size = new System.Drawing.Size(93, 13);
            tENDANGNHAPLabel.TabIndex = 10;
            tENDANGNHAPLabel.Text = "TENDANGNHAP:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(160, 78);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(44, 13);
            mANVLabel.TabIndex = 12;
            mANVLabel.Text = "Tên NV";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(160, 104);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(63, 13);
            mATKHAULabel.TabIndex = 14;
            mATKHAULabel.Text = "MATKHAU:";
            // 
            // hOATDONGLabel
            // 
            hOATDONGLabel.AutoSize = true;
            hOATDONGLabel.Location = new System.Drawing.Point(160, 130);
            hOATDONGLabel.Name = "hOATDONGLabel";
            hOATDONGLabel.Size = new System.Drawing.Size(72, 13);
            hOATDONGLabel.TabIndex = 16;
            hOATDONGLabel.Text = "HOATDONG:";
            // 
            // Thêm
            // 
            this.Thêm.Location = new System.Drawing.Point(26, 52);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(75, 23);
            this.Thêm.TabIndex = 7;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dS_DangNhap
            // 
            this.dS_DangNhap.DataSetName = "DS_DangNhap";
            this.dS_DangNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.dS_DangNhap;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNG_DKTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.tk_NND_DKTableAdapter = null;
            this.tableAdapterManager.tk_NNDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.DS_DangNhapTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENDANGNHAPTextEdit
            // 
            this.tENDANGNHAPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "TENDANGNHAP", true));
            this.tENDANGNHAPTextEdit.Location = new System.Drawing.Point(259, 49);
            this.tENDANGNHAPTextEdit.Name = "tENDANGNHAPTextEdit";
            this.tENDANGNHAPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENDANGNHAPTextEdit.TabIndex = 11;
            // 
            // mATKHAUTextEdit
            // 
            this.mATKHAUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "MATKHAU", true));
            this.mATKHAUTextEdit.Location = new System.Drawing.Point(259, 101);
            this.mATKHAUTextEdit.Name = "mATKHAUTextEdit";
            this.mATKHAUTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mATKHAUTextEdit.TabIndex = 15;
            // 
            // hOATDONGCheckEdit
            // 
            this.hOATDONGCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "HOATDONG", true));
            this.hOATDONGCheckEdit.Location = new System.Drawing.Point(259, 127);
            this.hOATDONGCheckEdit.Name = "hOATDONGCheckEdit";
            this.hOATDONGCheckEdit.Properties.Caption = "checkEdit1";
            this.hOATDONGCheckEdit.Size = new System.Drawing.Size(100, 20);
            this.hOATDONGCheckEdit.TabIndex = 17;
            // 
            // tAIKHOANGridControl
            // 
            this.tAIKHOANGridControl.DataSource = this.tAIKHOANBindingSource;
            this.tAIKHOANGridControl.Location = new System.Drawing.Point(411, 52);
            this.tAIKHOANGridControl.MainView = this.gridView1;
            this.tAIKHOANGridControl.Name = "tAIKHOANGridControl";
            this.tAIKHOANGridControl.Size = new System.Drawing.Size(405, 220);
            this.tAIKHOANGridControl.TabIndex = 17;
            this.tAIKHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.tAIKHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.dS_DangNhap;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // nHANVIENBindingSource1
            // 
            this.nHANVIENBindingSource1.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource1.DataSource = this.dS_DangNhap;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(841, 52);
            this.nHANVIENGridControl.MainView = this.gridView2;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(439, 220);
            this.nHANVIENGridControl.TabIndex = 17;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.nHANVIENGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(841, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource2
            // 
            this.nHANVIENBindingSource2.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource2.DataSource = this.nghiepVu;
            // 
            // nHANVIENTableAdapter1
            // 
            this.nHANVIENTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CT_HOADON_LINHKIENTableAdapter = null;
            this.tableAdapterManager1.Ct_mua_SPTableAdapter = null;
            this.tableAdapterManager1.CT_NHAP_LK_sreach_lk_manhapTableAdapter = null;
            this.tableAdapterManager1.CT_NHAP_SP_DK_LUUKHOTableAdapter = null;
            this.tableAdapterManager1.CT_NHAP_SPTableAdapter = null;
            this.tableAdapterManager1.HOADON1TableAdapter = null;
            this.tableAdapterManager1.HOADONTableAdapter = null;
            this.tableAdapterManager1.KHACHHANG_dkTableAdapter = null;
            this.tableAdapterManager1.KHACHHANGTableAdapter = null;
            this.tableAdapterManager1.KHO1TableAdapter = null;
            this.tableAdapterManager1.KHOTableAdapter = null;
            this.tableAdapterManager1.KHUYENMAI_DKTableAdapter = null;
            this.tableAdapterManager1.KHUYENMAITableAdapter = null;
            this.tableAdapterManager1.LAY_MANVbangTENDNTableAdapter = null;
            this.tableAdapterManager1.LINHKIENTableAdapter = null;
            this.tableAdapterManager1.LOAIHOADONTableAdapter = null;
            this.tableAdapterManager1.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager1.LOIDONGUOIDUNGTableAdapter = null;
            this.tableAdapterManager1.LOIDONHASXTableAdapter = null;
            this.tableAdapterManager1.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager1.NHANVIENTableAdapter = this.nHANVIENTableAdapter1;
            this.tableAdapterManager1.NHAPHANG1TableAdapter = null;
            this.tableAdapterManager1.NHAPHANGTableAdapter = null;
            this.tableAdapterManager1.SANPHAMTableAdapter = null;
            this.tableAdapterManager1.TAIKHOANTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENComboBox
            // 
            this.nHANVIENComboBox.DataSource = this.nHANVIENBindingSource2;
            this.nHANVIENComboBox.DisplayMember = "HOTEN";
            this.nHANVIENComboBox.FormattingEnabled = true;
            this.nHANVIENComboBox.Location = new System.Drawing.Point(259, 74);
            this.nHANVIENComboBox.Name = "nHANVIENComboBox";
            this.nHANVIENComboBox.Size = new System.Drawing.Size(100, 21);
            this.nHANVIENComboBox.TabIndex = 19;
            this.nHANVIENComboBox.ValueMember = "MANV";
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 344);
            this.Controls.Add(this.nHANVIENComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nHANVIENGridControl);
            this.Controls.Add(this.tAIKHOANGridControl);
            this.Controls.Add(tENDANGNHAPLabel);
            this.Controls.Add(this.tENDANGNHAPTextEdit);
            this.Controls.Add(mANVLabel);
            this.Controls.Add(mATKHAULabel);
            this.Controls.Add(this.mATKHAUTextEdit);
            this.Controls.Add(hOATDONGLabel);
            this.Controls.Add(this.hOATDONGCheckEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Thêm);
            this.Name = "ThemNguoiDung";
            this.Text = "ThemNguoiDung";
            this.Load += new System.EventHandler(this.ThemNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATKHAUTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DS_DangNhap dS_DangNhap;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DS_DangNhapTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DS_DangNhapTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit tENDANGNHAPTextEdit;
        private DevExpress.XtraEditors.TextEdit mATKHAUTextEdit;
        private DevExpress.XtraEditors.CheckEdit hOATDONGCheckEdit;
        private DevExpress.XtraGrid.GridControl tAIKHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DS_DangNhapTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Button button1;
        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource2;
        private NghiepVuTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox nHANVIENComboBox;
    }
}