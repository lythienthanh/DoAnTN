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
    public partial class hd_thongke_Sp : Form
    {
        public hd_thongke_Sp()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string ngayin, ngaybd, ngaykt,tensp,slbanduoc,tongtienbanduoc,masp;
        public hd_thongke_Sp(string ngayin, string ngaybd, string ngaykt, string tensp, string slbanduoc, string tongtienbanduoc,string masp)
            : this()
        {
            this.ngayin = ngayin;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
            this.tensp = tensp;
            this.slbanduoc = slbanduoc;
            this.tongtienbanduoc = tongtienbanduoc;
            this.masp = masp;
        }
            private void hd_thongke_Sp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.ThongKe_SP' table. You can move, or remove it, as needed.
            DateTime ngaybdau = Convert.ToDateTime(ngaybd).Date;
            DateTime ngaykthuc = Convert.ToDateTime(ngaykt).Date;
            this.ThongKe_SPTableAdapter.Fill(this.tt.ThongKe_SP,ngaybdau,ngaykthuc,masp);

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("ngaybd", ngaybd.ToString()));
            reportParameter.Add(new ReportParameter("ngaykt", ngaykt.ToString()));
            reportParameter.Add(new ReportParameter("tensp", tensp.ToString()));
            reportParameter.Add(new ReportParameter("slbanduoc", slbanduoc.ToString()));
            reportParameter.Add(new ReportParameter("tongtienbanduoc", tongtienbanduoc.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
