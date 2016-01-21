using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoChiTietPhieuTiepNhanBaoHanh
    {
        private int _MaCTPTNBH;

        public int MaCTPTNBH
        {
            get { return _MaCTPTNBH; }
            set { _MaCTPTNBH = value; }
        }

        private string _MaHoaDon;

        public string MaHoaDon
        {
            get { return _MaHoaDon; }
            set { _MaHoaDon = value; }
        }

        private string _MaSanPham;

        public string MaSanPham
        {
            get { return _MaSanPham; }
            set { _MaSanPham = value; }
        }

        private string _MoTaLoi;

        public string MoTaLoi
        {
            get { return _MoTaLoi; }
            set { _MoTaLoi = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private string _MaPTNBH;

        public string MaPTNBH
        {
            get { return _MaPTNBH; }
            set { _MaPTNBH = value; }
        }
    }
}
