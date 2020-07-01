namespace nha_tro
{
    partial class TimkiemSPKM
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.kM_TENSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nghiepVu = new nha_tro.NghiepVu();
            this.kHUYENMAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUYENMAITableAdapter = new nha_tro.NghiepVuTableAdapters.KHUYENMAITableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.kM_TENSPTableAdapter = new nha_tro.NghiepVuTableAdapters.KM_TENSPTableAdapter();
            this.mAKHUYENMAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALINHKIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHUYENMAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYBDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIATRIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kM_TENSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kHUYENMAIDataGridView
            // 
            this.kHUYENMAIDataGridView.AutoGenerateColumns = false;
            this.kHUYENMAIDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kHUYENMAIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHUYENMAIDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHUYENMAIDataGridViewTextBoxColumn,
            this.mASPDataGridViewTextBoxColumn,
            this.mALINHKIENDataGridViewTextBoxColumn,
            this.tENKHUYENMAIDataGridViewTextBoxColumn,
            this.nGAYBDDataGridViewTextBoxColumn,
            this.nGAYKTDataGridViewTextBoxColumn,
            this.gIATRIDataGridViewTextBoxColumn,
            this.tENSPDataGridViewTextBoxColumn});
            this.kHUYENMAIDataGridView.DataSource = this.kM_TENSPBindingSource;
            this.kHUYENMAIDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kHUYENMAIDataGridView.Location = new System.Drawing.Point(0, 148);
            this.kHUYENMAIDataGridView.Name = "kHUYENMAIDataGridView";
            this.kHUYENMAIDataGridView.Size = new System.Drawing.Size(723, 254);
            this.kHUYENMAIDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên SP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Gakuseisean_Aire_Search;
            this.button1.Location = new System.Drawing.Point(313, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
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
            this.button9.Size = new System.Drawing.Size(723, 42);
            this.button9.TabIndex = 29;
            this.button9.Text = "Tìm kiếm Sản Phẩm Khuyến Mãi";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // kM_TENSPBindingSource
            // 
            this.kM_TENSPBindingSource.DataMember = "KM_TENSP";
            this.kM_TENSPBindingSource.DataSource = this.nghiepVu;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUYENMAIBindingSource
            // 
            this.kHUYENMAIBindingSource.DataMember = "KHUYENMAI";
            this.kHUYENMAIBindingSource.DataSource = this.nghiepVu;
            // 
            // kHUYENMAITableAdapter
            // 
            this.kHUYENMAITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHUYENMAI_lk_malkTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = this.kHUYENMAITableAdapter;
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
            // kM_TENSPTableAdapter
            // 
            this.kM_TENSPTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHUYENMAIDataGridViewTextBoxColumn
            // 
            this.mAKHUYENMAIDataGridViewTextBoxColumn.DataPropertyName = "MAKHUYENMAI";
            this.mAKHUYENMAIDataGridViewTextBoxColumn.HeaderText = "Mã KM";
            this.mAKHUYENMAIDataGridViewTextBoxColumn.Name = "mAKHUYENMAIDataGridViewTextBoxColumn";
            // 
            // mASPDataGridViewTextBoxColumn
            // 
            this.mASPDataGridViewTextBoxColumn.DataPropertyName = "MASP";
            this.mASPDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.mASPDataGridViewTextBoxColumn.Name = "mASPDataGridViewTextBoxColumn";
            // 
            // mALINHKIENDataGridViewTextBoxColumn
            // 
            this.mALINHKIENDataGridViewTextBoxColumn.DataPropertyName = "MALINHKIEN";
            this.mALINHKIENDataGridViewTextBoxColumn.HeaderText = "Mã LK";
            this.mALINHKIENDataGridViewTextBoxColumn.Name = "mALINHKIENDataGridViewTextBoxColumn";
            // 
            // tENKHUYENMAIDataGridViewTextBoxColumn
            // 
            this.tENKHUYENMAIDataGridViewTextBoxColumn.DataPropertyName = "TENKHUYENMAI";
            this.tENKHUYENMAIDataGridViewTextBoxColumn.HeaderText = "Tên KM";
            this.tENKHUYENMAIDataGridViewTextBoxColumn.Name = "tENKHUYENMAIDataGridViewTextBoxColumn";
            // 
            // nGAYBDDataGridViewTextBoxColumn
            // 
            this.nGAYBDDataGridViewTextBoxColumn.DataPropertyName = "NGAYBD";
            this.nGAYBDDataGridViewTextBoxColumn.HeaderText = "Ngày BD";
            this.nGAYBDDataGridViewTextBoxColumn.Name = "nGAYBDDataGridViewTextBoxColumn";
            // 
            // nGAYKTDataGridViewTextBoxColumn
            // 
            this.nGAYKTDataGridViewTextBoxColumn.DataPropertyName = "NGAYKT";
            this.nGAYKTDataGridViewTextBoxColumn.HeaderText = "Ngày KT";
            this.nGAYKTDataGridViewTextBoxColumn.Name = "nGAYKTDataGridViewTextBoxColumn";
            // 
            // gIATRIDataGridViewTextBoxColumn
            // 
            this.gIATRIDataGridViewTextBoxColumn.DataPropertyName = "GIATRI";
            this.gIATRIDataGridViewTextBoxColumn.HeaderText = "Giá trị";
            this.gIATRIDataGridViewTextBoxColumn.Name = "gIATRIDataGridViewTextBoxColumn";
            // 
            // tENSPDataGridViewTextBoxColumn
            // 
            this.tENSPDataGridViewTextBoxColumn.DataPropertyName = "TENSP";
            this.tENSPDataGridViewTextBoxColumn.HeaderText = "Tên SP";
            this.tENSPDataGridViewTextBoxColumn.Name = "tENSPDataGridViewTextBoxColumn";
            // 
            // TimkiemSPKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 402);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kHUYENMAIDataGridView);
            this.Name = "TimkiemSPKM";
            this.Text = "TimkiemSPKM";
            this.Load += new System.EventHandler(this.TimkiemSPKM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kM_TENSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource;
        private NghiepVuTableAdapters.KHUYENMAITableAdapter kHUYENMAITableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHUYENMAIDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource kM_TENSPBindingSource;
        private NghiepVuTableAdapters.KM_TENSPTableAdapter kM_TENSPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHUYENMAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mASPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALINHKIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHUYENMAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYBDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIATRIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSPDataGridViewTextBoxColumn;
    }
}