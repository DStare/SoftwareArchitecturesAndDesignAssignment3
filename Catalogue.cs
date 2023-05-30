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
        String filePath = "Products.txt";
        List<Items> catalogueList = new List<Items>();

        public struct Items{
            public int productID;
            public string productName;
            public double Price;

        }

         public List<Items> Categorise(){
            StreamReader reader = new StreamReader(filePath);
            var PL = new List<Items>();
            var item = new Items();
            string line;
            int idx = 0;
            while ((line = reader.ReadLine()) != null){
                idx++;
                switch (idx){
                    case 1: item.productID = Convert.ToInt32(line); break;
                    case 2: item.productName = line; break;
                    case 3: item.Price = Convert.ToDouble(line); break;
                }
                if (line == "" && idx > 0 ){
                    PL.Add(item);
                    idx = 0;
                    item = new Items();
                }
            }
            if (idx > 0){
                PL.Add(item);
            }

            catalogueList = PL;

            reader.Close();
            
            return catalogueList;

        }

        public void showGUI() {

            Categorise();
            string userInput;
            while (true)
            {
                foreach (Items p in catalogueList){
                Console.WriteLine( String.Format( "Product ID={0} Product Name={1} Price={2}", p.productID, p.productName, p.Price));
                //
            }
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
