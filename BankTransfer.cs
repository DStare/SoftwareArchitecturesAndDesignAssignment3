using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class BankTransfer : PaymentMethod
    {
        bool isValidBankTransferDetails;
        string bsbNum, accountNum, accountName;
        public BankTransfer() {
            isValidBankTransferDetails = false;
        }

        public override void showGUI() {


            string userInput;
            while (true)
            {
                Console.WriteLine("****************");
                Console.WriteLine("\tBank Transfer Payment\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "to return to choose a different payment method, enter \"exit\"\n\n" +

                    "enter your BSB number:\n"

                    );

                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Console.WriteLine("returning to checkout\n");
                    break;
                }

                bsbNum = userInput;
                Console.WriteLine("enter your Account number:\n");
                accountNum = Console.ReadLine();
                Console.WriteLine("enter your Account name date:\n");
                accountName = Console.ReadLine();

                verifyPayment();

                if (isValidBankTransferDetails)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect details, try again.\n");
                }
            }

        }

        public override void processPayment(float totalPrice) {

            Console.WriteLine("Requesting payment from bank via bank transfer for total of: " + totalPrice);
        }
        public override void verifyPayment()
        {

            Console.WriteLine("Sending details to bank to verify");
            Console.WriteLine("verification successful");
            isValidBankTransferDetails = true;

        }
        public override void recordTransaction() { 
        
        }

        public override bool getIsValidPaymentDetails
        {
            get
            {
                return isValidBankTransferDetails;
            }
        }
    }
}
