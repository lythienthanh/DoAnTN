namespace nha_tro
{
    partial class QuanLyKhachHang
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label cMNDLabel;
            this.kHACHHANGDataGridView = new System.Windows.Forms.DataGridView();
            this.mAKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sDTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nghiepVu = new nha_tro.NghiepVu();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGTableAdapter = new nha_tro.NghiepVuTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.kHACHHANG_thanthietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHHANG_thanthietTableAdapter = new nha_tro.NghiepVuTableAdapters.KHACHHANG_thanthietTableAdapter();
            this.kHACHHANG_thanthietDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            mAKHLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANG_thanthietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANG_thanthietDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(761, 163);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(88, 13);
            mAKHLabel.TabIndex = 1;
            mAKHLabel.Text = "Mã khách hàng: ";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(761, 189);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(89, 13);
            tENKHLabel.TabIndex = 3;
            tENKHLabel.Text = "Tên khách hàng:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(761, 215);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(32, 13);
            sDTLabel.TabIndex = 5;
            sDTLabel.Text = "SDT:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(761, 241);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(43, 13);
            dIACHILabel.TabIndex = 7;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(761, 267);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(42, 13);
            cMNDLabel.TabIndex = 9;
            cMNDLabel.Text = "CMND:";
            // 
            // kHACHHANGDataGridView
            // 
            this.kHACHHANGDataGridView.AutoGenerateColumns = false;
            this.kHACHHANGDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kHACHHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.kHACHHANGDataGridView.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGDataGridView.Location = new System.Drawing.Point(12, 163);
            this.kHACHHANGDataGridView.Name = "kHACHHANGDataGridView";
            this.kHACHHANGDataGridView.Size = new System.Drawing.Size(729, 220);
            this.kHACHHANGDataGridView.TabIndex = 1;
            // 
            // mAKHTextEdit
            // 
            this.mAKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "MAKH", true));
            this.mAKHTextEdit.Location = new System.Drawing.Point(855, 160);
            this.mAKHTextEdit.Name = "mAKHTextEdit";
            this.mAKHTextEdit.Size = new System.Drawing.Size(146, 20);
            this.mAKHTextEdit.TabIndex = 2;
            // 
            // tENKHTextEdit
            // 
            this.tENKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "TENKH", true));
            this.tENKHTextEdit.Location = new System.Drawing.Point(855, 186);
            this.tENKHTextEdit.Name = "tENKHTextEdit";
            this.tENKHTextEdit.Size = new System.Drawing.Size(146, 20);
            this.tENKHTextEdit.TabIndex = 4;
            // 
            // sDTTextEdit
            // 
            this.sDTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "SDT", true));
            this.sDTTextEdit.Location = new System.Drawing.Point(855, 212);
            this.sDTTextEdit.Name = "sDTTextEdit";
            this.sDTTextEdit.Size = new System.Drawing.Size(146, 20);
            this.sDTTextEdit.TabIndex = 6;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(855, 238);
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(146, 20);
            this.dIACHITextEdit.TabIndex = 8;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(855, 264);
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Size = new System.Drawing.Size(146, 20);
            this.cMNDTextEdit.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button1.Location = new System.Drawing.Point(764, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete;
            this.button2.Location = new System.Drawing.Point(830, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.button3.Location = new System.Drawing.Point(896, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 46);
            this.button3.TabIndex = 11;
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
            this.button9.Image = global::nha_tro.Properties.Resources.User_Group_icon;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(1027, 134);
            this.button9.TabIndex = 32;
            this.button9.Text = "Quản Lý Khách Hàng";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kHACHHANG_thanthietDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 305);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng thân thiết";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.nghiepVu;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn5.HeaderText = "Chứng minh nhân dân";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
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
            // kHACHHANG_thanthietBindingSource
            // 
            this.kHACHHANG_thanthietBindingSource.DataMember = "KHACHHANG_thanthiet";
            this.kHACHHANG_thanthietBindingSource.DataSource = this.nghiepVu;
            // 
            // kHACHHANG_thanthietTableAdapter
            // 
            this.kHACHHANG_thanthietTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANG_thanthietDataGridView
            // 
            this.kHACHHANG_thanthietDataGridView.AutoGenerateColumns = false;
            this.kHACHHANG_thanthietDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kHACHHANG_thanthietDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANG_thanthietDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.kHACHHANG_thanthietDataGridView.DataSource = this.kHACHHANG_thanthietBindingSource;
            this.kHACHHANG_thanthietDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kHACHHANG_thanthietDataGridView.Location = new System.Drawing.Point(3, 16);
            this.kHACHHANG_thanthietDataGridView.Name = "kHACHHANG_thanthietDataGridView";
            this.kHACHHANG_thanthietDataGridView.Size = new System.Drawing.Size(983, 286);
            this.kHACHHANG_thanthietDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Danh sách khách hàng";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn6.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TENKH";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn8.HeaderText = "SDT";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn9.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CMND";
            this.dataGridViewTextBoxColumn10.HeaderText = "CMND";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Số lần mua";
            this.dataGridViewTextBoxColumn11.HeaderText = "Số lần mua";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // QuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(mAKHLabel);
            this.Controls.Add(this.mAKHTextEdit);
            this.Controls.Add(tENKHLabel);
            this.Controls.Add(this.tENKHTextEdit);
            this.Controls.Add(sDTLabel);
            this.Controls.Add(this.sDTTextEdit);
            this.Controls.Add(dIACHILabel);
            this.Controls.Add(this.dIACHITextEdit);
            this.Controls.Add(cMNDLabel);
            this.Controls.Add(this.cMNDTextEdit);
            this.Controls.Add(this.kHACHHANGDataGridView);
            this.Name = "QuanLyKhachHang";
            this.Text = "QuanLyKhachHang";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sDTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANG_thanthietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANG_thanthietDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private NghiepVuTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView kHACHHANGDataGridView;
        private DevExpress.XtraEditors.TextEdit mAKHTextEdit;
        private DevExpress.XtraEditors.TextEdit tENKHTextEdit;
        private DevExpress.XtraEditors.TextEdit sDTTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kHACHHANG_thanthietBindingSource;
        private NghiepVuTableAdapters.KHACHHANG_thanthietTableAdapter kHACHHANG_thanthietTableAdapter;
        private System.Windows.Forms.DataGridView kHACHHANG_thanthietDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Label label1;
    }
}