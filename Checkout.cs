using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    
    internal class Checkout 
    {
        BankTransfer bankTransfer;
        Creditcard creditcard;
        Account currentAccount;
        bool isTransactionComplete;

        ShoppingCart cart;
        public Checkout(ref ShoppingCart shoppingCart, ref Account account) { 
            bankTransfer = new BankTransfer();
            creditcard = new Creditcard();
            isTransactionComplete = false;
            cart = shoppingCart;
            currentAccount = account;
        }
         public void showGUI() {

            string userInput;

            while (true)
            {
                Console.WriteLine("****************");
                Console.WriteLine("\tCheckout\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "enter \"1\" to pay by credit card, \n" +
                    "enter \"2\" to pay by bank transfer, \n" +
                    "to return to naviagtion, enter \"5\"\n\n"
                    );

                userInput = Console.ReadLine();

                if (userInput != null)
                {
                    switch (userInput)
                    {
                        case "1":
                            Console.WriteLine("You have chosen credit card\n");
                            creditcard.showGUI();
                            if (creditcard.getIsValidPaymentDetails) {

                                creditcard.processPayment(cart.getTotalPrice());
                                Console.WriteLine("Please enter your address information: \n");
                                userInput = Console.ReadLine();
                                isTransactionComplete=true;
                            }
                            break;
                        case "2":
                            Console.WriteLine("You have chosen bank account\n");
                            bankTransfer.showGUI();
                            if (bankTransfer.getIsValidPaymentDetails)
                            {
                                bankTransfer.processPayment(cart.getTotalPrice());
                                Console.WriteLine("Please enter your address information: \n");
                                userInput = Console.ReadLine();
                                isTransactionComplete =true;
                            }
                            break;
                        case "5":
                            Console.WriteLine("You have chosen to return to navigation\n"); break;
                        default:
                            Console.WriteLine("Invalid option, try again\n");
                            break;
                    }
                }

                if (isTransactionComplete) {

                    int currentTransactionId = 0;
                    try
                    {
                        string line;
                        string[] transactionDetails;
                        using (StreamReader textFile = new StreamReader("../../../tables/Transactions.txt"))
                        {
                            line = textFile.ReadLine();
                            while ((line = textFile.ReadLine()) != null)
                            {
                                transactionDetails = line.Split(',');
                                currentTransactionId = Int32.Parse(transactionDetails[0]);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be read: ");
                        Console.WriteLine(e.Message);
                    }

                    currentTransactionId++;
                    try
                    {
                        List<selectedProducts> purchasedProducts = cart.getShoppingCartProductsList();
                        using (StreamWriter textFile = File.AppendText(    "../../../tables/Transactions.txt"))
                        {
                            string productIDs = "";
                            string quantities = "";
                            for (int i = 0; i < purchasedProducts.Count;i++) {
                                productIDs += purchasedProducts[i].id.ToString();
                                if (i < purchasedProducts.Count - 1) {
                                    productIDs += "/";
                                }
                            }

                            for (int i = 0; i < purchasedProducts.Count; i++) {
                                quantities += purchasedProducts[i].quantity.ToString();
                                if (i < purchasedProducts.Count - 1)
                                {
                                    quantities += "/";
                                }
                            }

                            textFile.WriteLine(
                                    currentTransactionId.ToString() + "," +
                                    currentAccount.getCustomerUsername() + "," +
                                    productIDs + "," +
                                    quantities + "," +
                                    cart.getTotalPrice().ToString()
                                    );
                        }
                    }
                    catch (Exception e)
                    {
                        // Let the user know what went wrong.
                        Console.WriteLine("The file could not be written to:");
                        Console.WriteLine(e.Message);
                    }
                }

                if (userInput == "5" || isTransactionComplete)
                {
                    Console.WriteLine("returning to navigation\n");
                    break;
                }

            }





        }
    }
}
