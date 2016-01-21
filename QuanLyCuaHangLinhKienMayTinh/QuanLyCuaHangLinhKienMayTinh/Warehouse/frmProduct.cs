using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Warehouse;
using CommonLayer;
using DevExpress.Data.PLinq.Helpers;

using DevExpress.XtraPrinting.Native;
using DTO.Warehouse;

namespace QuanLyCuaHangLinhKienMayTinh.Warehouse
{
    public partial class frmProduct : Form
    {
        static int indexsearch = 0;

        #region Declare
        private BllProduct _bllProduct;
        private List<TextBox> _listTextBoxs;
        #endregion

        #region Initialization 
        public frmProduct()
        {
            InitializeComponent();

            _bllProduct = new BllProduct();

            _listTextBoxs = new List<TextBox>();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
           // dgvListProduct.DataSource = _bllProduct.GetListProducts();

            //DgvDataBindings();

            //InitListTextBoxs();
			try
            {
                dgvListProduct.DataSource = _bllProduct.GetListProducts();
            

            DgvDataBindings();

            InitListTextBoxs();
                ClearTextBox();
                txtMaSanPham.Enabled = true;
                btnLuu.Enabled = true;
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi không load được danh sách sản phẩm" + ex.Message,-1);
            }


        }

        private void InitListTextBoxs()
        {
            _listTextBoxs.Add(txtMaSanPham);
            _listTextBoxs.Add(txtTenSanPham);
            _listTextBoxs.Add(txtLoaiSanPham);
            _listTextBoxs.Add(txtThoiGianBaoHanh);
            _listTextBoxs.Add(txtDonGiaNhap);
            _listTextBoxs.Add(txtDonGiaBan);
            _listTextBoxs.Add(txtDonViTinh);
        }

        private void DgvDataBindings()
        {
			 DevComponents.DotNetBar.Controls.DataGridViewX g = dgvListProduct;
            if (g.SelectedRows.Count == 1)
            {
                txtMaSanPham.Text = g.SelectedRows[0].Cells[0].Value.ToString();


                txtTenSanPham.Text = g.SelectedRows[0].Cells[1].Value.ToString();


                txtLoaiSanPham.Text = g.SelectedRows[0].Cells[2].Value.ToString();


                txtThoiGianBaoHanh.Text = g.SelectedRows[0].Cells[3].Value.ToString();

                txtDonGiaNhap.Text = g.SelectedRows[0].Cells[4].Value.ToString();


                txtDonGiaBan.Text = g.SelectedRows[0].Cells[5].Value.ToString();


                txtDonViTinh.Text = g.SelectedRows[0].Cells[7].Value.ToString();

                txtGhiChu.Text = g.SelectedRows[0].Cells[8].Value.ToString();
            }

           /*  txtMaSanPham.DataBindings.Clear();
            txtMaSanPham.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtMaSanPham.DataBindings.Add("Text", dgvListProduct.DataSource, "MaSanPham");

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtTenSanPham.DataBindings.Add("Text", dgvListProduct.DataSource, "TenSanPham");

            txtLoaiSanPham.DataBindings.Clear();
            txtLoaiSanPham.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtLoaiSanPham.DataBindings.Add("Text", dgvListProduct.DataSource, "LoaiSanPham");

            txtThoiGianBaoHanh.DataBindings.Clear();
            txtThoiGianBaoHanh.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtThoiGianBaoHanh.DataBindings.Add("Text", dgvListProduct.DataSource, "ThoiGianBaoHanh");

            txtDonGiaNhap.DataBindings.Clear();
            txtDonGiaNhap.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtDonGiaNhap.DataBindings.Add("Text", dgvListProduct.DataSource, "DonGiaNhap");

            txtDonGiaBan.DataBindings.Clear();
            txtDonGiaBan.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtDonGiaBan.DataBindings.Add("Text", dgvListProduct.DataSource, "DonGiaBan");
            
            txtDonViTinh.DataBindings.Clear();
            txtDonViTinh.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtDonViTinh.DataBindings.Add("Text", dgvListProduct.DataSource, "DonViTinh");
            
            txtGhiChu.DataBindings.Clear();
            txtGhiChu.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.Never;
            txtGhiChu.DataBindings.Add("Text", dgvListProduct.DataSource, "GhiChu"); */
        }

        #endregion

        #region Feature Function
        private void Clear()
        {
            dgvListProduct.Rows.Clear();
        }

        private void ClearTextBox()
        {
            foreach (TextBox box in _listTextBoxs)
            {
                box.Clear();
            }
            txtGhiChu.Clear();
        }
        #endregion

