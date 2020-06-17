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
            mAKHTextEdit.Text = kHACHHANG_dkDataGridView.CurrentRow.Cells[0].Value.ToString();
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
            mAKHTextEdit.ReadOnly = true;
        }

        private string tendn;
        public BaoHanhh(string Message) : this()
        {
            tendn = Message;
        }

        private void button2_Click(object sender, EventArgs e)
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
            bAOHANHTableAdapter.Insert(int.Parse(textBox2.Text), mAKHTextEdit.Text, dateTimePicker1.Value, nbhxong,lOIDONGUOIDUNGComboBox.SelectedValue.ToString());
            //insert hd bao hanh
            /* hOADON_baohanhTableAdapter.Insert("khong", "MLHD05", dateTimePicker1.Value, textBox2.Text, manv, "", "", int.Parse(textBox2.Text));*/
            hOADON_baohanhTableAdapter.Insert("khong", "MLHD05", dateTimePicker1.Value, "", manv, "", "", int.Parse(textBox2.Text));

            /* update ma bao hanh cho hoa don*/
            hOADON_baohanhTableAdapter.Updatemahoadon(int.Parse(textBox2.Text), int.Parse(sELECT_DATA_HDDataGridView.CurrentRow.Cells[0].Value.ToString()));
            //load data
            this.select_baohanhTableAdapter.Fill(this.tt.select_baohanh, ((int)(System.Convert.ChangeType(textBox2.Text, typeof(int)))));
            bAOHANHTableAdapter.Fill(tt.BAOHANH);
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
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            textBox2.Text = bAOHANHComboBox.SelectedValue.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
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
                int? mahd = hOADON_baohanhTableAdapter.SELECT_MAHD(int.Parse(bAOHANHComboBox.SelectedValue.ToString()));
                HD_BAOHANH hd_Baohanh = new HD_BAOHANH(mahd.ToString(), bAOHANHComboBox.SelectedValue.ToString(), tongtien.ToString(), bAOHANHDataGridView.Rows[0].Cells[2].Value.ToString(), sELECT_DATA_HDDataGridView.CurrentRow.Cells[0].Value.ToString());
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
                int? mahd = hOADON_baohanhTableAdapter.SELECT_MAHD(int.Parse(bAOHANHComboBox.SelectedValue.ToString()));
                HD_BAOHANH hd_Baohanh = new HD_BAOHANH(mahd.ToString(), bAOHANHComboBox.SelectedValue.ToString(), tongtien.ToString(), bAOHANHDataGridView.Rows[0].Cells[2].Value.ToString(), sELECT_DATA_HDDataGridView.CurrentRow.Cells[0].Value.ToString());
                hd_Baohanh.ShowDialog();
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
            }*/

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
    }
}
