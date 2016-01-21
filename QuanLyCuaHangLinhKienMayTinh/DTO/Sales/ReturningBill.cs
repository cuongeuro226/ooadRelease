using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Sales
{
    public class ReturningBill
    {
        private string _returningBillId;
        private string _returningDate;
        private string _customerId;
        private string _customerName;
        private string _staffId;
        private string _billId;
        private string _productId;
        private string _productName;
        private int _returningFee;

        public ReturningBill(string returningBillId, string returningDate, string customerId,string customerName, string staffId, string billId, string productId, string productName, int returningFee)
        {
            _returningBillId = returningBillId;
            _returningDate = returningDate;
            _customerId = customerId;
            _customerName = customerName;
            _staffId = staffId;
            _billId = billId;
            _productId = productId;
            _productName = productName;
            _returningFee = returningFee;
        }
        public string ReturningBillId
        {
            get { return _returningBillId; }
            set
            {
                if (value.Length <= 10)
                    _returningBillId = value;
            }
        }
        public string ReturningDate
        {
            get { return _returningDate; }
            set
            {
                if (DateTime.Parse(value) < DateTime.Now)
                    _returningDate = value;
            }
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
        public string CustomerId
        {
            get { return _customerId; }
            set
            {
                if (value.Length <= 10)
                    _customerId = value;
            }

        }
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                    _customerName = value;
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
        public string ProductId
        {
            get { return _productId; }
            set
            {
                if (value.Length <= 10)
                    _productId = value;
            }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value;}
        }
        public int ReturningFee
        {
            get { return _returningFee; }
            set
            {
                if (value > 0)
                    _returningFee = value;
            }
        }
    }
}
