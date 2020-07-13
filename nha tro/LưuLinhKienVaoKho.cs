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
    public partial class LưuLinhKienVaoKho : Form
    {
        public LưuLinhKienVaoKho()
        {
            InitializeComponent();
        }
        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public LưuLinhKienVaoKho(string Message)
            : this()
        {
            tendn = Message;
        }

        private void LưuLinhKienVaoKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);
            // TODO: This line of code loads data into the 'tt.KHO_tt' table. You can move, or remove it, as needed.
            this.kHO_ttTableAdapter.Fill(this.tt.KHO_tt);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.FillBy_lk(this.nghiepVu.NHAPHANG1);


            nHAPHANGDataGridView.BorderStyle = BorderStyle.None;
            nHAPHANGDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            nHAPHANGDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            nHAPHANGDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            nHAPHANGDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            nHAPHANGDataGridView.BackgroundColor = Color.White;

            nHAPHANGDataGridView.EnableHeadersVisualStyles = false;
            nHAPHANGDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            nHAPHANGDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            nHAPHANGDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            cT_NHAP_SP_DK_LUUKHODataGridView.BorderStyle = BorderStyle.None;
            cT_NHAP_SP_DK_LUUKHODataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            cT_NHAP_SP_DK_LUUKHODataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            cT_NHAP_SP_DK_LUUKHODataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            cT_NHAP_SP_DK_LUUKHODataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            cT_NHAP_SP_DK_LUUKHODataGridView.BackgroundColor = Color.White;

            cT_NHAP_SP_DK_LUUKHODataGridView.EnableHeadersVisualStyles = false;
            cT_NHAP_SP_DK_LUUKHODataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            cT_NHAP_SP_DK_LUUKHODataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            cT_NHAP_SP_DK_LUUKHODataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void fill_theoMaNhapToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void nHAPHANGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (string.Compare(nHAPHANGDataGridView.CurrentRow.Cells[3].Value.ToString(), "Chưa lưu            ") == 0)
            {
                lưuKhoToolStripMenuItem.Enabled = true;
            }
            else
                lưuKhoToolStripMenuItem.Enabled = false;
        }

        private void lưuKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0 ; i < cT_NHAP_SP_DK_LUUKHODataGridView.Rows.Count - 1 ; i++)
            {
                //cap nhat kho
                lINHKIENTableAdapter.Update_SL_LK(int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString()), cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[0].Value.ToString());
            }

            //xuat hd
            try
            {
                this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            hOADON_ttTableAdapter.Insert(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[0].Cells[2].Value.ToString(), "MLHD03", DateTime.Today, "temp", hOADON_kttontaiDataGridView.Rows[0].Cells[1].Value.ToString());
            nHAPHANG1TableAdapter.UpdateQuery("Đã lưu", nHAPHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
            //xuly xuat file pdf
            int tongtien = 0;
            int sol = 0;
            for (int i = 0; i < cT_NHAP_SP_DK_LUUKHODataGridView.RowCount - 1; i++)
            {
                sol += int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString());
                tongtien += (int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString()) * int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[4].Value.ToString()));
            }
            //ThongKe.xuatfile_HD_NhapHang(cT_NHAP_SP_DK_LUUKHODataGridView, cT_NHAP_SP_DK_LUUKHODataGridView.Rows[0].Cells[0].Value.ToString(), tongtien.ToString(), sol.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), "HoaDon_NhapLK");
            Form4_hd_ncc_lk form4_Hd_Ncc_Lk = new Form4_hd_ncc_lk(hOADON_ttTableAdapter.select_MAHD().ToString(),DateTime.Today.ToString("dd/MM/yyyy"), nHAPHANGDataGridView.CurrentRow.Cells[0].Value.ToString(),tongtien.ToString(), tAIKHOANTableAdapter.tennv(hOADON_kttontaiDataGridView.Rows[0].Cells[1].Value.ToString()).ToString());
            form4_Hd_Ncc_Lk.ShowDialog();
            //====================================


            this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
            //this.kHOTableAdapter.Fill(this.nghiepVu.KHO);
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);

        }
        ThongKe ThongKe = new ThongKe();
        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thanhtoantheophantramLK ThanhToanTheoPhanTramNH = new thanhtoantheophantramLK(tendn);
            ThanhToanTheoPhanTramNH.ShowDialog();
        }
    }
}
