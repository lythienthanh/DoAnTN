﻿namespace nha_tro
{
    partial class Form_xuat_hd_TTTGNCC
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
            this.TinhTrangTTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TinhTrangTTTableAdapter = new nha_tro.ttTableAdapters.TinhTrangTTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTrangTTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TinhTrangTTBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report_xuat_hd_TTTGNCC.rdlc";
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
            // TinhTrangTTBindingSource
            // 
            this.TinhTrangTTBindingSource.DataMember = "TinhTrangTT";
            this.TinhTrangTTBindingSource.DataSource = this.tt;
            // 
            // TinhTrangTTTableAdapter
            // 
            this.TinhTrangTTTableAdapter.ClearBeforeFill = true;
            // 
            // Form_xuat_hd_TTTGNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_xuat_hd_TTTGNCC";
            this.Text = "Form_xuat_hd_TTTGNCC";
            this.Load += new System.EventHandler(this.Form_xuat_hd_TTTGNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TinhTrangTTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TinhTrangTTBindingSource;
        private tt tt;
        private ttTableAdapters.TinhTrangTTTableAdapter TinhTrangTTTableAdapter;
    }
}