        #region  Button Event
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void dgListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            txtMaSanPham.Enabled = true;
            btnLuu.Enabled = true;

        }

      
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSanPham.Text.IsEmpty())


                {
                    if (_bllProduct.DeleteProduct(txtMaSanPham.Text))
                    {
                        MessageBox.Show(Constants.MsgNotificationDeletetSuccessfuly);
                        dgvListProduct.DataSource = _bllProduct.GetListProducts();
                        DgvDataBindings();
                    }
                    else
                    {
                        DisplayNotify(Constants.MsgExceptionSql, -1);
                        // MessageBox.Show(Constants.MsgExceptionSql);
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayNotify("Không thể xóa", -1);

                // if (txtMaSanPham.Text.IsEmpty())
                // {
                // if (_bllProduct.DeleteProduct(txtMaSanPham.Text))
                // {
                // MessageBox.Show(Constants.MsgNotificationDeletetSuccessfuly);
                // }
                // else
                // {
                // MessageBox.Show(Constants.MsgExceptionSql);
                // }
                // }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
			string keyselect = "";
            try
            {
                if (!CheckTextBox())
                {
                    return;
                }
                DtoProduct data = new DtoProduct(
                    txtMaSanPham.Text,
                    txtTenSanPham.Text,
                    txtLoaiSanPham.Text,
                    int.Parse(txtThoiGianBaoHanh.Text),
                    double.Parse(txtDonGiaNhap.Text),
                    double.Parse(txtDonGiaBan.Text),
                    0,
                    txtDonViTinh.Text,
                    txtGhiChu.Text);
					keyselect = data.MaSanPham;

                if (_bllProduct.EditProduct(data))
                {
                    //MessageBox.Show(Constants.MsgNotificationEditSuccessfuly);
                    DisplayNotify(Constants.MsgNotificationEditSuccessfuly, 1);
					dgvListProduct.DataSource = _bllProduct.GetListProducts();
					DgvDataBindings();
					SelectRow(dgvListProduct, keyselect);
                }
                else
                {
                    // MessageBox.Show(Constants.MsgExceptionSql);
                    DisplayNotify(Constants.MsgExceptionSql, -1);
                }
                txtMaSanPham.Enabled = false;
                //  btnLamTuoi.PerformClick();
                
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            pnlFind.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
				string keyselect = "";
                if (!CheckTextBox())
                {
                    return;
                }
                DtoProduct data = new DtoProduct(
                    txtMaSanPham.Text,
                    txtTenSanPham.Text,
                    txtLoaiSanPham.Text,
                    int.Parse(txtThoiGianBaoHanh.Text),
                    double.Parse(txtDonGiaNhap.Text),
                    double.Parse(txtDonGiaBan.Text),
                    0,
                    txtDonViTinh.Text,
                    txtGhiChu.Text);
					keyselect = data.MaSanPham;

                if (_bllProduct.AddProduct(data))
                {
                    //MessageBox.Show(Constants.MsgNotificationSuccessfuly);
                    DisplayNotify(Constants.MsgNotificationSuccessfuly, 1);
                    btnLuu.Enabled = false;
					txtMaSanPham.Enabled = false;
					//  btnLamTuoi.PerformClick();
					dgvListProduct.DataSource = _bllProduct.GetListProducts();
					DgvDataBindings();
					SelectRow(dgvListProduct, keyselect);
                }
                else
                {
                    DisplayNotify(Constants.MsgAlreadyExist, -1);
                    //MessageBox.Show(Constants.MsgAlreadyExist);
                }
                txtMaSanPham.Enabled = false;
                 
            }
            catch (Exception ex)
            {
                DisplayNotify(ex.Message, -1);
            }

        }

      

        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = _bllProduct.GetListProducts();
            DgvDataBindings();
        }
        #endregion
        
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



        #region TextBox Event
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox) == txtDonGiaNhap)
            {
                try
                {
                    txtDonGiaBan.Text = String.Format("{0:N0}",(double.Parse((sender as TextBox).Text.ToString())*1.1));
                }
                catch (FormatException ex) { }
            }
        }

        private void txtNumberic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txtDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }
		private void dgvListProduct_SelectionChanged(object sender, EventArgs e)
        {
           
             

                DgvDataBindings();



            
               
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvListProduct.DataSource = _bllProduct.GetListProducts();

                DgvDataBindings();
                InitListTextBoxs();
                ClearTextBox();
                txtMaSanPham.Enabled = true;
                btnLuu.Enabled = true;

                
                 
            }
            catch (Exception ex)
            {
                DisplayNotify("Lỗi không load được danh sách sản phẩm" + ex.Message, -1);
            }
        }
        #endregion
		public void SelectRow(DataGridView dgv, string key)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null && dgv.Rows[i].Cells[j].Value != "")
                    {
                        if (dgv.Rows[i].Cells[j].Value.ToString() == key)
                        {
                            dgv.Rows[i].Selected = true;
                            dgv.FirstDisplayedScrollingRowIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        #region Check Data

        private bool CheckTextBox()
        {
            foreach (TextBox textBox in _listTextBoxs)
            {
                if (textBox.Name == "txtGhiChu")
                {
                    break;
                }
                if (textBox.Text.IsEmpty() || textBox.Text.Length == 0)
                {
                    textBox.BackColor = Color.Red;
                    return false;
                }
                else
                {
                    textBox.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            return true;
        }





        #endregion

        private void btnFindnext_Click(object sender, EventArgs e)
        {
            indexsearch = CommonFunction.Search(dgvListProduct, txtFindText.Text, indexsearch);
        }

        private void btnCloseFind_Click(object sender, EventArgs e)
        {
            pnlFind.Enabled = false;
        }
    }
}
