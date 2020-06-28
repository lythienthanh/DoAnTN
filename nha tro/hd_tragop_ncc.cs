using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ReportParameter = Microsoft.Reporting.WinForms.ReportParameter;
namespace nha_tro
{
    public partial class hd_tragop_ncc : Form
    {
        public hd_tragop_ncc()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string ngaybd, ngaykt, ngay,sldanhap,tongtiendathanhtoan,tongtien,tongtienconlai;
        public hd_tragop_ncc(string ngaybd, string ngaykt, string ngay, string sldanhap, string tongtiendathanhtoan, string tongtien, string tongtienconlai)
            : this()
        {
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.ngay = ngay;
            this.sldanhap = sldanhap;
            this.tongtiendathanhtoan = tongtiendathanhtoan;
            this.tongtien = tongtien;
            this.tongtienconlai = tongtienconlai;


        }
        private void hd_tragop_ncc_Load(object sender, EventArgs e)
        {
            DateTime? ngaybdau = Convert.ToDateTime(ngaybd).Date;
            DateTime? ngaykthuc = Convert.ToDateTime(ngaykt).Date;
            // TODO: This line of code loads data into the 'tt.THONGKE_TRAGOP_NCC' table. You can move, or remove it, as needed.
            this.THONGKE_TRAGOP_NCCTableAdapter.Fill(this.tt.THONGKE_TRAGOP_NCC, ngaybdau, ngaykthuc);
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("sldanhap", sldanhap.ToString()));
            reportParameter.Add(new ReportParameter("tongtiendathanhtoan", tongtiendathanhtoan.ToString()));
            reportParameter.Add(new ReportParameter("sotienconlai", tongtienconlai.ToString()));
            reportParameter.Add(new ReportParameter("tongtienphaitra", tongtien.ToString()));
            reportParameter.Add(new ReportParameter("ngay", DateTime.Today.ToString("dd/MM/yyyy")));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
