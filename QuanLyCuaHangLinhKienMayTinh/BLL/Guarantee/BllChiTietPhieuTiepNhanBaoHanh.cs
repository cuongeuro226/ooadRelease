using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Guarantee;
using DTO;
using System.Data;

namespace BLL.Guarantee
{
    public class BllChiTietPhieuTiepNhanBaoHanh
    {
        private DalChiTietPhieuTiepNhanBaoHanh dalCTPTNBH;

        public BllChiTietPhieuTiepNhanBaoHanh()
        {
            dalCTPTNBH = new DalChiTietPhieuTiepNhanBaoHanh();
        }

        public int AddChiTietPhieuTiepNhanBaoHanh(DtoChiTietPhieuTiepNhanBaoHanh dtoCTPTNBH)
        {
            return dalCTPTNBH.AddChiTietPhieuTiepNhanBaoHanh(dtoCTPTNBH);
        }

        public DataTable GetAllCTPTNBH(string maPTNBH)
        {
            return dalCTPTNBH.GetAllCTPTNBH(maPTNBH);
        }

        public int GetQuanlityDetailWarrantyBillByBillID(string id, string productID)
        {
            try
            {
                return (int) dalCTPTNBH.GetDetailWarrantyBillByBillID(id, productID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
