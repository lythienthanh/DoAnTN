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
    public partial class TraGop : Form
    {
        public TraGop()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime ngayDB = Convert.ToDateTime(dateTimePicker1.Value.ToString("dd/MM/yyyy"));


            try
            {
                this.thongKe_tragop_theongayTableAdapter.Fill(this.tt.thongKe_tragop_theongay, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker1.Value, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateTimePicker2.Value, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int sltheosp = 0;
            int sl = 0;
            int tongtien = 0;
            for (int i = 0; i < thongKe_tragop_theongayDataGridView.Rows.Count -1 ; i++)
            {
                sl += int.Parse(thongKe_tragop_theongayDataGridView.Rows[i].Cells[3].Value.ToString());
                sltheosp = int.Parse(thongKe_tragop_theongayDataGridView.Rows[i].Cells[3].Value.ToString());
                int dongia = int.Parse(thongKe_TinhDoanhThuTableAdapter.select_dongia_masp(thongKe_tragop_theongayDataGridView.Rows[i].Cells[1].Value.ToString()).ToString());
                tongtien += sltheosp * dongia;
            }
            textBox1.Text = sl.ToString();
            textBox2.Text = tongtien.ToString();

            try
            {
                this.traGop2_select_theo_ngayTableAdapter.Fill(this.tt.TraGop2_select_theo_ngay, Convert.ToDateTime(dateTimePicker2.Value.ToString()), Convert.ToDateTime(dateTimePicker1.Value.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int tongtienphaitra = 0;
            int tongtienconlai = 0;
            for (int i = 0; i < traGop2_select_theo_ngayDataGridView.RowCount - 1; i++)
            {
                tongtienphaitra += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[1].Value.ToString());
                tongtienconlai += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[2].Value.ToString());
            }
            textBox3.Text = (tongtienphaitra + (tongtienphaitra - tongtienconlai)).ToString();
            textBox4.Text = tongtienconlai.ToString();
            tongtienphaitra = 0;
            tongtienconlai = 0;

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void TraGop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.HOADON_cbo' table. You can move, or remove it, as needed.
            this.hOADON_cboTableAdapter.Fill(this.tt.HOADON_cbo);
            // TODO: This line of code loads data into the 'tt.tragop_cbo' table. You can move, or remove it, as needed.
            this.tragop_cboTableAdapter.Fill(this.tt.tragop_cbo);
            // TODO: This line of code loads data into the 'tt.TraGop' table. You can move, or remove it, as needed.
            this.traGopTableAdapter.Fill(this.tt.TraGop);

            hOADON_cboComboBox.Text = "";
            tragop_cboComboBox.Text = "";

            thongKe_tragop_theongayDataGridView.BorderStyle = BorderStyle.None;
            thongKe_tragop_theongayDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            thongKe_tragop_theongayDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            thongKe_tragop_theongayDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            thongKe_tragop_theongayDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            thongKe_tragop_theongayDataGridView.BackgroundColor = Color.White;

            thongKe_tragop_theongayDataGridView.EnableHeadersVisualStyles = false;
            thongKe_tragop_theongayDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            thongKe_tragop_theongayDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            thongKe_tragop_theongayDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            traGop2_select_theo_ngayDataGridView.BorderStyle = BorderStyle.None;
            traGop2_select_theo_ngayDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            traGop2_select_theo_ngayDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            traGop2_select_theo_ngayDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            traGop2_select_theo_ngayDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            traGop2_select_theo_ngayDataGridView.BackgroundColor = Color.White;

            traGop2_select_theo_ngayDataGridView.EnableHeadersVisualStyles = false;
            traGop2_select_theo_ngayDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            traGop2_select_theo_ngayDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            traGop2_select_theo_ngayDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mahd1 = 0;
            int mahd2 = 0;

            mahd1 = int.Parse(thongKe_tragop_theongayDataGridView.Rows[0].Cells[0].Value.ToString());
            mahd2 = int.Parse(thongKe_tragop_theongayDataGridView.Rows[thongKe_tragop_theongayDataGridView.Rows.Count - 2].Cells[0].Value.ToString());
            if (mahd1 != mahd2)
            {
                Form3 hd_Tragop_Kh_Theongay = new Form3(DateTime.Today.ToString("dd/MM/yyyy"), textBox1.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"), textBox2.Text);
                hd_Tragop_Kh_Theongay.ShowDialog();
            }
            else
            {
                hd_tragop_kh hd_Tragop_Kh = new hd_tragop_kh(DateTime.Today.ToString("dd/MM/yyyy"), textBox1.Text, textBox3.Text, textBox4.Text, traGop2_select_theo_ngayDataGridView.Rows[0].Cells[0].Value.ToString(), textBox2.Text);
                hd_Tragop_Kh.ShowDialog();
            }
        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            //try
            //{
            //    this.traGop2_select_theo_ngayTableAdapter.Fill(this.tt.TraGop2_select_theo_ngay, nGAYKTToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fillToolStripButton_Click_3(object sender, EventArgs e)
        {


        }

        private void tragop_cboComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            traGop2_select_theo_ngayTableAdapter.FillBy_matragop(this.tt.TraGop2_select_theo_ngay, tragop_cboComboBox.SelectedValue.ToString());
            thongKe_tragop_theongayTableAdapter.FillBy_matragop(this.tt.thongKe_tragop_theongay,tragop_cboComboBox.SelectedValue.ToString());
            int sl = 0;
            for (int i = 0; i < thongKe_tragop_theongayDataGridView.RowCount - 1; i++)
            {
                sl += int.Parse(thongKe_tragop_theongayDataGridView.Rows[i].Cells[3].Value.ToString());
            }
            int tongtiendathanhtoan = 0;
            int tongtienconlai = 0;
            for (int i = 0; i < traGop2_select_theo_ngayDataGridView.RowCount - 1; i++)
            {
                tongtiendathanhtoan += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[1].Value.ToString());
                tongtienconlai += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[2].Value.ToString());
            }
            textBox1.Text = sl.ToString();
            textBox3.Text = tongtiendathanhtoan.ToString();
            textBox4.Text = tongtienconlai.ToString();
            textBox2.Text = (tongtiendathanhtoan + tongtienconlai).ToString();
            hOADON_cboComboBox.Text = "";

        }

        private void hOADON_cboComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongKe_tragop_theongayTableAdapter.FillBy_mahd(this.tt.thongKe_tragop_theongay, int.Parse(hOADON_cboComboBox.SelectedValue.ToString()));
            traGop2_select_theo_ngayTableAdapter.FillBy_mahd(this.tt.TraGop2_select_theo_ngay, int.Parse(hOADON_cboComboBox.SelectedValue.ToString()));
            int sl = 0;      
            for (int i = 0; i < thongKe_tragop_theongayDataGridView.RowCount - 1; i++)
            {
                sl += int.Parse(thongKe_tragop_theongayDataGridView.Rows[i].Cells[3].Value.ToString());
            }
            int tongtiendathanhtoan = 0;
            int tongtienconlai = 0;
            for (int i = 0; i < traGop2_select_theo_ngayDataGridView.RowCount - 1; i++)
            {
                tongtiendathanhtoan += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[1].Value.ToString());
                tongtienconlai += int.Parse(traGop2_select_theo_ngayDataGridView.Rows[i].Cells[2].Value.ToString());
            }
            textBox1.Text = sl.ToString();
            textBox3.Text = tongtiendathanhtoan.ToString();
            textBox4.Text = tongtienconlai.ToString();
            textBox2.Text = (tongtiendathanhtoan + tongtienconlai).ToString();
            tragop_cboComboBox.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox3.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox3.Text = String.Format(culture, "{0:N0}", value);
            textBox3.Select(textBox3.Text.Length, 0);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(textBox4.Text, System.Globalization.NumberStyles.AllowThousands);
            textBox4.Text = String.Format(culture, "{0:N0}", value);
            textBox4.Select(textBox4.Text.Length, 0);
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
