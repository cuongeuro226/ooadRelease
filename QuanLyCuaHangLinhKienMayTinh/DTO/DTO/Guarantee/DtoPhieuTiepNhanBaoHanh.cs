using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DtoPhieuTiepNhanBaoHanh
    {
        private string _MaPTNBH;

        public string MaPTNBH
        {
            get { return _MaPTNBH; }
            set { _MaPTNBH = value; }
        }

        private string _MaNV;

        public string MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }
        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
    }
}
