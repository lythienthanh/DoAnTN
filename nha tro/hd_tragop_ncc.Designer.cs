namespace nha_tro
{
    partial class hd_tragop_ncc
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
            this.tt = new nha_tro.tt();
            this.THONGKE_TRAGOP_NCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.THONGKE_TRAGOP_NCCTableAdapter = new nha_tro.ttTableAdapters.THONGKE_TRAGOP_NCCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGKE_TRAGOP_NCCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "hd_tragop_ncc";
            reportDataSource1.Value = this.THONGKE_TRAGOP_NCCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report_tragop_ncc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // THONGKE_TRAGOP_NCCBindingSource
            // 
            this.THONGKE_TRAGOP_NCCBindingSource.DataMember = "THONGKE_TRAGOP_NCC";
            this.THONGKE_TRAGOP_NCCBindingSource.DataSource = this.tt;
            // 
            // THONGKE_TRAGOP_NCCTableAdapter
            // 
            this.THONGKE_TRAGOP_NCCTableAdapter.ClearBeforeFill = true;
            // 
            // hd_tragop_ncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hd_tragop_ncc";
            this.Text = "hd_tragop_ncc";
            this.Load += new System.EventHandler(this.hd_tragop_ncc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.THONGKE_TRAGOP_NCCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource THONGKE_TRAGOP_NCCBindingSource;
        private tt tt;
        private ttTableAdapters.THONGKE_TRAGOP_NCCTableAdapter THONGKE_TRAGOP_NCCTableAdapter;
    }
}