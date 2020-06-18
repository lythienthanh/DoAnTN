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
    public partial class TimKiemTheoSanPham : Form
    {
        public TimKiemTheoSanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void TimKiemTheoSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            TimKiemSanPhamDataContext db = new TimKiemSanPhamDataContext();
            var x = from y in db.SANPHAMs where y.TENSP.Contains(textBox1.Text) select y;
            sANPHAMDataGridView.DataSource = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                TimKiemSanPhamDataContext db = new TimKiemSanPhamDataContext();
                var y = from x in db.SANPHAMs where (x.DonGia >= (int.Parse(textBox2.Text))) where (x.DonGia <= (int.Parse(textBox3.Text))) select x;
                sANPHAMDataGridView.DataSource = y;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            
            }
                  
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
