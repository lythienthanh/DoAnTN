using nha_tro.ttTableAdapters;
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
            // TODO: This line of code loads data into the 'tt.sl_linhkien_trongkho' table. You can move, or remove it, as needed.
            this.sl_linhkien_trongkhoTableAdapter.Fill(this.tt.sl_linhkien_trongkho);
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

            sl_linhkien_trongkhoDataGridView.BorderStyle = BorderStyle.None;
            sl_linhkien_trongkhoDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            sl_linhkien_trongkhoDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sl_linhkien_trongkhoDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            sl_linhkien_trongkhoDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            sl_linhkien_trongkhoDataGridView.BackgroundColor = Color.White;

            sl_linhkien_trongkhoDataGridView.EnableHeadersVisualStyles = false;
            sl_linhkien_trongkhoDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            sl_linhkien_trongkhoDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            sl_linhkien_trongkhoDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
            try
            {
                sl_linhkien_trongkhoTableAdapter.FillBy_MAKHO(this.tt.sl_linhkien_trongkho, makho_cboComboBox.SelectedValue.ToString());
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sl_linhkien_trongkhoTableAdapter.FillBy_TENLINHKIEN(this.tt.sl_linhkien_trongkho, textBox3.Text);
        }
    }
}
