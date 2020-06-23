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
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new nha_tro.DS_DangNhapTableAdapters.NHANVIENTableAdapter();
            this.nHANVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nghiepVu = new nha_tro.NghiepVu();
            this.nHANVIENBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter1 = new nha_tro.NghiepVuTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager1 = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.nHANVIENComboBox = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tAIKHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            tENDANGNHAPLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mATKHAULabel = new System.Windows.Forms.Label();
            hOATDONGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENDANGNHAPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATKHAUTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOATDONGCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tENDANGNHAPLabel
            // 
            tENDANGNHAPLabel.AutoSize = true;
            tENDANGNHAPLabel.Location = new System.Drawing.Point(12, 129);
            tENDANGNHAPLabel.Name = "tENDANGNHAPLabel";
            tENDANGNHAPLabel.Size = new System.Drawing.Size(90, 13);
            tENDANGNHAPLabel.TabIndex = 10;
            tENDANGNHAPLabel.Text = "Tên Đăng Nhập: ";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(12, 155);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(85, 13);
            mANVLabel.TabIndex = 12;
            mANVLabel.Text = "Chọn Nhân Viên";
            // 
            // mATKHAULabel
            // 
            mATKHAULabel.AutoSize = true;
            mATKHAULabel.Location = new System.Drawing.Point(12, 181);
            mATKHAULabel.Name = "mATKHAULabel";
            mATKHAULabel.Size = new System.Drawing.Size(59, 13);
            mATKHAULabel.TabIndex = 14;
            mATKHAULabel.Text = "Mật Khẩu: ";
            // 
            // hOATDONGLabel
            // 
            hOATDONGLabel.AutoSize = true;
            hOATDONGLabel.Location = new System.Drawing.Point(12, 207);
            hOATDONGLabel.Name = "hOATDONGLabel";
            hOATDONGLabel.Size = new System.Drawing.Size(65, 13);
            hOATDONGLabel.TabIndex = 16;
            hOATDONGLabel.Text = "Hoạt Động: ";
            // 
            // Thêm
            // 
            this.Thêm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thêm.Image = global::nha_tro.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.Thêm.Location = new System.Drawing.Point(11, 232);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(60, 46);
            this.Thêm.TabIndex = 7;
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete;
            this.button2.Location = new System.Drawing.Point(90, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.button3.Location = new System.Drawing.Point(175, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 46);
            this.button3.TabIndex = 9;
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
            this.tENDANGNHAPTextEdit.Location = new System.Drawing.Point(111, 126);
            this.tENDANGNHAPTextEdit.Name = "tENDANGNHAPTextEdit";
            this.tENDANGNHAPTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENDANGNHAPTextEdit.TabIndex = 11;
            // 
            // mATKHAUTextEdit
            // 
            this.mATKHAUTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "MATKHAU", true));
            this.mATKHAUTextEdit.Location = new System.Drawing.Point(111, 178);
            this.mATKHAUTextEdit.Name = "mATKHAUTextEdit";
            this.mATKHAUTextEdit.Properties.PasswordChar = '*';
            this.mATKHAUTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mATKHAUTextEdit.TabIndex = 15;
            // 
            // hOATDONGCheckEdit
            // 
            this.hOATDONGCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tAIKHOANBindingSource, "HOATDONG", true));
            this.hOATDONGCheckEdit.Location = new System.Drawing.Point(111, 204);
            this.hOATDONGCheckEdit.Name = "hOATDONGCheckEdit";
            this.hOATDONGCheckEdit.Properties.Caption = "Có";
            this.hOATDONGCheckEdit.Size = new System.Drawing.Size(100, 20);
            this.hOATDONGCheckEdit.TabIndex = 17;
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
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Custom_Icon_Design_Mono_General_1_Add;
            this.button1.Location = new System.Drawing.Point(767, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "Thêm Nhân Viên";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.nHANVIENComboBox.Location = new System.Drawing.Point(111, 151);
            this.nHANVIENComboBox.Name = "nHANVIENComboBox";
            this.nHANVIENComboBox.Size = new System.Drawing.Size(100, 21);
            this.nHANVIENComboBox.TabIndex = 19;
            this.nHANVIENComboBox.ValueMember = "MANV";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = global::nha_tro.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(1303, 42);
            this.button9.TabIndex = 29;
            this.button9.Text = "Thêm Tài Khoản Cho Nhân Viên";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tAIKHOANGridControl);
            this.groupBox1.Location = new System.Drawing.Point(316, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 223);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // tAIKHOANGridControl
            // 
            this.tAIKHOANGridControl.DataSource = this.tAIKHOANBindingSource;
            this.tAIKHOANGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAIKHOANGridControl.Location = new System.Drawing.Point(3, 16);
            this.tAIKHOANGridControl.MainView = this.gridView1;
            this.tAIKHOANGridControl.Name = "tAIKHOANGridControl";
            this.tAIKHOANGridControl.Size = new System.Drawing.Size(439, 204);
            this.tAIKHOANGridControl.TabIndex = 18;
            this.tAIKHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.tAIKHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên đăng nhập";
            this.gridColumn1.FieldName = "TENDANGNHAP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã nhân viên";
            this.gridColumn2.FieldName = "MANV";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mật khẩu";
            this.gridColumn3.FieldName = "MATKHAU";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hoạt động";
            this.gridColumn4.FieldName = "HOATDONG";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nHANVIENGridControl);
            this.groupBox2.Location = new System.Drawing.Point(764, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 219);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(3, 16);
            this.nHANVIENGridControl.MainView = this.gridView2;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(521, 200);
            this.nHANVIENGridControl.TabIndex = 18;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn10,
            this.gridColumn7,
            this.gridColumn11,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView2.GridControl = this.nHANVIENGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã Nhân Viên";
            this.gridColumn5.FieldName = "MANV";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Họ và Tên";
            this.gridColumn6.FieldName = "HOTEN";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Giới Tính";
            this.gridColumn10.FieldName = "GIOITINH";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Ngày Sinh";
            this.gridColumn7.FieldName = "NGAYSINH";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "CMND";
            this.gridColumn11.FieldName = "CMND";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Địa Chỉ";
            this.gridColumn8.FieldName = "DIACHI";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "SĐT";
            this.gridColumn9.FieldName = "SDT";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            // 
            // ThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.nHANVIENComboBox);
            this.Controls.Add(this.button1);
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
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private DS_DangNhapTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource1;
        private System.Windows.Forms.Button button1;
        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource2;
        private NghiepVuTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter1;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox nHANVIENComboBox;
        private System.Windows.Forms.Button button9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl tAIKHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}