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
    public partial class TraGopNCC : Form
    {
        public TraGopNCC()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tHONGKE_TRAGOP_NCCTableAdapter.Fill(this.tt.THONGKE_TRAGOP_NCC, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value.ToString("MM/dd/yyyy"), typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value.ToString("MM/dd/yyyy"), typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


            for(int i = 0; i < tHONGKE_TRAGOP_NCCDataGridView.RowCount - 1; i++)
            {
                sl += int.Parse(tHONGKE_TRAGOP_NCCDataGridView.Rows[i].Cells[3].Value.ToString());
                tongtien += int.Parse(tHONGKE_TRAGOP_NCCDataGridView.Rows[i].Cells[3].Value.ToString()) * int.Parse(tHONGKE_TRAGOP_NCCDataGridView.Rows[i].Cells[4].Value.ToString());
                if (int.Parse(tHONGKE_TRAGOP_NCCDataGridView.Rows[i].Cells[7].Value.ToString()) <= 100)
                    tongtiendathanhtoan += tongtien - (tongtien * int.Parse(tHONGKE_TRAGOP_NCCDataGridView.Rows[i].Cells[7].Value.ToString()) / 100);
                else
                    tongtiendathanhtoan += tongtien - int.Parse(tHONGKE_TRAGOP_NCCDataGridView.Rows[i].Cells[7].Value.ToString());
            }



            textBox1.Text = sl.ToString();
            textBox3.Text = tongtiendathanhtoan.ToString();
            textBox4.Text = (tongtien - tongtiendathanhtoan).ToString();
            textBox2.Text = tongtien.ToString();
            textBox4.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox2.ReadOnly = true;

            sl = 0;
            tongtiendathanhtoan = 0;
            tongtien = 0;


        }
        int sl = 0;
        int tongtiendathanhtoan = 0;
        int tongtien = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(textBox3.Text, System.Globalization.NumberStyles.AllowThousands);
                textBox3.Text = String.Format(culture, "{0:N0}", value);
                textBox3.Select(textBox3.Text.Length, 0);
            }
            catch { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(textBox4.Text, System.Globalization.NumberStyles.AllowThousands);
                textBox4.Text = String.Format(culture, "{0:N0}", value);
                textBox4.Select(textBox4.Text.Length, 0);
            }
            catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                decimal value = decimal.Parse(textBox2.Text, System.Globalization.NumberStyles.AllowThousands);
                textBox2.Text = String.Format(culture, "{0:N0}", value);
                textBox2.Select(textBox2.Text.Length, 0);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hd_tragop_ncc hd_Tragop_Ncc = new hd_tragop_ncc(dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), DateTime.Today.ToString("dd/MM/yyyy"), sl.ToString(), tongtiendathanhtoan.ToString(), tongtien.ToString(), (tongtien - tongtiendathanhtoan).ToString());
            hd_Tragop_Ncc.ShowDialog();
        }

        private void TraGopNCC_Load(object sender, EventArgs e)
        {

            tHONGKE_TRAGOP_NCCDataGridView.BorderStyle = BorderStyle.None;
            tHONGKE_TRAGOP_NCCDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tHONGKE_TRAGOP_NCCDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tHONGKE_TRAGOP_NCCDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            tHONGKE_TRAGOP_NCCDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            tHONGKE_TRAGOP_NCCDataGridView.BackgroundColor = Color.White;

            tHONGKE_TRAGOP_NCCDataGridView.EnableHeadersVisualStyles = false;
            tHONGKE_TRAGOP_NCCDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tHONGKE_TRAGOP_NCCDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tHONGKE_TRAGOP_NCCDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
