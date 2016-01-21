using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    public partial class PrintThongKeTiepNhanBaoHanh : Form
    {
        DateTime tuNgay;

        public DateTime TuNgay
        {
            get { return tuNgay; }
            set { tuNgay = value; }
        }
        DateTime denNgay;

        public DateTime DenNgay
        {
            get { return denNgay; }
            set { denNgay = value; }
        }
        public PrintThongKeTiepNhanBaoHanh()
        {
            InitializeComponent();
        }

        private void PrintThongKePhieuBaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongKeDataSet.sp_PrintPTNBH' table. You can move, or remove it, as needed.
            this.sp_PrintPTNBHTableAdapter.Fill(this.ThongKeDataSet.sp_PrintPTNBH,tuNgay,denNgay);

            this.rvTNBH.RefreshReport();
            Setparameters();
            this.rvTNBH.RefreshReport();
        }

        private void Setparameters()
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[0].Values.Add(tuNgay.ToString());
            rp[1] = new ReportParameter("DenNgay");
            rp[1].Values.Add(denNgay.ToString());
            rvTNBH.LocalReport.SetParameters(rp);

        }
    }
}
