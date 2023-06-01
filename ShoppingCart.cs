using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    struct selectedProducts {
        public int id;
        public int quantity;
        public float price;
    }
    internal class ShoppingCart
    {

        List<selectedProducts> shoppingCartProducts;
        float totalPrice;

        public ShoppingCart() {
            shoppingCartProducts = new List<selectedProducts>();
        }

        public void showGUI()
        {

            string userInput;
            
                Console.WriteLine("****************");
                Console.WriteLine("\tShopping Cart\t");
                Console.WriteLine("****************");
                Console.WriteLine("\n\n\n");
                Console.WriteLine(
                    "Here is a list of all your currently selected items:\n"
                    );

            foreach (selectedProducts i in shoppingCartProducts) {
                Console.WriteLine("ID: " + i.id + "\tquantity: " + i.quantity + "\tprice: " + i.price);
            }
            calculateTotalPrice();

            Console.WriteLine("total price is: " + totalPrice);

                Console.WriteLine( "enter a product ID to remove or change the buying quantity: " +
                    "or enter \"exit\" to return to navigation \n\n");
            while (true)
            {
                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    Console.WriteLine("returning to navigation\n");
                    break;
                }
                bool isValidShoppingCartItem = false;
                bool exit = false;
                int newQuantity;
                for (int i = 0; i < shoppingCartProducts.Count; i++) {
                    if (shoppingCartProducts[i].id == Int32.Parse(userInput)) {
                        isValidShoppingCartItem = true;

                        while (true)
                        {
                            Console.WriteLine("enter \"remove\" to remove the item, \"exit\" to return to the shopping cart, or enter a new buying quantity.");
                            userInput = Console.ReadLine();

                            if (userInput == "exit")
                            {
                                exit = true;
                                break;
                            }

                            if (userInput == "remove")
                            {
                                shoppingCartProducts.Remove(shoppingCartProducts[i]);
                                break;
                            }

                            newQuantity = Int32.Parse(userInput);
                            selectedProducts currentProduct = shoppingCartProducts[i];                            
                            currentProduct.quantity = newQuantity;
                            shoppingCartProducts[i] = currentProduct;

                        }
                    }
                }

                if (exit)
                {
                    break;
                }


                if (!isValidShoppingCartItem) {
                    Console.WriteLine("error, incorrect product ID entered, try again.");
                }

            }

        }

        public void calculateTotalPrice() {

            float total = 0;

            foreach (selectedProducts i in shoppingCartProducts) {
                total += i.price * i.quantity;
            }

            totalPrice = total;
        }

        public void addProduct(int product, int quantity, float price) {

            bool isProductAlreadyInCart = false;
            selectedProducts currentProduct, newProduct; 

            for (int i = 0; i < shoppingCartProducts.Count;i++) {
                if (product == shoppingCartProducts[i].id) {

                    isProductAlreadyInCart = true;
                    currentProduct = shoppingCartProducts[i];
                    currentProduct.quantity += quantity;

                    shoppingCartProducts[i] = currentProduct;
                }
            }

            if (!isProductAlreadyInCart) {
                newProduct = new selectedProducts();
                newProduct.id = product;
                newProduct.quantity = quantity;
                newProduct.price = price;
                shoppingCartProducts.Add(newProduct);
            }

            calculateTotalPrice();

        }

        public List<selectedProducts> getShoppingCartProductsList() { 
            return shoppingCartProducts;
        }

        public float getTotalPrice() { 
            return totalPrice;
        }

    }
}
