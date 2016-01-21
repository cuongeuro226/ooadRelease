using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Guarantee;
using DTO;
using CommonLayer;

namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    public partial class frmPhieuTraHangBaoHanh : Form
    {
        string maNV = "";
        BllPhieuTraHangBaoHanh bllPTHBH;
        private BllPhieuTiepNhanBaoHanh bllPTNBH;
        public frmPhieuTraHangBaoHanh()
        {
            InitAll();
        }
        public frmPhieuTraHangBaoHanh(string manv)
        {
            maNV = manv;
            InitAll();
        }

        public void InitAll()
        {
            InitializeComponent();
            bllPTHBH = new BllPhieuTraHangBaoHanh();
            bllPTNBH = new BllPhieuTiepNhanBaoHanh();
            Load += frmPhieuTraHangBaoHanh_Load;
        }

        #region Notify
        public void ResetNotify()
        {
            lblNotify.Text = "";
            lblNotify.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
        }
        public void DisplayNotify(string error, int codeError)
        {
            if (codeError == 1)
            {
                lblNotify.Text = error;
                lblNotify.BackColor = Color.Green;
            }
            else
            {
                if (codeError == -1)
                {
                    lblNotify.Text = error;
                    lblNotify.BackColor = Color.Red;
                }
            }
            // timer
            int TimeInterval = error.Length * 30;
            if (TimeInterval < 800)
                TimeInterval = 800;
            timerNotify.Interval = TimeInterval;
            timerNotify.Start();
        }
        private void timerNotify_Tick(object sender, EventArgs e)
        {
            ResetNotify();
            timerNotify.Stop();
        }

        #endregion


        private void btnLuu_Click(object sender, EventArgs e)
        {
            DtoPhieuTraHangBaoHanh dtoPTHBH = new DtoPhieuTraHangBaoHanh();
            List<DtoChiTietPhieuTraHangBaoHanh> listCTPTHBH = new List<DtoChiTietPhieuTraHangBaoHanh>();

            dtoPTHBH.MaPTHBH = txtMaPTHBH.Text;
            dtoPTHBH.MaNV = maNV;
            dtoPTHBH.MaPTNBH = cbPTNBH.Text.ToString();
            dtoPTHBH.NgayLap = DateTime.Now;

            if (bllPTHBH.IsReturnProductWarranty(cbPTNBH.Text.ToString()))
            {
                DisplayNotify("Phiếu tiếp nhận bảo hành này đã được trả", -1);
                return;
            }
            if (dgvPTHBH.Rows.Count == 0)
            {
                DisplayNotify("Không thể lưu do không có chi tiết phiếu trả", -1);
                return;
            }


            foreach (DataGridViewRow row in dgvPTHBH.Rows)
            {
                DtoChiTietPhieuTraHangBaoHanh dtoCTPTHBH = new DtoChiTietPhieuTraHangBaoHanh();
                dtoCTPTHBH.MaPTHBH = txtMaPTHBH.Text.ToString();
                dtoCTPTHBH.MaSanPham = row.Cells[2].Value.ToString();
                dtoCTPTHBH.MoTaLoi = row.Cells[3].Value.ToString();
                dtoCTPTHBH.SoLuong = int.Parse(row.Cells[4].Value.ToString());
                if (row.Cells[1].Value != null)
                    dtoCTPTHBH.GhiChu = row.Cells[4].Value.ToString();
                else
                {
                    dtoCTPTHBH.GhiChu = "";
                }
                listCTPTHBH.Add(dtoCTPTHBH);
            }

            if (listCTPTHBH.Count == 0)
            {
                DisplayNotify("Không thể lưu do không có chi tiết phiếu trả", -1);
                return;
            }
                if (bllPTHBH.AddPhieuTraHangBaoHanh(dtoPTHBH,listCTPTHBH) == 1)
                {
                   CreateId();
                    MessageBox.Show(Constants.MsgNotificationSuccessfuly);
                }
                else
                {
                    MessageBox.Show(Constants.MsgExceptionError);
                }
        }

        private void cbPTNBH_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                dgvPTHBH.DataSource = bllPTHBH.GetAllPTHBHByMaPTNBH(cbPTNBH.Text);

            }
            catch (SqlException sqlException)
            {
                DisplayNotify("Lỗi kết nối cơ sở dữ liệu", -1);
                return;
            }
            catch (Exception ex)
            {

            }
        }

        private void frmPhieuTraHangBaoHanh_Load(object sender, EventArgs e)
        {
            
            CreateId();
            txtMaNV.Text = maNV;
            try
            {
                cbPTNBH.DataSource = bllPTHBH.GetMaPTNBH();
                foreach (DataRow row in bllPTHBH.GetMaPTNBH().Rows)
                {
                    cbPTNBH.AutoCompleteCustomSource.Add(row["MaPTNBH"].ToString());
                }
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
        }

        private void CreateId()
        {
            try
            {
                txtMaPTHBH.Text = bllPTHBH.CreatePTHBH();
            }
            catch (Exception ex)
            {
                DisplayNotify("Lỗi tạo mới mã phiếu trả hàng bảo hành", -1);
            }

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //frmInPhieuTraHangBaoHanh frmInPhieuTraHangBaoHanh = new frmInPhieuTraHangBaoHanh();
            //frmInPhieuTraHangBaoHanh.MaPTHBH = txtMaPTHBH.Text.ToString();
            //frmInPhieuTraHangBaoHanh.MaPTNBH = cbPTNBH.Text.ToString();
            //frmInPhieuTraHangBaoHanh.MaNV = cbMaNV.Text.ToString();
            //frmInPhieuTraHangBaoHanh.NgayTra = dtpNgayTra.Value.ToString();
            //frmInPhieuTraHangBaoHanh.ShowDialog();
        }

        private void ckbDateTimeSystem_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDateTimeSystem.Checked)
            {
                dtpNgayTra.Value = DateTime.Now;
                dtpNgayTra.Enabled = false;
            }
            else
            {
                dtpNgayTra.Enabled = true;
            }
        }

        private void dgvPTHBH_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvPTHBH.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgvPTHBH_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvPTHBH.Rows)
            {
                row.Cells[0].Value = i++;
            }
        }

        private void dgvPTHBH_Sorted(object sender, EventArgs e)
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvPTHBH.Rows)
            {
                row.Cells[0].Value = i++;
            }
        }
    }
}
