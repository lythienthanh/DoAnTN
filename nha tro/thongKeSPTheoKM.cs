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
            // TODO: This line of code loads data into the 'tt.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);

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
            for (int i = 0; i < thongKe_km_theo_maDataGridView.RowCount - 1; i++)
            {
                sltheosp = int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[3].Value.ToString());
                int dongia = int.Parse(thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_km_theo_maDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                tongtien += ((sltheosp * dongia) * (int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[2].Value.ToString())) / 100);
                sl += int.Parse(thongKe_km_theo_maDataGridView.Rows[i].Cells[3].Value.ToString());
            }
            textBox1.Text = sl.ToString();//sl tong
            textBox2.Text = tongtien.ToString();
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
    }
}
