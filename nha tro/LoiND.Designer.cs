namespace nha_tro
{
    partial class LoiND
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
            System.Windows.Forms.Label mALOINDLabel;
            System.Windows.Forms.Label tENLOINDLabel;
            this.nghiepVu = new nha_tro.NghiepVu();
            this.lOIDONGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOIDONGUOIDUNGTableAdapter = new nha_tro.NghiepVuTableAdapters.LOIDONGUOIDUNGTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.lOIDONGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOINDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOINDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            mALOINDLabel = new System.Windows.Forms.Label();
            tENLOINDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOINDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOINDTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOINDLabel
            // 
            mALOINDLabel.AutoSize = true;
            mALOINDLabel.Location = new System.Drawing.Point(30, 54);
            mALOINDLabel.Name = "mALOINDLabel";
            mALOINDLabel.Size = new System.Drawing.Size(59, 13);
            mALOINDLabel.TabIndex = 1;
            mALOINDLabel.Text = "MALOIND:";
            // 
            // tENLOINDLabel
            // 
            tENLOINDLabel.AutoSize = true;
            tENLOINDLabel.Location = new System.Drawing.Point(30, 80);
            tENLOINDLabel.Name = "tENLOINDLabel";
            tENLOINDLabel.Size = new System.Drawing.Size(65, 13);
            tENLOINDLabel.TabIndex = 3;
            tENLOINDLabel.Text = "TENLOIND:";
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOIDONGUOIDUNGBindingSource
            // 
            this.lOIDONGUOIDUNGBindingSource.DataMember = "LOIDONGUOIDUNG";
            this.lOIDONGUOIDUNGBindingSource.DataSource = this.nghiepVu;
            // 
            // lOIDONGUOIDUNGTableAdapter
            // 
            this.lOIDONGUOIDUNGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOIDONGUOIDUNGTableAdapter = this.lOIDONGUOIDUNGTableAdapter;
            this.tableAdapterManager.LOIDONHASXTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANG1TableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOIDONGUOIDUNGDataGridView
            // 
            this.lOIDONGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.lOIDONGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOIDONGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lOIDONGUOIDUNGDataGridView.DataSource = this.lOIDONGUOIDUNGBindingSource;
            this.lOIDONGUOIDUNGDataGridView.Location = new System.Drawing.Point(25, 153);
            this.lOIDONGUOIDUNGDataGridView.Name = "lOIDONGUOIDUNGDataGridView";
            this.lOIDONGUOIDUNGDataGridView.Size = new System.Drawing.Size(248, 220);
            this.lOIDONGUOIDUNGDataGridView.TabIndex = 0;
            this.lOIDONGUOIDUNGDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lOIDONGUOIDUNGDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOIND";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALOIND";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOIND";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENLOIND";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // mALOINDTextEdit
            // 
            this.mALOINDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOIDONGUOIDUNGBindingSource, "MALOIND", true));
            this.mALOINDTextEdit.Location = new System.Drawing.Point(101, 51);
            this.mALOINDTextEdit.Name = "mALOINDTextEdit";
            this.mALOINDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mALOINDTextEdit.TabIndex = 2;
            // 
            // tENLOINDTextEdit
            // 
            this.tENLOINDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOIDONGUOIDUNGBindingSource, "TENLOIND", true));
            this.tENLOINDTextEdit.Location = new System.Drawing.Point(101, 77);
            this.tENLOINDTextEdit.Name = "tENLOINDTextEdit";
            this.tENLOINDTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENLOINDTextEdit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lỗi người dùng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoiND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 396);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(mALOINDLabel);
            this.Controls.Add(this.mALOINDTextEdit);
            this.Controls.Add(tENLOINDLabel);
            this.Controls.Add(this.tENLOINDTextEdit);
            this.Controls.Add(this.lOIDONGUOIDUNGDataGridView);
            this.Name = "LoiND";
            this.Text = "LoiND";
            this.Load += new System.EventHandler(this.LoiND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOINDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOINDTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource lOIDONGUOIDUNGBindingSource;
        private NghiepVuTableAdapters.LOIDONGUOIDUNGTableAdapter lOIDONGUOIDUNGTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lOIDONGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.TextEdit mALOINDTextEdit;
        private DevExpress.XtraEditors.TextEdit tENLOINDTextEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}