using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nha_tro
{
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.KHACHHANG_thanthiet' table. You can move, or remove it, as needed.
            this.kHACHHANG_thanthietTableAdapter.Fill(this.nghiepVu.KHACHHANG_thanthiet);
            // TODO: This line of code loads data into the 'nghiepVu.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);

            kHACHHANGDataGridView.BorderStyle = BorderStyle.None;
            kHACHHANGDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHACHHANGDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHACHHANGDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHACHHANGDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHACHHANGDataGridView.BackgroundColor = Color.White;

            kHACHHANGDataGridView.EnableHeadersVisualStyles = false;
            kHACHHANGDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHACHHANGDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHACHHANGDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            kHACHHANG_thanthietDataGridView.BorderStyle = BorderStyle.None;
            kHACHHANG_thanthietDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHACHHANG_thanthietDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHACHHANG_thanthietDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHACHHANG_thanthietDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHACHHANG_thanthietDataGridView.BackgroundColor = Color.White;

            kHACHHANG_thanthietDataGridView.EnableHeadersVisualStyles = false;
            kHACHHANG_thanthietDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHACHHANG_thanthietDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHACHHANG_thanthietDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.Insert(mAKHTextEdit.Text, tENKHTextEdit.Text, sDTTextEdit.Text, dIACHITextEdit.Text, cMNDTextEdit.Text);
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.Delete(mAKHTextEdit.Text, tENKHTextEdit.Text, sDTTextEdit.Text, dIACHITextEdit.Text, cMNDTextEdit.Text);
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.UpdateKHACHHANG(tENKHTextEdit.Text, sDTTextEdit.Text, dIACHITextEdit.Text, cMNDTextEdit.Text, mAKHTextEdit.Text);
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimKiem frm = new TimKiem();
            frm.ShowDialog();
        }
    }
}
