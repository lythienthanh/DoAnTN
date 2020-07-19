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
    public partial class Form4_hd_tragop_landau : Form
    {
        public Form4_hd_tragop_landau()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string mahd, matragop, ngay, tongtiendatra, tongtienconlai, tongtienphaitra;
        public Form4_hd_tragop_landau(string mahd, string matragop, string ngay,string tongtiendatra,string tongtienconlai, string tongtienphaitra)
            : this()
        {
            this.matragop = matragop;
            this.mahd = mahd;
            this.ngay = ngay;
            this.tongtiendatra = tongtiendatra;
            this.tongtienconlai = tongtienconlai;
            this.tongtienphaitra = tongtienphaitra;
        }
        private void Form4_hd_tragop_landau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NghiepVu.xuat_hd_tragop_landau' table. You can move, or remove it, as needed.
            this.xuat_hd_tragop_landauTableAdapter.Fill(this.NghiepVu.xuat_hd_tragop_landau,int.Parse(mahd));

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("matragop", matragop.ToString()));
            reportParameter.Add(new ReportParameter("ngay", ngay.ToString()));
            reportParameter.Add(new ReportParameter("tongtiendatra", tongtiendatra.ToString()));
            reportParameter.Add(new ReportParameter("tongtienconlai", tongtienconlai.ToString()));
            reportParameter.Add(new ReportParameter("tongtienphaitra", tongtienphaitra.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
