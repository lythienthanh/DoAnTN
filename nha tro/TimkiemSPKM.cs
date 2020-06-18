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
    public partial class TimkiemSPKM : Form
    {
        public TimkiemSPKM()
        {
            InitializeComponent();
        }

        private void kHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUYENMAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void TimkiemSPKM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.nghiepVu.KHUYENMAI);


            kHUYENMAIDataGridView.BorderStyle = BorderStyle.None;
            kHUYENMAIDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHUYENMAIDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHUYENMAIDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHUYENMAIDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHUYENMAIDataGridView.BackgroundColor = Color.White;

            kHUYENMAIDataGridView.EnableHeadersVisualStyles = false;
            kHUYENMAIDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHUYENMAIDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHUYENMAIDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiemSanPhamDataContext db = new TimKiemSanPhamDataContext();
            var x=from y in db.KHUYENMAIs where y.MASP.Contains(textBox1.Text) select y;
            kHUYENMAIDataGridView.DataSource = x;

        }
    }
}
