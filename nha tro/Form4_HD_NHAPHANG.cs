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
    public partial class Form4_HD_NHAPHANG : Form
    {
        public Form4_HD_NHAPHANG()
        {
            InitializeComponent();
        }
        //====nhan data tu form ban hang
        private string mahd, ngayin, manhap, tongtien, tennv;

        public Form4_HD_NHAPHANG(string mahd, string ngayin, string manhap, string tongtien, string tennv)
            : this()
        {
            this.mahd = mahd;
            this.ngayin = ngayin;
            this.manhap = manhap;
            this.tongtien = tongtien;
            this.tennv = tennv;
        }
        private void Form4_HD_NHAPHANG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'NghiepVu.XUAT_HD_NHAPHANG_SP' table. You can move, or remove it, as needed.
            this.XUAT_HD_NHAPHANG_SPTableAdapter.Fill(this.NghiepVu.XUAT_HD_NHAPHANG_SP,manhap);

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("manhap", manhap.ToString()));
            reportParameter.Add(new ReportParameter("tongtien", tongtien.ToString()));
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("tennv", tennv.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
