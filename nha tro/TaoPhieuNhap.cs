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
    public partial class MH000000000000000024 : Form
    {
        public MH000000000000000024()
        {
            InitializeComponent();
        }

        private void cT_NHAP_SPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cT_NHAP_SPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }
        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public MH000000000000000024(string Message)
            : this()
        {
            tendn = Message;
        }
        private void TaoPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG' table. You can move, or remove it, as needed.
            this.nHAPHANGTableAdapter.Fill(this.nghiepVu.NHAPHANG);
            // TODO: This line of code loads data into the 'nghiepVu.CT_NHAP_SP' table. You can move, or remove it, as needed.
            this.cT_NHAP_SPTableAdapter.Fill(this.nghiepVu.CT_NHAP_SP);
            mANVTextEdit.ReadOnly = true;
            mANVTextEdit.Text = tendn;

            xUAT_HD_NHAPHANG_SPDataGridView.BorderStyle = BorderStyle.None;
            xUAT_HD_NHAPHANG_SPDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            xUAT_HD_NHAPHANG_SPDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            xUAT_HD_NHAPHANG_SPDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            xUAT_HD_NHAPHANG_SPDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            xUAT_HD_NHAPHANG_SPDataGridView.BackgroundColor = Color.White;

            xUAT_HD_NHAPHANG_SPDataGridView.EnableHeadersVisualStyles = false;
            xUAT_HD_NHAPHANG_SPDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            xUAT_HD_NHAPHANG_SPDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            xUAT_HD_NHAPHANG_SPDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.lAY_MANVbangTENDNTableAdapter.Fill_DK(this.nghiepVu.LAY_MANVbangTENDN, mANVTextEdit.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            string MANV = lAY_MANVbangTENDNDataGridView.Rows[0].Cells[0].Value.ToString();
            nHAPHANGTableAdapter.InsertQuery("PN"+((nHAPHANGTableAdapter.SoDong())+1), MANV, dateTimePicker1.Text,"Chưa lưu");
            MessageBox.Show("Thêm thành công");

            //load
            this.nHAPHANGTableAdapter.Fill(this.nghiepVu.NHAPHANG);
        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void fill_dkToolStripButton_Click_1(object sender, EventArgs e)
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

        private void nHAPHANGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (nHAPHANGComboBox.SelectedValue != null)
                { this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, nHAPHANGComboBox.SelectedValue.ToString()); }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            try
            {
                this.xUAT_HD_NHAPHANG_SPTableAdapter.Fill(this.nghiepVu.XUAT_HD_NHAPHANG_SP, nHAPHANGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cT_NHAP_SPTableAdapter.Insert(nHAPHANGComboBox.SelectedValue.ToString(), sANPHAMComboBox.SelectedValue.ToString(), nHACUNGCAPComboBox.SelectedValue.ToString(), int.Parse(sLSpinEdit.Text), int.Parse(donGiaSpinEdit.Text));
            int dongia = int.Parse(donGiaSpinEdit.Text) + ((int.Parse(donGiaSpinEdit.Text) * 10) / 100);
            cT_NHAP_SPTableAdapter.update_dongia(dongia, sANPHAMComboBox.SelectedValue.ToString());
            MessageBox.Show("Them Thanh Cong");
            //load
            this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, nHAPHANGComboBox.SelectedValue.ToString());
            try
            {
                this.xUAT_HD_NHAPHANG_SPTableAdapter.Fill(this.nghiepVu.XUAT_HD_NHAPHANG_SP, nHAPHANGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nHAPHANGTableAdapter.DeleteQuery_MANHAP(nHAPHANGComboBox.SelectedValue.ToString());
            MessageBox.Show("Them Thanh Cong");
            //load
            this.nHAPHANGTableAdapter.Fill(this.nghiepVu.NHAPHANG);
            try
            {
                this.xUAT_HD_NHAPHANG_SPTableAdapter.Fill(this.nghiepVu.XUAT_HD_NHAPHANG_SP, nHAPHANGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cT_NHAP_SPTableAdapter.DeleteQuery_NCC(nHAPHANGComboBox.SelectedValue.ToString(), sANPHAMComboBox.SelectedValue.ToString(), nHACUNGCAPComboBox.SelectedValue.ToString());
            MessageBox.Show("Xoa Thanh Cong");
            //load
            this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, nHAPHANGComboBox.SelectedValue.ToString());
            try
            {
                this.xUAT_HD_NHAPHANG_SPTableAdapter.Fill(this.nghiepVu.XUAT_HD_NHAPHANG_SP, nHAPHANGComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cT_NHAP_SPTableAdapter.UpdateQuery(int.Parse(sLSpinEdit.Text), int.Parse(donGiaSpinEdit.Text), nHAPHANGComboBox.SelectedValue.ToString(),sANPHAMComboBox.SelectedValue.ToString());
            MessageBox.Show("Thành công");
            //load
            this.cT_Nhap_dkTableAdapter.Fill_dk(this.nghiepVu.CT_Nhap_dk, nHAPHANGComboBox.SelectedValue.ToString());
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }
    }
}
