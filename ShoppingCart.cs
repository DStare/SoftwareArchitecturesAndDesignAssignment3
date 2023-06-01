using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    
    internal class ShoppingCart
    {
        public ShoppingCart() { }

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
