using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using CommonLayer;
using System.Data;

namespace DAL.Guarantee
{
    public class DalChiTietPhieuTiepNhanBaoHanh
    {
        public int AddChiTietPhieuTiepNhanBaoHanh(DtoChiTietPhieuTiepNhanBaoHanh dtoCTPTNBH)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@MaCTPTNBH", dtoCTPTNBH.MaCTPTNBH),
                    new SqlParameter("@MaHoaDon", dtoCTPTNBH.MaHoaDon),
                    new SqlParameter("@MaSanPham", dtoCTPTNBH.MaSanPham),
                    new SqlParameter("@MoTaLoi", dtoCTPTNBH.MoTaLoi),
                    new SqlParameter("@SoLuong", dtoCTPTNBH.SoLuong),
                    new SqlParameter("@MaPTNBH", dtoCTPTNBH.MaPTNBH),
                };
                return SqlHelper.ExecuteNonQuery(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "sp_InsertCTPTNBH", para);

            }
            catch (SqlException)
            {
                throw new ArgumentException(Constants.MsgExceptionSql);
            }
            catch (Exception)
            {
                throw new AggregateException(Constants.MsgExceptionError);
            }
        }

        public DataTable GetAllCTPTNBH(string maPTNBH)
        {
            return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                CommandType.StoredProcedure,
                "sp_GetAllCTPTNBH", new SqlParameter("@MaPTNBH", maPTNBH)).Tables[0];
        }

        public object GetDetailWarrantyBillByBillID(string id, string productID)
        {
            try
            {
                var querry = "select sum(SoLuong) from CHITIETPHIEUTIEPNHANBAOHANH where MaHoaDon=@id and MaSanPham=@productID";
                SqlParameter[] para =
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@productID", productID),
                };
                return SqlHelper.ExecuteScalar(Constants.ConnectionString, CommandType.Text, querry,
                    para);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu.");
            }
            catch (Exception)
            {
                throw new Exception("Lỗi không xác định.");
            }
        }


    }
}

