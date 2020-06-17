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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }
        public void getdata()
        {
            // TODO: This line of code loads data into the 'nghiepVu.SP_NEW' table. You can move, or remove it, as needed.
            this.sP_NEWTableAdapter.Fill(this.nghiepVu.SP_NEW);
            // TODO: This line of code loads data into the 'nghiepVu.KHO1' table. You can move, or remove it, as needed.
            this.kHO1TableAdapter.Fill(this.nghiepVu.KHO1);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu.LOAISANPHAM' table. You can move, or remove it, as needed.
            this.lOAISANPHAMTableAdapter.Fill(this.nghiepVu.LOAISANPHAM);
            //// TODO: This line of code loads data into the 'nghiepVu.KHO' table. You can move, or remove it, as needed.
            //this.kHOTableAdapter.Fill(this.nghiepVu.KHO);
            //// TODO: This line of code loads data into the 'nghiepVu.KHO' table. You can move, or remove it, as needed.
            //this.kHOTableAdapter.Fill(this.nghiepVu.KHO);
            // TODO: This line of code loads data into the 'nghiepVu.LOAISANPHAM' table. You can move, or remove it, as needed.
            this.lOAISANPHAMTableAdapter.Fill(this.nghiepVu.LOAISANPHAM);
            // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            getdata();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                sANPHAMTableAdapter.Insert(("SP"+(sANPHAMTableAdapter.select_sodong()+1)),sANPHAMComboBox.SelectedValue.ToString(), kHOComboBox.SelectedValue.ToString(), tENSPTextEdit.Text, tINHTRANGTextEdit.Text,int.Parse(donGiaSpinEdit.Text));
                MessageBox.Show("Thành Công");
                //load girdview
                this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
                // TODO: This line of code loads data into the 'nghiepVu.SANPHAM' table. You can move, or remove it, as needed.

                getdata();

        }

        private void button6_Click(object sender, EventArgs e)
        {

                lOAISANPHAMTableAdapter.Insert(("L"+(lOAISANPHAMTableAdapter.SELECT_SODONG()+1)), tENLOAITextEdit.Text);
                MessageBox.Show("Thành Công");
                //load girdview
                this.lOAISANPHAMTableAdapter.Fill(this.nghiepVu.LOAISANPHAM);


        }

        private void button9_Click(object sender, EventArgs e)
        {

            kHO1TableAdapter.THEM(kHO1ComboBox.SelectedValue.ToString(), int.Parse(sLSpinEdit.Text), sANPHAMComboBox1.SelectedValue.ToString(), diaChiTextEdit.Text, int.Parse(textBox1.Text),"TEMP");
            MessageBox.Show("Thành Công");
            //load girdview
            this.kHO1TableAdapter.Fill(this.nghiepVu.KHO1);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (kHOTableAdapter.kt_trung_kho(mAKHOTextEdit1.Text) != 0)
            //{
            //    kHOTableAdapter.Delete(mAKHOTextEdit1.Text, int.Parse(sLSpinEdit1.Text), mASPTextEdit1.Text);
            //    MessageBox.Show("Xóa Thành Công");
            //}
            //else
            //    MessageBox.Show("Xóa Thất bại");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sANPHAMTableAdapter.kt_trung_sp(mASPTextEdit.Text) != 0)
            {
                sANPHAMTableAdapter.Delete(mASPTextEdit.Text, sANPHAMComboBox.SelectedValue.ToString(), kHOComboBox.SelectedValue.ToString(), tENSPTextEdit.Text, tINHTRANGTextEdit.Text, int.Parse(donGiaSpinEdit.Text));
                MessageBox.Show("Thành Công");
                //load girdview
                this.sANPHAMTableAdapter.Fill(this.nghiepVu.SANPHAM);
            }
            else
                MessageBox.Show("Xóa Thất bại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            ////this.Validate();
            //this.sANPHAMBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.nghiepVu);
            sANPHAMTableAdapter.UpdateQuery(tENSPTextEdit.Text, mALOAITextEdit.Text, kHOComboBox.SelectedValue.ToString(), tINHTRANGTextEdit.Text, int.Parse(donGiaSpinEdit.Text), mASPTextEdit.Text);
            MessageBox.Show("Sữa thành công!!!");
            getdata();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAISANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);
            MessageBox.Show("Sữa thành công!!!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);
            MessageBox.Show("Sữa thành công!!!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            kHO1TableAdapter.THEM("KHO" + kHO1TableAdapter.so_dong(), int.Parse(sLSpinEdit.Text), sANPHAMComboBox1.SelectedValue.ToString(), diaChiTextEdit.Text, int.Parse(textBox1.Text),"LK00");
            MessageBox.Show("Thành Công");
            //load girdview
            this.kHO1TableAdapter.Fill(this.nghiepVu.KHO1);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHO1TableAdapter.FillBy(this.nghiepVu.KHO1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kHO1TableAdapter.FillBy1(this.nghiepVu.KHO1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
