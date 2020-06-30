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
    public partial class hd_tragop_kh : Form
    {
        public hd_tragop_kh()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string ngayin, sldaban, tongtiendathanhtoan, tongtienconlai, tongtienphainhan,matragop;
        public hd_tragop_kh(string ngayin, string sldaban, string tongtiendathanhtoan, string tongtienconlai,string matragop,string tongtienphainhan)
            : this()
        {
            this.ngayin = ngayin;
            this.sldaban = sldaban;
            this.tongtienphainhan = tongtienphainhan;
            this.tongtiendathanhtoan = tongtiendathanhtoan;
            this.tongtienconlai = tongtienconlai;
            this.matragop = matragop;
        }

        private void hd_tragop_kh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.hoa_tragop_kh' table. You can move, or remove it, as needed.
            this.hoa_tragop_khTableAdapter.Fill(this.tt.hoa_tragop_kh, matragop);

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("sldaban", sldaban.ToString()));
            reportParameter.Add(new ReportParameter("tongtiendathanhtoan", tongtiendathanhtoan.ToString()));
            reportParameter.Add(new ReportParameter("tongtienconlai", tongtienconlai.ToString()));
            reportParameter.Add(new ReportParameter("tongtienphainhan", tongtienphainhan.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
