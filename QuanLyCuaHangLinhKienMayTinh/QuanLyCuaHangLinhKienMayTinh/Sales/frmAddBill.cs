using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Sales;
using CommonLayer;
using DTO.Sales;
namespace QuanLyCuaHangLinhKienMayTinh.Sales
{
    public partial class frmAddBill : Form
    {
        List<string> listPhone = new List<string>();
        String MaNV = "NV1";
        AddBillBLL bll= new AddBillBLL();
        string productId= "";
        string productName="";
        // tổng giấ trị hóa đơn
        int sumMoney = 0;

        #region init
        public frmAddBill()
        {
            InitializeComponent();
        }
        public frmAddBill(string manv)
        {
            MaNV = manv;
            InitializeComponent();
        }
        public void frmAddBill_Load(object sender, EventArgs e)
        {
            loadWhenInit();

        }
        public void loadWhenInit()
        {
            // load san pham
            try
            {
                dgvProduct.DataSource = bll.GetAllProduct();
            }
            catch (Exception ex) { DisplayNotify("không load được danh sách sản phẩm, mã lỗi:" + ex.Message, -1);
                return;
            }
            // load nhom san pham
            try
            {
                LoadProductCategory();
            }
            catch (Exception ex) { DisplayNotify("không load được danh sách loại sản phẩm, mã lỗi:" + ex.Message, -1);
                return;
            }
            // load thue suat
            try
            {
                txtTaxPercent.Text = bll.GetTax().ToString() + "%";
            }
            catch (Exception ex) { DisplayNotify("không load thuế suất, mã lỗi:" + ex.Message, -1);return; }
            lbStatus.Text = "";
            //clean dgv
             
            dgvProduct.ClearSelection();
            //
            addDataAutoIDcard();

        }
        public void addDataAutoIDcard()
        {
            // get phone
            try
            {
                listPhone = bll.GetAllPhone();
            }
            catch (Exception ex) { DisplayNotify("Khoong thể load danh sách khách hàng, mã lỗi" + ex.Message, -1);return; }
            txtPhoneNumber.AutoCompleteCustomSource.AddRange(listPhone.ToArray());
            
        }

        public void LoadProductCategory()
        {
            cbProductType.Items.Add("Tất cả");
            try
            {
                DataTable dt = bll.GetProductCategory();

                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    cbProductType.Items.Add(dt.Rows[i][0]);
                }
            }
            catch (Exception ex) { throw ex; };
            cbProductType.SelectedIndex = 0;
        }

        #endregion
       
