using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
   
internal class Catalogue
    {
        ShoppingCart cart;
        List<Product> productList;
        public Catalogue(ref ShoppingCart shoppingCart) { 
            cart = shoppingCart;
            productList = new List<Product>();
            getItemsFromTable();
        }

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
                    "To return to naviagtion, enter \"exit\"\n\n" 
                    );


                foreach (Product i in productList)
                {
                    Console.WriteLine("ID: " + i.id + "\tname: " + i.name + "\tprice: " + i.price);
                }

                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Console.WriteLine("returning to navigation\n");
                    break;
                }

                bool isProductFound = false;

                int productID = 0;
                int quantity = 0;
                float price = 0;

                Product currentProduct;

                if (userInput != null)
                {
                    Console.WriteLine("checking for item");

                    for (int i =0; i < productList.Count; i++){
                        if (productList[i].id == Int32.Parse(userInput)) {                           
                            isProductFound = true;
                            productID = Int32.Parse(userInput);
                            currentProduct = productList[i];
                            price = currentProduct.price;
                        }
                    }

                    if (isProductFound)
                    {
                        Console.WriteLine("Please enter the desired ammount of: " + userInput);
                        userInput = Console.ReadLine();
                        quantity = Int32.Parse(userInput);
                        cart.addProduct(productID,quantity,price);
                        isProductFound = false;
                    }
                    else {
                        Console.WriteLine("Error, product was not found, try again.\n");
                    }
                }          

            }

        }


        public void getItemsFromTable() {

            try
            {
                using (StreamReader textFile = new StreamReader("../../../tables/Products.txt"))
                {
                    string line;
                    string[] productDetails;

                    line = textFile.ReadLine();
                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = textFile.ReadLine()) != null)
                    {
                        productDetails = line.Split(',');
                        Product i = new Product(
                            Int32.Parse(productDetails[0]), 
                            productDetails[1], 
                            float.Parse(productDetails[2]));
                        productList.Add(i);
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

    }
}
