using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Warehouse;
using CommonLayer;
namespace DTO.Sales
{
    public class Bill
    {
        private string _billId;
        private string _billDate;
        private string _customerId;
        private string _staffId;
        private int _sum;
        private List<BillDetail> _productList = new List<BillDetail>();
        private string _customerName;
        public Bill(string billId, string billDate, string cusId, string staffId, string cusName, int sum, List<BillDetail> proList)
        {
            _billId = billId;
            _billDate = billDate;
            _customerId = cusId;
            _staffId = staffId;
            _sum = sum;
            _customerName = cusName;
            _productList = proList;
        }
        public string BillId
        {
            get { return _billId; }
            set
            {
                if (value.Length <= 10)
                    _billId = value;
            }
        }
        public string BillDate
        {
            get { return _billDate; }
            set
            {
                if (DateTime.Parse(value) < DateTime.Now)
                    _billDate = value;
            }
        }
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                if (value.Length <= 10)
                    _customerId = value;
            }

        }
        public string StaffId
        {
            get { return _staffId; }
            set
            {
                if (value.Length <= 10)
                    _staffId = value;
            }
        }
       
        public int Sum
        {
            get { return _sum; }
            set
            {
                if (value > 0)
                    _sum = value;
            }
        }
        public List<BillDetail> ProductList
        {
            get { return _productList; }
            set
            {
                if (value.Count > 0)
                {
                    foreach (BillDetail p in value)
                    {
                        _productList.Add(p);
                    }
                }
            }
        }
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        //end class
    }
}
