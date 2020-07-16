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
    public partial class Form_xuat_hd_TTTGNCC : Form
    {
        public Form_xuat_hd_TTTGNCC()
        {
            InitializeComponent();
        }
        //====nhan data tu form ban hang
        private string mahd, ngayin, manhap, tongtienthanhtoan, sotienconlai,tennv;

        public Form_xuat_hd_TTTGNCC(string mahd, string ngayin, string manhap, string tongtienthanhtoan, string sotienconlai,string tennv)
            : this()
        {
            this.mahd = mahd;
            this.ngayin = ngayin;
            this.manhap = manhap;
            this.tongtienthanhtoan = tongtienthanhtoan;
            this.sotienconlai = sotienconlai;
            this.tennv = tennv;
        }
        private void Form_xuat_hd_TTTGNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.TinhTrangTT' table. You can move, or remove it, as needed.
            this.TinhTrangTTTableAdapter.FillBy_selectPhieuNhap(this.tt.TinhTrangTT, manhap);

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("manhap", manhap.ToString()));
            reportParameter.Add(new ReportParameter("sotienthanhtoan", tongtienthanhtoan.ToString()));
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("sotienconlai", sotienconlai.ToString()));
            reportParameter.Add(new ReportParameter("tennv", tennv.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
