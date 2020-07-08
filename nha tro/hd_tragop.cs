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
    public partial class hd_tragop : Form
    {
        public hd_tragop()
        {
            InitializeComponent();
        }
        //====nhan data tu form bAO HANH
        private string mahd, matragop, ngay;

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
        }

        public hd_tragop(string mahd, string matragop, string ngay)
            : this()
        {
            this.matragop = matragop;
            this.mahd = mahd;
            this.ngay = ngay;
        }
        private void hd_tragop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.TraGop1' table. You can move, or remove it, as needed.
            this.TraGop1TableAdapter.Fill_dk(this.tt.TraGop1,matragop);
            this.ct_mua_sp_lkTableAdapter.Fill(this.nghiepVu.ct_mua_sp_lk, ((int)(System.Convert.ChangeType(mahd, typeof(int)))));

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("matragop", matragop.ToString()));
            reportParameter.Add(new ReportParameter("ngay", ngay.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();

        }
    }
}
