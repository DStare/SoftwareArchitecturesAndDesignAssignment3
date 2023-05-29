
namespace assignment3;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Checkout checkout = new Checkout();
        Catalogue catalogue = new Catalogue();
        ShoppingCart shoppingCart = new ShoppingCart();
        Account account = new Account();
        Navigation navigation = new Navigation(ref catalogue,ref checkout,ref account,ref shoppingCart);
        navigation.shNavOptions();


    }
}