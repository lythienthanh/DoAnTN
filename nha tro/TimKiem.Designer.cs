namespace nha_tro
{
    partial class TimKiem
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
            this.timKiemChuaNhanhDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.timKiemChuaNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nghiepVu = new nha_tro.NghiepVu();
            this.timKiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timKiemTableAdapter = new nha_tro.NghiepVuTableAdapters.TimKiemTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.timKiemChuaNhanhTableAdapter = new nha_tro.NghiepVuTableAdapters.TimKiemChuaNhanhTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemChuaNhanhDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemChuaNhanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timKiemChuaNhanhDataGridView
            // 
            this.timKiemChuaNhanhDataGridView.AutoGenerateColumns = false;
            this.timKiemChuaNhanhDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timKiemChuaNhanhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timKiemChuaNhanhDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.timKiemChuaNhanhDataGridView.DataSource = this.timKiemChuaNhanhBindingSource;
            this.timKiemChuaNhanhDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timKiemChuaNhanhDataGridView.Location = new System.Drawing.Point(0, 117);
            this.timKiemChuaNhanhDataGridView.Name = "timKiemChuaNhanhDataGridView";
            this.timKiemChuaNhanhDataGridView.Size = new System.Drawing.Size(1014, 301);
            this.timKiemChuaNhanhDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Gakuseisean_Aire_Search;
            this.button1.Location = new System.Drawing.Point(179, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = global::nha_tro.Properties.Resources.Gakuseisean_Aire_Search;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(1014, 42);
            this.button9.TabIndex = 27;
            this.button9.Text = "Tìm kiếm thông tin khách hàng";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // timKiemChuaNhanhBindingSource
            // 
            this.timKiemChuaNhanhBindingSource.DataMember = "TimKiemChuaNhanh";
            this.timKiemChuaNhanhBindingSource.DataSource = this.nghiepVu;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timKiemBindingSource
            // 
            this.timKiemBindingSource.DataMember = "TimKiem";
            this.timKiemBindingSource.DataSource = this.nghiepVu;
            // 
            // timKiemTableAdapter
            // 
            this.timKiemTableAdapter.ClearBeforeFill = true;
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
            // timKiemChuaNhanhTableAdapter
            // 
            this.timKiemChuaNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaSP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tên khuyến mãi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn6.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn7.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MALOAIHD";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mã loại hóa đơn";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NGAYLAP";
            this.dataGridViewTextBoxColumn10.HeaderText = "Ngày lập";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MaTraGop";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mã trả góp";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaNV";
            this.dataGridViewTextBoxColumn12.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Số Lượng";
            this.dataGridViewTextBoxColumn15.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn16.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 418);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timKiemChuaNhanhDataGridView);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timKiemChuaNhanhDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemChuaNhanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource timKiemBindingSource;
        private NghiepVuTableAdapters.TimKiemTableAdapter timKiemTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource timKiemChuaNhanhBindingSource;
        private NghiepVuTableAdapters.TimKiemChuaNhanhTableAdapter timKiemChuaNhanhTableAdapter;
        private System.Windows.Forms.DataGridView timKiemChuaNhanhDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}