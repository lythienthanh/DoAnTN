using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class ThemSPKhuyenMai : Form
    {
        public ThemSPKhuyenMai()
        {
            InitializeComponent();
        }

        private void kHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUYENMAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tt);

        }

        private void ThemSPKhuyenMai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu1.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu1.LINHKIEN);
            // TODO: This line of code loads data into the 'nghiepVu1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter1.Fill(this.nghiepVu1.SANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu1.KHUYENMAI' table. You can move, or remove it, as needed.
            //this.kHUYENMAITableAdapter1.Fill(this.nghiepVu1.KHUYENMAI);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
           /* this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);*/
            // TODO: This line of code loads data into the 'tt.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);

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

            kHUYENMAI2DataGridView.BorderStyle = BorderStyle.None;
            kHUYENMAI2DataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            kHUYENMAI2DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            kHUYENMAI2DataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            kHUYENMAI2DataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            kHUYENMAI2DataGridView.BackgroundColor = Color.White;

            kHUYENMAI2DataGridView.EnableHeadersVisualStyles = false;
            kHUYENMAI2DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            kHUYENMAI2DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            kHUYENMAI2DataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //if (mAKHUYENMAITextEdit.Text.Length != 0 && mASPTextEdit.Text.Length != 0 && gIATRISpinEdit.Text.Length != 0 && nGAYBDDateEdit.Text.Length != 0 && nGAYKTDateEdit.Text.Length != 0)
            //{
            //    cT_KM_SPTableAdapter.Insert(mAKHUYENMAITextEdit.Text, mASPTextEdit.Text, double.Parse(gIATRISpinEdit.Text), Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text));
            //    mAKHUYENMAIToolStripTextBox.Text = mAKHUYENMAITextEdit.Text;
            //    try
            //    {
            //        this.cT_KM_SPTableAdapter.Fill(this.tt.CT_KM_SP, mAKHUYENMAIToolStripTextBox.Text);
            //    }
            //    catch (System.Exception ex)
            //    {
            //        System.Windows.Forms.MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            
            //}
            
        }

        private void sANPHAMDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.kHUYENMAITableAdapter.Insert(mAKHUYENMAITextEdit.Text, tENKHUYENMAITextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text), lINHKIENComboBox.SelectedValue.ToString(), sANPHAMComboBox.SelectedValue.ToString(), double.Parse(gIATRISpinEdit.Text));


                this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);
            }

            catch
            {
                MessageBox.Show("Thông tin cần thêm không hợp lệ");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.kHUYENMAITableAdapter.Delete(mAKHUYENMAITextEdit.Text, tENKHUYENMAITextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text), lINHKIENComboBox.SelectedValue.ToString(), sANPHAMComboBox.SelectedValue.ToString(), double.Parse(gIATRISpinEdit.Text));
            kHUYENMAITableAdapter.DeleteQuery(mAKHUYENMAITextEdit.Text, sANPHAMComboBox.SelectedValue.ToString(), lINHKIENComboBox.SelectedValue.ToString());
            this.kHUYENMAITableAdapter.Fill(tt.KHUYENMAI);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHUYENMAITableAdapter1.UpdateKHUYENMAI(sANPHAMComboBox.SelectedValue.ToString(), lINHKIENComboBox.SelectedValue.ToString(), tENKHUYENMAITextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text), double.Parse(gIATRISpinEdit.Text), mAKHUYENMAITextEdit.Text);
                this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

       

        private void kHUYENMAIDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.kHUYENMAI1TableAdapter.Fill_MaKM(tt.KHUYENMAI1, kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
        }

        
        private void kHUYENMAIDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                kHUYENMAI2TableAdapter.Fill(tt.KHUYENMAI2, kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
                mAKHUYENMAITextEdit.Text = kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString();
                tENKHUYENMAITextEdit.Text = kHUYENMAIDataGridView.CurrentRow.Cells[1].Value.ToString();
                DateTime ngaybd = Convert.ToDateTime(kHUYENMAIDataGridView.CurrentRow.Cells[2].Value.ToString());
                nGAYBDDateEdit.Text = ngaybd.ToString("MM/dd/yyyy");
                DateTime ngaykt = Convert.ToDateTime(kHUYENMAIDataGridView.CurrentRow.Cells[3].Value.ToString());
                nGAYKTDateEdit.Text = ngaykt.ToString("MM/dd/yyyy");

                int temp = DateTime.Today.Date.CompareTo(Convert.ToDateTime(kHUYENMAIDataGridView.CurrentRow.Cells[2].Value.ToString()));

                if ( temp < 0)
                {
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                    button3.Enabled = false;
                }
                kHUYENMAI2TableAdapter.FillBy(this.tt.KHUYENMAI2, kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimkiemSPKM frm = new TimkiemSPKM();
            frm.ShowDialog();
        }
    }
}
