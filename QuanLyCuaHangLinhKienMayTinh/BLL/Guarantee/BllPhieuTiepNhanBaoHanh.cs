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
    public class BllPhieuTiepNhanBaoHanh
    {
        private DalPhieuTiepNhanBaoHanh dalPTNBH;

        public BllPhieuTiepNhanBaoHanh() {
            dalPTNBH = new DalPhieuTiepNhanBaoHanh();
        }

        public bool AddPhieuTiepNhanBaoHanh(DtoPhieuTiepNhanBaoHanh dtoPTNBH, List<DtoChiTietPhieuTiepNhanBaoHanh> listCTPTNBH)
        {
            return dalPTNBH.AddPhieuTiepNhanBaoHanh(dtoPTNBH, listCTPTNBH) == 0 ? false : true;
        }

        public DataTable GetListMaNV()
        {
            return dalPTNBH.GetListMaNV();
        }

        public DataTable GetKhachHangByPTNBH(string maPTNBH)
        {
            return dalPTNBH.GetKhachHangByPTNBH(maPTNBH);
        }

        public string CreatePTNBH()
        {
            try
            {
                int s = (int)dalPTNBH.GetCountPTNBH() + 1;
                return ("PTNBH" + s);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetMaHD()
        {
            return dalPTNBH.GetMaHD();
        }

        public DataTable GetSanPhamByMaHD(string maHD)
        {
            return dalPTNBH.GetSanPhamByMaHD(maHD);
        }

        //public int AddPhieuTiepNhanBaoHanh(DtoPhieuTiepNhanBaoHanh dtoPTNBH)
        //{
        //    return dalPTNBH.AddPhieuTiepNhanBaoHanh(dtoPTNBH);
        //}

        //public DataTable GetKhachHangByMaHoaDon(string maHoaDon)
        //{
        //    return dalPTNBH.GetKhachHangByMaHoaDon(maHoaDon);
        //}

        //public DataTable GetListSanPhamByMaHoaDon(string maHoaDon)
        //{
        //    return dalPTNBH.GetListSanPhamByMaHoaDon(maHoaDon);
        //}
        public int GetQuanlity(string id, string productID)
        {
            try
            {
                return (int)dalPTNBH.GetQuanlityFromWarrantyReturn(id, productID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
