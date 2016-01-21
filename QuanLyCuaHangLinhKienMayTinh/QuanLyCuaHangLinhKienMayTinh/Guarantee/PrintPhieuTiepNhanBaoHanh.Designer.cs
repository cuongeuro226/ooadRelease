namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    partial class PrintPhieuTiepNhanBaoHanh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhieuTiepNhanBaoHanhDataSet = new QuanLyCuaHangLinhKienMayTinh.Guarantee.PhieuTiepNhanBaoHanhDataSet();
            this.sp_SprintPTNBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SprintPTNBHTableAdapter = new QuanLyCuaHangLinhKienMayTinh.Guarantee.PhieuTiepNhanBaoHanhDataSetTableAdapters.sp_SprintPTNBHTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTiepNhanBaoHanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SprintPTNBHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 479);
            this.panel1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PTNBH_DataSet";
            reportDataSource1.Value = this.sp_SprintPTNBHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangLinhKienMayTinh.Guarantee.PrintPhieuTiepNhanBaoHanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(842, 479);
            this.reportViewer1.TabIndex = 0;
            // 
            // PhieuTiepNhanBaoHanhDataSet
            // 
            this.PhieuTiepNhanBaoHanhDataSet.DataSetName = "PhieuTiepNhanBaoHanhDataSet";
            this.PhieuTiepNhanBaoHanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SprintPTNBHBindingSource
            // 
            this.sp_SprintPTNBHBindingSource.DataMember = "sp_SprintPTNBH";
            this.sp_SprintPTNBHBindingSource.DataSource = this.PhieuTiepNhanBaoHanhDataSet;
            // 
            // sp_SprintPTNBHTableAdapter
            // 
            this.sp_SprintPTNBHTableAdapter.ClearBeforeFill = true;
            // 
            // PrintPhieuTiepNhanBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 479);
            this.Controls.Add(this.panel1);
            this.Name = "PrintPhieuTiepNhanBaoHanh";
            this.Text = "PrintPhieuTiepNhanBaoHanh";
            this.Load += new System.EventHandler(this.PrintPhieuTiepNhanBaoHanh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTiepNhanBaoHanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SprintPTNBHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_SprintPTNBHBindingSource;
        private PhieuTiepNhanBaoHanhDataSet PhieuTiepNhanBaoHanhDataSet;
        private PhieuTiepNhanBaoHanhDataSetTableAdapters.sp_SprintPTNBHTableAdapter sp_SprintPTNBHTableAdapter;
    }
}