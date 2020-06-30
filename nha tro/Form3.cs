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
namespace nha_tro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }        //====nhan data tu form bAO HANH
        private string ngayin, sldaban, tongtiendathanhtoan, tongtienconlai, tongtienphainhan, ngaybd, ngaykt;
        public Form3(string ngayin, string sldaban, string tongtiendathanhtoan, string tongtienconlai, string ngaybd, string ngaykt, string tongtienphainhan)
            : this()
        {
            this.ngayin = ngayin;
            this.sldaban = sldaban;
            this.tongtienphainhan = tongtienphainhan;
            this.tongtiendathanhtoan = tongtiendathanhtoan;
            this.tongtienconlai = tongtienconlai;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime ngaybdau = DateTime.ParseExact(ngaybd, "dd/MM/yyyy", null);
            DateTime ngaykthuc = DateTime.ParseExact(ngaykt, "dd/MM/yyyy", null);
            this.hd_tragop_kh_theongayTableAdapter.Fill(this.tt.hd_tragop_kh_theongay, ngaybdau, ngaykthuc);
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("sldaban", sldaban.ToString()));
            reportParameter.Add(new ReportParameter("tongtiendathanhtoan", tongtiendathanhtoan.ToString()));
            reportParameter.Add(new ReportParameter("tongtienconlai", tongtienconlai.ToString()));
            reportParameter.Add(new ReportParameter("tongtienphainhan", tongtienphainhan.ToString()));
            this.reportViewer2.LocalReport.SetParameters(reportParameter);
            this.reportViewer2.RefreshReport();
        }
    }
}
