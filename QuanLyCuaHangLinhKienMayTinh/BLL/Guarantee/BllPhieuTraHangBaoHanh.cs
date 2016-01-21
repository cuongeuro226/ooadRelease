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
    public class BllPhieuTraHangBaoHanh
    {
        DalPhieuTraHangBaoHanh dalPTHBH;

        public BllPhieuTraHangBaoHanh()
        {
            dalPTHBH = new DalPhieuTraHangBaoHanh();
        }

        public int AddPhieuTraHangBaoHanh(DtoPhieuTraHangBaoHanh dtoPTHBH, List<DtoChiTietPhieuTraHangBaoHanh> listCTPTHBH)
        {
            return dalPTHBH.AddPhieuTraHangBaoHanh(dtoPTHBH,listCTPTHBH);
        }

        public DataTable GetAllPTHBHByMaPTNBH(string maPTNBH)
        {
            return dalPTHBH.GetAllPTHBHByMaPTNBH(maPTNBH);
        }

        public DataTable GetMaPTNBH()
        {
            return dalPTHBH.GetMaPTNBH();
        }

        public string CreatePTHBH()
        {
            try
            {
                int s = (int) dalPTHBH.GetCountMaPTHBH() + 1;
                return ("PTHBH" + s);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsReturnProductWarranty(string id)
        {
            return dalPTHBH.IsReturnProductWarranty(id) == 1 ? true : false;
        }

        public int GetQuanlity(string id, string productID)
        {
            return (int) dalPTHBH.GetQuanlity(id, productID);
        }
    }
}
