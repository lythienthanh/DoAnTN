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
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);

            nHACUNGCAPDataGridView.BorderStyle = BorderStyle.None;
            nHACUNGCAPDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            nHACUNGCAPDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            nHACUNGCAPDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            nHACUNGCAPDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            nHACUNGCAPDataGridView.BackgroundColor = Color.White;

            nHACUNGCAPDataGridView.EnableHeadersVisualStyles = false;
            nHACUNGCAPDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            nHACUNGCAPDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            nHACUNGCAPDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nHACUNGCAPTableAdapter.Insert(mANCCTextEdit.Text, tENNCCTextEdit.Text, dIACHITextEdit.Text, sDTTextEdit.Text);
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nHACUNGCAPTableAdapter.Delete(mANCCTextEdit.Text, tENNCCTextEdit.Text, dIACHITextEdit.Text, sDTTextEdit.Text);
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nHACUNGCAPTableAdapter.UpdateNCC(tENNCCTextEdit.Text, dIACHITextEdit.Text, sDTTextEdit.Text, mANCCTextEdit.Text);
            this.nHACUNGCAPTableAdapter.Fill(this.nghiepVu.NHACUNGCAP);

        }
    }
}
