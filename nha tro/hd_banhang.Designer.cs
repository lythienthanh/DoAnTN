﻿namespace nha_tro
{
    partial class hd_banhang
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
            this.HD_banhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new nha_tro.tt();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HD_banhangTableAdapter = new nha_tro.ttTableAdapters.HD_banhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HD_banhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).BeginInit();
            this.SuspendLayout();
            // 
            // HD_banhangBindingSource
            // 
            this.HD_banhangBindingSource.DataMember = "HD_banhang";
            this.HD_banhangBindingSource.DataSource = this.tt;
            // 
            // tt
            // 
            this.tt.DataSetName = "tt";
            this.tt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "nha_tro.Report_banhang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // HD_banhangTableAdapter
            // 
            this.HD_banhangTableAdapter.ClearBeforeFill = true;
            // 
            // hd_banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "hd_banhang";
            this.Text = "hd_banhang";
            this.Load += new System.EventHandler(this.hd_banhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HD_banhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HD_banhangBindingSource;
        private tt tt;
        private ttTableAdapters.HD_banhangTableAdapter HD_banhangTableAdapter;
    }
}