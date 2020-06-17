namespace nha_tro
{
    partial class thongKeSPTheoKM
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
            this.kHUYENMAIDataGridView = new System.Windows.Forms.DataGridView();
            this.kHUYENMAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.thongKe_km_theo_maDataGridView = new System.Windows.Forms.DataGridView();
            this.thongKe_km_theo_maBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUYENMAITableAdapter = new nha_tro.ttTableAdapters.KHUYENMAITableAdapter();
            this.tableAdapterManager = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.thongKe_km_theo_maTableAdapter = new nha_tro.ttTableAdapters.ThongKe_km_theo_maTableAdapter();
            this.kHUYENMAIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thongKe_TinhDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKe_TinhDoanhThuTableAdapter = new nha_tro.ttTableAdapters.ThongKe_TinhDoanhThuTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_km_theo_maDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_km_theo_maBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_TinhDoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kHUYENMAIDataGridView
            // 
            this.kHUYENMAIDataGridView.AutoGenerateColumns = false;
            this.kHUYENMAIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHUYENMAIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.kHUYENMAIDataGridView.DataSource = this.kHUYENMAIBindingSource;
            this.kHUYENMAIDataGridView.Location = new System.Drawing.Point(41, 23);
            this.kHUYENMAIDataGridView.Name = "kHUYENMAIDataGridView";
            this.kHUYENMAIDataGridView.Size = new System.Drawing.Size(747, 190);
            this.kHUYENMAIDataGridView.TabIndex = 1;
            this.kHUYENMAIDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kHUYENMAIDataGridView_CellClick);
            // 
            // kHUYENMAIBindingSource
            // 
            this.kHUYENMAIBindingSource.DataMember = "KHUYENMAI";
            this.kHUYENMAIBindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thongKe_km_theo_maDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(41, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 268);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            // 
            // thongKe_km_theo_maDataGridView
            // 
            this.thongKe_km_theo_maDataGridView.AutoGenerateColumns = false;
            this.thongKe_km_theo_maDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongKe_km_theo_maDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.thongKe_km_theo_maDataGridView.DataSource = this.thongKe_km_theo_maBindingSource;
            this.thongKe_km_theo_maDataGridView.Location = new System.Drawing.Point(6, 34);
            this.thongKe_km_theo_maDataGridView.Name = "thongKe_km_theo_maDataGridView";
            this.thongKe_km_theo_maDataGridView.Size = new System.Drawing.Size(735, 220);
            this.thongKe_km_theo_maDataGridView.TabIndex = 0;
            // 
            // thongKe_km_theo_maBindingSource
            // 
            this.thongKe_km_theo_maBindingSource.DataMember = "ThongKe_km_theo_ma";
            this.thongKe_km_theo_maBindingSource.DataSource = this.tt;
            // 
            // kHUYENMAITableAdapter
            // 
            this.kHUYENMAITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOHANH1TableAdapter = null;
            this.tableAdapterManager.BAOHANHTableAdapter = null;
            this.tableAdapterManager.Ct_KM_LKTableAdapter = null;
            this.tableAdapterManager.CT_KM_SPTableAdapter = null;
            this.tableAdapterManager.Ct_mua_SP_TIMKIEMTableAdapter = null;
            this.tableAdapterManager.CT_NHAP_LK_theoMaNhapTableAdapter = null;
            this.tableAdapterManager.DATHANG_SPTableAdapter = null;
            this.tableAdapterManager.DOITRATableAdapter = null;
            this.tableAdapterManager.HOADON_kttontaiTableAdapter = null;
            this.tableAdapterManager.HOADON_timmahd_vuathemTableAdapter = null;
            this.tableAdapterManager.HOADON_ttTableAdapter = null;
            this.tableAdapterManager.KHO_ttTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = this.kHUYENMAITableAdapter;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.SANPHAM__sreach_giaTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_TIMMANVTableAdapter = null;
            this.tableAdapterManager.TinhTrangTTTableAdapter = null;
            this.tableAdapterManager.TraGop1TableAdapter = null;
            this.tableAdapterManager.TraGopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.ttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thongKe_km_theo_maTableAdapter
            // 
            this.thongKe_km_theo_maTableAdapter.ClearBeforeFill = true;
            // 
            // kHUYENMAIBindingSource1
            // 
            this.kHUYENMAIBindingSource1.DataMember = "KHUYENMAI";
            this.kHUYENMAIBindingSource1.DataSource = this.tt;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1103, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Xuất file pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(921, 504);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(812, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tổng Tiền Bán Được";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(921, 477);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "SL Đã Bán";
            // 
            // thongKe_TinhDoanhThuBindingSource
            // 
            this.thongKe_TinhDoanhThuBindingSource.DataMember = "ThongKe_TinhDoanhThu";
            this.thongKe_TinhDoanhThuBindingSource.DataSource = this.tt;
            // 
            // thongKe_TinhDoanhThuTableAdapter
            // 
            this.thongKe_TinhDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKHUYENMAI";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khuyến mãi";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MALINHKIEN";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã linh kiện";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENKHUYENMAI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên khuyến mãi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NGAYBD";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày bắt dầu";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NGAYKT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ngày kết thúc";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GIATRI";
            this.dataGridViewTextBoxColumn7.HeaderText = "Giá trị";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaHD";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GIATRI";
            this.dataGridViewTextBoxColumn10.HeaderText = "Giá trị";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SL";
            this.dataGridViewTextBoxColumn11.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn12.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // thongKeSPTheoKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kHUYENMAIDataGridView);
            this.Name = "thongKeSPTheoKM";
            this.Text = "thongKeSPTheoKM";
            this.Load += new System.EventHandler(this.thongKeSPTheoKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_km_theo_maDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_km_theo_maBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_TinhDoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tt tt;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource;
        private ttTableAdapters.KHUYENMAITableAdapter kHUYENMAITableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHUYENMAIDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource thongKe_km_theo_maBindingSource;
        private ttTableAdapters.ThongKe_km_theo_maTableAdapter thongKe_km_theo_maTableAdapter;
        private System.Windows.Forms.DataGridView thongKe_km_theo_maDataGridView;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource thongKe_TinhDoanhThuBindingSource;
        private ttTableAdapters.ThongKe_TinhDoanhThuTableAdapter thongKe_TinhDoanhThuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}