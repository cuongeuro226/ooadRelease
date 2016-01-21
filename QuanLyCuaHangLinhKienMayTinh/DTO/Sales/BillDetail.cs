using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Sales
{
    public class BillDetail
    {
        private string _productId;
        private string _productName;
        private int _amount;
        private int _price;
        public BillDetail(string proId, string proName, int amount,int price )
        {
            _productId = proId;
            _productName = proName;
            _amount = amount;
            _price = price;
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
            set
            {
                
                    _productName = value;
            }
        }
        public int Amount
        {
            get { return _amount; }
            set
            {
                if (value > 0)
                    _amount = value;
            }
        }
        public int Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
    }
}
