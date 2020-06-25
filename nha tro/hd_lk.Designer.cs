namespace nha_tro
{
    partial class hd_lk
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
            this.ct_mua_lkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ct_mua_lkTableAdapter = new nha_tro.ttTableAdapters.ct_mua_lkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_mua_lkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HD_MUA_LK";
            reportDataSource1.Value = this.ct_mua_lkBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report_banLK.rdlc";
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
            // ct_mua_lkBindingSource
            // 
            this.ct_mua_lkBindingSource.DataMember = "ct_mua_lk";
            this.ct_mua_lkBindingSource.DataSource = this.tt;
            // 
            // ct_mua_lkTableAdapter
            // 
            this.ct_mua_lkTableAdapter.ClearBeforeFill = true;
            // 
            // hd_lk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hd_lk";
            this.Text = "hd_lk";
            this.Load += new System.EventHandler(this.hd_lk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ct_mua_lkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ct_mua_lkBindingSource;
        private tt tt;
        private ttTableAdapters.ct_mua_lkTableAdapter ct_mua_lkTableAdapter;
    }
}