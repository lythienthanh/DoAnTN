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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.TraGop' table. You can move, or remove it, as needed.
            this.traGopTableAdapter.Fill(this.tt.TraGop);
            // TODO: This line of code loads data into the 'tt.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter1.Fill(this.tt.KHUYENMAI);
            // TODO: This line of code loads data into the 'tt.KHO_tt' table. You can move, or remove it, as needed.
            this.kHO_ttTableAdapter.Fill(this.tt.KHO_tt);
            // TODO: This line of code loads data into the 'tt.HOADON_timmahd_vuathem' table. You can move, or remove it, as needed.
            this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
            // TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);
            // TODO: This line of code loads data into the 'nghiepVu.Ct_mua_SP' table. You can move, or remove it, as needed.
            //this.ct_mua_SPTableAdapter.Fill(this.nghiepVu.Ct_mua_SP);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.nghiepVu.HOADON);
            // TODO: This line of code loads data into the 'nghiepVu.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.nghiepVu.HOADON);
            //// TODO: This line of code loads data into the 'nghiepVu.KHUYENMAI' table. You can move, or remove it, as needed.
            //this.kHUYENMAITableAdapter.Fill(this.nghiepVu.KHUYENMAI);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            maTraGopTextEdit.ReadOnly = true;

            sANPHAMDataGridView.BorderStyle = BorderStyle.None;
            sANPHAMDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            sANPHAMDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sANPHAMDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            sANPHAMDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            sANPHAMDataGridView.BackgroundColor = Color.White;

            sANPHAMDataGridView.EnableHeadersVisualStyles = false;
            sANPHAMDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            sANPHAMDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            sANPHAMDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
            kHUYENMAI_DKDataGridView.BorderStyle = BorderStyle.None;
            kHUYENMAI_DKDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHUYENMAI_DKDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHUYENMAI_DKDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHUYENMAI_DKDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHUYENMAI_DKDataGridView.BackgroundColor = Color.White;

            kHUYENMAI_DKDataGridView.EnableHeadersVisualStyles = false;
            kHUYENMAI_DKDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHUYENMAI_DKDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHUYENMAI_DKDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
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
            //
            ct_mua_SP_TIMKIEMDataGridView.BorderStyle = BorderStyle.None;
            ct_mua_SP_TIMKIEMDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ct_mua_SP_TIMKIEMDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ct_mua_SP_TIMKIEMDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            ct_mua_SP_TIMKIEMDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ct_mua_SP_TIMKIEMDataGridView.BackgroundColor = Color.White;

            ct_mua_SP_TIMKIEMDataGridView.EnableHeadersVisualStyles = false;
            ct_mua_SP_TIMKIEMDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ct_mua_SP_TIMKIEMDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            ct_mua_SP_TIMKIEMDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.kHUYENMAI_DKTableAdapter.Fill_DK(this.nghiepVu.KHUYENMAI_DK, mASPToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void sANPHAMDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.kHUYENMAI_DKTableAdapter.Fill_DK(this.nghiepVu.KHUYENMAI_DK, sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBox4.Text = sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void fill_dkToolStripButton_Click_1(object sender, EventArgs e)
        {
            ////try
            ////{
            ////    this.kHACHHANG_dkTableAdapter.Fill_dk(this.nghiepVu.KHACHHANG_dk, sDTToolStripTextBox.Text);
            ////}
            ////catch (System.Exception ex)
            ////{
            ////    System.Windows.Forms.MessageBox.Show(ex.Message);
            ////}

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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'nghiepVu.KHUYENMAI' table. You can move, or remove it, as needed.
            //this.kHUYENMAITableAdapter.Fill(this.nghiepVu.KHUYENMAI);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang QuanLyKhachHang = new QuanLyKhachHang();
            QuanLyKhachHang.ShowDialog();
        }
        int tongtien = 0;
        int tienkm = 0;
        ThongKe ThongKe = new ThongKe();
        private void button2_Click_1(object sender, EventArgs e)
        {
            temp = 0;
            //cap nhat lai kho
            for (int i = 0; i < ct_mua_SP_TIMKIEMDataGridView.Rows.Count - 1; i++)
            {
                kHO_ttTableAdapter.Update_sl_kho(int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString()), ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), "KHO1");

                //xu ly khuyen mai

                //kt co khuyen mai hay k
                try
                {
                    //lay don gia san pham
                    try
                    {
                        this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    int giatri = int.Parse(cT_KM_SPTableAdapter.SELECT_GIATRI(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), DateTime.Today).ToString());
                    int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                    int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                    int giatrisaukm = (sl * dongia * giatri) / 100;
                    tongtien += giatrisaukm;
                }
                catch
                {
                    //lay don gia san pham
                    try
                    {
                        this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }

                    int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                    int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                    tongtien += (sl * dongia);
                }   
            }

            // xu li khuyen mai khach hang than thiet
            if (int.Parse(sANPHAMTableAdapter.demsolanmua(textBox1.Text).ToString()) > 4)
            {
                tongtien = (tongtien - ((tongtien * 5) / 100));
                label7.Text = tongtien.ToString();

            }
            else
            {
                label7.Text = tongtien.ToString();
            }

            int temp1 = 0;
            for(int i=0;i < ct_mua_SP_TIMKIEMDataGridView.Rows.Count - 1; i++)
            {
                temp1 += int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString()) * int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
            }
            tienkm = temp1 - tongtien;

            //xuat report
            hd_banhang hd_Banhang = new hd_banhang(mahd.ToString(), textBox3.Text, tienkm.ToString(), tongtien.ToString());
            hd_Banhang.ShowDialog();
            //===========

            //XU LY XUAT pdf======================================================================================
            /*
             * 
             *              
                        //sreach datagid
                        string NamNgayThangStar = DateTime.Today.ToString("dd/MM/yyyy");

                        //==========================================
                        ThongKe.xuatfile_HD(ct_mua_SP_TIMKIEMDataGridView, label7.Text, NamNgayThangStar, "Hoa_Don");

                        //========================

                        //Restart===============================================================================
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";

                        //load dl
                        try
                        {
                            this.ct_mua_SP_TIMKIEMTableAdapter.Fill_TIMKIEM(this.tt.Ct_mua_SP_TIMKIEM, ((int)(System.Convert.ChangeType(1, typeof(int)))), "KH01");
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                        textBox2.ReadOnly = false;
                        //cap nhat kho linh kien
                        *//*            if (ct_KM_LKDataGridView.RowCount != 1)
                                    {
                                        ct_KM_LKTableAdapter.UpdateSL(ct_KM_LKDataGridView.Rows[0].Cells[2].Value.ToString());
                                    }*/
            //==================================================================================================
            MessageBox.Show("Thành công!!!");

            tongtien = 0;


            // TODO: This line of code loads data into the 'tt.HOADON_timmahd_vuathem' table. You can move, or remove it, as needed.
            this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
        }

        private void hOADONGridControl_Click(object sender, EventArgs e)
        {

        }

        private void hOADONGridControl_Click_1(object sender, EventArgs e)
        {

        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void fill_DKToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.kHUYENMAI_DKTableAdapter.Fill_DK(this.nghiepVu.KHUYENMAI_DK, sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fill_dkToolStripButton_Click_3(object sender, EventArgs e)
        {
            //try
            //{
            //    this.kHACHHANG_dkTableAdapter.Fill_dk(this.nghiepVu.KHACHHANG_dk, sDTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public BanHang(string Message)
            : this()
        {
            tendn = Message;
        }
        int temp = 0;
        int mahd = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            //sreach manv
            if (textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox1.Text.Length != 0)
            {
                try
                {
                    this.tAIKHOAN_TIMMANVTableAdapter.Fill_TIMMANV(this.tt.TAIKHOAN_TIMMANV, tendn);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                string MaNV = tAIKHOAN_TIMMANVDataGridView.Rows[0].Cells[0].Value.ToString();
                //them hoa don
                if (temp == 0)
                {
                    hOADON_ttTableAdapter.Insert("temp", "MLHD02", DateTime.Today, "temp", MaNV);
                    temp++;
                }
                //them cthd

                mahd = int.Parse(hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString()) + 1;
                ct_mua_SPTableAdapter.Insert(mahd, textBox3.Text, textBox4.Text, textBox5.Text);
                textBox2.Text = mahd.ToString();
                textBox2.ReadOnly = true;
                //load dl
                try
                {
                    this.ct_mua_SP_TIMKIEMTableAdapter.Fill_TIMKIEM(this.tt.Ct_mua_SP_TIMKIEM, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))), textBox3.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }


                for (int i = 0; i < kHUYENMAI_DKDataGridView.Rows.Count - 1; i++)
                {
                    //kt co tang kem phu kien hay k neu co update sl trong kho linh kien
                    if (string.Compare(kHUYENMAI_DKDataGridView.Rows[i].Cells[2].Value.ToString(), "TEMP") == 0)
                    {
                        //MALINHKIEN = TEMP
                    }
                    else
                    {
                        //co tang kem linh kien
                        //update sl kho LK
                        kHO_ttTableAdapter.Update_SL_LK(1, kHUYENMAI_DKDataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                }


                //xu ly khuyen mai
                for (int i = 0; i < ct_mua_SP_TIMKIEMDataGridView.Rows.Count - 1; i++)
                {
                    //kHO_ttTableAdapter.Update_sl_kho(int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString()), ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), "KHO1");

                    //kt co khuyen mai giam gia san pham hay k
                    if (int.Parse(kHUYENMAITableAdapter1.kt_CoKMkhong(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), DateTime.Today).ToString()) != 0)
                    {
                        try
                        {
                            int giatri = int.Parse(kHUYENMAITableAdapter1.SELECT_GIATRI(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), DateTime.Today).ToString());
                            //sreach gia
                            try
                            {
                                this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                            }
                            catch (System.Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }
                            int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                            int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                            int giatrisaukm = (sl * dongia * giatri) / 100;
                            tongtien += giatrisaukm;
                        }
                        catch
                        {
                            int giatri = 1;

                            //sreach gia
                            try
                            {
                                this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                            }
                            catch (System.Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message);
                            }
                            int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                            int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                            int giatrisaukm = (sl * dongia * giatri) / 100;
                            tongtien += giatrisaukm;
                        }
                    }
                    else
                    {
                        //sreach gia
                        try
                        {
                            this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                        int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                        int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                        tongtien += (sl * dongia);
                    }
                }
                label7.Text = tongtien.ToString();
                soTienPhaiTraSpinEdit.Text = ((tongtien * 50) / 100).ToString();
                soTienConLaiSpinEdit.Text = (tongtien - int.Parse(soTienPhaiTraSpinEdit.Text)).ToString();

                int matragop = int.Parse(traGopTableAdapter.demrows().ToString()) + 1;

                maTraGopTextEdit.Text = matragop.ToString();
                try
                {
                    this.ct_hoa_donTableAdapter.Fill(this.tt.ct_hoa_don, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))), textBox3.Text, DateTime.Today);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                //xu li khuyen mai khach hang than thiet
                if (int.Parse(sANPHAMTableAdapter.demsolanmua(textBox1.Text).ToString()) > 4)
                {
                    label7.Text = (tongtien - ((tongtien * 5) / 100)).ToString();
                    MessageBox.Show("Bạn là khách hàng thân thiết nên được giảm 5% hóa đơn");
                }
                else
                {
                    label7.Text = tongtien.ToString();
                }
            }
            else
            {

                MessageBox.Show("Chưa đủ thông tin thanh toán");
            }
            tongtien = 0;

        }

        private void kHACHHANG_dkDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = kHACHHANG_dkDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void fill_TIMKIEMToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.ct_mua_SP_TIMKIEMTableAdapter.Fill_TIMKIEM(this.tt.Ct_mua_SP_TIMKIEM, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))), textBox3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fill_TIMMANVToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fill_sreach_giaToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            temp = 0;
            //insert tra gop
            traGopTableAdapter.Insert(maTraGopTextEdit.Text, int.Parse(soTienPhaiTraSpinEdit.Text), int.Parse(soTienConLaiSpinEdit.Text), DateTime.Today, DateTime.Today.AddDays(30));

            //sreach manv
            try
            {
                this.tAIKHOAN_TIMMANVTableAdapter.Fill_TIMMANV(this.tt.TAIKHOAN_TIMMANV, tendn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            string MaNV = tAIKHOAN_TIMMANVDataGridView.Rows[0].Cells[0].Value.ToString();

            //update matragop cho hoadon
            hOADON_ttTableAdapter.updateThanhToanTG(maTraGopTextEdit.Text, mahd);

            textBox2.Text = mahd.ToString();
            //
            temp = 0;
            //cap nhat lai kho
            for (int i = 0; i < ct_mua_SP_TIMKIEMDataGridView.Rows.Count - 1; i++)
            {
                kHO_ttTableAdapter.Update_sl_kho(int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString()), ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), "KHO1");

                //xu ly khuyen mai
                //kt co khuyen mai hay k
                if (int.Parse(kHUYENMAITableAdapter1.kt_CoKMkhong(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), DateTime.Today).ToString()) != 0)
                {
                    int giatri = int.Parse(kHUYENMAITableAdapter1.SELECT_GIATRI(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString(), DateTime.Today).ToString());
                    //sreach gia
                    try
                    {
                        this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                    int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                    int giatrisaukm = (sl * dongia * giatri) / 100;
                    tongtien += giatrisaukm;
                }
                else
                {
                    //sreach gia
                    try
                    {
                        this.sANPHAM__sreach_giaTableAdapter.Fill_sreach_gia(this.tt.SANPHAM__sreach_gia, ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[2].Value.ToString());
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    int sl = int.Parse(ct_mua_SP_TIMKIEMDataGridView.Rows[i].Cells[3].Value.ToString());
                    int dongia = int.Parse(sANPHAM__sreach_giaDataGridView.Rows[0].Cells[0].Value.ToString());
                    tongtien += (sl * dongia);
                }
            }
            //XU LY XUAT pdf

            //sreach datagid
            string NamNgayThangStar = DateTime.Today.ToString("dd/MM/yyyy");

            //==========================================
            ThongKe.xuatfile_HD_TraGop(ct_hoa_donDataGridView, maTraGopTextEdit.Text, label7.Text, NamNgayThangStar, "Hoa_Don_traGop");

            //========================

            //Restart==============================
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            maTraGopTextEdit.Text = "";
            soTienPhaiTraSpinEdit.Text = "";
            soTienConLaiSpinEdit.Text = "";
            //load dl
            try
            {
                this.ct_mua_SP_TIMKIEMTableAdapter.Fill_TIMKIEM(this.tt.Ct_mua_SP_TIMKIEM, ((int)(System.Convert.ChangeType(1, typeof(int)))), "KH01");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBox2.ReadOnly = false;
            MessageBox.Show("Thành công!!!");
            //cap nhat kho linh kien
            /*            if (ct_KM_LKDataGridView.RowCount != 1)
                        {
                            ct_KM_LKTableAdapter.UpdateSL(ct_KM_LKDataGridView.Rows[0].Cells[2].Value.ToString());
                        }*/
            label7.Text = tongtien.ToString();
            tongtien = 0;
            // TODO: This line of code loads data into the 'tt.HOADON_timmahd_vuathem' table. You can move, or remove it, as needed.
            this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.cT_KM_SPTableAdapter.Fill(this.tt.CT_KM_SP, mAKHUYENMAIToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void kHUYENMAI_DKDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*            try
                        {
                            this.cT_KM_SPTableAdapter.Fill(this.tt.CT_KM_SP, kHUYENMAI_DKDataGridView.CurrentRow.Cells[0].Value.ToString());
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }
                        try
                        {
                            this.ct_KM_LKTableAdapter.Fill(this.tt.Ct_KM_LK, kHUYENMAI_DKDataGridView.CurrentRow.Cells[0].Value.ToString());
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }*/

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {


        }
    }
}
