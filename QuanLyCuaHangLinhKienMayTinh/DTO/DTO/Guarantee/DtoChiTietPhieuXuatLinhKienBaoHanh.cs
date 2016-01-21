using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoChiTietPhieuXuatLinhKienBaoHanh
    {
        private int _MaCTPXLK;

        public int MaCTPXLK
        {
            get { return _MaCTPXLK; }
            set { _MaCTPXLK = value; }
        }
        private string _MaPXLKBH;

        public string MaPXLKBH
        {
            get { return _MaPXLKBH; }
            set { _MaPXLKBH = value; }
        }

        private string maLinhKien;

        public string MaLinhKien
        {
            get { return maLinhKien; }
            set { maLinhKien = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        
        //private string _DonGia;

        //public string DonGia
        //{
        //    get { return _DonGia; }
        //    set { _DonGia = value; }
        //}
    }
}
