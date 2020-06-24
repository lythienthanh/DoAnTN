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
            this.mALOISXTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLOISXTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            mALOISXLabel.Size = new System.Drawing.Size(78, 13);
            mALOISXLabel.TabIndex = 1;
            mALOISXLabel.Text = "Mã lỗi sản xuất";
            // 
            // tENLOISXLabel
            // 
            tENLOISXLabel.AutoSize = true;
            tENLOISXLabel.Location = new System.Drawing.Point(12, 83);
            tENLOISXLabel.Name = "tENLOISXLabel";
            tENLOISXLabel.Size = new System.Drawing.Size(82, 13);
            tENLOISXLabel.TabIndex = 3;
            tENLOISXLabel.Text = "Tên lỗi sản xuất";
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
            this.lOIDONHASXDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lOIDONHASXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOIDONHASXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.lOIDONHASXDataGridView.DataSource = this.lOIDONHASXBindingSource;
            this.lOIDONHASXDataGridView.Location = new System.Drawing.Point(12, 178);
            this.lOIDONHASXDataGridView.Name = "lOIDONHASXDataGridView";
            this.lOIDONHASXDataGridView.Size = new System.Drawing.Size(257, 200);
            this.lOIDONHASXDataGridView.TabIndex = 1;
            // 
            // mALOISXTextEdit
            // 
            this.mALOISXTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOIDONHASXBindingSource, "MALOISX", true));
            this.mALOISXTextEdit.Location = new System.Drawing.Point(121, 54);
            this.mALOISXTextEdit.Name = "mALOISXTextEdit";
            this.mALOISXTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mALOISXTextEdit.TabIndex = 2;
            // 
            // tENLOISXTextEdit
            // 
            this.tENLOISXTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOIDONHASXBindingSource, "TENLOISX", true));
            this.tENLOISXTextEdit.Location = new System.Drawing.Point(121, 80);
            this.tENLOISXTextEdit.Name = "tENLOISXTextEdit";
            this.tENLOISXTextEdit.Size = new System.Drawing.Size(147, 20);
            this.tENLOISXTextEdit.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button1.Location = new System.Drawing.Point(15, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 54);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete;
            this.button2.Location = new System.Drawing.Point(110, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 54);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.button3.Location = new System.Drawing.Point(200, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 54);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(280, 42);
            this.button9.TabIndex = 31;
            this.button9.Text = "Lỗi sản xuất";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOISX";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã lỗi sản xuất";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOISX";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên lỗi sản xuất";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // LOISX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 403);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private DevExpress.XtraEditors.TextEdit mALOISXTextEdit;
        private DevExpress.XtraEditors.TextEdit tENLOISXTextEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button9;
    }
}