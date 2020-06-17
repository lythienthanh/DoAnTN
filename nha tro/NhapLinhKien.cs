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
    public partial class NhapLinhKien : Form
    {
        public NhapLinhKien()
        {
            InitializeComponent();
        }
                //====nhan ten dang nhap tu form dang nhap
        private string tendn;
        public NhapLinhKien(string Message)
            : this()
        {
            tendn = Message;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaoPhieuNhapLinhKien TaoPhieuNhapLinhKien = new TaoPhieuNhapLinhKien(tendn);
            TaoPhieuNhapLinhKien.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LưuLinhKienVaoKho llkvk = new LưuLinhKienVaoKho(tendn);
            llkvk.ShowDialog();
        }
    }
}
