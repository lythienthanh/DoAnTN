namespace nha_tro
{
    partial class PhanQuyen
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
            this.dataTable_dkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DangNhap = new nha_tro.DS_DangNhap();
            this.pHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter = new nha_tro.DS_DangNhapTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new nha_tro.DS_DangNhapTableAdapters.TableAdapterManager();
            this.pHANQUYENTableAdapter = new nha_tro.DS_DangNhapTableAdapters.PHANQUYENTableAdapter();
            this.dataTable_dkTableAdapter = new nha_tro.DS_DangNhapTableAdapters.DataTable_dkTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.mANHOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNHOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phanQuyenDKDataGridView = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coQuyenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_dkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable_dkBindingSource
            // 
            this.dataTable_dkBindingSource.DataMember = "DataTable_dk";
            this.dataTable_dkBindingSource.DataSource = this.dS_DangNhap;
            // 
            // dS_DangNhap
            // 
            this.dS_DangNhap.DataSetName = "DS_DangNhap";
            this.dS_DangNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHANQUYENBindingSource
            // 
            this.pHANQUYENBindingSource.DataMember = "PHANQUYEN";
            this.pHANQUYENBindingSource.DataSource = this.dS_DangNhap;
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.dS_DangNhap;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNG_DKTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = this.pHANQUYENTableAdapter;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.tk_NND_DKTableAdapter = null;
            this.tableAdapterManager.tk_NNDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.DS_DangNhapTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pHANQUYENTableAdapter
            // 
            this.pHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable_dkTableAdapter
            // 
            this.dataTable_dkTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nhomNguoiDungDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 237);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhóm người dùng";
            // 
            // nhomNguoiDungDataGridView
            // 
            this.nhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.nhomNguoiDungDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANHOMDataGridViewTextBoxColumn,
            this.tENNHOMDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.nhomNguoiDungDataGridView.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nhomNguoiDungDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(3, 16);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(323, 218);
            this.nhomNguoiDungDataGridView.TabIndex = 4;
            this.nhomNguoiDungDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhomNguoiDungDataGridView_CellClick);
            // 
            // mANHOMDataGridViewTextBoxColumn
            // 
            this.mANHOMDataGridViewTextBoxColumn.DataPropertyName = "MANHOM";
            this.mANHOMDataGridViewTextBoxColumn.HeaderText = "Mã nhóm";
            this.mANHOMDataGridViewTextBoxColumn.Name = "mANHOMDataGridViewTextBoxColumn";
            // 
            // tENNHOMDataGridViewTextBoxColumn
            // 
            this.tENNHOMDataGridViewTextBoxColumn.DataPropertyName = "TENNHOM";
            this.tENNHOMDataGridViewTextBoxColumn.HeaderText = "Tên nhóm";
            this.tENNHOMDataGridViewTextBoxColumn.Name = "tENNHOMDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phanQuyenDKDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(377, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 237);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấp quyền cho người dùng xem màn hình ";
            // 
            // phanQuyenDKDataGridView
            // 
            this.phanQuyenDKDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDKDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.phanQuyenDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaManHinh,
            this.TenManHinh,
            this.coQuyenDataGridViewCheckBoxColumn});
            this.phanQuyenDKDataGridView.DataSource = this.dataTable_dkBindingSource;
            this.phanQuyenDKDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phanQuyenDKDataGridView.Location = new System.Drawing.Point(3, 16);
            this.phanQuyenDKDataGridView.Name = "phanQuyenDKDataGridView";
            this.phanQuyenDKDataGridView.Size = new System.Drawing.Size(406, 218);
            this.phanQuyenDKDataGridView.TabIndex = 4;
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
            this.button9.Size = new System.Drawing.Size(801, 42);
            this.button9.TabIndex = 31;
            this.button9.Text = "CẤP QUYỀN CHO NHÓM NGƯỜI DÙNG";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_save;
            this.button1.Location = new System.Drawing.Point(707, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 44);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaManHinh
            // 
            this.MaManHinh.DataPropertyName = "MaManHinh";
            this.MaManHinh.HeaderText = "Mã màn hình";
            this.MaManHinh.Name = "MaManHinh";
            // 
            // TenManHinh
            // 
            this.TenManHinh.DataPropertyName = "TenManHinh";
            this.TenManHinh.HeaderText = "Tên màn hình";
            this.TenManHinh.Name = "TenManHinh";
            // 
            // coQuyenDataGridViewCheckBoxColumn
            // 
            this.coQuyenDataGridViewCheckBoxColumn.DataPropertyName = "CoQuyen";
            this.coQuyenDataGridViewCheckBoxColumn.HeaderText = "Có quyền";
            this.coQuyenDataGridViewCheckBoxColumn.Name = "coQuyenDataGridViewCheckBoxColumn";
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Name = "PhanQuyen";
            this.Text = "CẤP QUYỀN CHO NHÓM NGƯỜI DÙNG";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_dkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DS_DangNhap dS_DangNhap;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private DS_DangNhapTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private DS_DangNhapTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_DangNhapTableAdapters.PHANQUYENTableAdapter pHANQUYENTableAdapter;
        private System.Windows.Forms.BindingSource pHANQUYENBindingSource;
        private System.Windows.Forms.BindingSource dataTable_dkBindingSource;
        private DS_DangNhapTableAdapters.DataTable_dkTableAdapter dataTable_dkTableAdapter;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView nhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNHOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView phanQuyenDKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn maManHinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenManHinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenManHinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coQuyenDataGridViewCheckBoxColumn;
    }
}