using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Catalogue
    {
        private List<Products> _products;

        public Catalogue(){
            _products = new List<Products>();
        }
        public List<Products> Products{
            get{
                return _products;
            }
        }

        public int ProductCount{
            get{
                return _products.Count;
            }
        }

        public void AddProduct(Products p){
            _products.Add(p);
        }

        public void RemoveProduct(Products p){
            _products.Remove(p);
        }

        public void PlaceOrder(IEnumerable<Products> Sort, ShoppingCart sc, Account c){
            
        }

    }
}
