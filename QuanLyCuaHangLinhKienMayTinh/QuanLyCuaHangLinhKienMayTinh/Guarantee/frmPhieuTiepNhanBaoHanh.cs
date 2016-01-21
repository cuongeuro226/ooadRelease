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
using DTO;
using BLL.Guarantee;
using CommonLayer;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.XtraPrinting.Native;

namespace QuanLyCuaHangLinhKienMayTinh.Guarantee
{
    public partial class frmPhieuTiepNhanBaoHanh : Form
    {
        string maNV = "";
        private BllPhieuTiepNhanBaoHanh bllPTNBH;

        private BllChiTietPhieuTiepNhanBaoHanh bllCTPTNBH;

        private string _maPTNBH;
        public void InitAll()
        {
            InitializeComponent();

            dgvDetailWarranty.ClearSelection();

            bllPTNBH = new BllPhieuTiepNhanBaoHanh();
            bllCTPTNBH = new BllChiTietPhieuTiepNhanBaoHanh();
            Load += frmPhieuTiepNhanBaoHanh_Load;
            nbudQuanlity.TextChanged += NbudQuanlity_TextChanged;
        }

        public frmPhieuTiepNhanBaoHanh()
        {

            InitAll();

        }

        public frmPhieuTiepNhanBaoHanh(string manv)
        {
            maNV = manv;
            InitAll();

        }

        private void NbudQuanlity_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateId()
        {
            try
            {
                txtMaPTNBH.Text = bllPTNBH.CreatePTNBH();
            }
            catch(Exception ex)
            {
                lblThongBao.Text = "Lỗi không tạo mới! mã lỗi " + ex.Message;
            }
            
        }

        private void frmPhieuTiepNhanBaoHanh_Load(object sender, EventArgs e)
        {
            CreateId();
            txtMaNV.Text = maNV;
            GetMaHD();

            //cbNV.DataSource = bllPTNBH.GetListMaNV();
            //txtMaPTNBH.Text = "PTNBH002";
            //dgvCTPTNBH.DataSource = bllCTPTNBH.GetAllCTPTNBH(txtMaPTNBH.Text.ToString());
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DtoPhieuTiepNhanBaoHanh dtoPTNBH = new DtoPhieuTiepNhanBaoHanh();
            List<DtoChiTietPhieuTiepNhanBaoHanh> listCTPTNBH = new List<DtoChiTietPhieuTiepNhanBaoHanh>();

            dtoPTNBH.MaPTNBH = txtMaPTNBH.Text;
            _maPTNBH = txtMaPTNBH.Text;

            dtoPTNBH.MaNV = txtMaNV.Text.ToString();
            dtoPTNBH.NgayLap = DateTime.Now;

            foreach (DataGridViewRow row in dgvDetailWarranty.Rows)
            {
                DtoChiTietPhieuTiepNhanBaoHanh dtoCTPTNBH = new DtoChiTietPhieuTiepNhanBaoHanh();
                //dtoCTPTNBH.MaCTPTNBH = int.Parse(dgvCTPTNBH.Rows[i].Cells[0].Value.ToString());
                dtoCTPTNBH.MaHoaDon = row.Cells[1].Value.ToString();
                dtoCTPTNBH.MaSanPham = row.Cells[2].Value.ToString();
                dtoCTPTNBH.MoTaLoi = row.Cells[4].Value.ToString();
                dtoCTPTNBH.SoLuong = int.Parse(row.Cells[5].Value.ToString());
                dtoCTPTNBH.MaPTNBH = dtoPTNBH.MaPTNBH;

                listCTPTNBH.Add(dtoCTPTNBH);
            }
            if (listCTPTNBH.Count == 0)
            {
                DisplayNotify("Không thể tạo phiếu tiếp nhận không có chi tiết", -1);
                return;
            }
            if (bllPTNBH.AddPhieuTiepNhanBaoHanh(dtoPTNBH, listCTPTNBH))
            {
                try
                {
                    txtMaPTNBH.Text = bllPTNBH.CreatePTNBH();
                }
                catch (Exception ex)
                {
                    lblThongBao.Text = "Lỗi không tạo mới! mã lỗi " + ex.Message;
                }
                btnClear.PerformClick();
                txtAboutError.Clear();
                MessageBox.Show(Constants.MsgNotificationSuccessfuly);
                //btnThoat.PerformClick();
            }
            else
            {
                MessageBox.Show(Constants.MsgExceptionError);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            if (_maPTNBH == txtMaPTNBH.Text)
            {
                MessageBox.Show("Không thể tạo phiếu tiếp nhận bảo hành!");
                return;
            }
            PrintPhieuTiepNhanBaoHanh inPTNBH = new PrintPhieuTiepNhanBaoHanh();
            inPTNBH.MaPTNBH = _maPTNBH;
            inPTNBH.MaNV = txtMaNV.Text.ToString();
            inPTNBH.NgayLap = dateTimePTNBH.Value.ToString();// ("dd/mm/yyyy");
            inPTNBH.ShowDialog();

            _maPTNBH = txtMaPTNBH.Text;
        }

        

        private void txtMoTaLoi_TextChanged(object sender, EventArgs e)
        {
            if (txtAboutError.Text.Length == 0)
            {
                lblTBMoTaLoi.Enabled = true;
            }
            else
                lblTBMoTaLoi.Enabled = false;
        }

        private void cbMaHD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvProducts.DataSource = bllPTNBH.GetSanPhamByMaHD(cbMaHD.Text);

                if (cbMaHD.Text.Length == 0)
                {
                    lblTBMaHD.Enabled = true;
                }
                else
                {
                    lblTBMaHD.Enabled = false;
                }
            }
            catch (SqlException sqlException)
            {
                DisplayNotify("Lỗi kết nối cơ sở dữ liệu", - 1);
                return;
            }
            catch (Exception ex)
            {
             
            }
        }

