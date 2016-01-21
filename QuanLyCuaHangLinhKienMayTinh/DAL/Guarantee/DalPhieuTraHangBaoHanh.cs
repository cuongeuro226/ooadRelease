using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using CommonLayer;
using System.Data;
using DTO;

namespace DAL.Guarantee
{
    public class DalPhieuTraHangBaoHanh
    {
        public int AddPhieuTraHangBaoHanh(DtoPhieuTraHangBaoHanh dtoPTHBH, List<DtoChiTietPhieuTraHangBaoHanh> listCTPTHBH)
        {
            try
            {

                SqlConnection con = new SqlConnection(Constants.ConnectionString);
                con.Open();
                SqlTransaction tran = con.BeginTransaction();
                try
                {
                    SqlParameter[] para =
                    {
                    new SqlParameter("@MaPTHBH", dtoPTHBH.MaPTHBH),
                    new SqlParameter("@MaNV", dtoPTHBH.MaNV),
                    new SqlParameter("@MaPTNBH", dtoPTHBH.MaPTNBH),
                    new SqlParameter("@NgayLap", dtoPTHBH.NgayLap),
                };

                    SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "sp_InsertPTHBH", para);

                    foreach (DtoChiTietPhieuTraHangBaoHanh dtoCTPTHBH in listCTPTHBH)
                    {
                        SqlParameter[] para1 =
                        {
                        new SqlParameter("@MaPTHBH", dtoCTPTHBH.MaPTHBH),
                        new SqlParameter("@MaSanPham", dtoCTPTHBH.MaSanPham),
                        new SqlParameter("@MoTaLoi", dtoCTPTHBH.MoTaLoi),
                        new SqlParameter("@SoLuong", dtoCTPTHBH.SoLuong),
                        new SqlParameter("@GhiChu", dtoCTPTHBH.GhiChu),
                    };
                        SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "sp_InsertCTPTHBH", para1);
                    }

                    tran.Commit();

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    ex.ToString();
                    return 0;
                }

            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 1;
        }

        public DataTable GetAllPTHBHByMaPTNBH(string maPTNBH)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "sp_GetAllPTHBHByMaPTNBH", new SqlParameter("@MaPTNBH", maPTNBH)).Tables[0];
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetMaPTNBH()
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.StoredProcedure, "sp_GetMaPTNBH").Tables[0];
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int IsReturnProductWarranty(string id)
        {
            try
            {
                DataTable dt = SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.Text,
                    "select * from PHIEUTRAHANGBAOHANH where MaPTNBH=@ID", new SqlParameter("@ID", id)).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    return 1;
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }

        public object GetCountMaPTHBH()
        {
            try
            {
                return SqlHelper.ExecuteScalar(Constants.ConnectionString, CommandType.Text, "select count(MaPTHBH) from PHIEUTRAHANGBAOHANH");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetQuanlity(string id, string productID)
        {
            try
            {
                SqlParameter[] para = {
                new SqlParameter("@ID", id),
                new SqlParameter("@MaSanPham", productID)
                };
                return SqlHelper.ExecuteScalar(Constants.ConnectionString, CommandType.Text, @"select sum(CHITIETPHIEUTRAHANGBAOHANH.SoLuong) from 
(CHITIETPHIEUTRAHANGBAOHANH inner join PHIEUTRAHANGBAOHANH on CHITIETPHIEUTRAHANGBAOHANH.MaPTHBH = PHIEUTRAHANGBAOHANH.MaPTHBH)
where PHIEUTRAHANGBAOHANH.MaPTNBH = @ID and CHITIETPHIEUTRAHANGBAOHANH.MaSanPham = @MaSanPham", para);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 0;
        }
    }
}
