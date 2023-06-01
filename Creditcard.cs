using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Creditcard : PaymentMethod
    {
        string creditcardNum, creditcardCVVNum, creditcardExpiryDate;
        bool isValidCreditCardDetails;
        public Creditcard() {
            isValidCreditCardDetails = false;
        }

        public override void showGUI() {

            string userInput;
            while (true)
            {
                Console.WriteLine("****************");
                Console.WriteLine("\tCreditcard Payment\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "to return to choose a different payment method, enter \"exit\"\n\n" +

                    "enter your credit card number:\n"
                    
                    );

                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Console.WriteLine("returning to checkout\n");
                    break;
                }

                creditcardNum = userInput;
                Console.WriteLine("enter your CVV number:\n");
                creditcardCVVNum = Console.ReadLine();
                Console.WriteLine("enter your expiry date:\n");
                creditcardExpiryDate = Console.ReadLine();

                verifyPayment();

                if (isValidCreditCardDetails)
                {
                    break;
                }
                else {
                    Console.WriteLine("Incorrect details, try again.\n");
                }  
            }
        }

        public override void processPayment() { 
        
        }
        public override void verifyPayment() {

            Console.WriteLine("Sending details to bank to verify");
            Console.WriteLine("verification successful");
            isValidCreditCardDetails = true;
        
        }
        public override void recordTransaction() { 
        
        }

        public override bool getIsValidPaymentDetails {
            get {
                return isValidCreditCardDetails;
            }            
        }
    }
}
