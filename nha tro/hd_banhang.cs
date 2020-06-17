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
    public partial class hd_banhang : Form
    {
        public hd_banhang()
        {
            InitializeComponent();
        }
        //====nhan data tu form ban hang
        private string mahd,makh,tienkm,tongtien;

        public hd_banhang(string mahd,string makh,string tienkm,string tongtien)
            : this()
        {
            this.mahd = mahd;
            this.makh = makh;
            this.tienkm = tienkm;
            this.tongtien = tongtien;
        }

        private void hd_banhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tt.HD_banhang' table. You can move, or remove it, as needed.
            this.HD_banhangTableAdapter.Fill(this.tt.HD_banhang,int.Parse(mahd),makh);
            ReportParameterCollection reportParameter = new ReportParameterCollection();
            reportParameter.Add(new ReportParameter("mahd",mahd.ToString()));
            reportParameter.Add(new ReportParameter("tienkm", tienkm.ToString()));
            reportParameter.Add(new ReportParameter("tongtien", tongtien.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
