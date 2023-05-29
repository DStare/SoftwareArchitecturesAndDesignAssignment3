using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    internal class Catalogue
    {
        public Catalogue() { }

        public void showGUI() {
            string userInput;

            while (true)
            {
                Console.WriteLine("****************");
                Console.WriteLine("\tCatalogue\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "Here is a list of available items, to add to cart, select the product number\n" +
                    "To return to naviagtion, enter \"5\"\n\n" 
                    );

                userInput = Console.ReadLine();
                int userInputToNum;

                if (userInput != null)
                {
                    userInputToNum = Int32.Parse(userInput);

                    Console.WriteLine("checking for item");

                }

                if (userInput == "5")
                {
                    Console.WriteLine("returning to navigation\n");
                    break;
                }

            }


        }
    }
}