        //Khi nhấn tên khách hàng, hệ thống load dữ liệu lên panel bên phải
        
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==-1) return;
            this.productId = dgvProduct[0,e.RowIndex].Value.ToString();
            this.productName = dgvProduct[1, e.RowIndex].Value.ToString();
            try {
                string price = bll.GetProductPrice(productId);
                txtPrice.Text = price.Substring(0, price.IndexOf("."));
            }
            catch (Exception ex) { DisplayNotify("không load được giá sản phẩm, mã lỗi:" + ex.Message, -1); }
            
            
           
        }
        // Nhấn nút Ghi
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (productId == "")
            {
               
                DisplayNotify("Bạn chưa chọn sản phẩm nào!", -1);
                return;
            }
            if (nUdAmount.Value <= 0)
            {
                 
                DisplayNotify("Bạn phải nhập số lượng là số dương ", -1);
                return;
  
            }
            if (txtPrice.Text.Trim().Length == 0)
            {
                DisplayNotify("Bạn chưa chọn sản phẩm nào!", -1);
                return;
            }

            else
            {
                try
                {
                    if (int.Parse(bll.GetSumProductByID(productId)) == 0)
                    {
                        DisplayNotify("hàng hóa đã hết", -1);
                        return;
                    }
                    // check so luong
                    if (int.Parse(bll.GetSumProductByID(productId)) < int.Parse(nUdAmount.Value.ToString()))
                    {
                        DisplayNotify("số lượng hàng của sản phẩm bạn chọn hiện không đủ, bạn chọn nhỏ hơn " + int.Parse(bll.GetSumProductByID(productId)), -1);
                        return;
                    }
                }
                catch (Exception ex) { DisplayNotify("Lỗi không ghi được xuống CSDL, mã lỗi: " + ex.Message,-1); }
            }
            foreach (DataGridViewRow r in dgvProductAdded.Rows)
            {

                if (r.Cells[0].Value.ToString() == productId)
                {
                    try
                    {
                        // check so luong
                        if (int.Parse(bll.GetSumProductByID(productId)) < int.Parse(r.Cells[2].Value.ToString()) + nUdAmount.Value)
                        {DisplayNotify("số lượng hàng của sản phẩm bạn chọn hiện không đủ, bạn chọn nhỏ hơn " + int.Parse(bll.GetSumProductByID(productId)), -1);
                            return;
                        }
                        //
                        r.Cells[2].Value = int.Parse(r.Cells[2].Value.ToString()) + nUdAmount.Value;
                        r.Cells[4].Value = rule.parrtToMonney((int.Parse(rule.partToInt(r.Cells[3].Value.ToString()))* int.Parse(r.Cells[2].Value.ToString())).ToString());
                        r.Cells[3].Value = rule.parrtToMonney(r.Cells[3].Value.ToString());
                        sumMoney += int.Parse(txtPrice.Text) * (int)nUdAmount.Value;
                        sumMoney += int.Parse(txtPrice.Text) * (int)nUdAmount.Value;
                        sumMoney += int.Parse(txtPrice.Text) * (int)nUdAmount.Value;
                        txtTaxMoney.Text =rule.parrtToMonney( (sumMoney * 0.1).ToString());
                        txtSumMoney.Text =rule.parrtToMonney( sumMoney.ToString());
                        return;
                    }
                    catch(Exception ex)
                    {
                        DisplayNotify("Lỗi không lưu được xuống csdl, mã lỗi: " + ex.Message,-1);
                    }
                   
                }
            }

            try {
                int productPrice = int.Parse(txtPrice.Text);
                object[] row = new object[] { productId, productName, nUdAmount.Value.ToString(), productPrice.ToString(), (productPrice * nUdAmount.Value).ToString() };
                row[2] = int.Parse(row[2].ToString()) ;
                row[4] = rule.parrtToMonney((int.Parse(rule.partToInt(row[3].ToString())) * int.Parse(row[2].ToString())).ToString());
                row[3] = rule.parrtToMonney(row[3].ToString());
                dgvProductAdded.Rows.Add(row);
                sumMoney += productPrice * (int)nUdAmount.Value;
                txtTaxMoney.Text = rule.parrtToMonney((sumMoney * 0.1).ToString());
                txtSumMoney.Text =rule.parrtToMonney( sumMoney.ToString());
            }
            catch(Exception ex)
            {

                DisplayNotify("Lỗi trong quá trình ghi thêm sản phẩm, mã lỗi: " + ex.Message, -1);
            }
        }

        private void dgvProductAdded_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow r = dgvProductAdded.Rows[e.RowIndex];// (DataGridViewRow)sender;
            if (e.ColumnIndex == 5)
            {
                
                sumMoney -= int.Parse(rule.partToInt( r.Cells[3].Value.ToString())) * int.Parse(r.Cells[2].Value.ToString());
                txtTaxMoney.Text =rule.parrtToMonney( (sumMoney * 0.1).ToString());
                txtSumMoney.Text = sumMoney.ToString();
                dgvProductAdded.Rows.RemoveAt(e.RowIndex);
            }

        }
 
        // sự kiện chọn xong combobox 
        private void cbProductType_SelectedValueChanged(object sender, EventArgs e)
        {
            try {
                //MessageBox.Show("commit now!");
                //th1: không nhập tên sp, chọn loại là tất cả
                if (txtSearchProductName.Text == "" && cbProductType.Text == "Tất cả")
                {
                    dgvProduct.DataSource = bll.GetAllProduct();
                }
                // TH2: không nhập tên sp, có chọn tên loại 
                else if (txtSearchProductName.Text == "")
                {
                    dgvProduct.DataSource = bll.GetProduct(cbProductType.Text);
                }
                // TH3: có nhập tên sản phẩm, chọn loại là tất cả
                else if (cbProductType.Text == "Tất cả")
                {
                    dgvProduct.DataSource = bll.GetProductfromName(txtSearchProductName.Text);
                }
                // TH4: có nhập tên sản phẩm chọn loại sp xác định
                else
                {
                    dgvProduct.DataSource = bll.GetProduct(cbProductType.Text, txtSearchProductName.Text);
                }
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi lọc dữ liệu , mã lỗi"+ex.Message,-1);
            }
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // TH3: có nhập tên sản phẩm, chọn loại là tất cả
                if (cbProductType.Text == "Tất cả")
                {
                    dgvProduct.DataSource = bll.GetProductfromName(txtSearchProductName.Text);
                }
                // TH4: có nhập tên sản phẩm chọn loại sp xác định
                else
                {
                    dgvProduct.DataSource = bll.GetProduct(cbProductType.Text, txtSearchProductName.Text);
                }
            }
            catch(Exception ex)
            {
                DisplayNotify("Lỗi load dữ liệu tìm kiếm, mã lỗi" + ex.Message, -1);
            }
        }
        // Thêm hóa đơn
        private void btnSave_Click(object sender, EventArgs e)
        {


            Customer c = new Customer(txtCustomerId.Text, txtCustomerName.Text, txtIdCardNumber.Text, txtAddress.Text, txtPhoneNumber.Text);
            
            List<BillDetail> proList = new List<BillDetail>();
            foreach(DataGridViewRow row in dgvProductAdded.Rows)
            {
                BillDetail bp= new BillDetail(row.Cells[0].Value.ToString(),"",int.Parse(row.Cells[2].Value.ToString()),0);
                proList.Add(bp);
            }

            if (checkBeforeSave(proList) == false)
                return;

             

            try
            {
                bll.SaveBill(c, MaNV, int.Parse(rule.partToInt( txtSumMoney.Text)), proList);
                //
                DisplayNotify("Lưu thành công", 1);
               
            }
            catch (Exception ex)
            {
                
                DisplayNotify("Bị lỗi trong quá trình lưu dữ liệu" + ex.Message, -1);return;
            }

             
                try
                {
                    dgvProduct.DataSource = bll.GetAllProduct();
                    cleanDataInForm();
                    loadWhenInit();
                }
                catch (Exception ex) { DisplayNotify("Bị lỗi trong quá trình load lại danh sách san phẩm" + ex.Message, -1); }
            



        }

        

        public void cleanDataInForm()
        {
            txtCustomerName.Text = "";
            txtCustomerId.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtIdCardNumber.Text = "";
            txtPrice.Text = "";
            dgvProductAdded.Rows.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanDataInForm();
            

        }

        #region check data before save
        public bool checkBeforeSave(List<BillDetail> p)
        {
            if( p.Count<=0)
            {
                DisplayNotify("Nhập hàng hóa nào đó để tạo hóa đơn, hóa đơn không thể không có hàng hóa!",-1);
                return false;
            }
            if(txtCustomerName.Text.Trim().Length<=0)
            {
                DisplayNotify("Nhập tên khách hàng ...!", -1);
                return false;
            }
            if (txtPhoneNumber.Text.Trim().Length <= 0)
            {
                DisplayNotify("Nhập số điện thoại  khách hàng ...!", -1);
                return false;
            }
            if (rule.CheckPhone( txtPhoneNumber.Text.Trim())==false)
            {
                DisplayNotify("Nhập số điện thoại đúng kiểu (vd: 0987654115) ...!", -1);
                return false;
            }
            if (txtIdCardNumber.Text.Trim().Length <= 0)
            {
                DisplayNotify("Nhập CMND khách hàng ...!", -1);
                return false;
            }
            if (rule.CheckNumberID( txtIdCardNumber.Text.Trim())==false)
            {
                DisplayNotify("Nhập CMND đúng kiểu (vd: 205886233) ...!", -1);
                return false;
            }
            if (txtAddress.Text.Trim().Length <= 0)
            {
                DisplayNotify("Nhập đại chỉ khách hàng ...!", -1);
                return false;
            }
            return true;
        }


        #endregion


        #region Notify
        public void ResetNotify()
        {
            lblNotify.Text = "";
            lblNotify.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(45)))));
        }
        //1 ss// -1 error
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

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if(listPhone.Contains(txtPhoneNumber.Text)== true)
            {
                // get info custummer
                Customer c =  bll.GetCustomerByPhone(txtPhoneNumber.Text);
                changeTextByPhone(c.CustomerId,c.CustomerName, c.IdNumber, c.Address);

            }
            else
            {
                changeTextByPhone("","", "", "");
            }

            // get info custummer
        }

        public void changeTextByPhone(string id, string name, string idcard, string adress)
        {
            txtCustomerId.Text = id;
            txtCustomerName.Text = name;
            txtIdCardNumber.Text = idcard;
            //txtPhoneNumber.Text = adress;
            txtAddress.Text = adress;
            //txtCustomerId.Text = cellMaKH.Value.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadWhenInit();
        }

        private void txtDouble_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
