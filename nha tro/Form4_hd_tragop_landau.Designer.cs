namespace nha_tro
{
    partial class Form4_hd_tragop_landau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NghiepVu = new nha_tro.NghiepVu();
            this.xuat_hd_tragop_landauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xuat_hd_tragop_landauTableAdapter = new nha_tro.NghiepVuTableAdapters.xuat_hd_tragop_landauTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NghiepVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuat_hd_tragop_landauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.xuat_hd_tragop_landauBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report_hd_tragop_landau.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // NghiepVu
            // 
            this.NghiepVu.DataSetName = "NghiepVu";
            this.NghiepVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xuat_hd_tragop_landauBindingSource
            // 
            this.xuat_hd_tragop_landauBindingSource.DataMember = "xuat_hd_tragop_landau";
            this.xuat_hd_tragop_landauBindingSource.DataSource = this.NghiepVu;
            // 
            // xuat_hd_tragop_landauTableAdapter
            // 
            this.xuat_hd_tragop_landauTableAdapter.ClearBeforeFill = true;
            // 
            // Form4_hd_tragop_landau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4_hd_tragop_landau";
            this.Text = "Form4_hd_tragop_landau";
            this.Load += new System.EventHandler(this.Form4_hd_tragop_landau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NghiepVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuat_hd_tragop_landauBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource xuat_hd_tragop_landauBindingSource;
        private NghiepVu NghiepVu;
        private NghiepVuTableAdapters.xuat_hd_tragop_landauTableAdapter xuat_hd_tragop_landauTableAdapter;
    }
}