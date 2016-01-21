using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Sales
{
    public class Customer
    {
        private string _customerId;
        private string _customerName;
        private string _idNumber;
        private string _address;
        private string _phoneNumber;


        public Customer() { }

        public override bool Equals(object obj)
        {
            Customer ob = (Customer)obj;
            if (_customerId == ob.CustomerId && _customerName == ob.CustomerName && _idNumber == ob._idNumber && _address == ob._address && _phoneNumber == ob._phoneNumber)
                return true;
            return false;
        }
        public Customer(string cusId, string cusName, string idNumber, string address, string phoneNumber)
        {
            _customerId = cusId;
            _customerName = cusName;
            _idNumber = idNumber;
            _idNumber = idNumber;
            _address = address;
            _phoneNumber = phoneNumber;
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
            set { _customerName = value; }
        }
        public string IdNumber
        {
            get { return _idNumber; }
            set
            {
                if (value.Length < 10)
                {
                    _idNumber = value;
                }
            }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length < 12)
                {
                    _phoneNumber = value;
                }
            }
        }
    }
}
