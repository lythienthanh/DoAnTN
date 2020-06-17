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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nghiepVu.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.nghiepVu.HOADON);

        }
    }
}
