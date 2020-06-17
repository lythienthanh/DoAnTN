namespace nha_tro
{
    partial class ThongKeSanPham
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            this.nghiepVu = new nha_tro.NghiepVu();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new nha_tro.NghiepVuTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.sANPHAMComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tt = new nha_tro.tt();
            this.thongKe_SPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongKe_SPTableAdapter = new nha_tro.ttTableAdapters.ThongKe_SPTableAdapter();
            this.tableAdapterManager1 = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.thongKe_SPDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.thongKe_SPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANPHAMBindingSource
            // 
            this.sANPHAMBindingSource.DataMember = "SANPHAM";
            this.sANPHAMBindingSource.DataSource = this.nghiepVu;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            this.tableAdapterManager.SANPHAMTableAdapter = this.sANPHAMTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sANPHAMComboBox
            // 
            this.sANPHAMComboBox.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMComboBox.DisplayMember = "TENSP";
            this.sANPHAMComboBox.FormattingEnabled = true;
            this.sANPHAMComboBox.Location = new System.Drawing.Point(106, 41);
            this.sANPHAMComboBox.Name = "sANPHAMComboBox";
            this.sANPHAMComboBox.Size = new System.Drawing.Size(300, 21);
            this.sANPHAMComboBox.TabIndex = 1;
            this.sANPHAMComboBox.ValueMember = "MASP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(106, 141);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày Bắt Đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Kết Thúc";
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKe_SPBindingSource
            // 
            this.thongKe_SPBindingSource.DataMember = "ThongKe_SP";
            this.thongKe_SPBindingSource.DataSource = this.tt;
            // 
            // thongKe_SPTableAdapter
            // 
            this.thongKe_SPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BAOHANH1TableAdapter = null;
            this.tableAdapterManager1.BAOHANHTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.Ct_KM_LKTableAdapter = null;
            this.tableAdapterManager1.CT_KM_SPTableAdapter = null;
            this.tableAdapterManager1.Ct_mua_SP_TIMKIEMTableAdapter = null;
            this.tableAdapterManager1.CT_NHAP_LK_theoMaNhapTableAdapter = null;
            this.tableAdapterManager1.DATHANG_SPTableAdapter = null;
            this.tableAdapterManager1.DOITRATableAdapter = null;
            this.tableAdapterManager1.HOADON_kttontaiTableAdapter = null;
            this.tableAdapterManager1.HOADON_timmahd_vuathemTableAdapter = null;
            this.tableAdapterManager1.HOADON_ttTableAdapter = null;
            this.tableAdapterManager1.KHO_ttTableAdapter = null;
            this.tableAdapterManager1.KHUYENMAITableAdapter = null;
            this.tableAdapterManager1.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager1.SANPHAM__sreach_giaTableAdapter = null;
            this.tableAdapterManager1.TAIKHOAN_TIMMANVTableAdapter = null;
            this.tableAdapterManager1.TinhTrangTTTableAdapter = null;
            this.tableAdapterManager1.TraGop1TableAdapter = null;
            this.tableAdapterManager1.TraGopTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = nha_tro.ttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // thongKe_SPDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            this.thongKe_SPDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.thongKe_SPDataGridView.AutoGenerateColumns = false;
            this.thongKe_SPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongKe_SPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.thongKe_SPDataGridView.DataSource = this.thongKe_SPBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.thongKe_SPDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.thongKe_SPDataGridView.Location = new System.Drawing.Point(12, 211);
            this.thongKe_SPDataGridView.Name = "thongKe_SPDataGridView";
            this.thongKe_SPDataGridView.Size = new System.Drawing.Size(391, 220);
            this.thongKe_SPDataGridView.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SL Đã Bán";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 464);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng Tiền Bán Được";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xuất file pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thongKe_SPGridControl
            // 
            this.thongKe_SPGridControl.DataSource = this.thongKe_SPBindingSource;
            this.thongKe_SPGridControl.Location = new System.Drawing.Point(456, 12);
            this.thongKe_SPGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.thongKe_SPGridControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.thongKe_SPGridControl.MainView = this.gridView1;
            this.thongKe_SPGridControl.Name = "thongKe_SPGridControl";
            this.thongKe_SPGridControl.Size = new System.Drawing.Size(352, 205);
            this.thongKe_SPGridControl.TabIndex = 13;
            this.thongKe_SPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.thongKe_SPGridControl.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD,
            this.colNGAYLAP,
            this.colSL});
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.GridControl = this.thongKe_SPGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAHD
            // 
            this.colMAHD.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colMAHD.AppearanceHeader.Options.UseBackColor = true;
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 0;
            // 
            // colNGAYLAP
            // 
            this.colNGAYLAP.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colNGAYLAP.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYLAP.FieldName = "NGAYLAP";
            this.colNGAYLAP.Name = "colNGAYLAP";
            this.colNGAYLAP.Visible = true;
            this.colNGAYLAP.VisibleIndex = 1;
            // 
            // colSL
            // 
            this.colSL.AppearanceHeader.BackColor = System.Drawing.Color.Aqua;
            this.colSL.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.colSL.AppearanceHeader.Options.UseBackColor = true;
            this.colSL.FieldName = "SL";
            this.colSL.Name = "colSL";
            this.colSL.Visible = true;
            this.colSL.VisibleIndex = 2;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SL";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 505);
            this.Controls.Add(this.thongKe_SPGridControl);
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
            this.Controls.Add(this.sANPHAMComboBox);
            this.Name = "ThongKeSanPham";
            this.Text = "ThongKeSanPham";
            this.Load += new System.EventHandler(this.ThongKeSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private NghiepVuTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox sANPHAMComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private tt tt;
        private System.Windows.Forms.BindingSource thongKe_SPBindingSource;
        private ttTableAdapters.ThongKe_SPTableAdapter thongKe_SPTableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView thongKe_SPDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.GridControl thongKe_SPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}