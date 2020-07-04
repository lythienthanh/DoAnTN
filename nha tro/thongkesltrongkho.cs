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
    public partial class thongkesltrongkho : Form
    {
        public thongkesltrongkho()
        {
            InitializeComponent();
        }

        private void kHO1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void thongkesltrongkho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.makho_cbo' table. You can move, or remove it, as needed.
            this.makho_cboTableAdapter.Fill(this.nghiepVu.makho_cbo);
            // TODO: This line of code loads data into the 'tt.thongke_kho' table. You can move, or remove it, as needed.
            this.thongke_khoTableAdapter.Fill(this.tt.thongke_kho);
            // TODO: This line of code loads data into the 'nghiepVu.KHO1' table. You can move, or remove it, as needed.
            thongke_khoDataGridView.BorderStyle = BorderStyle.None;
            thongke_khoDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            thongke_khoDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            thongke_khoDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            thongke_khoDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            thongke_khoDataGridView.BackgroundColor = Color.White;

            thongke_khoDataGridView.EnableHeadersVisualStyles = false;
            thongke_khoDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            thongke_khoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            thongke_khoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thongke_khoTableAdapter.FillBy_TIMTEN(this.tt.thongke_kho, textBox1.Text);
            }
            catch { }
        }

        private void makho_cboComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                thongke_khoTableAdapter.FillBy_MAKHO(this.tt.thongke_kho, makho_cboComboBox.SelectedValue.ToString());
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                thongke_khoTableAdapter.FillBy_LOAISP(this.tt.thongke_kho, textBox2.Text);
            }
            catch { }
        }
    }
}
