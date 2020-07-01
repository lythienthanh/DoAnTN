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
            // TODO: This line of code loads data into the 'nghiepVu1.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter1.Fill(this.nghiepVu1.SANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu1.KHUYENMAI' table. You can move, or remove it, as needed.
            //this.kHUYENMAITableAdapter1.Fill(this.nghiepVu1.KHUYENMAI);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
           /* this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);*/
            // TODO: This line of code loads data into the 'tt.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);
            
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
                this.kHUYENMAITableAdapter.Insert(mAKHUYENMAITextEdit.Text, tENKHUYENMAITextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text), mALINHKIENTextEdit.Text, sANPHAMComboBox.SelectedValue.ToString(), double.Parse(gIATRISpinEdit.Text));


                this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);
            }

            catch
            {
                MessageBox.Show("Thông tin cần thêm không hợp lệ");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.kHUYENMAITableAdapter.Delete(mAKHUYENMAITextEdit.Text, tENKHUYENMAITextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text), mALINHKIENTextEdit.Text, sANPHAMComboBox.SelectedValue.ToString(), double.Parse(gIATRISpinEdit.Text));
            this.kHUYENMAITableAdapter.Fill(tt.KHUYENMAI);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHUYENMAITableAdapter1.UpdateKHUYENMAI(sANPHAMComboBox.SelectedValue.ToString(), mALINHKIENTextEdit.Text, tENKHUYENMAITextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text), double.Parse(gIATRISpinEdit.Text), mAKHUYENMAITextEdit.Text);
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
            kHUYENMAI2TableAdapter.Fill(tt.KHUYENMAI2, kHUYENMAIDataGridView.CurrentRow.Cells[0].Value.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TimkiemSPKM frm = new TimkiemSPKM();
            frm.ShowDialog();
        }
    }
}
