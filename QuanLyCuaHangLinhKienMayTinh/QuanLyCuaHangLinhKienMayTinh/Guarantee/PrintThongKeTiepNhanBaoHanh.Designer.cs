namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    partial class PrintThongKeTiepNhanBaoHanh
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
            this.sp_PrintPTNBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeDataSet = new QuanLyCuaHangLinhKienMayTinh.Guarantee.ThongKeDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvTNBH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_PrintPTNBHTableAdapter = new QuanLyCuaHangLinhKienMayTinh.Guarantee.ThongKeDataSetTableAdapters.sp_PrintPTNBHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PrintPTNBHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_PrintPTNBHBindingSource
            // 
            this.sp_PrintPTNBHBindingSource.DataMember = "sp_PrintPTNBH";
            this.sp_PrintPTNBHBindingSource.DataSource = this.ThongKeDataSet;
            // 
            // ThongKeDataSet
            // 
            this.ThongKeDataSet.DataSetName = "ThongKeDataSet";
            this.ThongKeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rvTNBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 398);
            this.panel1.TabIndex = 0;
            // 
            // rvTNBH
            // 
            this.rvTNBH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ThongKeTNBH_DataSet";
            reportDataSource1.Value = this.sp_PrintPTNBHBindingSource;
            this.rvTNBH.LocalReport.DataSources.Add(reportDataSource1);
            this.rvTNBH.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangLinhKienMayTinh.Guarantee.ReportThongKeTiepNhanBaoHanh.rdlc";
            this.rvTNBH.Location = new System.Drawing.Point(0, 0);
            this.rvTNBH.Name = "rvTNBH";
            this.rvTNBH.Size = new System.Drawing.Size(687, 398);
            this.rvTNBH.TabIndex = 0;
            // 
            // sp_PrintPTNBHTableAdapter
            // 
            this.sp_PrintPTNBHTableAdapter.ClearBeforeFill = true;
            // 
            // PrintThongKeTiepNhanBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 398);
            this.Controls.Add(this.panel1);
            this.Name = "PrintThongKeTiepNhanBaoHanh";
            this.Text = "PrintThongKePhieuBaoHanh";
            this.Load += new System.EventHandler(this.PrintThongKePhieuBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_PrintPTNBHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvTNBH;
        private System.Windows.Forms.BindingSource sp_PrintPTNBHBindingSource;
        private ThongKeDataSet ThongKeDataSet;
        private ThongKeDataSetTableAdapters.sp_PrintPTNBHTableAdapter sp_PrintPTNBHTableAdapter;
    }
}