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
            // TODO: This line of code loads data into the 'nghiepVu.LOAISANPHAM' table. You can move, or remove it, as needed.
            this.lOAISANPHAMTableAdapter.Fill(this.nghiepVu.LOAISANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.nghiepVu.KHO);
            // TODO: This line of code loads data into the 'nghiepVu.SP_Loaisp' table. You can move, or remove it, as needed.
            this.sP_LoaispTableAdapter.Fill(this.nghiepVu.SP_Loaisp);
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
            lOAISANPHAMComboBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0)
            {
                if(lOAISANPHAMComboBox.Text.Length != 0)
                {
                    sP_LoaispTableAdapter.FillBy_LOAISP_GIA(this.nghiepVu.SP_Loaisp, int.Parse(textBox2.Text), int.Parse(textBox3.Text), lOAISANPHAMComboBox.SelectedValue.ToString());
                }
                else
                {
                    sP_LoaispTableAdapter.FillBy_sreachTheoGia(this.nghiepVu.SP_Loaisp, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
                  
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sANPHAMDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kHOTableAdapter.FillBy_MASP(this.nghiepVu.KHO, sANPHAMDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sP_LoaispTableAdapter.FillBy_TENSP(this.nghiepVu.SP_Loaisp, textBox1.Text);
            }
            catch
            {

            }
        }
    }
}
