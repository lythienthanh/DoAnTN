namespace nha_tro
{
    partial class TraGop
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
            this.thongKe_tragop_theongayDataGridView = new System.Windows.Forms.DataGridView();
            this.thongKe_tragop_theongayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thongKe_tragop_theongayTableAdapter = new nha_tro.ttTableAdapters.thongKe_tragop_theongayTableAdapter();
            this.tableAdapterManager = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.traGopTableAdapter = new nha_tro.ttTableAdapters.TraGopTableAdapter();
            this.thongKe_TinhDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKe_TinhDoanhThuTableAdapter = new nha_tro.ttTableAdapters.ThongKe_TinhDoanhThuTableAdapter();
            this.traGopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traGop2_select_theo_ngayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traGop2_select_theo_ngayTableAdapter = new nha_tro.ttTableAdapters.TraGop2_select_theo_ngayTableAdapter();
            this.traGop2_select_theo_ngayDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_tragop_theongayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_tragop_theongayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_TinhDoanhThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traGopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traGop2_select_theo_ngayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traGop2_select_theo_ngayDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // thongKe_tragop_theongayDataGridView
            // 
            this.thongKe_tragop_theongayDataGridView.AutoGenerateColumns = false;
            this.thongKe_tragop_theongayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongKe_tragop_theongayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.thongKe_tragop_theongayDataGridView.DataSource = this.thongKe_tragop_theongayBindingSource;
            this.thongKe_tragop_theongayDataGridView.Location = new System.Drawing.Point(12, 165);
            this.thongKe_tragop_theongayDataGridView.Name = "thongKe_tragop_theongayDataGridView";
            this.thongKe_tragop_theongayDataGridView.Size = new System.Drawing.Size(450, 220);
            this.thongKe_tragop_theongayDataGridView.TabIndex = 2;
            // 
            // thongKe_tragop_theongayBindingSource
            // 
            this.thongKe_tragop_theongayBindingSource.DataMember = "thongKe_tragop_theongay";
            this.thongKe_tragop_theongayBindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ngày Kết Thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày Bắt Đầu";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(106, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Xuất file pdf";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(649, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tổng Tiền Phải Nhận";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(649, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "SL Đã Bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tổng Tiền Đã Thanh Toán";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(649, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(649, 293);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(176, 20);
            this.textBox4.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(499, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tổng Tiền Còn Lại";
            // 
            // thongKe_tragop_theongayTableAdapter
            // 
            this.thongKe_tragop_theongayTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.SANPHAM__sreach_giaTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_TIMMANVTableAdapter = null;
            this.tableAdapterManager.TinhTrangTTTableAdapter = null;
            this.tableAdapterManager.TraGop1TableAdapter = null;
            this.tableAdapterManager.TraGopTableAdapter = this.traGopTableAdapter;
            this.tableAdapterManager.UpdateOrder = nha_tro.ttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // traGopTableAdapter
            // 
            this.traGopTableAdapter.ClearBeforeFill = true;
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
            // traGopBindingSource
            // 
            this.traGopBindingSource.DataMember = "TraGop";
            this.traGopBindingSource.DataSource = this.tt;
            // 
            // traGop2_select_theo_ngayBindingSource
            // 
            this.traGop2_select_theo_ngayBindingSource.DataMember = "TraGop2_select_theo_ngay";
            this.traGop2_select_theo_ngayBindingSource.DataSource = this.tt;
            // 
            // traGop2_select_theo_ngayTableAdapter
            // 
            this.traGop2_select_theo_ngayTableAdapter.ClearBeforeFill = true;
            // 
            // traGop2_select_theo_ngayDataGridView
            // 
            this.traGop2_select_theo_ngayDataGridView.AutoGenerateColumns = false;
            this.traGop2_select_theo_ngayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traGop2_select_theo_ngayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.traGop2_select_theo_ngayDataGridView.DataSource = this.traGop2_select_theo_ngayBindingSource;
            this.traGop2_select_theo_ngayDataGridView.Location = new System.Drawing.Point(502, 25);
            this.traGop2_select_theo_ngayDataGridView.Name = "traGop2_select_theo_ngayDataGridView";
            this.traGop2_select_theo_ngayDataGridView.Size = new System.Drawing.Size(549, 134);
            this.traGop2_select_theo_ngayDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SL";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MaTraGop";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã trả góp";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoTienPhaiTra";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số tiền phải trả";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SoTienConLai";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số tiền còn lại";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NgayTra";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ngảy trả";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "deadline";
            this.dataGridViewTextBoxColumn9.HeaderText = "Hạn cuối";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // TraGop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 542);
            this.Controls.Add(this.traGop2_select_theo_ngayDataGridView);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.thongKe_tragop_theongayDataGridView);
            this.Name = "TraGop";
            this.Text = "TraGop";
            this.Load += new System.EventHandler(this.TraGop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_tragop_theongayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_tragop_theongayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_TinhDoanhThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traGopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traGop2_select_theo_ngayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traGop2_select_theo_ngayDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tt tt;
        private System.Windows.Forms.BindingSource thongKe_tragop_theongayBindingSource;
        private ttTableAdapters.thongKe_tragop_theongayTableAdapter thongKe_tragop_theongayTableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView thongKe_tragop_theongayDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource thongKe_TinhDoanhThuBindingSource;
        private ttTableAdapters.ThongKe_TinhDoanhThuTableAdapter thongKe_TinhDoanhThuTableAdapter;
        private ttTableAdapters.TraGopTableAdapter traGopTableAdapter;
        private System.Windows.Forms.BindingSource traGopBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource traGop2_select_theo_ngayBindingSource;
        private ttTableAdapters.TraGop2_select_theo_ngayTableAdapter traGop2_select_theo_ngayTableAdapter;
        private System.Windows.Forms.DataGridView traGop2_select_theo_ngayDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}