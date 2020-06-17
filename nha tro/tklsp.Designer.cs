namespace nha_tro
{
    partial class tklsp
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
            this.THONGKE_LOAISPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.THONGKE_LOAISPTableAdapter = new nha_tro.ttTableAdapters.THONGKE_LOAISPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.THONGKE_LOAISPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            this.SuspendLayout();
            // 
            // THONGKE_LOAISPBindingSource
            // 
            this.THONGKE_LOAISPBindingSource.DataMember = "THONGKE_LOAISP";
            this.THONGKE_LOAISPBindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tklsp";
            reportDataSource1.Value = this.THONGKE_LOAISPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Reporttklsp.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // THONGKE_LOAISPTableAdapter
            // 
            this.THONGKE_LOAISPTableAdapter.ClearBeforeFill = true;
            // 
            // tklsp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "tklsp";
            this.Text = "tklsp";
            this.Load += new System.EventHandler(this.tklsp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.THONGKE_LOAISPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource THONGKE_LOAISPBindingSource;
        private tt tt;
        private ttTableAdapters.THONGKE_LOAISPTableAdapter THONGKE_LOAISPTableAdapter;
    }
}