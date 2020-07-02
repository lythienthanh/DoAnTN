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
    public partial class hd_doitra : Form
    {
        public hd_doitra()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string ngayin, mahddoi, mahdtra, spdoi, sptra, sotienthanhtoan, sotiennhan,madoitra;
        public hd_doitra(string ngayin, string mahddoi, string mahdtra, string spdoi, string sptra, string sotienthanhtoan, string sotiennhan,string madoitra)
            : this()
        {
            this.ngayin = ngayin;
            this.mahddoi = mahddoi;
            this.mahdtra = mahdtra;
            this.spdoi = spdoi;
            this.sptra = sptra;
            this.sotienthanhtoan = sotienthanhtoan;
            this.sotiennhan = sotiennhan;
            this.madoitra = madoitra;


        }
        private void hd_doitra_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("mahddoi", mahddoi.ToString()));
            reportParameter.Add(new ReportParameter("mahdtra", mahdtra.ToString()));
            reportParameter.Add(new ReportParameter("spdoi", spdoi.ToString()));
            reportParameter.Add(new ReportParameter("sptra", sptra.ToString()));
            reportParameter.Add(new ReportParameter("sotienthanhtoan", sotienthanhtoan.ToString()));
            reportParameter.Add(new ReportParameter("sotiennhan", sotiennhan.ToString()));
            reportParameter.Add(new ReportParameter("madoitra", madoitra.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
