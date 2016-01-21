using CommonLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Sales;
using DTO.Sales;
using Microsoft.ApplicationBlocks.Data;

namespace DAL.Sales
{
    public class BillDAL
    {
        public BillDAL()
        {
           
        }

        //proList: Danh sách mã sản phẩm và số lượng tương ứng của một hóa đơn id= billId
        public int AddBill(Bill data, Customer c, string idcusnew)
        {
            try {
                SqlConnection con = new SqlConnection(Constants.ConnectionString);
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try {
                    Customer cc = GetCustomerByID(c.CustomerId);
                    int p0 = 1;
                    if (cc.Equals(c) == false)
                    {
                        data.CustomerId = idcusnew;
                        SqlParameter[] para0 =
                       {
                    new SqlParameter("@MaKH",idcusnew),
                    new SqlParameter("@TenKH",c.CustomerName),
                    new SqlParameter("@DiaChi",c.Address),
                    new SqlParameter("@SoDT",c.PhoneNumber),
                    new SqlParameter("@CMND",c.IdNumber),
                    new SqlParameter("@Email",""),
                    };
                        //save cus
                        // p0 = SqlQuery.writeSQL("insert into KHACHHANG VALUES (@MaKH, @TenKH, @DiaChi, @SoDT, @CMND,@Email)", para0);
                        p0 = SqlHelper.ExecuteNonQuery(tran, CommandType.Text, "insert into KHACHHANG VALUES (@MaKH, @TenKH, @DiaChi, @SoDT, @CMND,@Email)", para0);
                    }


                    SqlParameter[] para1 =
                        {
                    new SqlParameter("@MaHD",data.BillId),
                    new SqlParameter("@NgayHD",data.BillDate.ToString()),
                    new SqlParameter("@MaKH",data.CustomerId),
                    new SqlParameter("@MaNV",data.StaffId),
                    new SqlParameter("@ThanhTien",data.Sum),
                };
                    //int p1 = SqlQuery.writeSQL("insert into HOADON VALUES (@MaHD, @NgayHD, @MaKH, @MaNV, @ThanhTien)", para1);
                    int p1 = SqlHelper.ExecuteNonQuery(tran, CommandType.Text, "insert into HOADON VALUES (@MaHD, @NgayHD, @MaKH, @MaNV, @ThanhTien)", para1);
                    int p2 = 0, p3 = 0;
                    for (int i = 0; i < data.ProductList.Count; i++)
                    {
                        SqlParameter[] listpara ={
                            new SqlParameter("@MaHD", data.BillId),
                            new SqlParameter("@MaSP",data.ProductList[i].ProductId),
                            new SqlParameter("@SL", data.ProductList[i].Amount),


                             };
                        SqlParameter[] listpara11 ={
                            new SqlParameter("@MaSP",data.ProductList[i].ProductId),
                            new SqlParameter("@SL", data.ProductList[i].Amount),


                             };
                        //string aaa = "insert into CHITIETHOADON VALUES ('"+billId+"','"+proList[i].proId+"'," + proList[i].num + ")";
                        //SqlQuery.writeSQL(aaa);
                        // p2 = SqlQuery.writeSQL("insert into CHITIETHOADON VALUES (@MaHD,@MaSP,@SL)", listpara);
                        p2 = SqlHelper.ExecuteNonQuery(tran, CommandType.Text, "insert into CHITIETHOADON VALUES (@MaHD,@MaSP,@SL)", listpara);
                        //p3 = SqlQuery.writeSQL("update SANPHAM set SoLuong=SoLuong-@SL where MaSanPham=@MaSP", listpara);
                        p3 = SqlHelper.ExecuteNonQuery(tran, CommandType.Text, "update SANPHAM set SoLuong=SoLuong-@SL where MaSanPham=@MaSP", listpara11);
                    }

                    tran.Commit();

                    return p0 * p1 * p2 * p3;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi kết nối CSDL");
            }
        }
        
        public List<BillDetail> GetBillDetail(string billId)
        {
            try {
                List<BillDetail> list = new List<DTO.Sales.BillDetail>();
                //DataTable dt = SqlQuery.readSQL("select TenSanPham, CHITIETHOADON.SoLuong, DonGiaBan from CHITIETHOADON join SANPHAM on CHITIETHOADON.MaSanPham=SANPHAM.MaSanPham where MaHD='" + billId + "'");
                DataTable dt =SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select TenSanPham, CHITIETHOADON.SoLuong, DonGiaBan from CHITIETHOADON join SANPHAM on CHITIETHOADON.MaSanPham=SANPHAM.MaSanPham where MaHD='" + billId + "'").Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillDetail b = new BillDetail(billId, dt.Rows[0][0].ToString(), int.Parse(dt.Rows[0][1].ToString()), int.Parse(dt.Rows[0][2].ToString().Substring(0, dt.Rows[0][2].ToString().IndexOf("."))));
                    list.Add(b);
                }
                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            
        }
        //Lấy danh sách sản phẩm theo tên và loại
        public DataTable GetProduct(string productName, string categoryId)
        {
            try
            {
                // return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM where TenSanPham like '%" + productName + "%' and LoaiSanPham=N'" + categoryId + "'");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select MaSanPham, TenSanPham, SoLuong from SANPHAM where TenSanPham like '%" + productName + "%' and LoaiSanPham=N'" + categoryId + "'").Tables[0];

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetProduct(string categoryName)
        {
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM where LoaiSanPham=N'" + categoryName + "'");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select MaSanPham, TenSanPham, SoLuong from SANPHAM where LoaiSanPham=N'" + categoryName + "'").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable GetProductfromName(string productName)
        {
            try {
                // return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM where TenSanPham like '%"+productName+"%'");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select MaSanPham, TenSanPham, SoLuong from SANPHAM where TenSanPham like '%" + productName + "%'").Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // lấy danh sách khách hàng theo tên khách hàng và loại khách hàng 
        //public DataTable GetCustomer(string cusName)
        //{
        //   return SqlQuery.readSQL("select MaKH, TenKH from KHACHHANG where TenKH like '%"+cusName+"%'");
        //}

        // Lấy tất cả khách hàng
        public DataTable GetAllCustomer()
        {
            try {
                // return SqlQuery.readSQL("select MaKH, TenKH from KHACHHANG");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select MaKH, TenKH from KHACHHANG").Tables[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
        // Lấy tất cả sản phẩm
        public DataTable GetAllProduct()
        {
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select MaSanPham, TenSanPham, SoLuong from SANPHAM").Tables[0];
            }
            catch(Exception ex)
            { throw ex; }
        }
        //public Customer GetCustomerDetail(string cusId)
        //{
        //    DataTable dt= SqlQuery.readSQL("Select CMND, DiaChi, SoDT from KHACHHANG where MaKH='"+cusId+"'");
        //    return new Customer(cusId,"", dt.Rows[0][0].ToString(),dt.Rows[0][1].ToString(),dt.Rows[0][2].ToString());
        //}
        public DataTable GetProductPrice(string productId)
        {
            //return SqlQuery.readSQL("Select DonGiaBan from SANPHAM where MaSanPham='" + productId + "'");
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "Select DonGiaBan from SANPHAM where MaSanPham='" + productId + "'").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataTable GetCategoryList()
        {
            //return SqlQuery.readSQL("select distinct LoaiSanPham from SANPHAM");
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select distinct LoaiSanPham from SANPHAM").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        // lấy quy định về thuế suất
        public DataTable GetRule(string rule)
        {
            //return SqlQuery.readSQL("select GiaTri from THAMSO where TenTS= N'"+rule+"'");
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select GiaTri from THAMSO where TenTS= N'" + rule + "'").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        // Lấy mã hóa đơn cuối cùng
        public DataTable GetLastBillId()
        {
            // return SqlQuery.readSQL("select top 1 MaHD from HOADON order by MaHD desc");
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select top 1 MaHD from HOADON order by MaHD desc").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        // lấy mã khách hàng cuối cùng
        public DataTable GetLastCustomerId()
        {
            //return SqlQuery.readSQL("select COUNT(*) from KHACHHANG ");
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select COUNT(*) from KHACHHANG ").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        //lấy tất cả hóa đơn
        public List<Bill> GetAllBill()
        {
            try {
                //DataTable dt = SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH,ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH ");
                DataTable dt =  SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH,ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH ").Tables[0];
                List<Bill> listBill = new List<Bill>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
                    Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
                    listBill.Add(b);

                }
                return listBill;
            }
            catch(Exception ex)
            { throw ex; }
        }
        // Lấy danh sách các hóa đơn từ ngày đến ngày
        public List<Bill> GetBillByDate(string startDate, string endDate)
        {
            try {
                //DataTable dt = SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where NgayHD between '" + startDate + "' and '" + endDate + "'");
                DataTable dt = SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where NgayHD between '" + startDate + "' and '" + endDate + "'").Tables[0];
                List<Bill> listBill = new List<Bill>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
                    Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
                    listBill.Add(b);

                }
                return listBill;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        // Lấy danh sách hóa đơn theo Tên Hàng
        //public List<Bill> GetBillByProductName(string productName)
        //{
        //    DataTable dt=SqlQuery.readSQL("Select HOADON.MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH join CHITIETHOADON on HOADON.MaHD= CHITIETHOADON.MaHD join SANPHAM on CHITIETHOADON.MaSanPham=SANPHAM.MaSanPham where TenSanPham like '%"+productName+"%'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        //// Lấy danh sách hóa đơn  Mã nhân viên 
        //public List<Bill> GetBillByStaffId(string staffId)
        //{
        //    DataTable dt= SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where MaNV like '%"+staffId+"%'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        //// Lấy danh sách hóa đơn  Mã khách hàng
        //public List<Bill> GetBillByCustomerId(string customerId)
        //{
        //    DataTable dt= SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where KHACHHANG.MaKH like '%" + customerId + "%'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        //// Lấy danh sách hóa đơn theo Tên khách hàng
        //public List<Bill> GetBillByCustomerName(string customerName)
        //{
        //    DataTable dt= SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where TenKH like '%"+customerName+"%'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        //// Lấy danh sách hóa đơn theo Tên Hàng và ngày hóa đơn
        //public List<Bill> GetBillByProductName(string productName, string startDate, string endDate)
        //{
        //    DataTable dt=SqlQuery.readSQL("Select HOADON.MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH join CHITIETHOADON on HOADON.MaHD= CHITIETHOADON.MaHD join SANPHAM on CHITIETHOADON.MaSanPham=SANPHAM.MaSanPham where TenSanPham like '%" + productName + "%' and NgayHD between '" + startDate + "' and '" + endDate + "'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        //// Lấy danh sách hóa đơn theo Mã nhân viên  và ngày hóa đơn
        //public List<Bill> GetBillByStaffId(string staffId, string startDate, string endDate)
        //{
        //    DataTable dt= SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH,MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where MaNV like '%" + staffId + "%' and NgayHD between '" + startDate + "' and '" + endDate + "'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        
        //// Lấy danh sách hóa đơn theo Mã khách hàng và ngày hóa đơn
        //public List<Bill> GetBillByCustomerId(string customerId, string startDate, string endDate)
        //{
        //    DataTable dt= SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where KHACHHANG.MaKH like '%" + customerId + "%' and NgayHD between '" + startDate + "' and '" + endDate + "'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        
        //// Lấy danh sách hóa đơn theo Tên khách hàng và ngày hóa đơn
        //public List<Bill> GetBillByCustomerName(string customerName, string startDate, string endDate)
        //{
        //    DataTable dt = SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH, ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH where TenKH like '%" + customerName + "%' and NgayHD between '" + startDate + "' and '" + endDate + "'");
        //    List<Bill> listBill = new List<Bill>();
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
        //        Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
        //        listBill.Add(b);

        //    }
        //    return listBill;
        //}
        //public DataTable GetIncomeByMonth(string dateFrom, string dateTo)
        //{
        //    SqlParameter[] listpara = { new SqlParameter("@dateFrom", dateFrom), new SqlParameter("@dateTo", dateTo) };
        //    return SqlQuery.readProcedure("GetIncomeByDate", listpara);
        //}
        //public DataTable GetIncomeByYear(int yearFrom, int yearTo)
        //{
        //    SqlParameter[] listpara = { new SqlParameter("@yearFrom", yearFrom), new SqlParameter("@yearTo", yearTo) };
        //    return SqlQuery.readProcedure("GetIncomeByYear", listpara);
        //}
        public DataTable GetSumProductByID(string ProductID)
        {

            //DataTable dt = SqlQuery.readSQL("select SoLuong from   SANPHAM   where SANPHAM.MaSanPham='" + ProductID + "'");
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select SoLuong from   SANPHAM   where SANPHAM.MaSanPham='" + ProductID + "'").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }

        }
        public DataTable GetAllPhone()
        {

            //DataTable dt = SqlQuery.readSQL("select SoDT from  KHACHHANG");
            
            try
            {
                //return SqlQuery.readSQL("select MaSanPham, TenSanPham, SoLuong from SANPHAM");
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select SoDT from  KHACHHANG").Tables[0];
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Customer GetCustomerByPhone(string phone)
        {

            try {
                Customer c = new Customer();
                //DataTable d = SqlQuery.readSQL("select* from KHACHHANG where SoDT='" + phone + "'");
                DataTable d = SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select* from KHACHHANG where SoDT='" + phone + "'").Tables[0];
                if (d.Rows.Count > 0)
                {
                    c = new Customer(d.Rows[0].ItemArray[0].ToString(), d.Rows[0].ItemArray[1].ToString(), d.Rows[0].ItemArray[4].ToString(), d.Rows[0].ItemArray[2].ToString(), d.Rows[0].ItemArray[3].ToString());
                }
                return c;
            }catch(Exception ex) { throw ex; };
        }

        public Customer GetCustomerByID(string id)
        {
            try
            {
                Customer c = new Customer();
                //DataTable d = SqlQuery.readSQL("select* from KHACHHANG where MaKH='" + id + "'");
                DataTable d = SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select* from KHACHHANG where MaKH='" + id + "'").Tables[0];
                if (d.Rows.Count > 0)
                {
                    c = new Customer(d.Rows[0].ItemArray[0].ToString(), d.Rows[0].ItemArray[1].ToString(), d.Rows[0].ItemArray[4].ToString(), d.Rows[0].ItemArray[2].ToString(), d.Rows[0].ItemArray[3].ToString());
                }
                return c;
            }catch(Exception ex) { throw ex; }
        }

    }
}
