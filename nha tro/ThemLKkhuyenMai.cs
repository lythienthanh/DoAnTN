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
    public partial class ThemLKkhuyenMai : Form
    {
        public ThemLKkhuyenMai()
        {
            InitializeComponent();
        }

        private void kHUYENMAIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUYENMAIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tt);

        }

        private void ThemLKkhuyenMai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.KHUYENMAI' table. You can move, or remove it, as needed.
            this.kHUYENMAITableAdapter.Fill(this.tt.KHUYENMAI);

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ct_KM_LKTableAdapter.Fill(this.tt.Ct_KM_LK, mAKHUYENMAIToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ct_KM_LKTableAdapter.Insert(double.Parse(gIATRISpinEdit.Text), mAKHUYENMAITextEdit.Text, mALINHKIENTextEdit.Text, Convert.ToDateTime(nGAYBDDateEdit.Text), Convert.ToDateTime(nGAYKTDateEdit.Text));
            mAKHUYENMAIToolStripTextBox.Text = mAKHUYENMAITextEdit.Text;
            try
            {
                this.ct_KM_LKTableAdapter.Fill(this.tt.Ct_KM_LK, mAKHUYENMAIToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
