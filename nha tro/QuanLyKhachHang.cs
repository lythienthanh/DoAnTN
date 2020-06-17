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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.Insert(mAKHTextEdit.Text, tENKHTextEdit.Text, sDTTextEdit.Text, dIACHITextEdit.Text, cMNDTextEdit.Text);
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.Delete(mAKHTextEdit.Text, tENKHTextEdit.Text, sDTTextEdit.Text, dIACHITextEdit.Text, cMNDTextEdit.Text);
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.UpdateKHACHHANG(tENKHTextEdit.Text, sDTTextEdit.Text, dIACHITextEdit.Text, cMNDTextEdit.Text, mAKHTextEdit.Text);
            this.kHACHHANGTableAdapter.Fill(this.nghiepVu.KHACHHANG);
        }
    }
}
