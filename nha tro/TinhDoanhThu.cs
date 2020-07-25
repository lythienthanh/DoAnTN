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
    public partial class TinhDoanhThu : Form
    {
        public TinhDoanhThu()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime ngaytemp = Convert.ToDateTime("01/01/2000");
            //clear
            try
            {
                this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, ngaytemp, ngaytemp);
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
            //tinh thong ke theo ngay
            if (radioButton1.Checked == true)
            {
                try
                {
                    this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, dateTimePicker1.Value, dateTimePicker2.Value);
                }
                catch (System.Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                //tinh sl da ban
                int sl = 0;
                int tongtien = 0;

                for (int i = 0; i < thongKe_TinhDoanhThuDataGridView.RowCount - 1; i++)
                {
                    if (string.Compare(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString(), "khong") != 0)//tinh tien sp
                    {
                        if (thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString())) != null) //co km
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) - ((int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) * int.Parse(thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString())).ToString()) / 100);
                        }
                        else
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString()));
                        }
                    }
                    else//tinh tien lk
                    {
                        if (thongKe_SPTableAdapter.kt_km_lk(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString()), thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) != null)
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheolk = (thongKe_TinhDoanhThuTableAdapter.dongia_linhkien(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheolk) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) - ((int.Parse(dongiatheolk) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) * int.Parse(thongKe_SPTableAdapter.kt_km_lk(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString()), thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()).ToString()) / 100);
                        }
                        else
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheolk = (thongKe_TinhDoanhThuTableAdapter.dongia_linhkien(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheolk) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString()));
                        }
                    }
                }

                textBox4.Text = sl.ToString();
                textBox3.Text = tongtien.ToString();
                sl = 0;
                tongtien = 0;
            }
            else if (radioButton2.Checked == true)
            {
                string dauthang = DateTime.Today.Year + "/" + DateTime.Today.Month + "/01" ;
                string cuoithang = DateTime.Today.Year + "/" +DateTime.Today.Month + "/"+DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
                try
                {
                    this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, Convert.ToDateTime( dauthang), Convert.ToDateTime(cuoithang));
                }
                catch (System.Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                //tinh sl da ban
                int sl = 0;
                int tongtien = 0;
                for (int i = 0; i < thongKe_TinhDoanhThuDataGridView.RowCount - 1; i++)
                {
                    if (string.Compare(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString(), "khong") != 0)//tinh tien sp
                    {
                        if (thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString())) != null) //co km
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) - ((int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) * int.Parse(thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString())).ToString()) / 100);
                        }
                        else
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString()));
                        }
                    }
                    else//tinh tien lk
                    {
                        if (thongKe_SPTableAdapter.kt_km_lk(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString()), thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) != null)
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheolk = (thongKe_TinhDoanhThuTableAdapter.dongia_linhkien(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheolk) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) - ((int.Parse(dongiatheolk) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) * int.Parse(thongKe_SPTableAdapter.kt_km_lk(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString()), thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()).ToString()) / 100);
                        }
                        else
                        {
                            sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                            string dongiatheolk = (thongKe_TinhDoanhThuTableAdapter.dongia_linhkien(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString())).ToString();
                            tongtien += (int.Parse(dongiatheolk) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString()));
                        }
                    }
                }
                textBox4.Text = sl.ToString();
                textBox3.Text = tongtien.ToString();
                sl = 0;
                tongtien = 0;
            }
            else
            {
/*                string daunam = textBox2.Text + "/01/01"  ;
                string cuoinam = textBox1.Text + "/01/01" ;
                try
                {
                    this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, Convert.ToDateTime( daunam),Convert.ToDateTime( cuoinam));
                }
                catch (System.Exception ex)
                {
                    //System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                //tinh sl da ban
                int sl = 0;
                int tongtien = 0;
                for (int i = 0; i < thongKe_TinhDoanhThuDataGridView.RowCount - 1; i++)
                {
                    if (thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString())) != null) //co km
                    {
                        sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                        string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                        tongtien += (int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString())) - ((int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString()))*int.Parse(thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[0].Value.ToString())).ToString()) /100);
                    }
                    else
                    {
                        sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                        string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                        tongtien += (int.Parse(dongiatheomasp) * int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString()));
                    }
                }
                textBox4.Text = sl.ToString();
                textBox3.Text = tongtien.ToString();
                sl = 0;
                tongtien = 0;*/
            }


            try
            {
                this.hOADON_chenhlechTableAdapter.Fill(this.tt.HOADON_chenhlech, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString(), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString(), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int tienbaohanh = 0;

            for (int i = 0; i < hOADON_chenhlechDataGridView.RowCount - 1; i++)
            {
                if (int.Parse(hOADON_chenhlechDataGridView.Rows[i].Cells[0].Value.ToString()) >= 0)
                {
                    tienbaohanh += int.Parse(hOADON_chenhlechDataGridView.Rows[i].Cells[0].Value.ToString());
                }
                else
                {
                    string temp = hOADON_chenhlechDataGridView.Rows[i].Cells[0].Value.ToString();
                    string temp1 = temp.Substring(1, temp.Length - 1);
                    tienbaohanh += int.Parse(temp1);
                }
            }

            textBox2.ReadOnly = true;
            textBox2.Text = tienbaohanh.ToString();

            textBox1.ReadOnly = true;
            textBox1.Text = hOADON_chenhlechTableAdapter.tien_suachua(Convert.ToDateTime(dateTimePicker1.Value.ToString()), Convert.ToDateTime(dateTimePicker2.Value.ToString())).ToString();

        }

        private void TinhDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            thongKe_TinhDoanhThuDataGridView.BorderStyle = BorderStyle.None;
            thongKe_TinhDoanhThuDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            thongKe_TinhDoanhThuDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            thongKe_TinhDoanhThuDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            thongKe_TinhDoanhThuDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            thongKe_TinhDoanhThuDataGridView.BackgroundColor = Color.White;

            thongKe_TinhDoanhThuDataGridView.EnableHeadersVisualStyles = false;
            thongKe_TinhDoanhThuDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            thongKe_TinhDoanhThuDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            thongKe_TinhDoanhThuDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        ThongKe ThongKe = new ThongKe();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //do du lieu vao sheet
                /*string fromMont = dateTimePicker1.Value.ToString().Substring(0, 2);
                string fromDay = dateTimePicker1.Value.ToString().Substring(3, 2);
                string fromyear = dateTimePicker1.Value.ToString().Substring(6, 4);

                string toMont = dateTimePicker2.Value.ToString().Substring(0, 2);
                string tongay = dateTimePicker2.Value.ToString().Substring(3, 2);
                string toYear = dateTimePicker2.Value.ToString().Substring(6, 4);
*/
                //sreach datagid
                string NamNgayThangStar = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                string NamNgayThangEnd = dateTimePicker2.Value.ToString("MM/dd/yyyy");

                //==========================================
                TinhDTTheoNgay tinhDTTheoNgay = new TinhDTTheoNgay(textBox4.Text, textBox3.Text, DateTime.Today.ToString("dd/MM/yyyy"), NamNgayThangStar, NamNgayThangEnd);
                tinhDTTheoNgay.ShowDialog();

/*                ThongKe.xuatfile_tinhtong_khoantime(thongKe_TinhDoanhThuDataGridView, textBox3.Text, textBox4.Text, NamNgayThangStar, NamNgayThangEnd, "ThongKe_DoanhThu");
*/            }
            else if (radioButton2.Checked == true)
            {
                
                //do du lieu vao sheet
                string dauthang =DateTime.Today.Month+ "/01/" + DateTime.Today.Year;
                string cuoithang = DateTime.Today.Month + "/"+ DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) + "/"  + DateTime.Today.Year;

                //==========================================
                
                TinhDTTheoNgay tinhDTTheoNgay = new TinhDTTheoNgay(textBox4.Text, textBox3.Text, DateTime.Today.ToString("dd/MM/yyyy"), dauthang, cuoithang);
                tinhDTTheoNgay.ShowDialog();
                //ThongKe.xuatfile_tinhtong_khoantime(thongKe_TinhDoanhThuDataGridView, textBox3.Text, textBox4.Text, dauthang, cuoithang, "ThongKe_DoanhThu");
            }
            else
            {
/*                //do du lieu vao sheet
                string daunam = "01/01/" + textBox2.Text;
                string cuoinam = "01/01/" + textBox1.Text;
                

                //==========================================
                //ThongKe.xuatfile_tinhtong_khoantime(thongKe_TinhDoanhThuDataGridView, textBox3.Text, textBox4.Text, daunam, cuoinam, "ThongKe_DoanhThu");
                TinhDTTheoNgay tinhDTTheoNgay = new TinhDTTheoNgay(textBox4.Text, textBox3.Text, DateTime.Today.ToString("dd/MM/yyyy"), daunam, cuoinam);
                tinhDTTheoNgay.ShowDialog();*/
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox3.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox3.Text = String.Format(culture, "{0:N0}", value);
            textBox3.Select(textBox3.Text.Length, 0);
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sl = 0;
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            //this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            try
            {
                this.thongKe_SPTableAdapter.Fill(this.tt.ThongKe_SP, dateTimePicker4.Value, dateTimePicker3.Value, sANPHAMComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            string dongia = thongKe_SPTableAdapter.select_dongia(sANPHAMComboBox.SelectedValue.ToString()).ToString();
            int tongtienhientai = 0;
            for (int i = 0; i < thongKe_SPDataGridView.RowCount - 1; i++)
            {
                sl += int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString());
                

                if (thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_SPDataGridView.Rows[i].Cells[0].Value.ToString())) != null) //co km
                {
                    tongtienhientai = int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString())*int.Parse(dongia);
                    tongtienbanduoc += tongtienhientai - (tongtienhientai * int.Parse(thongKe_SPTableAdapter.kt_cokm_k(int.Parse(thongKe_SPDataGridView.Rows[i].Cells[0].Value.ToString())).ToString())) /100;
                }
                else
                {
                    tongtienhientai = int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString()) * int.Parse(dongia);
                    tongtienbanduoc += tongtienhientai;
                }    
            }
            textBox6.Text = sl.ToString();
            textBox5.Text = tongtienbanduoc.ToString();

        }
        int tongtienbanduoc = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            hd_thongke_Sp hd_Thongke_Sp = new hd_thongke_Sp(DateTime.Today.ToString("dd/MM/yyyy"), dateTimePicker4.Value.ToString(), dateTimePicker3.Value.ToString(), sANPHAMComboBox.Text, textBox6.Text, tongtienbanduoc.ToString(), sANPHAMComboBox.SelectedValue.ToString());
            hd_Thongke_Sp.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox5.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox5.Text = String.Format(culture, "{0:N0}", value);
            textBox5.Select(textBox5.Text.Length, 0);
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
/*            try
            {
                this.hOADON_chenhlechTableAdapter.Fill(this.tt.HOADON_chenhlech, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngaybdToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(ngayktToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }
    }
}
