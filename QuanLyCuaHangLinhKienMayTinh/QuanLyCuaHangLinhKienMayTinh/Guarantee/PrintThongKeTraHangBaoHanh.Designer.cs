namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    partial class PrintThongKeTraHangBaoHanh
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
            this.rvPTHBH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeDataSet = new QuanLyCuaHangLinhKienMayTinh.Guarantee.ThongKeDataSet();
            this.sp_PrintPTHBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_PrintPTHBHTableAdapter = new QuanLyCuaHangLinhKienMayTinh.Guarantee.ThongKeDataSetTableAdapters.sp_PrintPTHBHTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PrintPTHBHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rvPTHBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 414);
            this.panel1.TabIndex = 0;
            // 
            // rvPTHBH
            // 
            this.rvPTHBH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ThongKePTHBH_DataSet";
            reportDataSource1.Value = this.sp_PrintPTHBHBindingSource;
            this.rvPTHBH.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPTHBH.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangLinhKienMayTinh.Guarantee.ReportThongKeTraHangBaoHanh.rdlc";
            this.rvPTHBH.Location = new System.Drawing.Point(0, 0);
            this.rvPTHBH.Name = "rvPTHBH";
            this.rvPTHBH.Size = new System.Drawing.Size(776, 414);
            this.rvPTHBH.TabIndex = 0;
            // 
            // ThongKeDataSet
            // 
            this.ThongKeDataSet.DataSetName = "ThongKeDataSet";
            this.ThongKeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_PrintPTHBHBindingSource
            // 
            this.sp_PrintPTHBHBindingSource.DataMember = "sp_PrintPTHBH";
            this.sp_PrintPTHBHBindingSource.DataSource = this.ThongKeDataSet;
            // 
            // sp_PrintPTHBHTableAdapter
            // 
            this.sp_PrintPTHBHTableAdapter.ClearBeforeFill = true;
            // 
            // PrintThongKeTraHangBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 414);
            this.Controls.Add(this.panel1);
            this.Name = "PrintThongKeTraHangBaoHanh";
            this.Text = "PrintThongKeTraHangBaoHanh";
            this.Load += new System.EventHandler(this.PrintThongKeTraHangBaoHanh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_PrintPTHBHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvPTHBH;
        private System.Windows.Forms.BindingSource sp_PrintPTHBHBindingSource;
        private ThongKeDataSet ThongKeDataSet;
        private ThongKeDataSetTableAdapters.sp_PrintPTHBHTableAdapter sp_PrintPTHBHTableAdapter;
    }
}