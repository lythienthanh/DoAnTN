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
    public partial class report_banhang : Form
    {
        public report_banhang()
        {
            InitializeComponent();
        }
        //====nhan data tu form ban hang
        private string mahd, makh, tienkm, tongtien,tennv;

        public report_banhang(string mahd, string makh, string tienkm, string tongtien,string tennv)
            : this()
        {
            this.mahd = mahd;
            this.makh = makh;
            this.tienkm = tienkm;
            this.tongtien = tongtien;
            this.tennv = tennv;
        }
        private void report_banhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NghiepVu.ct_mua_sp_lk' table. You can move, or remove it, as needed.
            this.ct_mua_sp_lkTableAdapter.Fill(this.NghiepVu.ct_mua_sp_lk,int.Parse(mahd));

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("tennv", tennv.ToString()));
            reportParameter.Add(new ReportParameter("ngayin", DateTime.Today.ToString()));
            reportParameter.Add(new ReportParameter("tongkm", tienkm.ToString()));
            reportParameter.Add(new ReportParameter("tongtien", tongtien.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
