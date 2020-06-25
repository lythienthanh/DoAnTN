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
    public partial class banlinhkien : Form
    {
        public banlinhkien()
        {
            InitializeComponent();
        }

        private void lINHKIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lINHKIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void banlinhkien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.CT_HOADON_LINHKIEN' table. You can move, or remove it, as needed.
            this.cT_HOADON_LINHKIENTableAdapter.Fill(this.tt.CT_HOADON_LINHKIEN);
            // TODO: This line of code loads data into the 'tt.HOADON_timmahd_vuathem' table. You can move, or remove it, as needed.
            this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);
            // TODO: This line of code loads data into the 'tt.KHO_tt' table. You can move, or remove it, as needed.
            this.kHO_ttTableAdapter.Fill(this.tt.KHO_tt);
            // TODO: This line of code loads data into the 'nghiepVu.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            lINHKIENDataGridView.BorderStyle = BorderStyle.None;
            lINHKIENDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lINHKIENDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lINHKIENDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lINHKIENDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lINHKIENDataGridView.BackgroundColor = Color.White;

            lINHKIENDataGridView.EnableHeadersVisualStyles = false;
            lINHKIENDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lINHKIENDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            lINHKIENDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            kHUYENMAI_lk_malkDataGridView.BorderStyle = BorderStyle.None;
            kHUYENMAI_lk_malkDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHUYENMAI_lk_malkDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHUYENMAI_lk_malkDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHUYENMAI_lk_malkDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHUYENMAI_lk_malkDataGridView.BackgroundColor = Color.White;

            kHUYENMAI_lk_malkDataGridView.EnableHeadersVisualStyles = false;
            kHUYENMAI_lk_malkDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHUYENMAI_lk_malkDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHUYENMAI_lk_malkDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            kHACHHANG_dkDataGridView.BorderStyle = BorderStyle.None;
            kHACHHANG_dkDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHACHHANG_dkDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHACHHANG_dkDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHACHHANG_dkDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHACHHANG_dkDataGridView.BackgroundColor = Color.White;

            kHACHHANG_dkDataGridView.EnableHeadersVisualStyles = false;
            kHACHHANG_dkDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHACHHANG_dkDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHACHHANG_dkDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


            ct_mua_lkDataGridView.BorderStyle = BorderStyle.None;
            ct_mua_lkDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ct_mua_lkDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ct_mua_lkDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ct_mua_lkDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ct_mua_lkDataGridView.BackgroundColor = Color.White;

            ct_mua_lkDataGridView.EnableHeadersVisualStyles = false;
            ct_mua_lkDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ct_mua_lkDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ct_mua_lkDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
/*            try
            {
                this.kHUYENMAI_DKTableAdapter.Fill_DK(this.nghiepVu.KHUYENMAI_DK, mASPToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void fill_dkToolStripButton1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHACHHANG_dkTableAdapter.Fill_dk(this.nghiepVu.KHACHHANG_dk, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang quanLyKhachHang = new QuanLyKhachHang();
            quanLyKhachHang.ShowDialog();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void lINHKIENDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.kHUYENMAI_lk_malkTableAdapter.Fill(this.nghiepVu.KHUYENMAI_lk_malk, lINHKIENDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBox4.Text = lINHKIENDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox4.ReadOnly = true;
        }
        public int kt_sl_trongKho() // 0 hết | 1 còn
        {
            int? sltk = kHO_ttTableAdapter.KT_SL_TRONGKHO(lINHKIENDataGridView.CurrentRow.Cells[0].Value.ToString());
            int slmht = int.Parse(textBox5.Text);
            if (sltk - slmht < 0)
                return 0;
            return 1;
        }
        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public banlinhkien(string Message)
            : this()
        {
            tendn = Message;
        }


        int temp = 0;
        int mahd = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (kt_sl_trongKho() != 0)
            {
                //TIM MA NV
                try
                {
                    this.tAIKHOAN_TIMMANVTableAdapter.Fill_TIMMANV(this.tt.TAIKHOAN_TIMMANV, tendn);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                string MaNV = tAIKHOAN_TIMMANVDataGridView.Rows[0].Cells[0].Value.ToString();
                //=====================================================================================

                //tao hoa hon
                if (temp == 0)
                {
                    hOADON_ttTableAdapter.Insert("temp", "MLHD02", DateTime.Today, "temp", MaNV);
                    temp++;
                }
                //=====================================================================================

                //them CT_HOADON_LINHKIEN
                mahd = int.Parse(hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString()) + 1;
                cT_HOADON_LINHKIENTableAdapter.Insert(textBox4.Text,mahd,int.Parse(textBox5.Text));
                textBox2.Text = mahd.ToString();
                textBox2.ReadOnly = true;
                //=========================================================================================

                //cap lai sl trong kho
                kHO_ttTableAdapter.Update_SL_LK(int.Parse(textBox5.Text), lINHKIENDataGridView.CurrentRow.Cells[0].Value.ToString());
                //===================================================================================================================

                
                //load data
                try
                {
                    this.ct_mua_lkTableAdapter.Fill(this.tt.ct_mua_lk, mahd);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                //=============================================================


                //tinh tien
                tongtien += lINHKIENTableAdapter.select_dongia_malk(textBox4.Text);              
                //==================================================================

                //kt xem co khuyen mai khong
                if (kHUYENMAI_lk_malkTableAdapter.KT_COKMKHONG(textBox4.Text, DateTime.Today) == 1)
                {
                    string giatri = kHUYENMAI_lk_malkTableAdapter.FillBy_SELECTGIATRI(textBox4.Text, DateTime.Today).ToString();
                    tongtien = tongtien - tongtien * int.Parse(giatri) / 100;
                    tienkm += tongtien * int.Parse(giatri) / 100;
                }
                //=================================================================
                label7.Text = tongtien.ToString();


            }
            else
            {
                MessageBox.Show("Linh kiện đã hết"); ;
            }

        }
        int? tienkm = 0;
        int? tongtien = 0;
        private void fill_TIMMANVToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void kHACHHANG_dkDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = kHACHHANG_dkDataGridView.CurrentRow.Cells[0].Value.ToString();
            textBox3.ReadOnly = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hd_lk hd_Lk = new hd_lk(textBox2.Text, DateTime.Today.ToString("dd/MM/yyyy"), tienkm.ToString(), label7.Text);
            hd_Lk.ShowDialog();
        }
    }
}
