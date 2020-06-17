using nha_tro.NghiepVuTableAdapters;
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
    public partial class thanhtoantheophantramLK : Form
    {
        public thanhtoantheophantramLK()
        {
            InitializeComponent();
        }

        //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public thanhtoantheophantramLK(string Message) : this()
        {
            tendn = Message;
        }

        private void tinhTrangTTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void thanhtoantheophantramLK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            // TODO: This line of code loads data into the 'tt.HOADON_timmahd_vuathem' table. You can move, or remove it, as needed.
            this.hOADON_timmahd_vuathemTableAdapter.Fill_timmahd_vuathem(this.tt.HOADON_timmahd_vuathem);
            // TODO: This line of code loads data into the 'tt.HOADON_tt' table. You can move, or remove it, as needed.
            this.hOADON_ttTableAdapter.Fill(this.tt.HOADON_tt);
            // TODO: This line of code loads data into the 'tt.TinhTrangTT' table. You can move, or remove it, as needed.
            this.tinhTrangTTTableAdapter.Fill(this.tt.TinhTrangTT);
            // TODO: This line of code loads data into the 'nghiepVu.NHAPHANG1' table. You can move, or remove it, as needed.
            this.nHAPHANG1TableAdapter.FillBy_lk(this.nghiepVu.NHAPHANG1);

        }

        private void fill_theoMaNhapToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void nHAPHANG1DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label14.Text = nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString();
            try
            {
                this.cT_NHAP_LK_theoMaNhapTableAdapter.Fill_theoMaNhap(this.tt.CT_NHAP_LK_theoMaNhap, nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            this.nHAPHANG1TableAdapter.FillBy_FULL_LK(nghiepVu.NHAPHANG1);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            this.nHAPHANG1TableAdapter.FillBy_LK_DaThanhToan(nghiepVu.NHAPHANG1);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            this.nHAPHANG1TableAdapter.FillBy_ChuaThanhToan_LK(nghiepVu.NHAPHANG1);
        }

        private void cT_NHAP_SP_DK_LUUKHODataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label15.Text = cT_NHAP_SP_DK_LUUKHODataGridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cT_NHAP_SP_DK_LUUKHODataGridView.RowCount != 1 /*&& cT_NHAP_LK_sreach_lk_manhapDataGridView.RowCount != 1*/)
            {
                hOADON_ttTableAdapter.Insert(label15.Text,"MLHD01",DateTime.Today,"temp",tAIKHOANDataGridView.CurrentRow.Cells[0].Value.ToString());
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
                hOADON_ttTableAdapter.Insert(label15.Text, "MLHD03", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
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
                hOADON_ttTableAdapter.Insert(label15.Text, "MLHD01", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
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
                hOADON_ttTableAdapter.Insert(label15.Text, "MLHD03", DateTime.Today, "temp", tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString());
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hOADON_kttontaiTableAdapter.Fill(this.tt.HOADON_kttontai, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(nGAYLAPToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tinhTrangTTDataGridView1_Click(object sender, EventArgs e)
        {
            textBox3.Text = tinhTrangTTDataGridView1.CurrentRow.Cells[0].Value.ToString();
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
                    if (int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString()) <= 100)
                    {
                        //update tinh trang trong bang tinhtrangTT
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");    
                    }
                    else
                        MessageBox.Show("vượt quá số tiền phải trả !!!");
                }
                else
                {
                    if (int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString()) <= tongtien)
                    {
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox6.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");
                        /*int sotiendatra = int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString());
                        int sotienconlai = tongtien - sotiendatra;*/
                      
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

        private void button3_Click(object sender, EventArgs e)
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
                    if (int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString()) <= 100)
                    {
                        //update tinh trang trong bang tinhtrangTT
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox4.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");

                        int phantramdatra = int.Parse(textBox4.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString());
                        int phantramconlai = 100 - phantramdatra;
                        int tontienconlaiphaitra = tongtien * phantramconlai / 100;

                        ThongKe thongKe = new ThongKe();
                        thongKe.xuatfileHD_TragopNCC(tinhTrangTTDataGridView1, (int.Parse(textBox4.Text) * tongtien / 100).ToString(), tontienconlaiphaitra.ToString(), DateTime.Today.ToString(), "hdTG_NCC");
                    }
                    else
                        MessageBox.Show("vượt quá số tiền phải trả !!!");
                }
                else
                {
                    if (int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString()) <= tongtien)
                    {
                        tinhTrangTTTableAdapter.UpdateQuery(int.Parse(textBox6.Text), int.Parse(textBox3.Text));
                        //update trang thai trong bang phieu nhap
                        tinhTrangTTTableAdapter.updatetinhtrang(nHAPHANG1DataGridView.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Thành Công");
                        int sotiendatra = int.Parse(textBox6.Text) + int.Parse(tinhTrangTTDataGridView1.Rows[0].Cells[1].Value.ToString());
                        int sotienconlai = tongtien - sotiendatra;
                        ThongKe thongKe = new ThongKe();
                        thongKe.xuatfileHD_TragopNCC(tinhTrangTTDataGridView1, textBox6.ToString(), sotienconlai.ToString(), DateTime.Today.ToString(), "hdTG_NCC");


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
    }
}
