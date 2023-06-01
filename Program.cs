
namespace assignment3;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Account account = new Account();
        ShoppingCart shoppingCart = new ShoppingCart();
        Checkout checkout = new Checkout(ref shoppingCart, ref account);
        Catalogue catalogue = new Catalogue(ref shoppingCart);
        
        Navigation navigation = new Navigation(ref catalogue,ref checkout,ref account,ref shoppingCart);
        navigation.shNavOptions();


    }
}