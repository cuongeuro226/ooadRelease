using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Guarantee;

namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    public partial class frmThongKeBaoHanh : Form
    {
        BllThongKeBaoHanh bllThongKe;

        public frmThongKeBaoHanh()
        {
            InitializeComponent();
            bllThongKe = new BllThongKeBaoHanh();
            Load += frmThongKeBaoHanh_Load;
        }

        private void frmThongKeBaoHanh_Load(object sender, EventArgs e)
        {
            rbPTHBH.Checked = true;
            LoadAll();
        }

        private void LoadAll()
        {
            if(rbPTNBH.Checked == true)
            {
                dgvDanhSach.DataSource = bllThongKe.GetThongKePTNBH(dtpTuNgay.Value, dtpDenNgay.Value);
            }
            else
                if(rbPTHBH.Checked == true)
                {
                    dgvDanhSach.DataSource = bllThongKe.GetThongKePTHBH(dtpTuNgay.Value, dtpDenNgay.Value);
                }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void rbPTHBH_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = bllThongKe.GetThongKePTHBH(dtpTuNgay.Value, dtpDenNgay.Value);
            gbDanhSach.Text = "Danh sách Phiếu trả hàng bảo hành";
        }

        private void rbPTNBH_CheckedChanged(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = bllThongKe.GetThongKePTNBH(dtpTuNgay.Value, dtpDenNgay.Value);
            gbDanhSach.Text = "Danh sách Phiếu tiếp nhận bảo hành";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (rbPTNBH.Checked == true)
            {
                PrintThongKeTiepNhanBaoHanh frm = new PrintThongKeTiepNhanBaoHanh();
                frm.TuNgay = dtpTuNgay.Value;
                frm.DenNgay = dtpDenNgay.Value;
                frm.ShowDialog();
            }
            else
                if(rbPTHBH.Checked == true)
                {
                    PrintThongKeTraHangBaoHanh frm = new PrintThongKeTraHangBaoHanh();
                    frm.TuNgay = dtpTuNgay.Value;
                    frm.DenNgay = dtpDenNgay.Value;
                    frm.ShowDialog();
                }
        }

    }
}
