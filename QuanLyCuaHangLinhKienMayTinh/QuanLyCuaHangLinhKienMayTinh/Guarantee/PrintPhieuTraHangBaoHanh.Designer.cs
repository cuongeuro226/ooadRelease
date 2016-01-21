namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    partial class PrintPhieuTraHangBaoHanh
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
            this.rpvPTHBH = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PhieuTraHangBaoHanhDataSet = new QuanLyCuaHangLinhKienMayTinh.Guarantee.PhieuTraHangBaoHanhDataSet();
            this.sp_SprintPTHBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_SprintPTHBHTableAdapter = new QuanLyCuaHangLinhKienMayTinh.Guarantee.PhieuTraHangBaoHanhDataSetTableAdapters.sp_SprintPTHBHTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTraHangBaoHanhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SprintPTHBHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvPTHBH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 428);
            this.panel1.TabIndex = 0;
            // 
            // rpvPTHBH
            // 
            this.rpvPTHBH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PTHBH_DataSet";
            reportDataSource1.Value = this.sp_SprintPTHBHBindingSource;
            this.rpvPTHBH.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPTHBH.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangLinhKienMayTinh.Guarantee.PrintPhieuTraHangBaoHanh.rdlc";
            this.rpvPTHBH.Location = new System.Drawing.Point(0, 0);
            this.rpvPTHBH.Name = "rpvPTHBH";
            this.rpvPTHBH.Size = new System.Drawing.Size(707, 428);
            this.rpvPTHBH.TabIndex = 0;
            // 
            // PhieuTraHangBaoHanhDataSet
            // 
            this.PhieuTraHangBaoHanhDataSet.DataSetName = "PhieuTraHangBaoHanhDataSet";
            this.PhieuTraHangBaoHanhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_SprintPTHBHBindingSource
            // 
            this.sp_SprintPTHBHBindingSource.DataMember = "sp_SprintPTHBH";
            this.sp_SprintPTHBHBindingSource.DataSource = this.PhieuTraHangBaoHanhDataSet;
            // 
            // sp_SprintPTHBHTableAdapter
            // 
            this.sp_SprintPTHBHTableAdapter.ClearBeforeFill = true;
            // 
            // PrintPhieuTraHangBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 428);
            this.Controls.Add(this.panel1);
            this.Name = "PrintPhieuTraHangBaoHanh";
            this.Text = "PrintPhieuTraHangBaoHanh";
            this.Load += new System.EventHandler(this.PrintPhieuTraHangBaoHanh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhieuTraHangBaoHanhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_SprintPTHBHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPTHBH;
        private System.Windows.Forms.BindingSource sp_SprintPTHBHBindingSource;
        private PhieuTraHangBaoHanhDataSet PhieuTraHangBaoHanhDataSet;
        private PhieuTraHangBaoHanhDataSetTableAdapters.sp_SprintPTHBHTableAdapter sp_SprintPTHBHTableAdapter;
    }
}