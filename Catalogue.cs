using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class Catalogue
    {
        private List<Products> _catalogue;

        public Catalogue(){
            _catalogue = new List<Products>();
        }
        public List<Products> Catalogues{
            get{
                return _catalogue;
            }
        }


        public void AddProduct(Products p){
            _catalogue.Add(p);
        }

        public void RemoveProduct(Products p){
            _catalogue.Remove(p);
        }

        public IEnumerable<Products> Display(){
            var sIndex = _catalogue.OrderBy(p=>p.ProductID);
            int i = 1;
            Console.WriteLine("{0,-1}{1,-15}{2,-15}","ID ","Name","Price");
            foreach (Products p in sIndex){
            Console.WriteLine("{0,-1}{1,-15}{2,-15}",p.ProductID,p.ProductName,p.Price);
            i++;
            }
            return sIndex;
        }
        public void PlaceOrder(IEnumerable<Products> Display, ShoppingCart sc){
            //Check ID and check for qnty
            
            string input = null;
            string input2 = null;
            int intInput;
            int quantity;
            Console.WriteLine("Please choose a product, please type [0] to checkout");

            do {
            input = Console.ReadLine();
            intInput = Convert.ToInt32(input);
            
            if (intInput > 0){
                Console.WriteLine("Please enter amount");
                input2 = Console.ReadLine();
                quantity = Convert.ToInt32(input2);

                foreach (Products ps in _catalogue){
                    if (intInput == ps.ProductID){
                    //Console.WriteLine(ps.ProductName);
                    for (int i = 0; i < quantity; i++){
                        sc.AddSelection(ps);
                    }
                    Console.WriteLine("You have added "+ ps.ProductName + quantity +"times");
                    Console.WriteLine("Please enter another product id or exit with [0]");
                }
                 }
            }
           
            }while (intInput != 0);
            Console.WriteLine("This is your shopping cart:");
            //exit -> shoppingcart = dontneed
            //exit ->nav (catalogue) select 1/2/3/4/5 = we keep
            /*
            for (int i = 0; i < sc.ShoppingCartCount ; i++){
                Console.WriteLine("{0,-1}{1,-15}{2,-15} ",sc[i].ProductID,sc[i].ProductName,sc[i].Price);
            }*/
        }

    }
}
