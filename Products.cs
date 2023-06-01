using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assignment3
{
    public class Products
    {
        private int _productID;
        private string _productName;

        private double _price;

        public Products (int productID, string productName, double price){
            _productID = productID;
            _productName = productName;
            _price = price;
        }

        public int ProductID{
            get {
                return _productID;
            }
            set {
                _productID = value;
            }
        }

        public string ProductName{
            get{
                return _productName;
            }
            set {
                _productName = value;
            }
        }
        
        public double Price{
            get{
                return _price;
            }
            set {
                _price = value;
            }
        }

        
    }
}