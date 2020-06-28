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
            //clear
            try
            {
                this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Convert.ToDateTime("01/01/1800"), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Convert.ToDateTime("01/01/1800"), typeof(System.DateTime))))));
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
                    this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
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
                    sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                    string dongiatheomasp = (thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString())).ToString();
                    tongtien += (int.Parse(dongiatheomasp) * sl);
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
                    this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Convert.ToDateTime(dauthang), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Convert.ToDateTime(cuoithang), typeof(System.DateTime))))));
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
                    sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                    int dongiatheomasp = int.Parse(thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                    tongtien += (dongiatheomasp * sl);
                }
                textBox4.Text = sl.ToString();
                textBox3.Text = tongtien.ToString();
                sl = 0;
                tongtien = 0;
            }
            else
            {
                string daunam = textBox2.Text + "/01/01"  ;
                string cuoinam = textBox1.Text + "/01/01" ;
                try
                {
                    this.thongKe_TinhDoanhThuTableAdapter.Fill(this.tt.ThongKe_TinhDoanhThu, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Convert.ToDateTime(daunam), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Convert.ToDateTime(cuoinam), typeof(System.DateTime))))));
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
                    sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[3].Value.ToString());
                    int dongiatheomasp = int.Parse(thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                    tongtien += (dongiatheomasp * sl);
                }
                textBox4.Text = sl.ToString();
                textBox3.Text = tongtien.ToString();
                sl = 0;
                tongtien = 0;
            }

        }

        private void TinhDoanhThu_Load(object sender, EventArgs e)
        {
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
                //do du lieu vao sheet
                string daunam = "01/01/" + textBox2.Text;
                string cuoinam = "01/01/" + textBox1.Text;
                

                //==========================================
                //ThongKe.xuatfile_tinhtong_khoantime(thongKe_TinhDoanhThuDataGridView, textBox3.Text, textBox4.Text, daunam, cuoinam, "ThongKe_DoanhThu");
                TinhDTTheoNgay tinhDTTheoNgay = new TinhDTTheoNgay(textBox4.Text, textBox3.Text, DateTime.Today.ToString("dd/MM/yyyy"), daunam, cuoinam);
                tinhDTTheoNgay.ShowDialog();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox3.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox3.Text = String.Format(culture, "{0:N0}", value);
            textBox3.Select(textBox3.Text.Length, 0);
        }
    }
}
