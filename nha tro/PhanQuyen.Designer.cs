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
            this.button1 = new System.Windows.Forms.Button();
            this.phanQuyenDKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataTable_dkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DangNhap = new nha_tro.DS_DangNhap();
            this.pHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNGTableAdapter = new nha_tro.DS_DangNhapTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new nha_tro.DS_DangNhapTableAdapters.TableAdapterManager();
            this.pHANQUYENTableAdapter = new nha_tro.DS_DangNhapTableAdapters.PHANQUYENTableAdapter();
            this.dataTable_dkTableAdapter = new nha_tro.DS_DangNhapTableAdapters.DataTable_dkTableAdapter();
            this.mANHOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNHOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maManHinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenManHinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coQuyenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_dkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phanQuyenDKDataGridView
            // 
            this.phanQuyenDKDataGridView.AutoGenerateColumns = false;
            this.phanQuyenDKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phanQuyenDKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maManHinhDataGridViewTextBoxColumn,
            this.tenManHinhDataGridViewTextBoxColumn,
            this.coQuyenDataGridViewCheckBoxColumn});
            this.phanQuyenDKDataGridView.DataSource = this.dataTable_dkBindingSource;
            this.phanQuyenDKDataGridView.Location = new System.Drawing.Point(347, 41);
            this.phanQuyenDKDataGridView.Name = "phanQuyenDKDataGridView";
            this.phanQuyenDKDataGridView.Size = new System.Drawing.Size(442, 220);
            this.phanQuyenDKDataGridView.TabIndex = 3;
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
            // nhomNguoiDungDataGridView
            // 
            this.nhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.nhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANHOMDataGridViewTextBoxColumn,
            this.tENNHOMDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.nhomNguoiDungDataGridView.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 41);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(329, 220);
            this.nhomNguoiDungDataGridView.TabIndex = 3;
            this.nhomNguoiDungDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhomNguoiDungDataGridView_CellClick);
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
            // maManHinhDataGridViewTextBoxColumn
            // 
            this.maManHinhDataGridViewTextBoxColumn.DataPropertyName = "MaManHinh";
            this.maManHinhDataGridViewTextBoxColumn.HeaderText = "Mã màn hình";
            this.maManHinhDataGridViewTextBoxColumn.Name = "maManHinhDataGridViewTextBoxColumn";
            // 
            // tenManHinhDataGridViewTextBoxColumn
            // 
            this.tenManHinhDataGridViewTextBoxColumn.DataPropertyName = "TenManHinh";
            this.tenManHinhDataGridViewTextBoxColumn.HeaderText = "Tên màn hình";
            this.tenManHinhDataGridViewTextBoxColumn.Name = "tenManHinhDataGridViewTextBoxColumn";
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
            this.ClientSize = new System.Drawing.Size(801, 271);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Controls.Add(this.phanQuyenDKDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phanQuyenDKDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_dkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHANQUYENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView phanQuyenDKDataGridView;
        private System.Windows.Forms.DataGridView nhomNguoiDungDataGridView;
        private DS_DangNhap dS_DangNhap;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private DS_DangNhapTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private DS_DangNhapTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_DangNhapTableAdapters.PHANQUYENTableAdapter pHANQUYENTableAdapter;
        private System.Windows.Forms.BindingSource pHANQUYENBindingSource;
        private System.Windows.Forms.BindingSource dataTable_dkBindingSource;
        private DS_DangNhapTableAdapters.DataTable_dkTableAdapter dataTable_dkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maManHinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenManHinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coQuyenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNHOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}