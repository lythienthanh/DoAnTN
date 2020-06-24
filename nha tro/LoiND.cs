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
    public partial class LoiND : Form
    {
        public LoiND()
        {
            InitializeComponent();
        }

        private void lOIDONGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOIDONGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void LoiND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.LOIDONGUOIDUNG' table. You can move, or remove it, as needed.
            this.lOIDONGUOIDUNGTableAdapter.Fill(this.nghiepVu.LOIDONGUOIDUNG);

            lOIDONGUOIDUNGDataGridView.BorderStyle = BorderStyle.None;
            lOIDONGUOIDUNGDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lOIDONGUOIDUNGDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lOIDONGUOIDUNGDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lOIDONGUOIDUNGDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lOIDONGUOIDUNGDataGridView.BackgroundColor = Color.White;

            lOIDONGUOIDUNGDataGridView.EnableHeadersVisualStyles = false;
            lOIDONGUOIDUNGDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lOIDONGUOIDUNGDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            lOIDONGUOIDUNGDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void lOIDONGUOIDUNGDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lOIDONGUOIDUNGTableAdapter.Insert(mALOINDTextEdit.Text, tENLOINDTextEdit.Text);
                this.lOIDONGUOIDUNGTableAdapter.Fill(this.nghiepVu.LOIDONGUOIDUNG);
            }
            catch
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lOIDONGUOIDUNGTableAdapter.Delete(mALOINDTextEdit.Text, tENLOINDTextEdit.Text);
            this.lOIDONGUOIDUNGTableAdapter.Fill(this.nghiepVu.LOIDONGUOIDUNG);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lOIDONGUOIDUNGTableAdapter.UpdateLOIDONGUOIDUNG(tENLOINDTextEdit.Text, mALOINDTextEdit.Text);
            this.lOIDONGUOIDUNGTableAdapter.Fill(this.nghiepVu.LOIDONGUOIDUNG);
        }
    }
}
