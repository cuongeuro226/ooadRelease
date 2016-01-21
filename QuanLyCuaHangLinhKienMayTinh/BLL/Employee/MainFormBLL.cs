using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
   public class MainFormBLL
    {
        MainFormDAL ddd = new MainFormDAL();
        public Employee GetEmployee(string EmployeeID)
        {
           // MainFormDAL ddd = new MainFormDAL();

            DataTable data = ddd.GetEmployee(EmployeeID);
            try
            {
                Employee c = new Employee();
                if (data.Rows.Count > 0)
                {
                    DataRow r = data.Rows[0];
                    c.EmployeeID = r.ItemArray[0].ToString();
                    c.EmployeeName = r.ItemArray[1].ToString();
                    c.Sex = r.ItemArray[2].ToString();
                    c.NumberID = r.ItemArray[3].ToString();
                    c.Phone = r.ItemArray[4].ToString();
                    c.BirthDay = r.ItemArray[5].ToString();
                    c.Address = r.ItemArray[6].ToString();
                    c.PlaceBirth = r.ItemArray[7].ToString();
                    c.Age = r.ItemArray[8].ToString();
                    c.PositionID = r.ItemArray[9].ToString();
                    c.PositionName = GetPositionName(r.ItemArray[9].ToString());
                    c.Salary = r.ItemArray[10].ToString();
                    c.DayWorking = r.ItemArray[11].ToString();
                    c.StatusName = r.ItemArray[13].ToString();
                    //c.ImageLink = new MemoryStream(Encoding.UTF8.GetBytes(r.ItemArray[12].ToString()));
                    c.PassWord = r.ItemArray[14].ToString();
                    c.ControlID = r.ItemArray[15].ToString();
                    return c;
                }
                else
                    return c;

            }
            catch (Exception ex)
            {
                throw ex;
            }




        }

        public string GetPositionName(string positionID)
        {
            DataTable d = (ddd.GetPositionName(positionID));
            string pos = "";
            try
            {
                if (d.Rows.Count > 0)
                    pos = d.Rows[0].ItemArray[0].ToString();
                return pos;
            }
            catch (Exception e)
            {
                throw e;
            }
            return pos;
        }
        public byte[] GetImage(string EmployeeID)
        {
            //byte[] b;
            try
            {
                DataTable d = new DataTable();
                d = ddd.GetImage(EmployeeID);
                byte[] b = (byte[])(d.Rows[0][0]);
                return b;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
