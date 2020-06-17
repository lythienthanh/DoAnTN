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
    public partial class HD_BAOHANH : Form
    {
        public HD_BAOHANH()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }
        //====nhan data tu form bAO HANH
        private string mahd, mabaohanh, tongtien, ngay,mahdbaohanh;

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        public HD_BAOHANH(string mahd, string mabaohanh, string tongtien, string ngay, string mahdbaohanh)
            : this()
        {
            this.mahdbaohanh = mahdbaohanh;
            this.mahd = mahd;
            this.mabaohanh = mabaohanh;
            this.tongtien = tongtien;
            this.ngay = ngay;
        }
        private void HD_BAOHANH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.hd_baohanh' table. You can move, or remove it, as needed.
            this.hd_baohanhTableAdapter.Fill(this.tt.hd_baohanh,int.Parse(mabaohanh));

            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd", mahd.ToString()));
            reportParameter.Add(new ReportParameter("mabaohanh", mabaohanh.ToString()));
            reportParameter.Add(new ReportParameter("tongtien", tongtien.ToString()));
            reportParameter.Add(new ReportParameter("ngay", ngay.ToString()));
            reportParameter.Add(new ReportParameter("mahdbaohanh", mahdbaohanh.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();

        }
    }
}
