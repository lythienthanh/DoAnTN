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
    public partial class xuat_tk_loinhuan : Form
    {
        public xuat_tk_loinhuan()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string ngayin, slban, tongtiennhap, tongtienban, sotienloi, ngaykt,ngaybd;
        public xuat_tk_loinhuan(string ngayin, string ngaykt, string slban, string tongtiennhap, string ngaybd,string tongtienban,string sotienloi)
            : this()
        {
            this.ngayin = ngayin;
            this.slban = slban;
            this.tongtiennhap = tongtiennhap;
            this.tongtienban = tongtienban;
            this.sotienloi = sotienloi;
            this.ngaybd = ngaybd;
            this.ngaykt = ngaykt;


        }
        private void xuat_tk_loinhuan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.xuat_tk_loinhuan' table. You can move, or remove it, as needed.
            this.xuat_tk_loinhuanTableAdapter.Fill(this.tt.xuat_tk_loinhuan,Convert.ToDateTime(ngaybd), Convert.ToDateTime(ngaykt));

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("slban", slban.ToString()));
            reportParameter.Add(new ReportParameter("tongtiennhap", tongtiennhap.ToString()));
            reportParameter.Add(new ReportParameter("tongtienban", tongtienban.ToString()));
            reportParameter.Add(new ReportParameter("tongtienloi", sotienloi.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
