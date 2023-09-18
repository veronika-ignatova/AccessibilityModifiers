using CustomerLib;
internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.SetUserName("a", "b");
        Console.WriteLine(customer.UserName);
        customer.UserName = "c";
        Console.WriteLine(customer.UserName);

    }
}