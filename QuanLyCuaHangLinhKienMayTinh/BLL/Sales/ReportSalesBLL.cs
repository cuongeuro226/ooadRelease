using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Sales;
using System.Data;
using DTO.Sales;

namespace BLL.Sales
{
    public class ReportSalesBLL
    {
        BillDAL dal = new BillDAL();
        AddBillBLL addBillBLL = new AddBillBLL();
        public List<Bill> GetAllBill(){
            try
            {
                return dal.GetAllBill();
            }
            catch (Exception ex) { throw ex; }
        }
        public DataTable GetBillDetail(string billId){
            try
            {
                return addBillBLL.GetBillDetail(billId);
            }
            catch (Exception ex) { throw ex; }
        }
        //Lay danh sach bill theo ngay
        public List<Bill> GetBillByDate(DateTime startDate, DateTime endDate)
        {
            try
            { 
            string startDateStr = startDate.ToString("yyyy-MM-dd 00:00:00");
            string endDateStr = endDate.ToString("yyy-MM-dd 00:00:00");
            return dal.GetBillByDate(startDateStr, endDateStr);
            }
            catch (Exception ex) { throw ex; }
        }
        //Lấy danh sách hóa đơn theo Tên Hàng

        #region comment
        //public List<Bill> GetBillByProductName(string productName)
        //{
        //    try
        //    {
        //        return dal.GetBillByProductName(productName);
        //    }
        //    catch (Exception ex) { throw ex; }

        //}
        //// Lấy danh sách hóa đơn  Mã nhân viên 
        //public List<Bill> GetBillByStaffId(string staffId)
        //{
        //    return dal.GetBillByStaffId(staffId);
        //}
        //// Lấy danh sách hóa đơn  Mã khách hàng
        //public List<Bill> GetBillByCustomerId(string customerId)
        //{
        //    return dal.GetBillByCustomerId(customerId);
        //}
        //// Lấy danh sách hóa đơn  Tên khách hàng
        //public List<Bill> GetBillByCustomerName(string customerName)
        //{
        //    return dal.GetBillByCustomerName(customerName);
        //}
        //// Lấy danh sách hóa đơn theo Tên Hàng và ngày hóa đơn
        //public List<Bill> GetBillByProductName(string productName, DateTime startDate, DateTime endDate)
        //{
        //    string startDateStr = startDate.ToString("yyyy-MM-dd 00:00:00");
        //    string endDateStr = endDate.ToString("yyy-MM-dd 00:00:00");
        //    return dal.GetBillByProductName(productName, startDateStr, endDateStr);
        //}
        //// Lấy danh sách hóa đơn  Mã nhân viên  và ngày hóa đơn
        //public List<Bill> GetBillByStaffId(string staffId, DateTime startDate, DateTime endDate)
        //{
        //    string startDateStr = startDate.ToString("yyyy-MM-dd 00:00:00");
        //    string endDateStr = endDate.ToString("yyy-MM-dd 00:00:00");
        //    return dal.GetBillByProductName(staffId, startDateStr, endDateStr);
        //}

        //// Lấy danh sách hóa đơn  Mã khách hàng và ngày hóa đơn
        //public List<Bill> GetBillByCustomerId(string customerId, DateTime startDate, DateTime endDate)
        //{
        //    string startDateStr = startDate.ToString("yyyy-MM-dd 00:00:00");
        //    string endDateStr = endDate.ToString("yyy-MM-dd 00:00:00");
        //    return dal.GetBillByCustomerId(customerId, startDateStr, endDateStr);
        //}

        //// Lấy danh sách hóa đơn  Tên khách hàng và ngày hóa đơn
        //public List<Bill> GetBillByCustomerName(string customerName, DateTime startDate, DateTime endDate)
        //{
        //    string startDateStr = startDate.ToString("yyyy-MM-dd 00:00:00");
        //    string endDateStr = endDate.ToString("yyy-MM-dd 00:00:00");
        //    return dal.GetBillByCustomerName(customerName, startDateStr, endDateStr);
        //}
        #endregion
    }
}