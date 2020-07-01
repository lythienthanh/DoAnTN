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
    public partial class ThongKeTop5 : Form
    {
        public ThongKeTop5()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOP_5TableAdapter.Fill(this.tt.TOP_5, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            if (thongKe_SPDataGridView.RowCount == 1)
                MessageBox.Show("Không có dữ liệu !!!");
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tOP_10TableAdapter.Fill(this.tt.TOP_10, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker4.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker3.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            if (thongKe_SPDataGridView.RowCount == 1)
            {
                MessageBox.Show("Không có dữ liệu !!!");
            }
        }

        private void ThongKeTop5_Load(object sender, EventArgs e)
        {
            thongKe_SPDataGridView.BorderStyle = BorderStyle.None;
            thongKe_SPDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            thongKe_SPDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            thongKe_SPDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            thongKe_SPDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            thongKe_SPDataGridView.BackgroundColor = Color.White;

            thongKe_SPDataGridView.EnableHeadersVisualStyles = false;
            thongKe_SPDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            thongKe_SPDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            thongKe_SPDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
