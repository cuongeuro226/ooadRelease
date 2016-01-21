using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        LoginDAL dan = new LoginDAL();
        public bool CheckDangNhap(string manv, string matkhau)
        {
            try
            {
                DataTable d = dan.LayMatKhauNhanVien(manv);
                if (d.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    if (d.Rows.Count > 0)
                    {
                        if (d.Rows[0].ItemArray[0].ToString() == matkhau)
                        {

                            return true;
                        }
                        else
                            return false;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<string> GetFuntionByEmployeeID(string employeeID)
        {
            try
            {

                DataTable da = dan.GetEmployee(employeeID);
                    if (da.Rows.Count > 0)
                    {
                        da.Rows[0].ItemArray[0].ToString();
                        return GetFuntionByPositionID(da.Rows[0].ItemArray[15].ToString());
                    }
                    return null;

                

                 
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> GetFuntionByPositionID(string positionID)
        {
             
            try
            {
                LoginDAL d = new LoginDAL();
                return d.GetFuntionByPositionID(positionID);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

   


    }
}
