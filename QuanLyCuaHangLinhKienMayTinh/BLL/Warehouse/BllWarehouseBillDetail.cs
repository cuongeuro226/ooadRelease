using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Warehouse;

namespace BLL.Warehouse
{
    public class BllWarehouseBillDetail
    {
        private DalWarehouseBillDetail _dalWarehouseBillDetail;

        public BllWarehouseBillDetail()
        {
            _dalWarehouseBillDetail = new DalWarehouseBillDetail();
        }


        public DataTable GetWarehouseBillDetailList()
        {
            try
            {
                return _dalWarehouseBillDetail.GetWarehouseBillDetailList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetWarehouseBillDetailWithWarehouseBillID(string id)
        {
            try
            {
                return _dalWarehouseBillDetail.GetWarehouseBillDetailWithWarehouseBillID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public double SumTotal(string id)
        {
            try
            {
                double s = 0;
                DataTable dt = _dalWarehouseBillDetail.GetWarehouseBillDetailWithWarehouseBillID(id);
                foreach (DataRow row in dt.Rows)
                {
                    s += double.Parse(row["DonGiaNhap"].ToString()) *
                         int.Parse(row["SoLuong"].ToString());
                }
                return s;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
