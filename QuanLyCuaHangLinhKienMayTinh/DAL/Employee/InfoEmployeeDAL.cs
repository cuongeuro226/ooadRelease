using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using CommonLayer;
using System.IO;

namespace DAL
{
   public class InfoEmployeeDAL
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
                   "GetEmployee",para).Tables[0];
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
                   "GetPositionName",para).Tables[0];
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataTable GetListPosition()
        {
            try
            {
                //SqlParameter[] para =
                //{
                //    new SqlParameter ("@Machucvu",positionID),
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
        public void UpdateEmployee(string manv, string ten, string gioitinh, string cmnd, string sdt,
                         string ngaysinh, string diachi, string noisinh, string tuoi, string chucvu,
                         string luong, string ngayVaoLam, string pass, string trangthai , MemoryStream anhThe)
        {
            try
            {
                SqlParameter[] para =
                {
                    new SqlParameter("@MaNV", manv),
                    new SqlParameter("@Ten", ten),
                    new SqlParameter("@GioiTinh", gioitinh),
                    new SqlParameter("@CMND", cmnd),
                    new SqlParameter("@SDT", sdt),
                    new SqlParameter("@NgaySinh", ngaysinh),
                    new SqlParameter("@DiaChi", diachi),
                    new SqlParameter("@NoiSinh", noisinh),
                    new SqlParameter("@Tuoi", tuoi),
                    new SqlParameter("@ChucVu", chucvu),
                    new SqlParameter("@Luong", luong),
                    new SqlParameter("@NgayVaoLam", ngayVaoLam),
                    new SqlParameter("@AnhThe", anhThe.ToArray()),
                    new SqlParameter("@TrangThai", trangthai),
                    new SqlParameter("@Password", pass),
                    new SqlParameter("@MaCN",manv)
                };
                SqlHelper.ExecuteNonQuery(Constants.ConnectionString,
                   CommandType.StoredProcedure,
                   "UpdateEmployee", para);

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
                    for (int i = 0; i < d.Rows[0].ItemArray.Length; i++)
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
    }
}
