using CommonLayer;
using DTO.Sales;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Sales
{
    public class ReportSalesDAL
    {

        public List<Bill> GetAllBill()
        {
            try
            {
                //DataTable dt = SqlQuery.readSQL("Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH,ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH ");
                DataTable dt = SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "Select MaHD, NgayHD, HOADON.MaKH, MaNV, TenKH,ThanhTien from HOADON join KHACHHANG on HOADON.MaKH=KHACHHANG.MaKH ").Tables[0];
                List<Bill> listBill = new List<Bill>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    List<BillDetail> detailList = this.GetBillDetail(dt.Rows[0][0].ToString());
                    Bill b = new Bill(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), int.Parse(dt.Rows[i][5].ToString().Substring(0, dt.Rows[i][5].ToString().IndexOf("."))), detailList);
                    listBill.Add(b);

                }
                return listBill;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public List<BillDetail> GetBillDetail(string billId)
        {
            try
            {
                List<BillDetail> list = new List<DTO.Sales.BillDetail>();
                //DataTable dt = SqlQuery.readSQL("select TenSanPham, CHITIETHOADON.SoLuong, DonGiaBan from CHITIETHOADON join SANPHAM on CHITIETHOADON.MaSanPham=SANPHAM.MaSanPham where MaHD='" + billId + "'");
                DataTable dt = SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text, "select TenSanPham, CHITIETHOADON.SoLuong, DonGiaBan from CHITIETHOADON join SANPHAM on CHITIETHOADON.MaSanPham=SANPHAM.MaSanPham where MaHD='" + billId + "'").Tables[0];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillDetail b = new BillDetail(billId, dt.Rows[0][0].ToString(), int.Parse(dt.Rows[0][1].ToString()), int.Parse(dt.Rows[0][2].ToString().Substring(0, dt.Rows[0][2].ToString().IndexOf("."))));
                    list.Add(b);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public List<Bill> GetBillByDate(string startDate, string endDate)
        {
            try
            {
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
