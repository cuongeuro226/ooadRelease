using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Warehouse;
using DTO.Sales;
using DAL.Sales;
using System.Data;
using CommonLayer;
//chức năng add bill làm từ chủ nhật ngày 14/12
namespace BLL.Sales
{
    public class AddBillBLL
    {
        
        BillDAL dal= new BillDAL();
        DataTable customerList;
        public AddBillBLL()
        {
            try {
                customerList = dal.GetAllCustomer();
            }
            catch (Exception ex) { throw ex; }
        }
        public DataTable GetAllProduct()
        {
            try
            { 
            return dal.GetAllProduct();
            }
            catch (Exception ex) { throw ex; }
        }
        public int SaveBill(Customer c, string staffId, int sum, List<BillDetail>proList)
        {
            try {
                string now = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
                string lastBillId = dal.GetLastBillId().Rows.Count == 0 ? "" : dal.GetLastBillId().Rows[0][0].ToString();



                Bill b = new Bill(AddBillBLL.NextId("HD", lastBillId), now, c.CustomerId, staffId, "aaa", sum, proList);
                return dal.AddBill(b, c, "KH" + GetLastCustomer());
            }
            catch (Exception ex) { throw ex; }
        }
        public String GetProductPrice(string productId)
        {
            try {
                return dal.GetProductPrice(productId).Rows[0][0].ToString();
            }
            catch (Exception ex) { throw ex; }
        }
        public static string NextId(string reStr, string id)
        {
           
            if (id == "")
            {
                return reStr+"000001";
            }
            int len = id.Length;
            int subLen = reStr.Length;
            string str = id.Substring(subLen, len - subLen);
            int nextNum = int.Parse(str) + 1;
            string num = nextNum.ToString();
            while (num.Length < 6)
            {
                num = "0"+num;
            }
            return reStr + num;
        }
        public DataTable GetProductCategory()
        {
            try
            {
                return dal.GetCategoryList();
            }
            catch (Exception ex) { throw ex; }
        }
        public DataTable GetProduct(string category)
        {
            try {
                return dal.GetProduct(category); }
            catch (Exception ex) { throw ex; }
        }
        public DataTable GetProduct(string category, string productName)
        {
            try {
                return dal.GetProduct(productName, category);
            }
            catch (Exception ex) { throw ex; }
        }
        public DataTable GetProductfromName(string productName)
        {
            try {
                return dal.GetProductfromName(productName);
            }
            catch (Exception ex) { throw ex; }
        }
        public int GetTax()
        {
            try {
                return int.Parse(dal.GetRule("Thuế suất").Rows[0][0].ToString());
            }
            catch (Exception ex) { throw ex; }
        }
        public int GetLastCustomer()
        {
            try {
                return (int.Parse(dal.GetLastCustomerId().Rows[0][0].ToString()) + 1);
            }
            catch (Exception ex) { throw ex; }
        }
        public DataTable GetBillDetail(string billId)
        {
            try {
                List<BillDetail> productList = dal.GetBillDetail(billId);
                DataTable dt = new DataTable();
                dt.Columns.Add("TenSanPham");
                dt.Columns.Add("SoLuong");
                dt.Columns.Add("DonGiaBan");
                dt.Columns.Add("ThanhTien");
                foreach (BillDetail b in productList)
                {
                    int toCash = b.Amount * b.Price;
                    dt.Rows.Add(new string[] { b.ProductName, b.Amount.ToString(), b.Price.ToString(), toCash.ToString() });
                }
                return dt;
            }
            catch (Exception ex) { throw ex; }
        }
        public string GetSumProductByID(string ProductID)
        {
            try
            {
                DataTable d = dal.GetSumProductByID(ProductID);
                if (d.Rows.Count > 0)
                {
                    return d.Rows[0].ItemArray[0].ToString();
                }
                return "0";
            }
            catch (Exception ex) { throw ex; }
        }
        public List<string>  GetAllPhone()
        {
            try
            {
                List<string> data = new List<string>();
                DataTable d = dal.GetAllPhone();
                foreach (DataRow r in d.Rows)
                {
                    data.Add(r.ItemArray[0].ToString());
                }
                return data;
            }
            catch (Exception ex) { throw ex; }
        }
        public Customer GetCustomerByPhone(string phone)
        {
            try {
                return dal.GetCustomerByPhone(phone);
            }
            catch (Exception ex) { throw ex; }
        }



        #region comment
        //public DataTable GetAllCustomer()
        //{
        //    return dal.GetAllCustomer();
        //}
        //public DataTable SearchProduct (string productName, string category)
        //{
        //    return dal.GetProduct (productName,category);
        //}
        //public DataTable SearchCustomer(string customerName)
        //{
        //    return dal.GetCustomer(customerName);

        //}
        //public Customer GetCustomerDetail(string cusId)
        //{
        //    return dal.GetCustomerDetail(cusId);
        //}
        //public DataTable GetBillToday(string staffId)
        //{
        //    string today = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
        //    List<Bill> billList = dal.GetBillToday(today, staffId);
        //    DataTable dt= new DataTable();
        //    // MaHD, NgayHD, HOADON.MaKH, TenKH, ThanhTien
        //    DataColumn col = dt.Columns.Add("stt", System.Type.GetType("System.Int16"));
        //    col.SetOrdinal(0);
        //    dt.Columns.Add("NgayHD");
        //    dt.Columns.Add("MaKH");
        //    dt.Columns.Add("TenKH");
        //    dt.Columns.Add("MaHD");
        //    dt.Columns.Add("ThanhTien");
        //    int i = 1;
        //    foreach (Bill b in billList)
        //    {
        //        dt.Rows.Add(new string[] {i.ToString(),b.BillDate,b.CustomerId, b.CustomerName, b.BillId, b.Sum.ToString() });
        //        i++;
        //    }
        //    return dt;
        //}
        #endregion
    }
}
