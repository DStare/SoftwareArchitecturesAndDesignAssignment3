using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment3
{
    internal class Navigation
    {

        Catalogue catalogue;
        Checkout checkout;
        Account account;
        ShoppingCart shoppingCart;
        public Navigation(ref Catalogue cataloguePntr, ref Checkout checkoutPntr, ref Account accountPntr, ref ShoppingCart shoppingCartPntr) { 
            
            catalogue = cataloguePntr;
            checkout = checkoutPntr;
            account = accountPntr;
            shoppingCart = shoppingCartPntr;

        }

        public void shNavOptions() {

            string userInput;            

            while (true) {

                Console.WriteLine("****************");
                Console.WriteLine("\tNavigation\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "enter \"1\" for Account,\n" +
                    "enter \"2\" for Catalogue,\n" +
                    "enter \"3\" for Checkout,\n" +
                    "enter \"4\" for Shopping Cart,\n" +
                    "enter \"5\" to exit the app,\n"
                    );

                userInput = Console.ReadLine();
             
                if (userInput != null)
                {
                    switch (userInput) {
                        case "1":
                            Console.WriteLine("You have chosen Account\n");
                            account.showGUI();
                            break;
                        case "2":
                            Console.WriteLine("You have chosen Catalogue\n");
                            catalogue.showGUI();
                            break;
                        case "3":
                            Console.WriteLine("You have chosen Checkout\n");
                            checkout.showGUI();
                            break;
                        case "4":
                            Console.WriteLine("You have chosen ShoppingCart\n");
                            shoppingCart.showGUI();
                            break;
                        case "5":
                            Console.WriteLine("You have chosen to exit\n");
                            break;
                        default:
                            Console.WriteLine("Invalid option, try again\n");
                            break;

                    }
                }

                if (userInput == "5") {
                    Console.WriteLine("Exiting the program.\n");
                    break;
                }
            
            }
        }
    }
}
