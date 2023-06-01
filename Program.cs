
namespace assignment3;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Checkout checkout = new Checkout();
        ShoppingCart shoppingCart = new ShoppingCart();

        Catalogue catalogue = new Catalogue();
        
        Account account = new Account();
        Navigation navigation = new Navigation(ref catalogue,ref checkout,ref account,ref shoppingCart);
        navigation.shNavOptions();


    }
}