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
    public partial class hd_tragop_kh_theongay : Form
    {
        public hd_tragop_kh_theongay()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string ngayin, sldaban, tongtiendathanhtoan, tongtienconlai, tongtienphainhan, ngaybd, ngaykt;
        public hd_tragop_kh_theongay(string ngayin, string sldaban, string tongtiendathanhtoan, string tongtienconlai, string ngaybd,string ngaykt, string tongtienphainhan)
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
        private void hd_tragop_kh_theongay_Load(object sender, EventArgs e)
        {
            DateTime ngaybdau = Convert.ToDateTime(ngaybd);
            DateTime ngaykthuc = DateTime.ParseExact(ngaykt,"dd/MM/yyyy",null);
            this.hd_tragop_kh_theongayTableAdapter.Fill(this.tt.hd_tragop_kh_theongay, ngaybdau, ngaykthuc);
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("sldaban", sldaban.ToString()));
            reportParameter.Add(new ReportParameter("tongtiendathanhtoan", tongtiendathanhtoan.ToString()));
            reportParameter.Add(new ReportParameter("tongtienconlai", tongtienconlai.ToString()));
            reportParameter.Add(new ReportParameter("tongtienphainhan", tongtienphainhan.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {


        }
    }
}
