namespace nha_tro
{
    partial class LOISX
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
            System.Windows.Forms.Label mALOISXLabel;
            System.Windows.Forms.Label tENLOISXLabel;
            this.nghiepVu = new nha_tro.NghiepVu();
            this.lOIDONHASXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOIDONHASXTableAdapter = new nha_tro.NghiepVuTableAdapters.LOIDONHASXTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.lOIDONHASXDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOISXTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOISXTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            mALOISXLabel = new System.Windows.Forms.Label();
            tENLOISXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONHASXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONHASXDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOISXTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOISXTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOISXLabel
            // 
            mALOISXLabel.AutoSize = true;
            mALOISXLabel.Location = new System.Drawing.Point(12, 57);
            mALOISXLabel.Name = "mALOISXLabel";
            mALOISXLabel.Size = new System.Drawing.Size(57, 13);
            mALOISXLabel.TabIndex = 1;
            mALOISXLabel.Text = "MALOISX:";
            // 
            // tENLOISXLabel
            // 
            tENLOISXLabel.AutoSize = true;
            tENLOISXLabel.Location = new System.Drawing.Point(12, 83);
            tENLOISXLabel.Name = "tENLOISXLabel";
            tENLOISXLabel.Size = new System.Drawing.Size(63, 13);
            tENLOISXLabel.TabIndex = 3;
            tENLOISXLabel.Text = "TENLOISX:";
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOIDONHASXBindingSource
            // 
            this.lOIDONHASXBindingSource.DataMember = "LOIDONHASX";
            this.lOIDONHASXBindingSource.DataSource = this.nghiepVu;
            // 
            // lOIDONHASXTableAdapter
            // 
            this.lOIDONHASXTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LOIDONHASXTableAdapter = this.lOIDONHASXTableAdapter;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANG1TableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOIDONHASXDataGridView
            // 
            this.lOIDONHASXDataGridView.AutoGenerateColumns = false;
            this.lOIDONHASXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOIDONHASXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lOIDONHASXDataGridView.DataSource = this.lOIDONHASXBindingSource;
            this.lOIDONHASXDataGridView.Location = new System.Drawing.Point(12, 135);
            this.lOIDONHASXDataGridView.Name = "lOIDONHASXDataGridView";
            this.lOIDONHASXDataGridView.Size = new System.Drawing.Size(257, 200);
            this.lOIDONHASXDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOISX";
            this.dataGridViewTextBoxColumn1.HeaderText = "MALOISX";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOISX";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENLOISX";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // mALOISXTextEdit
            // 
            this.mALOISXTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOIDONHASXBindingSource, "MALOISX", true));
            this.mALOISXTextEdit.Location = new System.Drawing.Point(81, 54);
            this.mALOISXTextEdit.Name = "mALOISXTextEdit";
            this.mALOISXTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mALOISXTextEdit.TabIndex = 2;
            // 
            // tENLOISXTextEdit
            // 
            this.tENLOISXTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOIDONHASXBindingSource, "TENLOISX", true));
            this.tENLOISXTextEdit.Location = new System.Drawing.Point(81, 80);
            this.tENLOISXTextEdit.Name = "tENLOISXTextEdit";
            this.tENLOISXTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENLOISXTextEdit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "LỖI NHÀ SẢN XUẤT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LOISX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 351);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(mALOISXLabel);
            this.Controls.Add(this.mALOISXTextEdit);
            this.Controls.Add(tENLOISXLabel);
            this.Controls.Add(this.tENLOISXTextEdit);
            this.Controls.Add(this.lOIDONHASXDataGridView);
            this.Name = "LOISX";
            this.Text = "LOISX";
            this.Load += new System.EventHandler(this.LOISX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONHASXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOIDONHASXDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALOISXTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLOISXTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource lOIDONHASXBindingSource;
        private NghiepVuTableAdapters.LOIDONHASXTableAdapter lOIDONHASXTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lOIDONHASXDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.TextEdit mALOISXTextEdit;
        private DevExpress.XtraEditors.TextEdit tENLOISXTextEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}