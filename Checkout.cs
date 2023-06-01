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
        bool isTransactionComplete;
        public Checkout() { 
            bankTransfer = new BankTransfer();
            creditcard = new Creditcard();
            isTransactionComplete = false;
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
                                creditcard.processPayment();
                                isTransactionComplete=true;
                            }
                            break;
                        case "2":
                            Console.WriteLine("You have chosen bank account\n");
                            bankTransfer.showGUI();
                            if (bankTransfer.getIsValidPaymentDetails)
                            {
                                bankTransfer.processPayment();
                                isTransactionComplete=true;
                            }
                            break;
                        case "5":
                            Console.WriteLine("You have chosen to return to navigation\n"); break;
                        default:
                            Console.WriteLine("Invalid option, try again\n");
                            break;

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
