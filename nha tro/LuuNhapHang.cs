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
    public partial class LuuNhapHang : Form
    {
        public LuuNhapHang()
        {
            InitializeComponent();
        }

        private void nHAPHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAPHANG1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void LuuNhapHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);
            // TODO: This line of code loads data into the 'nghiepVu.KHO1' table. You can move, or remove it, as needed.
            this.kHO1TableAdapter.Fill(this.nghiepVu.KHO1);
            ////// TODO: This line of code loads data into the 'nghiepVu.HOADON' table. You can move, or remove it, as needed.
            ////this.hOADONTableAdapter.Fill(this.nghiepVu.HOADON);
            //// TODO: This line of code loads data into the 'nghiepVu.HOADON1' table. You can move, or remove it, as needed.
            //this.hOADON1TableAdapter.Fill(this.nghiepVu.HOADON1);
            ////// TODO: This line of code loads data into the 'nghiepVu.HOADON' table. You can move, or remove it, as needed.
            ////this.hOADONTableAdapter.Fill(this.nghiepVu.HOADON);
            //// TODO: This line of code loads data into the 'nghiepVu.HOADON' table. You can move, or remove it, as needed.
            //this.hOADONTableAdapter.Fill(this.nghiepVu.HOADON);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.FillBy1_sp(this.nghiepVu.NHAPHANG1);
            // TODO: This line of code loads data into the 'nghiepVu.KHO' table. You can move, or remove it, as needed.
            ////this.kHOTableAdapter.Fill(this.nghiepVu.KHO);
            // TODO: This line of code loads data into the 'nghiepVu.CT_NHAP_SP' table. You can move, or remove it, as needed.
            this.cT_NHAP_SPTableAdapter.Fill(this.nghiepVu.CT_NHAP_SP);


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

        private void nHAPHANGDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (string.Compare(nHAPHANGDataGridView.CurrentRow.Cells[3].Value.ToString(), "Chưa lưu            ") == 0)
            {
                lưuKhoToolStripMenuItem.Enabled = true;
            }
            else
            {
                lưuKhoToolStripMenuItem.Enabled = false;
            }

            try
            {
                this.cT_NHAP_SP_DK_LUUKHOTableAdapter.Fill_DK(this.nghiepVu.CT_NHAP_SP_DK_LUUKHO, nHAPHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }
       private string tendn;
       public LuuNhapHang(string Message) : this()
        {
            tendn = Message;
        }
        private void lưuKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            string manv = tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString();
            hOADON_ttTableAdapter.Insert(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[0].Cells[2].Value.ToString(), "MLHD01", DateTime.Today, "temp", manv);
            try
            {
                this.hOADON_kttontaiTableAdapter.Fill(this.tt.HOADON_kttontai, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DateTime.Today, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
                for (int i = 0; i < cT_NHAP_SP_DK_LUUKHODataGridView.RowCount - 1; i++)
                {
                    try
                    {
                        this.hOADON_kttontaiTableAdapter.Fill(this.tt.HOADON_kttontai, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DateTime.Today, typeof(System.DateTime))))));
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    string MASP = cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[1].Value.ToString();
                    string sl = cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString();
                    kHOTableAdapter.UpdateQuery_sl(int.Parse(sl), MASP, kHOComboBox.SelectedValue.ToString());
                    if (hOADON_kttontaiDataGridView.Rows[0].Cells[0].Value.ToString() != cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[2].Value.ToString())
                    {
                        hOADON_ttTableAdapter.Insert(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[2].Value.ToString(), "MLHD01", DateTime.Today, "temp", manv);
                    }


                }
                nHAPHANG1TableAdapter.UpdateQuery("Đã lưu", nHAPHANGDataGridView.CurrentRow.Cells[0].Value.ToString());
                int tongtien = 0;
                int sol = 0;
                //xuly xuat file pdf
                for (int i = 0; i < cT_NHAP_SP_DK_LUUKHODataGridView.RowCount - 1; i++)
                {
                    sol += int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString());
                    tongtien += (int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString()) * int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[4].Value.ToString()));
                }
                ThongKe.xuatfile_HD_NhapHang(cT_NHAP_SP_DK_LUUKHODataGridView, cT_NHAP_SP_DK_LUUKHODataGridView.Rows[0].Cells[0].Value.ToString(), tongtien.ToString(), sol.ToString(), DateTime.Now.ToString("dd/MM/yyyy"), "HoaDon_NhapHang");

                //====================================
                this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
                this.kHO1TableAdapter.Fill(this.nghiepVu.KHO1);
                
            //XU LY HOA DON

            //            hOADONTableAdapter.Insert_my("NCC001", "MLHD01              ", Convert.ToDateTime("2000/01/01"), "temp", "NV01");
            ////hOADON1TableAdapter.Insert("khong               ", cT_NHAP_SP_DK_LUUKHODataGridView.CurrentRow.Cells[2].Value.ToString(), "khong               ", "MLHD01              ", DateTime.Today, null,null, tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
                MessageBox.Show("Thành Công");


        }
        ThongKe ThongKe = new ThongKe();
        private void fill_DKToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.cT_NHAP_SP_DK_LUUKHOTableAdapter.Fill_DK(this.nghiepVu.CT_NHAP_SP_DK_LUUKHO, mANHAPToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ThanhToanNhapHang ThanhToanNhapHang = new ThanhToanNhapHang();
            //ThanhToanNhapHang.ShowDialog();
            //hOADONTableAdapter.Insert_my("NCC001", "MLHD01              ", Convert.ToDateTime("2000/01/01"), "temp", "NV01");
            //MessageBox.Show("TC");
        }

        private void fill_DKToolStripButton_Click_2(object sender, EventArgs e)
        {
            //try
            //{
            //    this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendn);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void thanhToánToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThanhToanTheoPhanTramNH ThanhToanTheoPhanTramNH = new ThanhToanTheoPhanTramNH(tendn);
            ThanhToanTheoPhanTramNH.ShowDialog();
        }
    }
}
