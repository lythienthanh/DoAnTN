namespace nha_tro
{
    partial class QuanLyLinhKien
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
            System.Windows.Forms.Label mALINHKIENLabel;
            System.Windows.Forms.Label tENLINHKIENLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAKHOLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lINHKIENDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lINHKIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nghiepVu = new nha_tro.NghiepVu();
            this.button1 = new System.Windows.Forms.Button();
            this.mALINHKIENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENLINHKIENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dONGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lINHKIENTableAdapter = new nha_tro.NghiepVuTableAdapters.LINHKIENTableAdapter();
            this.tableAdapterManager = new nha_tro.NghiepVuTableAdapters.TableAdapterManager();
            this.kHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOTableAdapter = new nha_tro.NghiepVuTableAdapters.KHOTableAdapter();
            this.mAKHOComboBox = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            mALINHKIENLabel = new System.Windows.Forms.Label();
            tENLINHKIENLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAKHOLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lINHKIENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHKIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALINHKIENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLINHKIENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mALINHKIENLabel
            // 
            mALINHKIENLabel.AutoSize = true;
            mALINHKIENLabel.Location = new System.Drawing.Point(94, 145);
            mALINHKIENLabel.Name = "mALINHKIENLabel";
            mALINHKIENLabel.Size = new System.Drawing.Size(69, 13);
            mALINHKIENLabel.TabIndex = 2;
            mALINHKIENLabel.Text = "Mã Linh Kiện";
            // 
            // tENLINHKIENLabel
            // 
            tENLINHKIENLabel.AutoSize = true;
            tENLINHKIENLabel.Location = new System.Drawing.Point(94, 171);
            tENLINHKIENLabel.Name = "tENLINHKIENLabel";
            tENLINHKIENLabel.Size = new System.Drawing.Size(73, 13);
            tENLINHKIENLabel.TabIndex = 4;
            tENLINHKIENLabel.Text = "Tên Linh Kiện";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(94, 206);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(46, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "Đơn Giá";
            // 
            // mAKHOLabel1
            // 
            mAKHOLabel1.AutoSize = true;
            mAKHOLabel1.Location = new System.Drawing.Point(97, 235);
            mAKHOLabel1.Name = "mAKHOLabel1";
            mAKHOLabel1.Size = new System.Drawing.Size(44, 13);
            mAKHOLabel1.TabIndex = 12;
            mAKHOLabel1.Text = "Mã Kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lINHKIENDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(418, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin linh kiện";
            // 
            // lINHKIENDataGridView
            // 
            this.lINHKIENDataGridView.AutoGenerateColumns = false;
            this.lINHKIENDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lINHKIENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lINHKIENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.lINHKIENDataGridView.DataSource = this.lINHKIENBindingSource;
            this.lINHKIENDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lINHKIENDataGridView.Location = new System.Drawing.Point(3, 16);
            this.lINHKIENDataGridView.Name = "lINHKIENDataGridView";
            this.lINHKIENDataGridView.Size = new System.Drawing.Size(518, 240);
            this.lINHKIENDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALINHKIEN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã linh kiện";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLINHKIEN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên linh kiện";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAKHO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã kho";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // lINHKIENBindingSource
            // 
            this.lINHKIENBindingSource.DataMember = "LINHKIEN";
            this.lINHKIENBindingSource.DataSource = this.nghiepVu;
            // 
            // nghiepVu
            // 
            this.nghiepVu.DataSetName = "NghiepVu";
            this.nghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::nha_tro.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.button1.Location = new System.Drawing.Point(86, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mALINHKIENTextEdit
            // 
            this.mALINHKIENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lINHKIENBindingSource, "MALINHKIEN", true));
            this.mALINHKIENTextEdit.Location = new System.Drawing.Point(182, 142);
            this.mALINHKIENTextEdit.Name = "mALINHKIENTextEdit";
            this.mALINHKIENTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mALINHKIENTextEdit.TabIndex = 3;
            // 
            // tENLINHKIENTextEdit
            // 
            this.tENLINHKIENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lINHKIENBindingSource, "TENLINHKIEN", true));
            this.tENLINHKIENTextEdit.Location = new System.Drawing.Point(182, 168);
            this.tENLINHKIENTextEdit.Name = "tENLINHKIENTextEdit";
            this.tENLINHKIENTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tENLINHKIENTextEdit.TabIndex = 5;
            // 
            // dONGIASpinEdit
            // 
            this.dONGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lINHKIENBindingSource, "DONGIA", true));
            this.dONGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dONGIASpinEdit.Location = new System.Drawing.Point(182, 203);
            this.dONGIASpinEdit.Name = "dONGIASpinEdit";
            this.dONGIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dONGIASpinEdit.Size = new System.Drawing.Size(100, 20);
            this.dONGIASpinEdit.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_edit_delete;
            this.button2.Location = new System.Drawing.Point(182, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 46);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::nha_tro.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_edit;
            this.button3.Location = new System.Drawing.Point(268, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 46);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lINHKIENTableAdapter
            // 
            this.lINHKIENTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LINHKIENTableAdapter = this.lINHKIENTableAdapter;
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
            // kHOBindingSource
            // 
            this.kHOBindingSource.DataMember = "KHO";
            this.kHOBindingSource.DataSource = this.nghiepVu;
            // 
            // kHOTableAdapter
            // 
            this.kHOTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHOComboBox
            // 
            this.mAKHOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOBindingSource, "MAKHO", true));
            this.mAKHOComboBox.FormattingEnabled = true;
            this.mAKHOComboBox.Location = new System.Drawing.Point(182, 232);
            this.mAKHOComboBox.Name = "mAKHOComboBox";
            this.mAKHOComboBox.Size = new System.Drawing.Size(100, 21);
            this.mAKHOComboBox.TabIndex = 13;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = global::nha_tro.Properties.Resources.Ampeross_Qetto_2_Headphones;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(954, 42);
            this.button9.TabIndex = 30;
            this.button9.Text = "QUẢN LÝ LINH KIỆN";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // QuanLyLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 381);
            this.Controls.Add(this.button9);
            this.Controls.Add(mAKHOLabel1);
            this.Controls.Add(this.mAKHOComboBox);
            this.Controls.Add(mALINHKIENLabel);
            this.Controls.Add(this.mALINHKIENTextEdit);
            this.Controls.Add(tENLINHKIENLabel);
            this.Controls.Add(this.tENLINHKIENTextEdit);
            this.Controls.Add(dONGIALabel);
            this.Controls.Add(this.dONGIASpinEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyLinhKien";
            this.Text = "QUẢN LÝ LINH KIỆN";
            this.Load += new System.EventHandler(this.QuanLyLinhKien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lINHKIENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lINHKIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALINHKIENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENLINHKIENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NghiepVu nghiepVu;
        private System.Windows.Forms.BindingSource lINHKIENBindingSource;
        private NghiepVuTableAdapters.LINHKIENTableAdapter lINHKIENTableAdapter;
        private NghiepVuTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView lINHKIENDataGridView;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.TextEdit mALINHKIENTextEdit;
        private DevExpress.XtraEditors.TextEdit tENLINHKIENTextEdit;
        private DevExpress.XtraEditors.SpinEdit dONGIASpinEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource kHOBindingSource;
        private NghiepVuTableAdapters.KHOTableAdapter kHOTableAdapter;
        private System.Windows.Forms.ComboBox mAKHOComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button9;
    }
}