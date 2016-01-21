using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPhieuXuatLinhKienBaoHanh
    {
        private string _MaPXLKBH;

        public string MaPXLKBH
        {
            get { return _MaPXLKBH; }
            set { _MaPXLKBH = value; }
        }
        private string _MaPTNBH;

        public string MaPTNBH
        {
            get { return _MaPTNBH; }
            set { _MaPTNBH = value; }
        }
        private string _MaNVKT;

        public string MaNVKT
        {
            get { return _MaNVKT; }
            set { _MaNVKT = value; }
        }
        private string _MaNVKho;

        public string MaNVKho
        {
            get { return _MaNVKho; }
            set { _MaNVKho = value; }
        }
        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
    }
}
