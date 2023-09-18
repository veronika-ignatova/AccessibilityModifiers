using CustomerLib;
using OrderLib;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.SetUserName("Veronika", "Ihnatova");
        Console.WriteLine(customer.UserName);
        customer.UserName = "Veronika";
        Console.WriteLine(customer.UserName);
        //Order order = new Order();
        //Item item = new Item();
        //item.Name = "item1";
    }
}