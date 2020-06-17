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
    public partial class ThemNguoiDungVaoNhom : Form
    {
        public ThemNguoiDungVaoNhom()
        {
            InitializeComponent();
        }

        private void nguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.nguoiDungBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_DangNhap.tk_NND' table. You can move, or remove it, as needed.
            this.tk_NNDTableAdapter.Fill(this.dS_DangNhap.tk_NND);
            // TODO: This line of code loads data into the 'dS_DangNhap.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dS_DangNhap.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            //// TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            //this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            //// TODO: This line of code loads data into the 'dS_DangNhap.TAIKHOAN' table. You can move, or remove it, as needed.
            //this.tAIKHOANTableAdapter.Fill(this.dS_DangNhap.TAIKHOAN);
            //// TODO: This line of code loads data into the 'dataSet1.NhomNguoiDung' table. You can move, or remove it, as needed.
            //this.nhomNguoiDungTableAdapter.Fill(this.dataSet1.NhomNguoiDung);
            //// TODO: This line of code loads data into the 'dataSet1.NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            //this.nguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSet1.NguoiDungNhomNguoiDung);
            //// TODO: This line of code loads data into the 'dataSet1.NguoiDung' table. You can move, or remove it, as needed.
            //this.nguoiDungTableAdapter.Fill(this.dataSet1.NguoiDung);
            //load_dl();

        }

        private void nhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.tk_NND_DKTableAdapter.Fill_DK(this.dS_DangNhap.tk_NND_DK, nhomNguoiDungComboBox.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void load_dl()
        {
            if (nhomNguoiDungComboBox.SelectedValue != null)
            {
                try
                {
                    this.tk_NND_DKTableAdapter.Fill_DK(this.dS_DangNhap.tk_NND_DK, nhomNguoiDungComboBox.SelectedValue.ToString());
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDN = tAIKHOANDataGridView.CurrentRow.Cells[0].Value.ToString();
            string manhom = nhomNguoiDungComboBox.SelectedValue.ToString();

            tk_NNDTableAdapter.Insert(tenDN, manhom);
            MessageBox.Show("Thanh Cong");

            load_dl();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tenDN = tk_NND_DKDataGridView.CurrentRow.Cells[0].Value.ToString();
            string manhom = nhomNguoiDungComboBox.SelectedValue.ToString();
            tk_NNDTableAdapter.Delete(tenDN, manhom);
            MessageBox.Show("Thanh Cong");

            load_dl();
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

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.nHOMNGUOIDUNG_DKTableAdapter.Fill_DK(this.dS_DangNhap.NHOMNGUOIDUNG_DK, mANHOMToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void fill_DKToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.tk_NND_DKTableAdapter.Fill_DK(this.dS_DangNhap.tk_NND_DK, mANHOMToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
        
    }
}
