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
    public partial class TaoPhieuNhapLinhKien : Form
    {
        public TaoPhieuNhapLinhKien()
        {
            InitializeComponent();
        }

        private void hOADON_ttBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADON_ttBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tt);

        }

        private void TaoPhieuNhapLinhKien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG' table. You can move, or remove it, as needed.
            this.nHAPHANGTableAdapter.Fill(this.nghiepVu.NHAPHANG);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
            // TODO: This line of code loads data into the 'nghiepVu.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);

            nHAPHANG1DataGridView.BorderStyle = BorderStyle.None;
            nHAPHANG1DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            nHAPHANG1DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            nHAPHANG1DataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            nHAPHANG1DataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            nHAPHANG1DataGridView.BackgroundColor = Color.White;

            nHAPHANG1DataGridView.EnableHeadersVisualStyles = false;
            nHAPHANG1DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            nHAPHANG1DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            nHAPHANG1DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            cT_NHAP_LK_theoMaNhapDataGridView.BorderStyle = BorderStyle.None;
            cT_NHAP_LK_theoMaNhapDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            cT_NHAP_LK_theoMaNhapDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            cT_NHAP_LK_theoMaNhapDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            cT_NHAP_LK_theoMaNhapDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            cT_NHAP_LK_theoMaNhapDataGridView.BackgroundColor = Color.White;

            cT_NHAP_LK_theoMaNhapDataGridView.EnableHeadersVisualStyles = false;
            cT_NHAP_LK_theoMaNhapDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            cT_NHAP_LK_theoMaNhapDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            cT_NHAP_LK_theoMaNhapDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }
        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public TaoPhieuNhapLinhKien(string Message) : this()
        {
            tendn = Message;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.lAY_MANVbangTENDNTableAdapter.Fill_DK(this.nghiepVu.LAY_MANVbangTENDN, tendn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            string MANV = lAY_MANVbangTENDNDataGridView1.Rows[0].Cells[0].Value.ToString();
            //nHAPHANGTableAdapter.InsertQuery(mANHAPTextEdit1.Text, MANV, dateTimePicker1.Text, "Chưa lưu");
            nHAPHANGTableAdapter.InsertQuery("PN" + ((nHAPHANGTableAdapter.SoDong()) + 1), MANV, dateTimePicker1.Text, "Chưa lưu");
            MessageBox.Show("Thêm thành công");

            //load
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG' table. You can move, or remove it, as needed.
            this.nHAPHANGTableAdapter.Fill(this.nghiepVu.NHAPHANG);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
            // TODO: This line of code loads data into the 'nghiepVu.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);
        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.lAY_MANVbangTENDNTableAdapter.Fill_DK(this.nghiepVu.LAY_MANVbangTENDN, tENDNToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fill_theoMaNhapToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void nHAPHANG1DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cT_NHAP_LK_theoMaNhapTableAdapter.Insert(lINHKIENComboBox.SelectedValue.ToString(),nHAPHANG1ComboBox.SelectedValue.ToString(),nHACUNGCAPComboBox.SelectedValue.ToString(),int.Parse(slSpinEdit.Text),int.Parse(donGiaSpinEdit.Text));
            MessageBox.Show("Thêm Thành Công!!!");
            //load dl
            try
            {
                this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANG1ComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cT_NHAP_LK_theoMaNhapTableAdapter.DeleteQuery(lINHKIENComboBox.SelectedValue.ToString(), nHAPHANG1ComboBox.SelectedValue.ToString(), nHACUNGCAPComboBox.SelectedValue.ToString());
            MessageBox.Show("Xóa Thành Công!!!");
            //load dl
            try
            {
                this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void nHAPHANG1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load dl
            try
            {
                this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANG1ComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cT_NHAP_LK_theoMaNhapTableAdapter.UpdateQuery(int.Parse(slSpinEdit.Text), int.Parse(donGiaSpinEdit.Text), lINHKIENComboBox.SelectedValue.ToString(), nHAPHANG1ComboBox.SelectedValue.ToString());
                //load dl
                try
                {
                    this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANG1ComboBox.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                   // System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            catch
            {
                MessageBox.Show("Mã nhập hoặc mã linh kiện không tồn tại!!!");
            }
        }
    }
}
