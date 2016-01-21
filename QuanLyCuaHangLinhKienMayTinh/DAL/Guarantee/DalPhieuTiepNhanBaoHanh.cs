using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Warehouse;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using CommonLayer;
using System.Data;

namespace DAL.Guarantee
{
    public class DalPhieuTiepNhanBaoHanh
    {
        //public int AddPhieuTiepNhanBaoHanh(DtoPhieuTiepNhanBaoHanh dtoPTNBH)
        //{
        //    try
        //    {
        //        SqlParameter[] para =
        //        {
        //            new SqlParameter("@MaPTNBH", dtoPTNBH.MaPTNBH),
        //            new SqlParameter("@MaNV", dtoPTNBH.MaNV),
        //            new SqlParameter("@NgayLap", dtoPTNBH.NgayLap),
        //        };
        //        return SqlHelper.ExecuteNonQuery(Constants.ConnectionString,
        //            CommandType.StoredProcedure,
        //            "sp_InsertPTNBH", para);

        //    }
        //    catch (SqlException)
        //    {
        //        throw new ArgumentException(Constants.MsgExceptionSql);
        //    }
        //    catch (Exception)
        //    {
        //        throw new AggregateException(Constants.MsgExceptionError);
        //    }
        //}

        public int AddPhieuTiepNhanBaoHanh(DtoPhieuTiepNhanBaoHanh dtoPTNBH, List<DtoChiTietPhieuTiepNhanBaoHanh> listCTPTNBH)
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
                    new SqlParameter("@MaPTNBH", dtoPTNBH.MaPTNBH),
                    new SqlParameter("@MaNV", dtoPTNBH.MaNV),
                    new SqlParameter("@NgayLap", dtoPTNBH.NgayLap),
                };

                    SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "sp_InsertPTNBH", para);

                    foreach (DtoChiTietPhieuTiepNhanBaoHanh dtoCTPTNBH in listCTPTNBH)
                    {
                        SqlParameter[] para1 =
                        {
                        //new SqlParameter("@MaCTPTNBH", dtoCTPTNBH.MaCTPTNBH),
                        new SqlParameter("@MaHoaDon", dtoCTPTNBH.MaHoaDon),
                        new SqlParameter("@MaSanPham", dtoCTPTNBH.MaSanPham),
                        new SqlParameter("@MoTaLoi", dtoCTPTNBH.MoTaLoi),
                        new SqlParameter("@SoLuong", dtoCTPTNBH.SoLuong),
                        new SqlParameter("@MaPTNBH", dtoCTPTNBH.MaPTNBH),
                    };
                        SqlHelper.ExecuteNonQuery(tran, CommandType.StoredProcedure, "sp_InsertCTPTNBH", para1);
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
            catch (SqlException ex)
            {
                throw new Exception("Lỗi cơ sở dữ liệu");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return 1;
        }

        public DataTable GetListMaNV()
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.StoredProcedure, "sp_GetMaNV").Tables[0];
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetKhachHangByPTNBH(string maPTNBH)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "sp_KhachHangByPTNBH", new SqlParameter("@MaPTNBH", maPTNBH)).Tables[0];
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetCountPTNBH()
        {
            try
            {
                return SqlHelper.ExecuteScalar(Constants.ConnectionString, CommandType.Text, "select count(MaPTNBH) from PHIEUTIEPNHANBAOHANH");
                //return int.Parse("n");
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Lỗi cơ sở dữ liệu");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetMaHD()
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString, CommandType.StoredProcedure, "sp_GetMaHD").Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetSanPhamByMaHD(string maHD)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                CommandType.StoredProcedure,
                "sp_GetSanPhamByMaHD", new SqlParameter("@MaHD", maHD)).Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetQuanlityFromWarrantyReturn(string billID, string productID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@MaHoaDon", billID),
                    new SqlParameter("@MaSanPham", productID)
                };
                return SqlHelper.ExecuteScalar(Constants.ConnectionString, CommandType.Text,
                    @"SELECT        SUM(dbo.CHITIETPHIEUTRAHANGBAOHANH.SoLuong) AS Expr1
FROM            dbo.PHIEUTRAHANGBAOHANH INNER JOIN
                         dbo.CHITIETPHIEUTRAHANGBAOHANH ON dbo.PHIEUTRAHANGBAOHANH.MaPTHBH = dbo.CHITIETPHIEUTRAHANGBAOHANH.MaPTHBH INNER JOIN
                         dbo.PHIEUTIEPNHANBAOHANH ON dbo.PHIEUTRAHANGBAOHANH.MaPTNBH = dbo.PHIEUTIEPNHANBAOHANH.MaPTNBH INNER JOIN
                         dbo.CHITIETPHIEUTIEPNHANBAOHANH ON dbo.PHIEUTIEPNHANBAOHANH.MaPTNBH = dbo.CHITIETPHIEUTIEPNHANBAOHANH.MaPTNBH
WHERE        (dbo.CHITIETPHIEUTIEPNHANBAOHANH.MaHoaDon = @MaHoaDon) AND (dbo.CHITIETPHIEUTRAHANGBAOHANH.MaSanPham = @MaSanPham)", para);
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
