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
    public partial class ThemNguoiDung : Form
    {
        public ThemNguoiDung()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.TAIKHOANTableAdapter.Insert(tENDANGNHAPTextEdit.Text,nHANVIENComboBox.SelectedValue.ToString(),mATKHAUTextEdit.Text,hOATDONGCheckEdit.Checked);
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            MessageBox.Show("Thành Công");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.TAIKHOANTableAdapter.Delete(tENDANGNHAPTextEdit.Text, nHANVIENComboBox.SelectedValue.ToString(), mATKHAUTextEdit.Text, hOATDONGCheckEdit.Checked);
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_DangNhap);
            MessageBox.Show("Cập nhật thành công!!!");
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.nguoiDungBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ThemNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter1.Fill(this.nghiepVu.NHANVIEN);
            // TODO: This line of code loads data into the 'dS_DangNhap.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dS_DangNhap.NHANVIEN);
            // TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            // TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            // TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            // TODO: This line of code loads data into the 'dataSet1.NguoiDung' table. You can move, or remove it, as needed.
            //this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);

        }

        private void tAIKHOANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_DangNhap);

        }

        private void tAIKHOANBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tAIKHOANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_DangNhap);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThemNhanVien ThemNhanVien = new ThemNhanVien();
            ThemNhanVien.ShowDialog();
        }
    }
}
