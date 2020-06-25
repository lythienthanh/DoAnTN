using DevExpress.DocumentServices.ServiceModel.DataContracts;
using Microsoft.Reporting.WinForms;
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
namespace nha_tro
{
    public partial class hd_lk : Form
    {
        public hd_lk()
        {
            InitializeComponent();
        }
        //====nhan data tu form ban hang
        private string mahd, ngay, tienkm, tongtien;

        public hd_lk(string mahd, string ngay, string tienkm, string tongtien)
            : this()
        {
            this.mahd = mahd;
            this.ngay = ngay;
            this.tienkm = tienkm;
            this.tongtien = tongtien;
        }
        private void hd_lk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.ct_mua_lk' table. You can move, or remove it, as needed.
            this.ct_mua_lkTableAdapter.Fill(this.tt.ct_mua_lk,int.Parse(mahd));
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("ngay", ngay.ToString()));
            reportParameter.Add(new ReportParameter("sotienkm", tienkm.ToString()));
            reportParameter.Add(new ReportParameter("tongtien", tongtien.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
    }
}
