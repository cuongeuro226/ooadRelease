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
    public class BllThongKeBaoHanh
    {
        DalThongKeBaoHanh dalThongKeBaoHanh;
        public BllThongKeBaoHanh()
        {
            dalThongKeBaoHanh = new DalThongKeBaoHanh();
        }

        public DataTable GetThongKePTNBH(DateTime tuNgay, DateTime denNgay)
        {
            return dalThongKeBaoHanh.GetThongKePTNBH(tuNgay, denNgay);
        }
        public DataTable GetThongKePTHBH(DateTime tuNgay, DateTime denNgay)
        {
            return dalThongKeBaoHanh.GetThongKePTHBH(tuNgay, denNgay);
        }
    }
}
