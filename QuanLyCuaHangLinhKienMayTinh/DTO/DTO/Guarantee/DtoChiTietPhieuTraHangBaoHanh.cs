using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoChiTietPhieuTraHangBaoHanh
    {
        private int _MaCTPTHBH;

        public int MaCTPTHBH
        {
            get { return _MaCTPTHBH; }
            set { _MaCTPTHBH = value; }
        }
        private string _MaPTHBH;

        public string MaPTHBH
        {
            get { return _MaPTHBH; }
            set { _MaPTHBH = value; }
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

        private string _ghiChu;

        public string GhiChu
        {
            get { return _ghiChu; }
            set { _ghiChu = value; }
        }
    }
}
