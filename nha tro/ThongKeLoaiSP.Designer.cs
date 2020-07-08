namespace nha_tro
{
    partial class ThongKeLoaiSP
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thongKe_SPDataGridView = new System.Windows.Forms.DataGridView();
            this.mAHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYLAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHONGKE_LOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.lOAISANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAISANPHAMTableAdapter = new nha_tro.ttTableAdapters.LOAISANPHAMTableAdapter();
            this.tableAdapterManager = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.lOAISANPHAMComboBox = new System.Windows.Forms.ComboBox();
            this.tHONGKE_LOAISPTableAdapter = new nha_tro.ttTableAdapters.THONGKE_LOAISPTableAdapter();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGKE_LOAISPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Iconsmind_Outline_Filter_2;
            this.button2.Location = new System.Drawing.Point(189, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Avosoft_Warm_Toolbar_Print__1_;
            this.button1.Location = new System.Drawing.Point(322, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 48);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 486);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 24;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng Tiền Bán Được";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 459);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "SL Đã Bán";
            // 
            // thongKe_SPDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            this.thongKe_SPDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.thongKe_SPDataGridView.AutoGenerateColumns = false;
            this.thongKe_SPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thongKe_SPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongKe_SPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAHDDataGridViewTextBoxColumn,
            this.nGAYLAPDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn});
            this.thongKe_SPDataGridView.DataSource = this.tHONGKE_LOAISPBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.thongKe_SPDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.thongKe_SPDataGridView.Location = new System.Drawing.Point(31, 233);
            this.thongKe_SPDataGridView.Name = "thongKe_SPDataGridView";
            this.thongKe_SPDataGridView.Size = new System.Drawing.Size(391, 220);
            this.thongKe_SPDataGridView.TabIndex = 20;
            // 
            // mAHDDataGridViewTextBoxColumn
            // 
            this.mAHDDataGridViewTextBoxColumn.DataPropertyName = "MAHD";
            this.mAHDDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.mAHDDataGridViewTextBoxColumn.Name = "mAHDDataGridViewTextBoxColumn";
            this.mAHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nGAYLAPDataGridViewTextBoxColumn
            // 
            this.nGAYLAPDataGridViewTextBoxColumn.DataPropertyName = "NGAYLAP";
            this.nGAYLAPDataGridViewTextBoxColumn.HeaderText = "Ngày lập";
            this.nGAYLAPDataGridViewTextBoxColumn.Name = "nGAYLAPDataGridViewTextBoxColumn";
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // tHONGKE_LOAISPBindingSource
            // 
            this.tHONGKE_LOAISPBindingSource.DataMember = "THONGKE_LOAISP";
            this.tHONGKE_LOAISPBindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAISANPHAMBindingSource
            // 
            this.lOAISANPHAMBindingSource.DataMember = "LOAISANPHAM";
            this.lOAISANPHAMBindingSource.DataSource = this.tt;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày Kết Thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày Bắt Đầu";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 163);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loại Sản Phẩm";
            // 
            // lOAISANPHAMTableAdapter
            // 
            this.lOAISANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOHANH1TableAdapter = null;
            this.tableAdapterManager.BAOHANHTableAdapter = null;
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
            this.tableAdapterManager.LOAISANPHAMTableAdapter = this.lOAISANPHAMTableAdapter;
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
            // lOAISANPHAMComboBox
            // 
            this.lOAISANPHAMComboBox.DataSource = this.lOAISANPHAMBindingSource;
            this.lOAISANPHAMComboBox.DisplayMember = "TENLOAI";
            this.lOAISANPHAMComboBox.FormattingEnabled = true;
            this.lOAISANPHAMComboBox.Location = new System.Drawing.Point(125, 63);
            this.lOAISANPHAMComboBox.Name = "lOAISANPHAMComboBox";
            this.lOAISANPHAMComboBox.Size = new System.Drawing.Size(300, 21);
            this.lOAISANPHAMComboBox.TabIndex = 27;
            this.lOAISANPHAMComboBox.ValueMember = "MALOAI";
            // 
            // tHONGKE_LOAISPTableAdapter
            // 
            this.tHONGKE_LOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = global::nha_tro.Properties.Resources.Designcontest_Ecommerce_Business_Dollar;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(443, 42);
            this.button9.TabIndex = 32;
            this.button9.Text = "THỐNG KÊ THEO LOẠI SẢN PHẨM";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // ThongKeLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 515);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.lOAISANPHAMComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thongKe_SPDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeLoaiSP";
            this.Text = "Thống kê theo loại sản phẩm";
            this.Load += new System.EventHandler(this.ThongKeLoaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGKE_LOAISPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView thongKe_SPDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private tt tt;
        private System.Windows.Forms.BindingSource lOAISANPHAMBindingSource;
        private ttTableAdapters.LOAISANPHAMTableAdapter lOAISANPHAMTableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox lOAISANPHAMComboBox;
        private System.Windows.Forms.BindingSource tHONGKE_LOAISPBindingSource;
        private ttTableAdapters.THONGKE_LOAISPTableAdapter tHONGKE_LOAISPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYLAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button9;
    }
}