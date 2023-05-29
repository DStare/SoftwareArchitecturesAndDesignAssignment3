using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Customer : Account
    {
        string username, password;
        bool inSignedInVar;
        public Customer(string user, string pass) { 
            username = user;
            password = pass;
            inSignedInVar = true;
        }

        public void showGUI() {
            string userInput;


            while (true)
            {
                    Console.WriteLine("****************");
                    Console.WriteLine("\tCustomer Account\t");
                    Console.WriteLine("****************");
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine(
                        "Welcome " + username + "! \n" +
                        "enter \"1\" to view receipts,\n" +
                        "enter \"2\" to sign out,\n" +
                        "enter \"3\" to change account info,\n" +
                        "enter \"5\" to return to navigation \n"
                        );

                    userInput = Console.ReadLine();

                    if (userInput != null)
                    {
                        switch (userInput)
                        {
                            case "1":
                                Console.WriteLine("You have chosen to view receipts\n");
                                //this.viewReceipts();
                                break;
                            case "2":
                                Console.WriteLine("You have chosen to sign out\n");
                                inSignedInVar = false;
                                break;
                            case "3":
                                Console.WriteLine("You have chosen to account info\n"); 
                                break;
                            case "5":
                                Console.WriteLine("You have chosen to return to navigation\n"); 
                                break;
                            default:
                                Console.WriteLine("Invalid option, try again\n");
                                break;
                        }
                    }

                    if (userInput == "5" || userInput == "2")
                    {
                        Console.WriteLine("returning to navigation\n");
                        break;
                    }

                }
            }

        public bool isSignedIn()
        {
            return inSignedInVar;
        }

    }

}

