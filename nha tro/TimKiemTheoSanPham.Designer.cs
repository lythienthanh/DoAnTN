namespace nha_tro
{
    partial class TimKiemTheoSanPham
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
            this.nghiepVu = new nha_tro.NghiepVu();
            this.sANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANPHAMTableAdapter = new nha_tro.NghiepVuTableAdapters.SANPHAMTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.sANPHAMDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // sANPHAMDataGridView
            // 
            this.sANPHAMDataGridView.AutoGenerateColumns = false;
            this.sANPHAMDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sANPHAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sANPHAMDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.sANPHAMDataGridView.DataSource = this.sANPHAMBindingSource;
            this.sANPHAMDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sANPHAMDataGridView.Location = new System.Drawing.Point(0, 137);
            this.sANPHAMDataGridView.Name = "sANPHAMDataGridView";
            this.sANPHAMDataGridView.Size = new System.Drawing.Size(697, 296);
            this.sANPHAMDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MALOAI";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã loại";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MAKHO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã kho";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENSP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TINHTRANG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tình trạng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
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
            this.button9.Size = new System.Drawing.Size(697, 42);
            this.button9.TabIndex = 28;
            this.button9.Text = "Tìm kiếm Sản Phẩm";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 75);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Giá";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(331, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 20);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 20);
            this.textBox2.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Gakuseisean_Aire_Search;
            this.button2.Location = new System.Drawing.Point(520, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 30);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Gakuseisean_Aire_Search;
            this.button1.Location = new System.Drawing.Point(331, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên SP";
            // 
            // TimKiemTheoSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.sANPHAMDataGridView);
            this.Name = "TimKiemTheoSanPham";
            this.Text = "TimKiemTheoSanPham";
            this.Load += new System.EventHandler(this.TimKiemTheoSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANPHAMDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource sANPHAMBindingSource;
        private NghiepVuTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sANPHAMDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}