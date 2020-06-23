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
    public partial class ThanhToanTheoPhanTramNH : Form
    {
        public ThanhToanTheoPhanTramNH()
        {
            InitializeComponent();
        }

        private void nHAPHANG1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHAPHANG1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void ThanhToanTheoPhanTramNH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.TinhTrangTT' table. You can move, or remove it, as needed.
            //this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            //// TODO: This line of code loads data into the 'tt.HOADON_timmahd_vuathem' table. You can move, or remove it, as needed.
            //this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);
            // TODO: This line of code loads data into the 'nghiepVu.CT_NHAP_SP' table. You can move, or remove it, as needed.
            this.cT_NHAP_SPTableAdapter.Fill(this.nghiepVu.CT_NHAP_SP);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.FillBy1_sp(this.nghiepVu.NHAPHANG1);



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

            tinhTrangTTDataGridView.BorderStyle = BorderStyle.None;
            tinhTrangTTDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tinhTrangTTDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tinhTrangTTDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            tinhTrangTTDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tinhTrangTTDataGridView.BackgroundColor = Color.White;

            tinhTrangTTDataGridView.EnableHeadersVisualStyles = false;
            tinhTrangTTDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tinhTrangTTDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tinhTrangTTDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void nHAPHANG1DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                this.cT_NHAP_SP_DK_LUUKHOTableAdapter.Fill_DK(this.nghiepVu.CT_NHAP_SP_DK_LUUKHO, label3.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            /*            try
                        {
                            this.cT_NHAP_LK_sreach_lk_manhapTableAdapter.Fill_sreach_lk_manhap(this.nghiepVu.CT_NHAP_LK_sreach_lk_manhap, label3.Text);
                        }
                        catch (System.Exception ex)
                        {
                            System.Windows.Forms.MessageBox.Show(ex.Message);
                        }*/

            //set button visible
            string tinhtranggoc = nHAPHANG1DataGridView.CurrentRow.Cells[3].Value.ToString();
            int dodai = tinhtranggoc.Length;
            if (dodai != 0)
            {
                string tinhtrang = tinhtranggoc.Substring(2, 1);
                if (string.Compare(tinhtrang, "%") == 0 || string.Compare(nHAPHANG1DataGridView.CurrentRow.Cells[3].Value.ToString(), "Đã lưu              ") == 0)
                {
                    button1.Enabled = false;
                }
                else
                    button1.Enabled = true;
            }
            else
                button1.Enabled = true;


            //xu ly thong tin phieu nhap theo hoa don

            tinhTrangTTTableAdapter.FillBy_selectPhieuNhap(this.tt.TinhTrangTT, nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
            tinhTrangTTTableAdapter.GetDataBy2_selectPhieuNhap(label13.Text);

        }


                //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public ThanhToanTheoPhanTramNH(string Message) : this()
        {
            tendn = Message;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //insert hoa don
            //tim ma nv
            try
            {
                this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendn);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            //==============================
            if (cT_NHAP_SP_DK_LUUKHODataGridView.RowCount != 1 /*&& cT_NHAP_LK_sreach_lk_manhapDataGridView.RowCount != 1*/)
            {
                hOADON_ttTableAdapter.Insert(label5.Text, "MLHD01", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
                //lay ma hd vua moi them
                this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
                string mahdvuathem = hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString();
                //insert tinh trang thanh toan
                if (textBox5.Text.Length == 0)
                {
                    tinhTrangTTTableAdapter.Insert(int.Parse(mahdvuathem), int.Parse(textBox1.Text), DateTime.Today, Convert.ToDateTime(textBox2.Text));
                    this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
                }
                else
                {
                    tinhTrangTTTableAdapter.Insert(int.Parse(mahdvuathem), int.Parse(textBox5.Text), DateTime.Today, Convert.ToDateTime(textBox2.Text));
                    this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);

                }
                hOADON_ttTableAdapter.Insert(label5.Text, "MLHD03", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
                //lay ma hd vua moi them
                this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
                mahdvuathem = hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString();
                //insert tinh trang thanh toan
                if (textBox5.Text.Length == 0)
                {
                    tinhTrangTTTableAdapter.Insert(int.Parse(mahdvuathem), int.Parse(textBox1.Text), DateTime.Today, Convert.ToDateTime(textBox2.Text));
                }
                else
                {
                    tinhTrangTTTableAdapter.Insert(int.Parse(mahdvuathem), int.Parse(textBox5.Text), DateTime.Today, Convert.ToDateTime(textBox2.Text));
                }
                //Thong bao
                MessageBox.Show("Thành công");
                this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            }
            else if (cT_NHAP_SP_DK_LUUKHODataGridView.RowCount != 0)
            {
                hOADON_ttTableAdapter.Insert(label5.Text, "MLHD01", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
                //lay ma hd vua moi them
                this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
                string mahdvuathem = hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString();
                //insert tinh trang thanh toan
                tinhTrangTTTableAdapter.Insert(int.Parse(mahdvuathem), int.Parse(textBox1.Text), DateTime.Today, Convert.ToDateTime(textBox2.Text));
                //Thong bao
                MessageBox.Show("Thành công");
                this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            }
            else 
            {
                hOADON_ttTableAdapter.Insert(label5.Text, "MLHD03", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
                //lay ma hd vua moi them
                this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
                string mahdvuathem = hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString();
                //insert tinh trang thanh toan
                tinhTrangTTTableAdapter.Insert(int.Parse(mahdvuathem), int.Parse(textBox1.Text), DateTime.Today, Convert.ToDateTime(textBox2.Text));
                //Thong bao
                MessageBox.Show("Thành công");
                this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            }

            //set trang thai

            if (textBox5.Text.Length == 0)
            {
                nHAPHANG1TableAdapter.UpdateQuery(textBox1.Text + "%", nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {

                nHAPHANG1TableAdapter.UpdateQuery(textBox5.Text, nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
            }

            //update manhap cho bang tinhtrangtt
            string mahd = hOADON_timmahd_vuathemDataGridView.Rows[0].Cells[0].Value.ToString();
            tinhTrangTTTableAdapter.updateMaNHAP(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString(), int.Parse(mahd));



            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
            button1.Enabled = true;
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

        private void fill_DKToolStripButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.cT_NHAP_SP_DK_LUUKHOTableAdapter.Fill_DK(this.nghiepVu.CT_NHAP_SP_DK_LUUKHO, mANHAPToolStripTextBox1.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void cT_NHAP_SP_DK_LUUKHODataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = cT_NHAP_SP_DK_LUUKHODataGridView.CurrentRow.Cells[2].Value.ToString();

        }

        private void fill_DKToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendnToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int tongtien = 0;
            for (int i = 0; i < cT_NHAP_SP_DK_LUUKHODataGridView.Rows.Count - 1; i++)
            {
                tongtien += (int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString()) * int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[4].Value.ToString()));
            }
            if ((textBox4.Text.Length == 0 && textBox6.Text.Length == 0) || (textBox4.Text.Length != 0 && textBox6.Text.Length != 0))
            {
                MessageBox.Show("Vui lòng lựa chọn một trong hai hình thức thanh toán");
            }
            else
            {
                //kiem tra tinh trang <= 100
                if (textBox6.Text.Length == 0)
                {
                    if (int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString()) <= 100)
                    {
                        //update tinh trang trong bang tinhtrangTT
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");

                        int phantramdatra = int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString());
                        int phantramconlai = 100 - phantramdatra;
                        int tontienconlaiphaitra = tongtien * phantramconlai / 100;

                        ThongKe thongKe = new ThongKe();
                        thongKe.xuatfileHD_TragopNCC(tinhTrangTTDataGridView, (int.Parse(textBox4.Text) * tongtien / 100).ToString(), tontienconlaiphaitra.ToString(), DateTime.Today.ToString(), "hdTG_NCC");
                    }
                    else
                        MessageBox.Show("vượt quá số tiền phải trả !!!");
                }
                else
                {
                    if (int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString()) <= tongtien)
                    {
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox6.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");
                        int sotiendatra = int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString());
                        int sotienconlai = tongtien - sotiendatra;
                        //ThongKe thongKe = new ThongKe();
                        //thongKe.xuatfileHD_TragopNCC(tinhTrangTTDataGridView, textBox6.ToString(), sotienconlai.ToString(), DateTime.Today.ToString(), "hdTG_NCC");


                    }
                    else
                    {
                        MessageBox.Show("vượt quá số tiền phải trả !!!");

                    }


                }
            }
            //load data
            this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
            try
            {
                int tinhtrangthanhtoan = int.Parse(tinhTrangTTTableAdapter.select_tinhtrangthanhtoan(int.Parse(textBox3.Text)).ToString());
                if (tinhtrangthanhtoan != 100)
                {
                    button2.Visible = true;
                }
                else
                {
                    button2.Visible = false;
                }
            }
            catch
            {
                button2.Visible = false;
            }
            
        }

        private void fill_sreach_lk_manhapToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void cT_NHAP_LK_sreach_lk_manhapDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*label5.Text = cT_NHAP_LK_sreach_lk_manhapDataGridView.CurrentRow.Cells[2].Value.ToString();*/
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
              
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            nHAPHANG1TableAdapter.FillBy(this.nghiepVu.NHAPHANG1); 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            nHAPHANG1TableAdapter.FillBy2(this.nghiepVu.NHAPHANG1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int tongtien = 0;
            for (int i = 0; i < cT_NHAP_SP_DK_LUUKHODataGridView.Rows.Count - 1; i++)
            {
                tongtien += (int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[3].Value.ToString()) * int.Parse(cT_NHAP_SP_DK_LUUKHODataGridView.Rows[i].Cells[4].Value.ToString()));
            }
            if ((textBox4.Text.Length == 0 && textBox6.Text.Length == 0) || (textBox4.Text.Length != 0 && textBox6.Text.Length != 0))
            {
                MessageBox.Show("Vui lòng lựa chọn một trong hai hình thức thanh toán");
            }
            else
            {
                //kiem tra tinh trang <= 100
                if (textBox6.Text.Length == 0)
                {
                    if (int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString()) <= 100)
                    {
                        //update tinh trang trong bang tinhtrangTT
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");

                        int phantramdatra = int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString());
                        int phantramconlai = 100 - phantramdatra;
                        int tontienconlaiphaitra = tongtien * phantramconlai / 100;

                        ThongKe thongKe = new ThongKe();
                        thongKe.xuatfileHD_TragopNCC(tinhTrangTTDataGridView, (int.Parse(textBox4.Text) * tongtien / 100).ToString(), tontienconlaiphaitra.ToString(), DateTime.Today.ToString(), "hdTG_NCC");
                    }
                    else
                        MessageBox.Show("vượt quá số tiền phải trả !!!");
                }
                else
                {
                    if (int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString()) <= tongtien)
                    {
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox6.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");
                        int sotiendatra = int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView.Rows[0].Cells[1].Value.ToString());
                        int sotienconlai = tongtien - sotiendatra;
                        ThongKe thongKe = new ThongKe();
                        thongKe.xuatfileHD_TragopNCC(tinhTrangTTDataGridView, textBox6.ToString(), sotienconlai.ToString(), DateTime.Today.ToString(), "hdTG_NCC");


                    }
                    else
                    {
                        MessageBox.Show("vượt quá số tiền phải trả !!!");

                    }


                }
            }
            //load data
            this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            this.nHAPHANG1TableAdapter.Fill(this.nghiepVu.NHAPHANG1);
        }

        private void tinhTrangTTDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = tinhTrangTTDataGridView.CurrentRow.Cells[0].Value.ToString();
            string x = tinhTrangTTDataGridView.CurrentRow.Cells[1].Value.ToString();
            if (int.Parse(x) > 100)
            {
                textBox4.Enabled = false;
                label8.Enabled = false;

            }
            else
            {
                textBox4.Enabled = true;
                label8.Enabled = true;
            
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }
    }
}
