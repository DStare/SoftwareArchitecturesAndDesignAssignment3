
namespace assignment3;
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Products Apple = new Products(1, "Apple", 4);
        //Console.WriteLine(Apple.ProductID);

        ShoppingCart _shoppingCart = new ShoppingCart();
        Catalogue _catalogue = new Catalogue();
        _catalogue.AddProduct(new Products(10, "Banana", 3));
        _catalogue.AddProduct(new Products(13, "Apple", 2));
        _catalogue.AddProduct(new Products(19, "Pear", 3));
        IEnumerable<Products> display;
        display = _catalogue.Display();
        _catalogue.PlaceOrder(display, _shoppingCart);
        _shoppingCart.testGui();
        //Console.WriteLine("this is ur total"+_shoppingCart.CalculateTotal());
        
        


        

        /*
        Checkout checkout = new Checkout();
        Catalogue catalogue = new Catalogue();
        ShoppingCart shoppingCart = new ShoppingCart();
        Account account = new Account();
        Navigation navigation = new Navigation(ref catalogue,ref checkout,ref account,ref shoppingCart);
        navigation.shNavOptions();*/


    }
}