using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace nha_tro
{
    public partial class ThongKeSanPham : Form
    {
        public ThongKeSanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void ThongKeSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);

            //this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sl = 0;
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            //this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            try
            {
                this.thongKe_SPTableAdapter.Fill(this.tt.ThongKe_SP, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), sANPHAMComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < thongKe_SPDataGridView.RowCount - 1; i++)
            {
                sl += int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString());
            }
            textBox1.Text = sl.ToString();
            string dongia = thongKe_SPTableAdapter.select_dongia(sANPHAMComboBox.SelectedValue.ToString()).ToString();
            textBox2.Text = (sl * int.Parse(dongia)).ToString();

        }
        ThongKe ThongKe = new ThongKe();
        private void button1_Click(object sender, EventArgs e)
        {
            ThongKe.xuatfile_tinhtong(thongKe_SPDataGridView, textBox2.Text,textBox1.Text, "ThongKe_SanPham");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox2.Text = String.Format(culture, "{0:N0}", value);
            textBox2.Select(textBox2.Text.Length, 0);
        }
    }
}
