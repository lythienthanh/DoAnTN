using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;
using Microsoft.Reporting.WinForms;
using DevExpress.XtraEditors.Filtering.Templates;

namespace nha_tro
{
    public partial class TinhDTTheoNgay : Form
    {
        public TinhDTTheoNgay()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string   tongtien, ngay,sl;
        private string ngaybd, ngaykt;

        public TinhDTTheoNgay(string soluong, string tongtien, string ngay,string ngaybd, string ngaykt)
            : this()
        {
            this.sl = soluong;
          
            this.tongtien = tongtien;
            this.ngay = ngay;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
        }
        private void TinhDTTheoNgay_Load(object sender, EventArgs e)
        {
            DateTime? ngaybatdau = DateTime.Parse(ngaybd.ToString());
            DateTime? ngayketthuc = DateTime.Parse(ngaykt.ToString());
            // TODO: This line of code loads data into the 'tt.ThongKe_DoanhThu' table. You can move, or remove it, as needed.
            this.ThongKe_DoanhThuTableAdapter.Fill(this.tt.ThongKe_DoanhThu, ngaybatdau, ngayketthuc);
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("SLDB", sl.ToString()));
      
            reportParameter.Add(new ReportParameter("TongTien", tongtien.ToString()));
            reportParameter.Add(new ReportParameter("Ngay", ngay.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
