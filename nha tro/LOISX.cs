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
    public partial class LOISX : Form
    {
        public LOISX()
        {
            InitializeComponent();
        }

        private void lOIDONHASXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOIDONHASXBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void LOISX_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.LOIDONHASX' table. You can move, or remove it, as needed.
            this.lOIDONHASXTableAdapter.Fill(this.nghiepVu.LOIDONHASX);

            lOIDONHASXDataGridView.BorderStyle = BorderStyle.None;
            lOIDONHASXDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            lOIDONHASXDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            lOIDONHASXDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            lOIDONHASXDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            lOIDONHASXDataGridView.BackgroundColor = Color.White;

            lOIDONHASXDataGridView.EnableHeadersVisualStyles = false;
            lOIDONHASXDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            lOIDONHASXDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            lOIDONHASXDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lOIDONHASXTableAdapter.Insert(mALOISXTextEdit.Text, tENLOISXTextEdit.Text);
                this.lOIDONHASXTableAdapter.Fill(this.nghiepVu.LOIDONHASX);
            }
            catch {

                MessageBox.Show("Không được nhập trùng mã or bỏ trống");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                lOIDONHASXTableAdapter.Delete(mALOISXTextEdit.Text, tENLOISXTextEdit.Text);
                this.lOIDONHASXTableAdapter.Fill(this.nghiepVu.LOIDONHASX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền chính xác mã lỗi");
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lOIDONHASXTableAdapter.UpdateLOIDONHASX(tENLOISXTextEdit.Text, mALOISXTextEdit.Text);
            this.lOIDONHASXTableAdapter.Fill(this.nghiepVu.LOIDONHASX);
        }
    }
}
