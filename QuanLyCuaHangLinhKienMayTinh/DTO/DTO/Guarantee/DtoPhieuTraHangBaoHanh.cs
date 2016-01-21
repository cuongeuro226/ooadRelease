using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPhieuTraHangBaoHanh
    {
        private string _MaPTHBH;

        public string MaPTHBH
        {
            get { return _MaPTHBH; }
            set { _MaPTHBH = value; }
        }
        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _maPTNBH;

        public string MaPTNBH
        {
            get { return _maPTNBH; }
            set { _maPTNBH = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
    }
}
