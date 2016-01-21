using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Sales
{
    public class ChangingBill
    {
        private string _changingBillId;
        private string _changingDate;
        private string _customerId;
        private string _customerName;
        private string _staffId;
        private string _billId;
        private string _changingProductId;
        private string _replaceProductId;
        private string _changingProductName;
        private string _replaceProductName;
        private int _changingFee;
        private int _returningFee;

        public ChangingBill(string changingBillId, string changingDate, string customerId, string customerName, string staffId, string billId, string changingProductId, string replaceProcductId, string changingProductName, string replaceProcductName, int changingFee, int returningFee)
        {
            _changingBillId = changingBillId;
            _changingDate = changingDate;
            _customerId = customerId;
            _customerName = customerName;
            _staffId = staffId;
            _billId = billId;
            _changingProductId = changingProductId;
            _replaceProductId = replaceProcductId;
            _changingProductName = changingProductName;
            _replaceProductName = replaceProcductName;
            _changingFee = changingFee;
            _returningFee = returningFee;
        }
        public string ChangingBillId
        {
            get { return _changingBillId; }
            set
            {
                if (value.Length <= 10)
                    _changingBillId = value;
            }
        }
        public string ChangingDate
        {
            get { return _changingDate; }
            set
            {
                if (DateTime.Parse(value) < DateTime.Now)
                    _changingDate = value;
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
        public string ChangingProductId
        {
            get { return _changingProductId; }
            set
            {
                if (value.Length <= 10)
                    _changingProductId = value;
            }
        }
        public string ReplaceProductId
        {
            get { return _replaceProductId; }
            set
            {
                if (value.Length <= 10)
                    _replaceProductId = value;
            }
        }
        public string ChangingProductName
        {
            get { return _changingProductName; }
            set
            {
                if (value.Length <= 10)
                    _changingProductName = value;
            }
        }
        public string ReplaceProductName
        {
            get { return _replaceProductName; }
            set
            {
                if (value.Length <= 10)
                    _replaceProductName = value;
            }
        }
        public int ChangingFee
        {
            get { return _changingFee; }
            set
            {
                if (value > 0)
                    _changingFee = value;
            }
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
