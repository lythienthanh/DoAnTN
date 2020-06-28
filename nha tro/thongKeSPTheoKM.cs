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
    public partial class thongKeSPTheoKM : Form
    {
        public thongKeSPTheoKM()
        {
            InitializeComponent();
        }

        private void kHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUYENMAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tt);

        }

        private void thongKeSPTheoKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            // TODO: This line of code loads data into the 'tt.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);

            kHUYENMAIDataGridView.BorderStyle = BorderStyle.None;
            kHUYENMAIDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHUYENMAIDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHUYENMAIDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHUYENMAIDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHUYENMAIDataGridView.BackgroundColor = Color.White;

            kHUYENMAIDataGridView.EnableHeadersVisualStyles = false;
            kHUYENMAIDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHUYENMAIDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHUYENMAIDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            thongKe_km_theo_maDataGridView.BorderStyle = BorderStyle.None;
            thongKe_km_theo_maDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            thongKe_km_theo_maDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            thongKe_km_theo_maDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            thongKe_km_theo_maDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            thongKe_km_theo_maDataGridView.BackgroundColor = Color.White;

            thongKe_km_theo_maDataGridView.EnableHeadersVisualStyles = false;
            thongKe_km_theo_maDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            thongKe_km_theo_maDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            thongKe_km_theo_maDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void fill_km_theo_maToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void kHUYENMAIComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kHUYENMAIDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.thongKe_km_theo_maTableAdapter.Fill_km_theo_ma(this.tt.ThongKe_km_theo_ma, kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            int sl = 0;
            int sltheosp = 0;
            int tongtien = 0;
            int tongtiendakm = 0;
            for (int i = 0; i < thongKe_km_theo_maDataGridView.RowCount - 1; i++)
            {
                sltheosp = int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[3].Value.ToString());
                int dongia = int.Parse(thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_km_theo_maDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                tongtien += ((sltheosp * dongia) * (int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[2].Value.ToString())) / 100);
                sl += int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[3].Value.ToString());

                tongtiendakm += (sltheosp * dongia);
                //xu li khuyen mai khach hang than thiet
                //tim ma khach hang
                string makh = sANPHAMTableAdapter.tim_makh_theo_mahd(int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[0].Value.ToString()));
                if (sANPHAMTableAdapter.solanmua_truocKM(Convert.ToDateTime(kHUYENMAIDataGridView.CurrentRow.Cells[4].Value.ToString()),makh) > 4)
                {
                    textBox2.Text = (tongtien - ((tongtien * 5) / 100)).ToString();
                    textBox3.Text = (tongtiendakm - (tongtien - ((tongtien * 5) / 100))).ToString();
                }
                else
                {
                    textBox2.Text = tongtien.ToString();
                }
            }
            textBox1.Text = sl.ToString();//sl tong
            
            tongtiendakm = 0;
            sl = 0;
            tongtien = 0;
            
        }

        ThongKe ThongKe = new ThongKe();
        private void button1_Click(object sender, EventArgs e)
        {
            ThongKe.xuatfile_tinhtong(thongKe_km_theo_maDataGridView, textBox2.Text, textBox1.Text, "ThongKe_SP_Theo_KM");
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox2.Text = String.Format(culture, "{0:N0}", value);
            textBox2.Select(textBox2.Text.Length, 0);
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
