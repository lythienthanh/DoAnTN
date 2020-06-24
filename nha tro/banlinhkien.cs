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
    public partial class banlinhkien : Form
    {
        public banlinhkien()
        {
            InitializeComponent();
        }

        private void lINHKIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lINHKIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void banlinhkien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);

            lINHKIENDataGridView.BorderStyle = BorderStyle.None;
            lINHKIENDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lINHKIENDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lINHKIENDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lINHKIENDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lINHKIENDataGridView.BackgroundColor = Color.White;

            lINHKIENDataGridView.EnableHeadersVisualStyles = false;
            lINHKIENDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lINHKIENDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            lINHKIENDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            kHUYENMAI_DKDataGridView.BorderStyle = BorderStyle.None;
            kHUYENMAI_DKDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHUYENMAI_DKDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHUYENMAI_DKDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHUYENMAI_DKDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHUYENMAI_DKDataGridView.BackgroundColor = Color.White;

            kHUYENMAI_DKDataGridView.EnableHeadersVisualStyles = false;
            kHUYENMAI_DKDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHUYENMAI_DKDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHUYENMAI_DKDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            kHACHHANG_dkDataGridView.BorderStyle = BorderStyle.None;
            kHACHHANG_dkDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHACHHANG_dkDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHACHHANG_dkDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHACHHANG_dkDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHACHHANG_dkDataGridView.BackgroundColor = Color.White;

            kHACHHANG_dkDataGridView.EnableHeadersVisualStyles = false;
            kHACHHANG_dkDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHACHHANG_dkDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHACHHANG_dkDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHUYENMAI_DKTableAdapter.Fill_DK(this.nghiepVu.KHUYENMAI_DK, mASPToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fill_dkToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHACHHANG_dkTableAdapter.Fill_dk(this.nghiepVu.KHACHHANG_dk, sDTToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
