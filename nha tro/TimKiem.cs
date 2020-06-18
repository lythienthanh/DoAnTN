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
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

        private void fill_TK2ToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.timKiemChuaNhanhTableAdapter.Fill_TK(this.nghiepVu.TimKiemChuaNhanh, textBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            timKiemChuaNhanhDataGridView.BorderStyle = BorderStyle.None;
            timKiemChuaNhanhDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            timKiemChuaNhanhDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            timKiemChuaNhanhDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            timKiemChuaNhanhDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            timKiemChuaNhanhDataGridView.BackgroundColor = Color.White;

            timKiemChuaNhanhDataGridView.EnableHeadersVisualStyles = false;
            timKiemChuaNhanhDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            timKiemChuaNhanhDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            timKiemChuaNhanhDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
