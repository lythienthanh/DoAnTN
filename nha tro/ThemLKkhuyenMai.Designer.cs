namespace nha_tro
{
    partial class ThemLKkhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLKkhuyenMai));
            System.Windows.Forms.Label gIATRILabel;
            System.Windows.Forms.Label mAKHUYENMAILabel;
            System.Windows.Forms.Label mALINHKIENLabel;
            System.Windows.Forms.Label nGAYBDLabel;
            System.Windows.Forms.Label nGAYKTLabel;
            this.tt = new nha_tro.tt();
            this.kHUYENMAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUYENMAITableAdapter = new nha_tro.ttTableAdapters.KHUYENMAITableAdapter();
            this.tableAdapterManager = new nha_tro.ttTableAdapters.TableAdapterManager();
            this.kHUYENMAIBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kHUYENMAIBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kHUYENMAIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ct_KM_LKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_KM_LKTableAdapter = new nha_tro.ttTableAdapters.Ct_KM_LKTableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.mAKHUYENMAIToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.mAKHUYENMAIToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ct_KM_LKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gIATRISpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAKHUYENMAITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mALINHKIENTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYBDDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.nGAYKTDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            gIATRILabel = new System.Windows.Forms.Label();
            mAKHUYENMAILabel = new System.Windows.Forms.Label();
            mALINHKIENLabel = new System.Windows.Forms.Label();
            nGAYBDLabel = new System.Windows.Forms.Label();
            nGAYKTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingNavigator)).BeginInit();
            this.kHUYENMAIBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_KM_LKBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_KM_LKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIATRISpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHUYENMAITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALINHKIENTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBDDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBDDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYKTDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYKTDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUYENMAIBindingSource
            // 
            this.kHUYENMAIBindingSource.DataMember = "KHUYENMAI";
            this.kHUYENMAIBindingSource.DataSource = this.tt;
            // 
            // kHUYENMAITableAdapter
            // 
            this.kHUYENMAITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOHANHTableAdapter = null;
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
            this.tableAdapterManager.KHUYENMAITableAdapter = this.kHUYENMAITableAdapter;
            this.tableAdapterManager.SANPHAM__sreach_giaTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_TIMMANVTableAdapter = null;
            this.tableAdapterManager.TinhTrangTTTableAdapter = null;
            this.tableAdapterManager.TraGop1TableAdapter = null;
            this.tableAdapterManager.TraGopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = nha_tro.ttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHUYENMAIBindingNavigator
            // 
            this.kHUYENMAIBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kHUYENMAIBindingNavigator.BindingSource = this.kHUYENMAIBindingSource;
            this.kHUYENMAIBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kHUYENMAIBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kHUYENMAIBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kHUYENMAIBindingNavigatorSaveItem});
            this.kHUYENMAIBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kHUYENMAIBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kHUYENMAIBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kHUYENMAIBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kHUYENMAIBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kHUYENMAIBindingNavigator.Name = "kHUYENMAIBindingNavigator";
            this.kHUYENMAIBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kHUYENMAIBindingNavigator.Size = new System.Drawing.Size(1264, 25);
            this.kHUYENMAIBindingNavigator.TabIndex = 0;
            this.kHUYENMAIBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // kHUYENMAIBindingNavigatorSaveItem
            // 
            this.kHUYENMAIBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kHUYENMAIBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kHUYENMAIBindingNavigatorSaveItem.Image")));
            this.kHUYENMAIBindingNavigatorSaveItem.Name = "kHUYENMAIBindingNavigatorSaveItem";
            this.kHUYENMAIBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kHUYENMAIBindingNavigatorSaveItem.Text = "Save Data";
            this.kHUYENMAIBindingNavigatorSaveItem.Click += new System.EventHandler(this.kHUYENMAIBindingNavigatorSaveItem_Click);
            // 
            // kHUYENMAIGridControl
            // 
            this.kHUYENMAIGridControl.DataSource = this.kHUYENMAIBindingSource;
            this.kHUYENMAIGridControl.Location = new System.Drawing.Point(12, 92);
            this.kHUYENMAIGridControl.MainView = this.gridView1;
            this.kHUYENMAIGridControl.Name = "kHUYENMAIGridControl";
            this.kHUYENMAIGridControl.Size = new System.Drawing.Size(740, 220);
            this.kHUYENMAIGridControl.TabIndex = 1;
            this.kHUYENMAIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.kHUYENMAIGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // ct_KM_LKBindingSource
            // 
            this.ct_KM_LKBindingSource.DataMember = "Ct_KM_LK";
            this.ct_KM_LKBindingSource.DataSource = this.tt;
            // 
            // ct_KM_LKTableAdapter
            // 
            this.ct_KM_LKTableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAKHUYENMAIToolStripLabel,
            this.mAKHUYENMAIToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1264, 25);
            this.fillToolStrip.TabIndex = 2;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // mAKHUYENMAIToolStripLabel
            // 
            this.mAKHUYENMAIToolStripLabel.Name = "mAKHUYENMAIToolStripLabel";
            this.mAKHUYENMAIToolStripLabel.Size = new System.Drawing.Size(97, 15);
            this.mAKHUYENMAIToolStripLabel.Text = "MAKHUYENMAI:";
            // 
            // mAKHUYENMAIToolStripTextBox
            // 
            this.mAKHUYENMAIToolStripTextBox.Name = "mAKHUYENMAIToolStripTextBox";
            this.mAKHUYENMAIToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(26, 19);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // ct_KM_LKGridControl
            // 
            this.ct_KM_LKGridControl.DataSource = this.ct_KM_LKBindingSource;
            this.ct_KM_LKGridControl.Location = new System.Drawing.Point(758, 92);
            this.ct_KM_LKGridControl.MainView = this.gridView2;
            this.ct_KM_LKGridControl.Name = "ct_KM_LKGridControl";
            this.ct_KM_LKGridControl.Size = new System.Drawing.Size(486, 220);
            this.ct_KM_LKGridControl.TabIndex = 3;
            this.ct_KM_LKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.ct_KM_LKGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // gIATRILabel
            // 
            gIATRILabel.AutoSize = true;
            gIATRILabel.Location = new System.Drawing.Point(755, 330);
            gIATRILabel.Name = "gIATRILabel";
            gIATRILabel.Size = new System.Drawing.Size(46, 13);
            gIATRILabel.TabIndex = 4;
            gIATRILabel.Text = "GIATRI:";
            // 
            // gIATRISpinEdit
            // 
            this.gIATRISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ct_KM_LKBindingSource, "GIATRI", true));
            this.gIATRISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gIATRISpinEdit.Location = new System.Drawing.Point(851, 327);
            this.gIATRISpinEdit.Name = "gIATRISpinEdit";
            this.gIATRISpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gIATRISpinEdit.Size = new System.Drawing.Size(100, 20);
            this.gIATRISpinEdit.TabIndex = 5;
            // 
            // mAKHUYENMAILabel
            // 
            mAKHUYENMAILabel.AutoSize = true;
            mAKHUYENMAILabel.Location = new System.Drawing.Point(755, 356);
            mAKHUYENMAILabel.Name = "mAKHUYENMAILabel";
            mAKHUYENMAILabel.Size = new System.Drawing.Size(90, 13);
            mAKHUYENMAILabel.TabIndex = 6;
            mAKHUYENMAILabel.Text = "MAKHUYENMAI:";
            // 
            // mAKHUYENMAITextEdit
            // 
            this.mAKHUYENMAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ct_KM_LKBindingSource, "MAKHUYENMAI", true));
            this.mAKHUYENMAITextEdit.Location = new System.Drawing.Point(851, 353);
            this.mAKHUYENMAITextEdit.Name = "mAKHUYENMAITextEdit";
            this.mAKHUYENMAITextEdit.Size = new System.Drawing.Size(100, 20);
            this.mAKHUYENMAITextEdit.TabIndex = 7;
            // 
            // mALINHKIENLabel
            // 
            mALINHKIENLabel.AutoSize = true;
            mALINHKIENLabel.Location = new System.Drawing.Point(755, 382);
            mALINHKIENLabel.Name = "mALINHKIENLabel";
            mALINHKIENLabel.Size = new System.Drawing.Size(76, 13);
            mALINHKIENLabel.TabIndex = 8;
            mALINHKIENLabel.Text = "MALINHKIEN:";
            // 
            // mALINHKIENTextEdit
            // 
            this.mALINHKIENTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ct_KM_LKBindingSource, "MALINHKIEN", true));
            this.mALINHKIENTextEdit.Location = new System.Drawing.Point(851, 379);
            this.mALINHKIENTextEdit.Name = "mALINHKIENTextEdit";
            this.mALINHKIENTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mALINHKIENTextEdit.TabIndex = 9;
            // 
            // nGAYBDLabel
            // 
            nGAYBDLabel.AutoSize = true;
            nGAYBDLabel.Location = new System.Drawing.Point(755, 408);
            nGAYBDLabel.Name = "nGAYBDLabel";
            nGAYBDLabel.Size = new System.Drawing.Size(55, 13);
            nGAYBDLabel.TabIndex = 10;
            nGAYBDLabel.Text = "NGAYBD:";
            // 
            // nGAYBDDateEdit
            // 
            this.nGAYBDDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ct_KM_LKBindingSource, "NGAYBD", true));
            this.nGAYBDDateEdit.EditValue = null;
            this.nGAYBDDateEdit.Location = new System.Drawing.Point(851, 405);
            this.nGAYBDDateEdit.Name = "nGAYBDDateEdit";
            this.nGAYBDDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYBDDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYBDDateEdit.Size = new System.Drawing.Size(100, 20);
            this.nGAYBDDateEdit.TabIndex = 11;
            // 
            // nGAYKTLabel
            // 
            nGAYKTLabel.AutoSize = true;
            nGAYKTLabel.Location = new System.Drawing.Point(755, 434);
            nGAYKTLabel.Name = "nGAYKTLabel";
            nGAYKTLabel.Size = new System.Drawing.Size(54, 13);
            nGAYKTLabel.TabIndex = 12;
            nGAYKTLabel.Text = "NGAYKT:";
            // 
            // nGAYKTDateEdit
            // 
            this.nGAYKTDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ct_KM_LKBindingSource, "NGAYKT", true));
            this.nGAYKTDateEdit.EditValue = null;
            this.nGAYKTDateEdit.Location = new System.Drawing.Point(851, 431);
            this.nGAYKTDateEdit.Name = "nGAYKTDateEdit";
            this.nGAYKTDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYKTDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYKTDateEdit.Size = new System.Drawing.Size(100, 20);
            this.nGAYKTDateEdit.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(957, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemLKkhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(gIATRILabel);
            this.Controls.Add(this.gIATRISpinEdit);
            this.Controls.Add(mAKHUYENMAILabel);
            this.Controls.Add(this.mAKHUYENMAITextEdit);
            this.Controls.Add(mALINHKIENLabel);
            this.Controls.Add(this.mALINHKIENTextEdit);
            this.Controls.Add(nGAYBDLabel);
            this.Controls.Add(this.nGAYBDDateEdit);
            this.Controls.Add(nGAYKTLabel);
            this.Controls.Add(this.nGAYKTDateEdit);
            this.Controls.Add(this.ct_KM_LKGridControl);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.kHUYENMAIGridControl);
            this.Controls.Add(this.kHUYENMAIBindingNavigator);
            this.Name = "ThemLKkhuyenMai";
            this.Text = "ThemLKkhuyenMai";
            this.Load += new System.EventHandler(this.ThemLKkhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIBindingNavigator)).EndInit();
            this.kHUYENMAIBindingNavigator.ResumeLayout(false);
            this.kHUYENMAIBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHUYENMAIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_KM_LKBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ct_KM_LKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIATRISpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAKHUYENMAITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mALINHKIENTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBDDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYBDDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYKTDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYKTDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tt tt;
        private System.Windows.Forms.BindingSource kHUYENMAIBindingSource;
        private ttTableAdapters.KHUYENMAITableAdapter kHUYENMAITableAdapter;
        private ttTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kHUYENMAIBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kHUYENMAIBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl kHUYENMAIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource ct_KM_LKBindingSource;
        private ttTableAdapters.Ct_KM_LKTableAdapter ct_KM_LKTableAdapter;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel mAKHUYENMAIToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox mAKHUYENMAIToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private DevExpress.XtraGrid.GridControl ct_KM_LKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SpinEdit gIATRISpinEdit;
        private DevExpress.XtraEditors.TextEdit mAKHUYENMAITextEdit;
        private DevExpress.XtraEditors.TextEdit mALINHKIENTextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYBDDateEdit;
        private DevExpress.XtraEditors.DateEdit nGAYKTDateEdit;
        private System.Windows.Forms.Button button1;
    }
}