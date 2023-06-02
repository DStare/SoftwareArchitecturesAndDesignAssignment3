using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    public class ShoppingCart
    {

        private List<Products> _shoppingCart;
        private int _quantity;

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

        public double CalculateTotal(){
            double total = 0;
            foreach (Products p in _shoppingCart){
                total += p.Price;
            }
            return total;
        }

        public void testGui(){
            Console.WriteLine(
           "Here is a list of all your currently selected items:\n"
           );
            /*foreach (Products p in _shoppingCart)
            {
                Console.WriteLine("{0,-1}{1,-15}{2,-15}", p.ProductID, p.ProductName, p.Price);
            }*/
            Dictionary<Products, int> freqMap = _shoppingCart.GroupBy(x => x).Where(g => g.Count() > 1).ToDictionary(x=> x.Key, x=>x.Count());
            Console.WriteLine("[Value, Count]: " + String.Join(",", freqMap));

            /*distinctList = _shoppingCart.Select(x => x.ProductID).Distinct().ToList();


            foreach (int i in distinctList){
                Console.WriteLine(i);
            }*/

            /*foreach (var data in _shoppingCart){
                if ()
            }*/

            /*Console.WriteLine("Input 1 to remove items");
            string input = null;
            string inputitem = null;
            int inputitemid = 0;
            if (input == "1")
            {
                Console.WriteLine("Please choose the product you want to remove");
                do
                {
                    inputitem = Console.ReadLine();
                    inputitemid = Convert.ToInt32(inputItem);

                    if (intInput > 0)
                    {
                        Console.WriteLine("Please enter amount");
                        input2 = Console.ReadLine();
                        quantity = Convert.ToInt32(input2);

                        foreach (Products ps in _catalogue)
                        {
                            if (intInput == ps.ProductID)
                            {
                                //Console.WriteLine(ps.ProductName);
                                for (int i = 0; i < quantity; i++)
                                {
                                    sc.AddSelection(ps);
                                }
                                Console.WriteLine("You have added " + ps.ProductName + quantity + "times");
                                Console.WriteLine("Please enter another product id or exit with [0]");
                            }
                        }
                    }
            }
           
            }while (intInput != 0);*/
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
