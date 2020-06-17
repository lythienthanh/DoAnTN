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
    public partial class MH000000000000000004 : Form
    {
        public MH000000000000000004()
        {
            InitializeComponent();
        }

        private void nHAPHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.nHAPHANGBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void MH000000000000000004_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.ttc' table. You can move, or remove it, as needed.
            //this.ttcTableAdapter.Fill(this.nghiepVu.ttc);
            //// TODO: This line of code loads data into the 'nghiepVu.ThongTinChung_NhapHang1' table. You can move, or remove it, as needed.
            //this.thongTinChung_NhapHang1TableAdapter.Fill(this.nghiepVu.ThongTinChung_NhapHang1);
            // TODO: This line of code loads data into the 'nghiepVu.ThongTinChung_NhapHang' table. You can move, or remove it, as needed.
            //this.thongTinChung_NhapHangTableAdapter.Fill_dk(this.nghiepVu.ThongTinChung_NhapHang);
            // TODO: This line of code loads data into the 'nghiepVu.ThongTinChung_NhapHang' table. You can move, or remove it, as needed.
            //this.thongTinChung_NhapHangTableAdapter.Fill_dk(this.nghiepVu.ThongTinChung_NhapHang);
             //TODO: This line of code loads data into the 'nghiepVu.ThongTinChung_NhapHang' table. You can move, or remove it, as needed.
            //this.thongTinChung_NhapHangTableAdapter.Fill_dk(this.nghiepVu.ThongTinChung_NhapHang);



        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, maNhapToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void cT_Nhap_dkDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, thongTinChung_NhapHang1DataGridView.CurrentRow.Cells[0].Value.ToString());
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }
                //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public MH000000000000000004(string Message)
            : this()
        {
            tendn = Message;
        }
        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoPhieuNhap TaoPhieuNhap = new TaoPhieuNhap(tendn);
            TaoPhieuNhap.ShowDialog();
        }

        private void themToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TaoPhieuNhap TaoPhieuNhap = new TaoPhieuNhap(tendn);
            TaoPhieuNhap.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LuuNhapHang LuuNhapHang = new LuuNhapHang(tendn);
            LuuNhapHang.ShowDialog();
        }

        private void thongTinChung_NhapHangDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, thongTinChung_NhapHang1DataGridView.CurrentRow.Cells[0].Value.ToString());
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }
    }
}
