namespace nha_tro
{
    partial class ThongKeTop5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.thongKe_SPDataGridView = new System.Windows.Forms.DataGridView();
            this.tOP_5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tOP_5TableAdapter = new nha_tro.ttTableAdapters.TOP_5TableAdapter();
            this.tableAdapterManager = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP_5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // thongKe_SPDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            this.thongKe_SPDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.thongKe_SPDataGridView.AutoGenerateColumns = false;
            this.thongKe_SPDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thongKe_SPDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.thongKe_SPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thongKe_SPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.thongKe_SPDataGridView.DataSource = this.tOP_5BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.thongKe_SPDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.thongKe_SPDataGridView.Location = new System.Drawing.Point(203, 180);
            this.thongKe_SPDataGridView.Name = "thongKe_SPDataGridView";
            this.thongKe_SPDataGridView.Size = new System.Drawing.Size(391, 220);
            this.thongKe_SPDataGridView.TabIndex = 31;
            // 
            // tOP_5BindingSource
            // 
            this.tOP_5BindingSource.DataMember = "TOP 5";
            this.tOP_5BindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày Kết Thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ngày Bắt Đầu";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(297, 110);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // tOP_5TableAdapter
            // 
            this.tOP_5TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOHANH1TableAdapter = null;
            this.tableAdapterManager.BAOHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Ct_KM_LKTableAdapter = null;
            this.tableAdapterManager.CT_KM_SPTableAdapter = null;
            this.tableAdapterManager.Ct_mua_SP_TIMKIEMTableAdapter = null;
            this.tableAdapterManager.CT_NHAP_LK_theoMaNhapTableAdapter = null;
            this.tableAdapterManager.DATHANG_SPTableAdapter = null;
            this.tableAdapterManager.DOITRATableAdapter = null;
            this.tableAdapterManager.HOADON_kttontaiTableAdapter = null;
            this.tableAdapterManager.HOADON_timmahd_vuathemTableAdapter = null;
            this.tableAdapterManager.HOADON_ttTableAdapter = null;
            this.tableAdapterManager.KHO_ttTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAISANPHAMTableAdapter = null;
            this.tableAdapterManager.SANPHAM__sreach_giaTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_TIMMANVTableAdapter = null;
            this.tableAdapterManager.TinhTrangTTTableAdapter = null;
            this.tableAdapterManager.TraGop1TableAdapter = null;
            this.tableAdapterManager.TraGopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.ttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sl Đã Bán";
            this.dataGridViewTextBoxColumn1.HeaderText = "Số lượng đã bán ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ThongKeTop5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.thongKe_SPDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ThongKeTop5";
            this.Text = "ThongKeTop5";
            ((System.ComponentModel.ISupportInitialize)(this.thongKe_SPDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tOP_5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView thongKe_SPDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private tt tt;
        private System.Windows.Forms.BindingSource tOP_5BindingSource;
        private ttTableAdapters.TOP_5TableAdapter tOP_5TableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn slĐãBánDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}