        private void GetMaHD()
        {
            try
            {
                cbMaHD.DataSource = bllPTNBH.GetMaHD();
                foreach (DataRow row in bllPTNBH.GetMaHD().Rows)
                {
                    cbMaHD.AutoCompleteCustomSource.Add(row.ItemArray[0].ToString());
                }

            }
            catch (SqlException sqlEx)
            {
                lblThongBao.Text = "Lỗi cơ sở dữ liệu! " + sqlEx.Message;
            }
            catch(Exception ex)
            {
                lblThongBao.Text = "Lỗi Mã hóa đơn!" + ex.Message;
            }
        }
       
        private void cbMaSp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DataRowView a = (DataRowView)cbMaSp.SelectedItem;
           //MessageBox.Show( a.Row.ItemArray[1].ToString());
        }

        private void dgvCTPTNBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nbudQuanlity.Value = int.Parse(dgvDetailWarranty.CurrentRow.Cells[5].Value.ToString());
                txtAboutError.Text = dgvDetailWarranty.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void ckbDateTimeSystem_Click(object sender, EventArgs e)
        {
            if (ckbDateTimeSystem.Checked)
            {
                dateTimePTNBH.Enabled = false;
            }
            else
            {
                dateTimePTNBH.Enabled = true;
            }
        }

        private bool CheckValue()
        {
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAboutError.Text.IsEmpty())
            {
                DisplayNotify("Không được để trống mô tả lỗi", -1);
                return;
            }
            try
            {
                if (dgvProducts.CurrentCell.Value != null)
                {
                    DateTime date = DateTime.Parse(dgvProducts.CurrentRow.Cells[4].Value.ToString());
                    date = date.AddDays(int.Parse(dgvProducts.CurrentRow.Cells[3].Value.ToString()));
                    if (date < DateTime.Now)
                    {
                        DisplayNotify("Sản phẩm hết thời gian bảo hành!", -1);
                        return;
                    }
                    int quanlity = 0;
                    int before = 0;
                    int warrantyReturn = 0;
                    try
                    {
                        warrantyReturn = bllPTNBH.GetQuanlity(cbMaHD.Text, dgvProducts.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch (Exception ex) { }
                    try
                    {
                        before = bllCTPTNBH.GetQuanlityDetailWarrantyBillByBillID(cbMaHD.Text,
                            dgvProducts.CurrentRow.Cells[0].Value.ToString());
                        quanlity += before;
                    }
                    catch (Exception) { }

                    foreach ( DataGridViewRow row in dgvDetailWarranty.Rows)
                    {

                        if (row.Cells[2].Value.ToString().Equals(dgvProducts.CurrentRow.Cells[0].Value.ToString()))
                        {
                            quanlity += int.Parse(row.Cells[5].Value.ToString());
                        }
                    }
                    var msg = String.Format("Bạn đã bảo hành {0} sản phẩm trước đó", before);
                    if (int.Parse(dgvProducts.CurrentRow.Cells[2].Value.ToString()) < quanlity + nbudQuanlity.Value - warrantyReturn)
                    {
                        if (before != 0)
                        {
                            DisplayNotify(msg + " -- Số lượng mua thực sự ít hơn", -1);
                        }
                        else
                        {
                            DisplayNotify("Số lượng mua thực sự ít hơn", -1);
                        }
                        return;
                    }

                    dgvDetailWarranty.Rows.Add("",
                        cbMaHD.Text,
                        dgvProducts.CurrentRow.Cells[0].Value,
                        dgvProducts.CurrentRow.Cells[1].Value,
                        txtAboutError.Text,
                        nbudQuanlity.Value
                        );
                    DisplayNotify("Thêm thành công!", 1);
                }
                else
                {
                    DisplayNotify("Chưa chọn sản phẩm", -1);
                }
            }
            catch (Exception)
            {

            }
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

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            try
            {
                if (dgvProducts.CurrentRow.Cells[2].Value != null)
                {
                    nbudQuanlity.Maximum = decimal.Parse(dgvProducts.CurrentRow.Cells[2].Value.ToString());
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetailWarranty.CurrentRow.Index != -1)
                {
                    dgvDetailWarranty.Rows.Remove(dgvDetailWarranty.CurrentRow);
                    DisplayNotify("Xóa thành công!", 1);

                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvDetailWarranty_DataMemberChanged(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvDetailWarranty.Rows)
            {
                row.Cells[0].Value = i++;
            }

        }

        private void dgvDetailWarranty_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDetailWarranty.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            txtAboutError.Clear();
        }

        private void dgvDetailWarranty_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvDetailWarranty.Rows)
            {
                row.Cells[0].Value = i++;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtAboutError.Text.IsEmpty())
            {
                DisplayNotify("Không được để trống mô tả lỗi", -1);
                return;
            }
            try
            {
                if (dgvProducts.CurrentCell.Value != null)
                {
                    DateTime date = DateTime.Parse(dgvProducts.CurrentRow.Cells[4].Value.ToString());
                    date = date.AddDays(int.Parse(dgvProducts.CurrentRow.Cells[3].Value.ToString()));
                    if (date < DateTime.Now)
                    {
                        DisplayNotify("Sản phẩm hết thời gian bảo hành!", -1);
                        return;
                    }
                    int quanlity = 0;
                    int before = 0;
                    int warrantyReturn = 0;
                    try
                    {
                        warrantyReturn = bllPTNBH.GetQuanlity(cbMaHD.Text, dgvProducts.CurrentRow.Cells[0].Value.ToString());
                    }
                    catch (Exception ex) { }
                    try
                    {
                        before = bllCTPTNBH.GetQuanlityDetailWarrantyBillByBillID(cbMaHD.Text,
                            dgvProducts.CurrentRow.Cells[0].Value.ToString());
                        quanlity += before;
                    }
                    catch (Exception) { }

                    foreach (DataGridViewRow row in dgvDetailWarranty.Rows)
                    {
                       
                   
                        if (row.Cells[2].Value.ToString().Equals(dgvProducts.CurrentRow.Cells[0].Value.ToString())
                            && row != dgvDetailWarranty.CurrentRow)
                        {
                            quanlity += int.Parse(row.Cells[5].Value.ToString());
                        }
                    }
                    var msg = String.Format("Bạn đã bảo hành {0} sản phẩm trước đó", before);
                    if (int.Parse(dgvProducts.CurrentRow.Cells[2].Value.ToString()) < quanlity + nbudQuanlity.Value - warrantyReturn)
                    {
                        if (before != 0)
                        {
                            DisplayNotify(msg + " -- Số lượng mua thực sự ít hơn", -1);
                        }
                        else
                        {
                            DisplayNotify("Số lượng mua thực sự ít hơn", -1);
                        }
                        return;
                    }

                    if (dgvDetailWarranty.CurrentRow.Index != -1)
                    {
                        dgvDetailWarranty.Rows.Insert(dgvDetailWarranty.CurrentRow.Index, "",
                            cbMaHD.Text,
                            dgvDetailWarranty.CurrentRow.Cells[2].Value,
                            dgvDetailWarranty.CurrentRow.Cells[3].Value,
                            txtAboutError.Text,
                            nbudQuanlity.Value
                            );
                        btnRemove.PerformClick();
                        DisplayNotify("Sửa thành công!", 1);
                    }
                    else
                    {
                        DisplayNotify("Chưa chọn chi tiết hóa đơn", -1);
                        return;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvDetailWarranty_Sorted(object sender, EventArgs e)
        {
            int i = 1;
            foreach (DataGridViewRow row in dgvDetailWarranty.Rows)
            {
                row.Cells[0].Value = i++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvDetailWarranty.Rows.Clear();
            DisplayNotify("Đã xóa toàn bộ", 1);

        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }

        private void nbudQuanlity_ValueChanged(object sender, EventArgs e)
        {
        }

        private void nbudQuanlity_Leave(object sender, EventArgs e)
        {
            if (nbudQuanlity.Text.IsEmpty())
            {
                nbudQuanlity.Text = nbudQuanlity.Value.ToString();
            }
        }

    }
}
