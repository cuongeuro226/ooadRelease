using BLL.Guarantee;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    public partial class PrintPhieuTiepNhanBaoHanh : Form
    {
        private BllPhieuTiepNhanBaoHanh bllPTNBH;
        public PrintPhieuTiepNhanBaoHanh()
        {
            InitializeComponent();
            bllPTNBH = new BllPhieuTiepNhanBaoHanh();
        }
        private string maPTNBH;

        public string MaPTNBH
        {
            get { return maPTNBH; }
            set { maPTNBH = value; }
        }

        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string ngayLap;

        public string NgayLap
        {
            get { return ngayLap; }
            set { ngayLap = value; }
        }

        private void PrintPhieuTiepNhanBaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PhieuTiepNhanBaoHanhDataSet.sp_SprintPTNBH' table. You can move, or remove it, as needed.
            this.sp_SprintPTNBHTableAdapter.Fill(this.PhieuTiepNhanBaoHanhDataSet.sp_SprintPTNBH,maPTNBH);

            this.reportViewer1.RefreshReport();
            SetParameters();
            this.reportViewer1.RefreshReport();
        }
        private void SetParameters()
        {
            ReportParameter[] rp = new ReportParameter[5];
            rp[0] = new ReportParameter("MaPTNBH");
            rp[0].Values.Add(maPTNBH);
            rp[1] = new ReportParameter("MaNV");
            rp[1].Values.Add(maNV);
            rp[2] = new ReportParameter("NgayLap");
            rp[2].Values.Add(ngayLap);
            rp[3] = new ReportParameter("MaKH");
            rp[3].Values.Add(bllPTNBH.GetKhachHangByPTNBH(maPTNBH).Rows[0][0].ToString());
            rp[4] = new ReportParameter("TenKH");
            rp[4].Values.Add(bllPTNBH.GetKhachHangByPTNBH(maPTNBH).Rows[0][1].ToString());
            reportViewer1.LocalReport.SetParameters(rp);
        }
    }
}
