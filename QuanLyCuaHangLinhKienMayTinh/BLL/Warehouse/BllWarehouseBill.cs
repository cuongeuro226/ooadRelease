using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO.Warehouse;

namespace BLL.Warehouse
{
    public class BllWarehouseBill
    {
        private DalWarehouseBill _dalWarehouseBill;

        public BllWarehouseBill()
        {
            _dalWarehouseBill = new DalWarehouseBill();
        }

        public DataTable GetWarehouseBillList()
        {
            try
            {
                return _dalWarehouseBill.GetWarehouseBillList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetEmployeeList()
        {
            try
            {
                return _dalWarehouseBill.GetEmployeeList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddWarehouseBillTran(DtoWarehouseBill warehouseBill, List<DtoWarehouseBillDetail> list)
        {
            try
            {
                return _dalWarehouseBill.AddWarehouseBillTran(warehouseBill, list) == 0 ? false : true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateWarehouseBillID()
        {
            try
            {
                string id = "MPNK{0}";
                int i = (int) _dalWarehouseBill.GetCount() + 1;
                return String.Format(id, i);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
