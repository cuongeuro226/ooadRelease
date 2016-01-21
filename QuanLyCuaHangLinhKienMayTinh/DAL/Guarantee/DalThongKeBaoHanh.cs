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
    public class DalThongKeBaoHanh
    {
        public DataTable GetThongKePTNBH(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "sp_ThongKePTNBH", new SqlParameter("@TuNgay", tuNgay),
                                        new SqlParameter("@DenNgay", denNgay)
                    ).Tables[0];
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
        public DataTable GetThongKePTHBH(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "sp_ThongKePTHBH", new SqlParameter("@TuNgay", tuNgay),
                                        new SqlParameter("@DenNgay", denNgay)
                    ).Tables[0];
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
    }
}
