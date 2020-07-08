namespace nha_tro
{
    partial class NhaCungCap
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
            System.Windows.Forms.Label mANCCLabel;
            System.Windows.Forms.Label tENNCCLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label sDTLabel;
            this.mANCCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nghiepVu = new nha_tro.NghiepVu();
            this.tENNCCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nHACUNGCAPDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.nHACUNGCAPTableAdapter = new nha_tro.NghiepVuTableAdapters.NHACUNGCAPTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.button9 = new System.Windows.Forms.Button();
            mANCCLabel = new System.Windows.Forms.Label();
            tENNCCLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mANCCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNCCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mANCCLabel
            // 
            mANCCLabel.AutoSize = true;
            mANCCLabel.Location = new System.Drawing.Point(89, 80);
            mANCCLabel.Name = "mANCCLabel";
            mANCCLabel.Size = new System.Drawing.Size(91, 13);
            mANCCLabel.TabIndex = 0;
            mANCCLabel.Text = "Mã nhà cung cấp";
            // 
            // tENNCCLabel
            // 
            tENNCCLabel.AutoSize = true;
            tENNCCLabel.Location = new System.Drawing.Point(89, 110);
            tENNCCLabel.Name = "tENNCCLabel";
            tENNCCLabel.Size = new System.Drawing.Size(95, 13);
            tENNCCLabel.TabIndex = 2;
            tENNCCLabel.Text = "Tên nhà cung cấp";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(89, 136);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(40, 13);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(89, 162);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(32, 13);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "SDT:";
            // 
            // mANCCTextEdit
            // 
            this.mANCCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "MANCC", true));
            this.mANCCTextEdit.Location = new System.Drawing.Point(194, 77);
            this.mANCCTextEdit.Name = "mANCCTextEdit";
            this.mANCCTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mANCCTextEdit.TabIndex = 1;
            // 
            // nHACUNGCAPBindingSource
            // 
            this.nHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.nHACUNGCAPBindingSource.DataSource = this.nghiepVu;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tENNCCTextEdit
            // 
            this.tENNCCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "TENNCC", true));
            this.tENNCCTextEdit.Location = new System.Drawing.Point(194, 103);
            this.tENNCCTextEdit.Name = "tENNCCTextEdit";
            this.tENNCCTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENNCCTextEdit.TabIndex = 3;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(194, 129);
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(100, 20);
            this.dIACHITextEdit.TabIndex = 5;
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHACUNGCAPBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(194, 155);
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(100, 20);
            this.sDTTextEdit.TabIndex = 7;
            // 
            // nHACUNGCAPDataGridView
            // 
            this.nHACUNGCAPDataGridView.AutoGenerateColumns = false;
            this.nHACUNGCAPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nHACUNGCAPDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.nHACUNGCAPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHACUNGCAPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nHACUNGCAPDataGridView.DataSource = this.nHACUNGCAPBindingSource;
            this.nHACUNGCAPDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHACUNGCAPDataGridView.Location = new System.Drawing.Point(3, 16);
            this.nHACUNGCAPDataGridView.Name = "nHACUNGCAPDataGridView";
            this.nHACUNGCAPDataGridView.Size = new System.Drawing.Size(592, 222);
            this.nHACUNGCAPDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhà cung cấp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNCC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhà cung cấp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nHACUNGCAPDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(347, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 241);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button1.Location = new System.Drawing.Point(91, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete;
            this.button2.Location = new System.Drawing.Point(169, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.button3.Location = new System.Drawing.Point(248, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 46);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nHACUNGCAPTableAdapter
            // 
            this.nHACUNGCAPTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LAY_MANVbangTENDNTableAdapter = null;
            this.tableAdapterManager.LINHKIENTableAdapter = null;
            this.tableAdapterManager.LOAIHOADONTableAdapter = null;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.LOIDONGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.LOIDONHASXTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = this.nHACUNGCAPTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANG1TableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.NghiepVuTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = global::nha_tro.Properties.Resources.Double_J_Design_Ravenna_3d_Home;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(982, 42);
            this.button9.TabIndex = 30;
            this.button9.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 330);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(mANCCLabel);
            this.Controls.Add(this.mANCCTextEdit);
            this.Controls.Add(tENNCCLabel);
            this.Controls.Add(this.tENNCCTextEdit);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.dIACHITextEdit);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextEdit);
            this.Name = "NhaCungCap";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mANCCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNCCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHACUNGCAPDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource nHACUNGCAPBindingSource;
        private NghiepVuTableAdapters.NHACUNGCAPTableAdapter nHACUNGCAPTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit mANCCTextEdit;
        private DevExpress.XtraEditors.TextEdit tENNCCTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private System.Windows.Forms.DataGridView nHACUNGCAPDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button9;
    }
}