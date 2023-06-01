using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class ShoppingCart
    {

        private List<Products> _shoppingCart;

        public ShoppingCart() {
            _shoppingCart = new List<Products>();
         }

        public List<Products> ShoppingCartList{
            get {
                return _shoppingCart;
            }
        }

        public void AddSelection(Products p){
            _shoppingCart.Add(p);
        }

        public void RemoveSelection(Products p){
            _shoppingCart.Remove(p);
        }

        public int ShoppingCartCount{
            get{
                return _shoppingCart.Count;
            }
        }

        public Products this[int i]{
            get{
                return _shoppingCart[i];
            }
        }

        public double CalculateTotal(ShoppingCart sc, Account a){
            double total = 0;
            for (int i = 0; i< sc.ShoppingCartCount; i++){
                total += sc[i].Price;
            }
            return total;
        }


        public void showGUI()
        {

            string userInput;

            
                Console.WriteLine("****************");
                Console.WriteLine("\tShopping Cart\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "Here is a list of all your currently selected items:\n"
                    );

                Console.WriteLine("*all your items*");

                Console.WriteLine(
                    "enter \"5\" to return to navigation \n\n");
            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput == "5")
                {
                    Console.WriteLine("returning to navigation\n");
                    break;
                }
                else {
                    Console.WriteLine("invalid option\n");
                }

            }

        }
    }
}
