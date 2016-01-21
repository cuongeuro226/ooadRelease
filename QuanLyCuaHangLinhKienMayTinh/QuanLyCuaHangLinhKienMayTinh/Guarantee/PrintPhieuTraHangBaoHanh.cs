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
    public partial class PrintPhieuTraHangBaoHanh : Form
    {
        private BllPhieuTiepNhanBaoHanh bllPTNBH;
        private string maPTNBH;

        public string MaPTNBH
        {
            get { return maPTNBH; }
            set { maPTNBH = value; }
        }

        private string maPTHBH;

        public string MaPTHBH
        {
            get { return maPTHBH; }
            set { maPTHBH = value; }
        }

        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        private string ngayTra;

        public string NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }
        public PrintPhieuTraHangBaoHanh()
        {
            InitializeComponent();
            bllPTNBH = new BllPhieuTiepNhanBaoHanh();
        }

        private void PrintPhieuTraHangBaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PhieuTraHangBaoHanhDataSet.sp_SprintPTHBH' table. You can move, or remove it, as needed.
            this.sp_SprintPTHBHTableAdapter.Fill(this.PhieuTraHangBaoHanhDataSet.sp_SprintPTHBH,maPTHBH);

            this.rpvPTHBH.RefreshReport();
            SetParameters();
            this.rpvPTHBH.RefreshReport();
        }

        private void SetParameters()
        {
            ReportParameter[] rp = new ReportParameter[6];
            rp[0] = new ReportParameter("PTHBH");
            rp[0].Values.Add(maPTHBH);
            rp[1] = new ReportParameter("PTNBH");
            rp[1].Values.Add(maPTNBH);
            rp[2] = new ReportParameter("MaNV");
            rp[2].Values.Add(maNV);
            rp[3] = new ReportParameter("MaKH");
            rp[3].Values.Add(bllPTNBH.GetKhachHangByPTNBH(maPTNBH).Rows[0][0].ToString());
            rp[4] = new ReportParameter("TenKH");
            rp[4].Values.Add(bllPTNBH.GetKhachHangByPTNBH(maPTNBH).Rows[0][1].ToString());
            rp[5] = new ReportParameter("NgayTra");
            rp[5].Values.Add(ngayTra);

            rpvPTHBH.LocalReport.SetParameters(rp);
        }
    }
}
