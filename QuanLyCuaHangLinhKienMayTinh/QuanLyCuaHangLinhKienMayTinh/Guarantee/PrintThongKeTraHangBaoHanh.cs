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
    public partial class PrintThongKeTraHangBaoHanh : Form
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
        public PrintThongKeTraHangBaoHanh()
        {
            InitializeComponent();
        }

        private void PrintThongKeTraHangBaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ThongKeDataSet.sp_PrintPTHBH' table. You can move, or remove it, as needed.
            this.sp_PrintPTHBHTableAdapter.Fill(this.ThongKeDataSet.sp_PrintPTHBH,tuNgay,denNgay);

            this.rvPTHBH.RefreshReport();
            Setparameters();
            this.rvPTHBH.RefreshReport();
        }
        private void Setparameters()
        {
            ReportParameter[] rp = new ReportParameter[2];
            rp[0] = new ReportParameter("TuNgay");
            rp[0].Values.Add(tuNgay.ToString());
            rp[1] = new ReportParameter("DenNgay");
            rp[1].Values.Add(denNgay.ToString());
            rvPTHBH.LocalReport.SetParameters(rp);

        }
    }
}
