using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Warehouse;
using CommonLayer;
using DevExpress.XtraPrinting.Native;
using DTO.Warehouse;

namespace QuanLyCuaHangLinhKienMayTinh.Warehouse
{
    public partial class frmAddWarehouseBill : Form
    {
        private string maNV = "";
        private BllProduct _bllProduct;
        private BllWarehouseBill _bllWarehouseBill;
        private BllWarehouseBillDetail _bllWarehouseBillDetail;
        public frmAddWarehouseBill()
        {
            InitAll();
        }
        public void InitAll()
        {
            InitializeComponent();

            _bllProduct = new BllProduct();
            _bllWarehouseBill = new BllWarehouseBill();
            _bllWarehouseBillDetail = new BllWarehouseBillDetail();

            Load += FrmAddWarehouseBill_Load;
        }
        public frmAddWarehouseBill(string manv)
        {
            maNV = manv;
            InitAll();
        }
        private void FrmAddWarehouseBill_Load(object sender, EventArgs e)
        {
            try
            {
                txtWarehouseBillID.Text = CreateNewWarehouseBillID();
                txtNguoiLapPhieu.Text = maNV;
                MaSanPham.DataSource = _bllProduct.GetListProducts();
                MaSanPham.DisplayMember = "TenSanPham";
                MaSanPham.ValueMember = "MaSanPham";
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
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



        #region Feature function
        private string CreateNewWarehouseBillID()
        {
            try
            {
                return _bllWarehouseBill.CreateWarehouseBillID();
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
            return "";
        }
        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                List<DtoWarehouseBillDetail> list = new List<DtoWarehouseBillDetail>();
                DtoWarehouseBill warehouseBill = new DtoWarehouseBill();
                warehouseBill.MaPhieuNhapKho = txtWarehouseBillID.Text;
                warehouseBill.NgayLapPhieu = DateTime.Now;
                warehouseBill.MaNguoiLapPhieu = maNV;
                warehouseBill.GhiChu = txtGhiChu.Text;
                for (int i = 0; i < dgvDetailWarehouseBill.Rows.Count - 1; i++)
                {
                    DtoWarehouseBillDetail detail = new DtoWarehouseBillDetail();
                    detail.MaPhieuNhapKho = warehouseBill.MaPhieuNhapKho;
                    detail.MaSanPham = dgvDetailWarehouseBill.Rows[i].Cells[1].Value.ToString();
                    detail.SoLuong = int.Parse(dgvDetailWarehouseBill.Rows[i].Cells[3].Value.ToString());
                    if (dgvDetailWarehouseBill.Rows[i].Cells[4].Value != null)
                    {
                        detail.GhiChu = dgvDetailWarehouseBill.Rows[i].Cells[4].Value.ToString();
                    }
                    else
                    {
                        detail.GhiChu = "";
                    }
                    list.Add(detail);
                }

                if (_bllWarehouseBill.AddWarehouseBillTran(warehouseBill, list))
                {
                    DisplayNotify("Thêm phiếu nhập kho thành công!", 1);
                    MessageBox.Show("Thêm phiếu nhập kho thành công!");
                    txtWarehouseBillID.Text = CreateNewWarehouseBillID();
                    dgvDetailWarehouseBill.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
        }

        private void dgvDetailWarehouseBill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var s = dgvDetailWarehouseBill.CurrentRow.Cells[1].Value.ToString();
                if (!s.IsEmpty() || s != null)
                {
                    DtoProduct dto = _bllProduct.GetProductByID(s);
                    dgvDetailWarehouseBill.CurrentRow.Cells[2].Value = dto.DonGiaNhap;
                }
                if (dgvDetailWarehouseBill.CurrentRow.Cells[3].Value == null)
                {
                    dgvDetailWarehouseBill.CurrentRow.Cells[3].Value = 1;
                }
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (dgvDetailWarehouseBill.Rows.Count == 1)
            {
                DisplayNotify("Không được để trống sản phẩm, số lượng", -1);
                return;
            }
            for (int i = 0; i < dgvDetailWarehouseBill.Rows.Count - 1; i++)
            {
                if (dgvDetailWarehouseBill.Rows[i].Cells[1].Value == null ||
                    dgvDetailWarehouseBill.Rows[i].Cells[2].Value == null ||
                    dgvDetailWarehouseBill.Rows[i].Cells[3].Value == null)
                {
                    DisplayNotify("Không được để trống sản phẩm, số lượng", -1);
                    return;
                }
            }

            DisplayNotify("Chấp nhận!", 1);
            btnThem.Enabled = true;

            txtTotal.Text = SumTotal().ToString();
        }

        private double SumTotal()
        {
            try
            {
                double s = 0;
                for (int i = 0; i < dgvDetailWarehouseBill.Rows.Count - 1; i++)
                {
                    s += double.Parse(dgvDetailWarehouseBill.Rows[i].Cells[2].Value.ToString()) *
                         double.Parse(dgvDetailWarehouseBill.Rows[i].Cells[3].Value.ToString());
                }
                return s;
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
            return 0;}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetailWarehouseBill_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                var s = dgvDetailWarehouseBill.CurrentRow.Cells[1].Value.ToString();
                if (!s.IsEmpty() || s != null)
                {
                    DtoProduct dto = _bllProduct.GetProductByID(s);
                    dgvDetailWarehouseBill.CurrentRow.Cells[2].Value = dto.DonGiaNhap;
                }
                SetValue();
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
        }

        private void dgvDetailWarehouseBill_Sorted(object sender, EventArgs e)
        {

        }

        private void dgvDetailWarehouseBill_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            SetValue();
        }

        private void dgvDetailWarehouseBill_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            SetValue();
        }

        private void SetValue()
        {
            try
            {
                if (dgvDetailWarehouseBill.CurrentRow.Cells[3].Value != null)
                {
                    dgvDetailWarehouseBill.CurrentRow.Cells[3].Value = (int) 1;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvDetailWarehouseBill_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvDetailWarehouseBill.CurrentRow.Cells[0].Value = e.RowIndex;
        }

        private void dgvDetailWarehouseBill_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var s = dgvDetailWarehouseBill.CurrentRow.Cells[1].Value.ToString();
                if (!s.IsEmpty() || s != null)
                {
                    DtoProduct dto = _bllProduct.GetProductByID(s);
                    dgvDetailWarehouseBill.CurrentRow.Cells[2].Value = dto.DonGiaNhap;
                }
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
        }}
}
