namespace nha_tro
{
    partial class thongkesltrongkho
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
            this.button9 = new System.Windows.Forms.Button();
            this.tt = new nha_tro.tt();
            this.thongke_khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongke_khoTableAdapter = new nha_tro.ttTableAdapters.thongke_khoTableAdapter();
            this.tableAdapterManager = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.thongke_khoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nghiepVu = new nha_tro.NghiepVu();
            this.makho_cboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makho_cboTableAdapter = new nha_tro.NghiepVuTableAdapters.makho_cboTableAdapter();
            this.tableAdapterManager1 = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.makho_cboComboBox = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.mAKHODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENLOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINHTRANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongke_khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongke_khoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makho_cboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(797, 42);
            this.button9.TabIndex = 32;
            this.button9.Text = "THỐNG KÊ SL TRONG KHO";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongke_khoBindingSource
            // 
            this.thongke_khoBindingSource.DataMember = "thongke_kho";
            this.thongke_khoBindingSource.DataSource = this.tt;
            // 
            // thongke_khoTableAdapter
            // 
            this.thongke_khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOHANH1TableAdapter = null;
            this.tableAdapterManager.BAOHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ct_bHTableAdapter = null;
            this.tableAdapterManager.CT_HOADON_LINHKIENTableAdapter = null;
            this.tableAdapterManager.Ct_KM_LKTableAdapter = null;
            this.tableAdapterManager.CT_KM_SPTableAdapter = null;
            this.tableAdapterManager.Ct_mua_SP_TIMKIEMTableAdapter = null;
            this.tableAdapterManager.CT_NHAP_LK_theoMaNhapTableAdapter = null;
            this.tableAdapterManager.DATHANG_SPTableAdapter = null;
            this.tableAdapterManager.DOITRATableAdapter = null;
            this.tableAdapterManager.HOADON_baohanhTableAdapter = null;
            this.tableAdapterManager.HOADON_kttontaiTableAdapter = null;
            this.tableAdapterManager.HOADON_timmahd_vuathemTableAdapter = null;
            this.tableAdapterManager.HOADON_ttTableAdapter = null;
            this.tableAdapterManager.KHO_ttTableAdapter = null;
            this.tableAdapterManager.KHUYENMAI1TableAdapter = null;
            this.tableAdapterManager.KHUYENMAI2TableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.NDBaoHanhTableAdapter = null;
            this.tableAdapterManager.SANPHAM__sreach_giaTableAdapter = null;
            this.tableAdapterManager.SP_LOITableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_TIMMANVTableAdapter = null;
            this.tableAdapterManager.TinhTrangTTTableAdapter = null;
            this.tableAdapterManager.TraGop_tinhtienTableAdapter = null;
            this.tableAdapterManager.TraGop1TableAdapter = null;
            this.tableAdapterManager.TraGopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.ttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thongke_khoDataGridView
            // 
            this.thongke_khoDataGridView.AutoGenerateColumns = false;
            this.thongke_khoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thongke_khoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongke_khoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHODataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.mALOAIDataGridViewTextBoxColumn,
            this.tENLOAIDataGridViewTextBoxColumn,
            this.tINHTRANGDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn});
            this.thongke_khoDataGridView.DataSource = this.thongke_khoBindingSource;
            this.thongke_khoDataGridView.Location = new System.Drawing.Point(12, 104);
            this.thongke_khoDataGridView.Name = "thongke_khoDataGridView";
            this.thongke_khoDataGridView.Size = new System.Drawing.Size(773, 220);
            this.thongke_khoDataGridView.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Tên SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "KHO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(611, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Loại SP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 37;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makho_cboBindingSource
            // 
            this.makho_cboBindingSource.DataMember = "makho_cbo";
            this.makho_cboBindingSource.DataSource = this.nghiepVu;
            // 
            // makho_cboTableAdapter
            // 
            this.makho_cboTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
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
            this.tableAdapterManager1.KHUYENMAI_lk_malkTableAdapter = null;
            this.tableAdapterManager1.KHUYENMAITableAdapter = null;
            this.tableAdapterManager1.LAY_MANVbangTENDNTableAdapter = null;
            this.tableAdapterManager1.LINHKIENTableAdapter = null;
            this.tableAdapterManager1.LOAIHOADONTableAdapter = null;
            this.tableAdapterManager1.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager1.LOIDONGUOIDUNGTableAdapter = null;
            this.tableAdapterManager1.LOIDONHASXTableAdapter = null;
            this.tableAdapterManager1.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager1.NHANVIENTableAdapter = null;
            this.tableAdapterManager1.NHAPHANG1TableAdapter = null;
            this.tableAdapterManager1.NHAPHANGTableAdapter = null;
            this.tableAdapterManager1.SANPHAMTableAdapter = null;
            this.tableAdapterManager1.TAIKHOANTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // makho_cboComboBox
            // 
            this.makho_cboComboBox.DataSource = this.makho_cboBindingSource;
            this.makho_cboComboBox.DisplayMember = "MAKHO";
            this.makho_cboComboBox.FormattingEnabled = true;
            this.makho_cboComboBox.Location = new System.Drawing.Point(402, 66);
            this.makho_cboComboBox.Name = "makho_cboComboBox";
            this.makho_cboComboBox.Size = new System.Drawing.Size(100, 21);
            this.makho_cboComboBox.TabIndex = 37;
            this.makho_cboComboBox.ValueMember = "MAKHO";
            this.makho_cboComboBox.SelectedIndexChanged += new System.EventHandler(this.makho_cboComboBox_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(679, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 38;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // mAKHODataGridViewTextBoxColumn
            // 
            this.mAKHODataGridViewTextBoxColumn.DataPropertyName = "MAKHO";
            this.mAKHODataGridViewTextBoxColumn.HeaderText = "Mã Kho";
            this.mAKHODataGridViewTextBoxColumn.Name = "mAKHODataGridViewTextBoxColumn";
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // mALOAIDataGridViewTextBoxColumn
            // 
            this.mALOAIDataGridViewTextBoxColumn.DataPropertyName = "MALOAI";
            this.mALOAIDataGridViewTextBoxColumn.HeaderText = "Mã loại sp";
            this.mALOAIDataGridViewTextBoxColumn.Name = "mALOAIDataGridViewTextBoxColumn";
            // 
            // tENLOAIDataGridViewTextBoxColumn
            // 
            this.tENLOAIDataGridViewTextBoxColumn.DataPropertyName = "TENLOAI";
            this.tENLOAIDataGridViewTextBoxColumn.HeaderText = "Tên loại sp";
            this.tENLOAIDataGridViewTextBoxColumn.Name = "tENLOAIDataGridViewTextBoxColumn";
            // 
            // tINHTRANGDataGridViewTextBoxColumn
            // 
            this.tINHTRANGDataGridViewTextBoxColumn.DataPropertyName = "TINHTRANG";
            this.tINHTRANGDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tINHTRANGDataGridViewTextBoxColumn.Name = "tINHTRANGDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            // 
            // thongkesltrongkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 350);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.makho_cboComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thongke_khoDataGridView);
            this.Controls.Add(this.button9);
            this.Name = "thongkesltrongkho";
            this.Text = "thongkesltrongkho";
            this.Load += new System.EventHandler(this.thongkesltrongkho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongke_khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongke_khoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makho_cboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private tt tt;
        private System.Windows.Forms.BindingSource thongke_khoBindingSource;
        private ttTableAdapters.thongke_khoTableAdapter thongke_khoTableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView thongke_khoDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource makho_cboBindingSource;
        private NghiepVuTableAdapters.makho_cboTableAdapter makho_cboTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox makho_cboComboBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENLOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tINHTRANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
    }
}