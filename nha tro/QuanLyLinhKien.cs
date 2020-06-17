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
    public partial class QuanLyLinhKien : Form
    {
        public QuanLyLinhKien()
        {
            InitializeComponent();
        }

        private void lINHKIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lINHKIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void QuanLyLinhKien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.nghiepVu.KHO);
            // TODO: This line of code loads data into the 'nghiepVu.LINHKIEN' table. You can move, or remove it, as needed.
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = mAKHOComboBox.Text;
            lINHKIENTableAdapter.Insert(mALINHKIENTextEdit.Text, tENLINHKIENTextEdit.Text, int.Parse(dONGIASpinEdit.Text),s);
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lINHKIENTableAdapter.Delete(mALINHKIENTextEdit.Text, tENLINHKIENTextEdit.Text, int.Parse(dONGIASpinEdit.Text), mAKHOComboBox.Text);
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lINHKIENTableAdapter.UpdateLINHKIEN(tENLINHKIENTextEdit.Text, int.Parse(dONGIASpinEdit.Text), mAKHOComboBox.Text, mALINHKIENTextEdit.Text);
            this.lINHKIENTableAdapter.Fill(this.nghiepVu.LINHKIEN);
        }
    }
}
