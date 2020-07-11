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
    public partial class hd_nhaphang : Form
    {
        public hd_nhaphang()
        {
            InitializeComponent();
        }

        private void hd_nhaphang_Load(object sender, EventArgs e)
        {
            this.cT_NHAP_SP_DK_LUUKHOTableAdapter.Fill_DK(this.nghiepVu.CT_NHAP_SP_DK_LUUKHO, manhap);

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("manhap", manhap.ToString()));
            reportParameter.Add(new ReportParameter("tongtien", tongtien.ToString()));
            reportParameter.Add(new ReportParameter("ngayin", ngayin.ToString()));
            reportParameter.Add(new ReportParameter("tennv", ngayin.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }
        //====nhan data tu form ban hang
        private string mahd, ngayin, manhap, tongtien, tennv;

        public hd_nhaphang(string mahd, string ngayin, string manhap, string tongtien,string tennv)
            : this()
        {
            this.mahd = mahd;
            this.ngayin = ngayin;
            this.manhap = manhap;
            this.tongtien = tongtien;
            this.tennv = tennv;
        }
        private void cT_NHAP_SP_DK_LUUKHOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cT_NHAP_SP_DK_LUUKHOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nghiepVu);

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
        }
    }
}
