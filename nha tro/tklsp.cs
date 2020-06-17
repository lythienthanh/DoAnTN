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
    public partial class tklsp : Form
    {
        public tklsp()
        {
            InitializeComponent();
        }

        //====nhan ten dang nhap tu form dang nhap
        private string maloaisp;
        private DateTime? ngaybd, ngaykt;
        public tklsp(DateTime? ngaybdd, DateTime? ngayktt, string maloaispp)
            : this()
        {
            ngaybd = ngaybdd;
            ngaykt = ngayktt;
            maloaisp = maloaispp;
        }

        private void tklsp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.THONGKE_LOAISP' table. You can move, or remove it, as needed.
            this.THONGKE_LOAISPTableAdapter.Fill(this.tt.THONGKE_LOAISP, ngaybd, ngaykt, maloaisp);

            this.reportViewer1.RefreshReport();
        }
    }
}
