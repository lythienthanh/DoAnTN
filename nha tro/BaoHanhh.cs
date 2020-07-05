using DevExpress.XtraEditors.Filtering.Templates;
using nha_tro.ttTableAdapters;
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
    public partial class BaoHanhh : Form
    {
        public BaoHanhh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                try
                {
                    this.kHACHHANG_dkTableAdapter.Fill_dk(this.nghiepVu.KHACHHANG_dk, textBox1.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số điện thoại or số điện thoại không có");

            }
        }

        private void fill_dkToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void kHACHHANG_dkDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.sELECT_DATA_HDTableAdapter.Fill(this.tt.SELECT_DATA_HD, kHACHHANG_dkDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch (System.Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBox3.Text = kHACHHANG_dkDataGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void BaoHanhh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.HOADON_baohanh' table. You can move, or remove it, as needed.
            this.hOADON_baohanhTableAdapter.Fill(this.tt.HOADON_baohanh);
            // TODO: This line of code loads data into the 'nghiepVu.LOIDONGUOIDUNG' table. You can move, or remove it, as needed.
            this.lOIDONGUOIDUNGTableAdapter.Fill(this.nghiepVu.LOIDONGUOIDUNG);
            // TODO: This line of code loads data into the 'nghiepVu.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
            // TODO: This line of code loads data into the 'tt.ct_bH' table. You can move, or remove it, as needed.
            this.ct_bHTableAdapter.Fill(this.tt.ct_bH);
            // TODO: This line of code loads data into the 'tt.NDBaoHanh' table. You can move, or remove it, as needed.
            this.nDBaoHanhTableAdapter.Fill(this.tt.NDBaoHanh);
            // TODO: This line of code loads data into the 'tt.BAOHANH' table. You can move, or remove it, as needed.
            this.bAOHANHTableAdapter.Fill(this.tt.BAOHANH);
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox4.Text = "";
            //
            kHACHHANG_dkDataGridView.BorderStyle = BorderStyle.None;
            kHACHHANG_dkDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHACHHANG_dkDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHACHHANG_dkDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHACHHANG_dkDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHACHHANG_dkDataGridView.BackgroundColor = Color.White;

            kHACHHANG_dkDataGridView.EnableHeadersVisualStyles = false;
            kHACHHANG_dkDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHACHHANG_dkDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHACHHANG_dkDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
            sELECT_DATA_HDDataGridView.BorderStyle = BorderStyle.None;
            sELECT_DATA_HDDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            sELECT_DATA_HDDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            sELECT_DATA_HDDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            sELECT_DATA_HDDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            sELECT_DATA_HDDataGridView.BackgroundColor = Color.White;

            sELECT_DATA_HDDataGridView.EnableHeadersVisualStyles = false;
            sELECT_DATA_HDDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            sELECT_DATA_HDDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            sELECT_DATA_HDDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
            bAOHANHDataGridView.BorderStyle = BorderStyle.None;
            bAOHANHDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            bAOHANHDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            bAOHANHDataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            bAOHANHDataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            bAOHANHDataGridView.BackgroundColor = Color.White;

            bAOHANHDataGridView.EnableHeadersVisualStyles = false;
            bAOHANHDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            bAOHANHDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            bAOHANHDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //
            dataTable2DataGridView.BorderStyle = BorderStyle.None;
            dataTable2DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataTable2DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataTable2DataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataTable2DataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataTable2DataGridView.BackgroundColor = Color.White;

            dataTable2DataGridView.EnableHeadersVisualStyles = false;
            dataTable2DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataTable2DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataTable2DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private string tendn;
        public BaoHanhh(string Message) : this()
        {
            tendn = Message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != "")
            {
                //tim manv
                try
                {
                    this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendn);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                string manv = tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString();


                DateTime? nbhxong = null;
                bAOHANHTableAdapter.Insert(int.Parse(textBox2.Text), textBox3.Text, dateTimePicker1.Value, nbhxong, lOIDONGUOIDUNGComboBox.SelectedValue.ToString());
                //insert hd bao hanh
                /* hOADON_baohanhTableAdapter.Insert("khong", "MLHD05", dateTimePicker1.Value, textBox2.Text, manv, "", "", int.Parse(textBox2.Text));*/
                hOADON_baohanhTableAdapter.Insert("khong", "MLHD05", dateTimePicker1.Value, "", manv, "", "", int.Parse(textBox2.Text));

                /* update ma bao hanh cho hoa don*/
                hOADON_baohanhTableAdapter.Updatemahoadon(int.Parse(textBox2.Text), int.Parse(sELECT_DATA_HDDataGridView.CurrentRow.Cells[0].Value.ToString()));
                //load data
                this.select_baohanhTableAdapter.Fill(this.tt.select_baohanh, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))));
                bAOHANHTableAdapter.Fill(tt.BAOHANH);

            }
            else
            {
                //tim manv
                try
                {
                    this.tAIKHOANTableAdapter.Fill_DK(this.nghiepVu.TAIKHOAN, tendn);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
                string manv = tAIKHOANDataGridView.Rows[0].Cells[1].Value.ToString();


                DateTime? nbhxong = null;
                bAOHANHTableAdapter.Insert(int.Parse(textBox2.Text), textBox3.Text, dateTimePicker1.Value, nbhxong, lOIDONGUOIDUNGComboBox.SelectedValue.ToString());
                //insert hd bao hanh
                /* hOADON_baohanhTableAdapter.Insert("khong", "MLHD05", dateTimePicker1.Value, textBox2.Text, manv, "", "", int.Parse(textBox2.Text));*/
                hOADON_baohanhTableAdapter.Insert("khong", "MLHD05", dateTimePicker1.Value, "", manv, "", "", int.Parse(textBox2.Text));
                //load data
                this.select_baohanhTableAdapter.Fill(this.tt.select_baohanh, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))));
                bAOHANHTableAdapter.Fill(tt.BAOHANH);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bAOHANHTableAdapter.DeleteQuery(int.Parse(textBox2.Text));
            //load data
            this.select_baohanhTableAdapter.Fill(this.tt.select_baohanh, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bAOHANHTableAdapter.UpdateQuery(dateTimePicker1.Value, dateTimePicker2.Value, int.Parse(textBox2.Text));
            //load data
            this.select_baohanhTableAdapter.Fill(this.tt.select_baohanh, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            ct_bHTableAdapter.Insert(int.Parse(bAOHANHComboBox.SelectedValue.ToString()), int.Parse(nDBaoHanhComboBox.SelectedValue.ToString()), lINHKIENComboBox.SelectedValue.ToString());
            //load data
            this.dataTable2TableAdapter.Fill(tt.DataTable2, int.Parse(bAOHANHComboBox.SelectedValue.ToString()));
            /*this.select_ctBhTableAdapter.Fill(this.tt.select_ctBh, ((int)(System.Convert.ChangeType(bAOHANHComboBox.SelectedValue.ToString(), typeof(int)))));*/

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ct_bHTableAdapter.DeleteQuery(int.Parse(nDBaoHanhComboBox.SelectedValue.ToString()), lINHKIENComboBox.SelectedValue.ToString());
            //load data
            this.dataTable2TableAdapter.Fill(tt.DataTable2, int.Parse(bAOHANHComboBox.SelectedValue.ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ct_bHTableAdapter.UpdateQuery(int.Parse(nDBaoHanhComboBox.SelectedValue.ToString()), lINHKIENComboBox.SelectedValue.ToString(), int.Parse(bAOHANHComboBox.SelectedValue.ToString()));
            //load data
            this.dataTable2TableAdapter.Fill(tt.DataTable2, int.Parse(bAOHANHComboBox.SelectedValue.ToString()));
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
        }
        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                try
                {
                    this.select_baohanhTableAdapter.Fill(this.tt.select_baohanh, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void bAOHANHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataTable2TableAdapter.Fill(this.tt.DataTable2, ((int)(System.Convert.ChangeType(bAOHANHComboBox.SelectedValue.ToString(), typeof(int)))));
                textBox2.Text = bAOHANHComboBox.SelectedValue.ToString();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != "")
            {
                string ngayban = sELECT_DATA_HDDataGridView.CurrentRow.Cells[6].Value.ToString();

                DateTime ngayb = Convert.ToDateTime(ngayban).AddMonths(6);
                if (ngayb < DateTime.Today)
                {
                    int tongtien = 0;
                    for (int i = 0; i < dataTable2DataGridView.Rows.Count - 1; i++)
                    {
                        tongtien += int.Parse(dataTable2DataGridView.Rows[i].Cells[4].Value.ToString()) + int.Parse(dataTable2DataGridView.Rows[i].Cells[5].Value.ToString());
                    }
                    int? mahd = hOADON_baohanhTableAdapter.selecet_mahdhientai();
                    HD_BAOHANH hd_Baohanh = new HD_BAOHANH(mahd.ToString(), bAOHANHComboBox.SelectedValue.ToString(), tongtien.ToString(), bAOHANHDataGridView.Rows[0].Cells[2].Value.ToString(), textBox4.Text);
                    hd_Baohanh.ShowDialog();
                }
                else
                {
                    int tongtien = 0;
                    for (int i = 0; i < dataTable2DataGridView.Rows.Count - 1; i++)
                    {
                        tongtien += int.Parse(dataTable2DataGridView.Rows[i].Cells[4].Value.ToString()) + int.Parse(dataTable2DataGridView.Rows[i].Cells[5].Value.ToString());
                        tongtien = tongtien - (tongtien * 10 / 100);
                    }
                    int? mahd = hOADON_baohanhTableAdapter.selecet_mahdhientai();
                    HD_BAOHANH hd_Baohanh = new HD_BAOHANH(mahd.ToString(), bAOHANHComboBox.SelectedValue.ToString(), tongtien.ToString(), bAOHANHDataGridView.Rows[0].Cells[2].Value.ToString(), textBox4.Text);
                    hd_Baohanh.ShowDialog();
                }
            }
            else
            {
                string ngayban = sELECT_DATA_HDDataGridView.CurrentRow.Cells[6].Value.ToString();

                DateTime ngayb = Convert.ToDateTime(ngayban).AddMonths(6);
                if (ngayb < DateTime.Today)
                {
                    int tongtien = 0;
                    for (int i = 0; i < dataTable2DataGridView.Rows.Count - 1; i++)
                    {
                        tongtien += int.Parse(dataTable2DataGridView.Rows[i].Cells[4].Value.ToString()) + int.Parse(dataTable2DataGridView.Rows[i].Cells[5].Value.ToString());
                    }
                    int? mahd = hOADON_baohanhTableAdapter.selecet_mahdhientai();
                    HD_BAOHANH hd_Baohanh = new HD_BAOHANH(mahd.ToString(), bAOHANHComboBox.SelectedValue.ToString(), tongtien.ToString(), bAOHANHDataGridView.Rows[0].Cells[2].Value.ToString(), "khong");
                    hd_Baohanh.ShowDialog();
                }
                else
                {
                    int tongtien = 0;
                    for (int i = 0; i < dataTable2DataGridView.Rows.Count - 1; i++)
                    {
                        tongtien += int.Parse(dataTable2DataGridView.Rows[i].Cells[4].Value.ToString()) + int.Parse(dataTable2DataGridView.Rows[i].Cells[5].Value.ToString());
                        tongtien = tongtien - (tongtien * 10 / 100);
                    }
                    int? mahd = hOADON_baohanhTableAdapter.selecet_mahdhientai();
                    HD_BAOHANH hd_Baohanh = new HD_BAOHANH(mahd.ToString(), bAOHANHComboBox.SelectedValue.ToString(), tongtien.ToString(), bAOHANHDataGridView.Rows[0].Cells[2].Value.ToString(), "khong");
                    hd_Baohanh.ShowDialog();
                }
            }
            
        }

        private void fill_GiaLKToolStripButton_Click(object sender, EventArgs e)
        {
           /* try
            {
                this.ct_BH_LKTableAdapter.Fill_GiaLK(this.tt.Ct_BH_LK, malkToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fill_GiaLKToolStripButton1_Click(object sender, EventArgs e)
        {
           /* try
            {
                this.ct_BH_LKTableAdapter.Fill_GiaLK(this.tt.Ct_BH_LK, ((int)(System.Convert.ChangeType(mabaohanhToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void fill_GiaLKToolStripButton_Click_1(object sender, EventArgs e)
        {
            /*try
            {
                this.ct_BH_LKTableAdapter.Fill_GiaLK(this.tt.Ct_BH_LK, ((int)(System.Convert.ChangeType(mabaohanhToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void fill_GiaLKToolStripButton1_Click_1(object sender, EventArgs e)
        {
          /*  try
            {
                this.ct_BH_LKTableAdapter.Fill_GiaLK(this.tt.Ct_BH_LK, ((int)(System.Convert.ChangeType(mabaohanhToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void fill_GiaLKToolStripButton2_Click(object sender, EventArgs e)
        {
           /* try
            {
                this.ct_BH_LKTableAdapter.Fill_GiaLK(this.tt.Ct_BH_LK, ((int)(System.Convert.ChangeType(mabaohanhToolStripTextBox2.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
/*            try
            {
                this.dataTable2TableAdapter.Fill(this.tt.DataTable2, ((int)(System.Convert.ChangeType(mabaohanhToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void dataTable2DataGridView_Click(object sender, EventArgs e)
        {
        }

        private void dataTable2DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void fill_DKToolStripButton_Click_1(object sender, EventArgs e)
        {


        }

        private void sELECT_DATA_HDDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ngayban = sELECT_DATA_HDDataGridView.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = sELECT_DATA_HDDataGridView.CurrentRow.Cells[0].Value.ToString();
            try
            {
                DateTime ngayb = Convert.ToDateTime(ngayban).AddMonths(6);
                if (ngayb < DateTime.Today)
                {
                    label5.Text = "Hết thời gian bảo hành";
                }
                else
                {
                    label5.Text = "Còn thời hạn bảo hành";

                }
            }
            catch { }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang QuanLyKhachHang = new QuanLyKhachHang();
            QuanLyKhachHang.ShowDialog();
        }
    }
}
