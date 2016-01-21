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
    public class PositionDAL
    {
        
        ///
        public DataTable GetPositionCount()
        {

            try
            {
                //SqlParameter[] para =
                //{
                //    new SqlParameter ("@MaChucVu",positionID),
                //};


                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "GetPositionCount").Tables[0];

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public DataTable GetAllPosition()
        {
            try
            {
                //SqlParameter[] para =
                //{
                //    new SqlParameter ("@MaChucVu",positionID),
                //};


                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "GetAllPosition").Tables[0];

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> GetFuntionByPositionID(string positionID)
        {
            List<string> l = new List<string>();
            try
            {    
                SqlParameter[] para =
                {
                    new SqlParameter("@MaCN", positionID),
                };


                DataTable d = SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "GetFuntionByPositionID", para).Tables[0];

                if (d.Rows.Count > 0)
                {
                    for (int i = 0; i < d.Rows[0].ItemArray.Length;i++)
                    {
                        l.Add(d.Rows[0].ItemArray[i].ToString());
                    }
                }
                return l;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void SavePosition(string PositionID, string PositionName, string Salary, string ControlID, List<string>arr)
        {
            SqlConnection con = new SqlConnection(Constants.ConnectionString);
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            try
            {
                
                SqlParameter[] para1 =
                {
                    new SqlParameter ("@MaChucNang",ControlID),
                    new SqlParameter ("@BanHang",arr[0]),
                    new SqlParameter ("@Kho",arr[1]),
                    new SqlParameter ("@BaoHanh",arr[2]),
                    new SqlParameter ("@ThongKe",arr[3]),
                    new SqlParameter ("@ThietLap",arr[4]),
                };
                
                SqlParameter[] para2 =
                {
                    new SqlParameter ("@MaChucVu",PositionID),
                    new SqlParameter ("@TenChucVu",PositionName),
                    new SqlParameter ("@Luong",Salary),
                    new SqlParameter ("@MaCN",ControlID),
                };



                SqlHelper.ExecuteNonQuery(tran,
                   CommandType.StoredProcedure,
                   "CreateFuntion", para1);
                SqlHelper.ExecuteNonQuery(tran,
                   CommandType.StoredProcedure,
                   "SavePosition",para2);
                tran.Commit();
                con.Close();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw e;
            }
        }

        public void UpdatePosition(string PositionID, string PositionName, string Salary, string ControlID, string IsDelete,List<string>arr)
        {
            SqlConnection con = new SqlConnection(Constants.ConnectionString);
            con.Open();
            SqlTransaction tran = con.BeginTransaction();
            try
            {
                
                SqlParameter[] para1 =
                {
                    new SqlParameter ("@MaChucVu",PositionID),
                    new SqlParameter ("@TenChucVu",PositionName),
                    new SqlParameter ("@Luong",Salary),
                    new SqlParameter ("@MaCN",ControlID),
                    new SqlParameter("@DaXoa",IsDelete),
                };
                SqlParameter[] para2 =
                {
                    new SqlParameter ("@MaChucNang",ControlID),
                    new SqlParameter ("@BanHang",arr[0]),
                    new SqlParameter ("@Kho",arr[1]),
                    new SqlParameter ("@BaoHanh",arr[2]),
                    new SqlParameter ("@ThongKe",arr[3]),
                    new SqlParameter ("@ThietLap",arr[4]),
                };


                SqlHelper.ExecuteNonQuery(tran,
                   CommandType.StoredProcedure,
                   "UpdateFuntion", para2);

                SqlHelper.ExecuteNonQuery(tran,
                   CommandType.StoredProcedure,
                   "UpdatePosition",para1);
                tran.Commit();
                con.Close();
            }
            catch (Exception e)
            {
                tran.Rollback();
                throw e;
            }
        }

        public void DeletePosition(string PositionID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter ("@MaChucVu",PositionID)
                };


                SqlHelper.ExecuteNonQuery(Constants.ConnectionString,
                   CommandType.StoredProcedure,
                   "DeletePosition", para);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetFuntion(string ControlID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter ("@MaCN",ControlID),
                };


                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "GetFuntion", para).Tables[0];

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public DataTable GetCountEmployeeUsePosition(string PositionID)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter ("@MaChucVu",PositionID),
                };


                return SqlHelper.ExecuteDataset(Constants.ConnectionString,
                    CommandType.StoredProcedure,
                    "GetCountEmployeeUsePosition", para).Tables[0];

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
    }
}
