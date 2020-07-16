using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace nha_tro
{
    public partial class ThongKeLoaiSP : Form
    {
        public ThongKeLoaiSP()
        {
            InitializeComponent();
        }

        private void lOAISANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAISANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tt);

        }

        private void ThongKeLoaiSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.THONGKE_LOAISP' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'tt.LOAISANPHAM' table. You can move, or remove it, as needed.
            this.lOAISANPHAMTableAdapter.Fill(this.tt.LOAISANPHAM);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sl = 0;
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            //this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            try
            {
                this.tHONGKE_LOAISPTableAdapter.Fill(this.tt.THONGKE_LOAISP, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), lOAISANPHAMComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            int tongtien = 0;
            for (int i = 0; i < thongKe_SPDataGridView.RowCount - 1; i++)
            {
                if(string.Compare(thongKe_SPDataGridView.Rows[i].Cells[3].Value.ToString().Trim(),"khong") != 0) //tinh tien sp
                {
                    sl += int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString());
                    tongtien += (int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString()) * int.Parse(thongKe_SPDataGridView.Rows[i].Cells[5].Value.ToString()));
                }
                else
                {
                    sl += int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString());
                    tongtien += (int.Parse(thongKe_SPDataGridView.Rows[i].Cells[2].Value.ToString()) * int.Parse(thongKe_SPDataGridView.Rows[i].Cells[7].Value.ToString()));
                }
            }
            textBox1.Text = sl.ToString();
            textBox2.Text = tongtien.ToString();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox2.Text = String.Format(culture, "{0:N0}", value);
            textBox2.Select(textBox2.Text.Length, 0);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {       
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tklsp thongkeloaispviewer = new tklsp(new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))), lOAISANPHAMComboBox.SelectedValue.ToString());
            thongkeloaispviewer.Show();
        }
    }
}
