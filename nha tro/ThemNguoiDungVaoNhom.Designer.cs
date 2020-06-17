namespace nha_tro
{
    partial class ThemNguoiDungVaoNhom
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
            this.nhomNguoiDungComboBox = new System.Windows.Forms.ComboBox();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_DangNhap = new nha_tro.DS_DangNhap();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tAIKHOANTableAdapter = new nha_tro.DS_DangNhapTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new nha_tro.DS_DangNhapTableAdapters.TableAdapterManager();
            this.nHOMNGUOIDUNGTableAdapter = new nha_tro.DS_DangNhapTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.nHOMNGUOIDUNG_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHOMNGUOIDUNG_DKTableAdapter = new nha_tro.DS_DangNhapTableAdapters.NHOMNGUOIDUNG_DKTableAdapter();
            this.tk_NNDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tk_NNDTableAdapter = new nha_tro.DS_DangNhapTableAdapters.tk_NNDTableAdapter();
            this.tk_NND_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tk_NND_DKTableAdapter = new nha_tro.DS_DangNhapTableAdapters.tk_NND_DKTableAdapter();
            this.tAIKHOANDataGridView = new System.Windows.Forms.DataGridView();
            this.tk_NND_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNG_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_NNDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_NND_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_NND_DKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nhomNguoiDungComboBox
            // 
            this.nhomNguoiDungComboBox.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.nhomNguoiDungComboBox.DisplayMember = "TENNHOM";
            this.nhomNguoiDungComboBox.FormattingEnabled = true;
            this.nhomNguoiDungComboBox.Location = new System.Drawing.Point(445, 44);
            this.nhomNguoiDungComboBox.Name = "nhomNguoiDungComboBox";
            this.nhomNguoiDungComboBox.Size = new System.Drawing.Size(300, 21);
            this.nhomNguoiDungComboBox.TabIndex = 3;
            this.nhomNguoiDungComboBox.ValueMember = "MaNhom";
            this.nhomNguoiDungComboBox.SelectedIndexChanged += new System.EventHandler(this.nhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.dS_DangNhap;
            // 
            // dS_DangNhap
            // 
            this.dS_DangNhap.DataSetName = "DS_DangNhap";
            this.dS_DangNhap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tAIKHOANBindingSource
            // 
            this.tAIKHOANBindingSource.DataMember = "TAIKHOAN";
            this.tAIKHOANBindingSource.DataSource = this.dS_DangNhap;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNG_DKTableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.tk_NND_DKTableAdapter = null;
            this.tableAdapterManager.tk_NNDTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.DS_DangNhapTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // nHOMNGUOIDUNG_DKBindingSource
            // 
            this.nHOMNGUOIDUNG_DKBindingSource.DataMember = "NHOMNGUOIDUNG_DK";
            this.nHOMNGUOIDUNG_DKBindingSource.DataSource = this.dS_DangNhap;
            // 
            // nHOMNGUOIDUNG_DKTableAdapter
            // 
            this.nHOMNGUOIDUNG_DKTableAdapter.ClearBeforeFill = true;
            // 
            // tk_NNDBindingSource
            // 
            this.tk_NNDBindingSource.DataMember = "tk_NND";
            this.tk_NNDBindingSource.DataSource = this.dS_DangNhap;
            // 
            // tk_NNDTableAdapter
            // 
            this.tk_NNDTableAdapter.ClearBeforeFill = true;
            // 
            // tk_NND_DKBindingSource
            // 
            this.tk_NND_DKBindingSource.DataMember = "tk_NND_DK";
            this.tk_NND_DKBindingSource.DataSource = this.dS_DangNhap;
            // 
            // tk_NND_DKTableAdapter
            // 
            this.tk_NND_DKTableAdapter.ClearBeforeFill = true;
            // 
            // tAIKHOANDataGridView
            // 
            this.tAIKHOANDataGridView.AutoGenerateColumns = false;
            this.tAIKHOANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tAIKHOANDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.tAIKHOANDataGridView.DataSource = this.tAIKHOANBindingSource;
            this.tAIKHOANDataGridView.Location = new System.Drawing.Point(12, 89);
            this.tAIKHOANDataGridView.Name = "tAIKHOANDataGridView";
            this.tAIKHOANDataGridView.Size = new System.Drawing.Size(346, 220);
            this.tAIKHOANDataGridView.TabIndex = 7;
            // 
            // tk_NND_DKDataGridView
            // 
            this.tk_NND_DKDataGridView.AutoGenerateColumns = false;
            this.tk_NND_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tk_NND_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tk_NND_DKDataGridView.DataSource = this.tk_NND_DKBindingSource;
            this.tk_NND_DKDataGridView.Location = new System.Drawing.Point(445, 89);
            this.tk_NND_DKDataGridView.Name = "tk_NND_DKDataGridView";
            this.tk_NND_DKDataGridView.Size = new System.Drawing.Size(341, 220);
            this.tk_NND_DKDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên đăng nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MATKHAU";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mật khẩu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "HOATDONG";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Tình trạng hoạt động";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tên đăng nhập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ThemNguoiDungVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 452);
            this.Controls.Add(this.tk_NND_DKDataGridView);
            this.Controls.Add(this.tAIKHOANDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nhomNguoiDungComboBox);
            this.Name = "ThemNguoiDungVaoNhom";
            this.Text = "ThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.ThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_DangNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNG_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_NNDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_NND_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tk_NND_DKDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox nhomNguoiDungComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DS_DangNhap dS_DangNhap;
        private System.Windows.Forms.BindingSource tAIKHOANBindingSource;
        private DS_DangNhapTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DS_DangNhapTableAdapters.TableAdapterManager tableAdapterManager;
        private DS_DangNhapTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNG_DKBindingSource;
        private DS_DangNhapTableAdapters.NHOMNGUOIDUNG_DKTableAdapter nHOMNGUOIDUNG_DKTableAdapter;
        private System.Windows.Forms.BindingSource tk_NNDBindingSource;
        private DS_DangNhapTableAdapters.tk_NNDTableAdapter tk_NNDTableAdapter;
        private System.Windows.Forms.BindingSource tk_NND_DKBindingSource;
        private DS_DangNhapTableAdapters.tk_NND_DKTableAdapter tk_NND_DKTableAdapter;
        private System.Windows.Forms.DataGridView tAIKHOANDataGridView;
        private System.Windows.Forms.DataGridView tk_NND_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}