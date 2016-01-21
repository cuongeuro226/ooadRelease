using CommonLayer;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MainFormDAL
    {
        public DataTable GetEmployee(string EmployeeID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter ("@MaNV",EmployeeID),
                };


                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                   CommandType.StoredProcedure,
                   "GetEmployee", para).Tables[0];
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetPositionName(string positionID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter ("@Machucvu",positionID),
                };

                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                   CommandType.StoredProcedure,
                   "GetPositionName", para).Tables[0];
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetImage(string EmployeeID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter ("@MaNV",EmployeeID),
                };


                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "GetImage", para).Tables[0];

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
