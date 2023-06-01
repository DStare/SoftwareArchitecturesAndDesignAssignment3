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
                                this.viewReceipts();
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

        private void viewReceipts()
        {

            string userInput;

            while (true)
            {
                Console.WriteLine("****************");
                Console.WriteLine("\tReceipts\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "these are your receipts, enter a transaction ID to view more details. Or enter \"exit\" to leave.\n\n\n" +
                    "Transaction IDs: \t"
                    );
                try
                {
                    using (StreamReader textFile = new StreamReader("../../../tables/Transactions.txt"))
                    {
                        string line;
                        string[] transactionDetails;

                        // Read and display lines from the file until 
                        // the end of the file is reached. 
                        while ((line = textFile.ReadLine()) != null)
                        {
                            transactionDetails = line.Split('/');
                             if (transactionDetails[1] == username)
                             {
                                Console.WriteLine(transactionDetails[0]);                   
                               
                             }                             
                            
                        }
                    }
                }
                catch (Exception e)
                {
                    // Let the user know what went wrong.
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(e.Message);
                }

                userInput = Console.ReadLine();

                if (userInput != null)
                {

                    try
                    {
                        using (StreamReader textFile = new StreamReader("../../../tables/Transactions.txt"))
                        {
                            string line;
                            string[] transactionDetails;

                            // Read and display lines from the file until 
                            // the end of the file is reached. 
                            while ((line = textFile.ReadLine()) != null)
                            {
                                transactionDetails = line.Split(',');
                                if (transactionDetails[0] == userInput)
                                {
                                    string[] products = transactionDetails[2].Split("/");
                                    string[] quantities = transactionDetails[3].Split("/");

                                    Console.WriteLine("\n\nProducts:");
                                    for (int i = 0; i < products.Length; i++) {
                                        Console.WriteLine("\t" + products[i] + "\tat quantity: " + quantities[i]);
                                    }

                                    Console.WriteLine("Final price: " + transactionDetails[4] +"\n\n");
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be read:");
                        Console.WriteLine(e.Message);
                    }


                }

                if (userInput == "exit")
                {
                    Console.WriteLine("returning to navigation\n");
                    break;
                }
            }

        }

    }

}

