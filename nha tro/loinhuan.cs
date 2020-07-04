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
    public partial class loinhuan : Form
    {
        public loinhuan()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.thongke_loinhuanTableAdapter.Fill(this.tt.thongke_loinhuan, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString(), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString(), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            int sl = 0;
            int tongtiennhap = 0;
            int tongtienban = 0;
            for (int i = 0; i < thongKe_TinhDoanhThuDataGridView.RowCount - 1; i++)
            {
                sl += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString());
                tongtiennhap += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) * int.Parse(thongke_loinhuanTableAdapter.dongianhap(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString(), DateTime.Today.ToString("MM/dd/yyyy")).ToString());
                tongtienban += int.Parse(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[4].Value.ToString()) * int.Parse(thongke_loinhuanTableAdapter.dongia_ban(thongKe_TinhDoanhThuDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
            }
            textBox4.Text = sl.ToString();
            textBox2.Text = tongtiennhap.ToString();
            textBox1.Text = tongtienban.ToString();
            textBox3.Text = (tongtienban - tongtiennhap).ToString();

        }

        private void loinhuan_Load(object sender, EventArgs e)
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
    }
}
