using CustomerLib;
using OrderLib;
using TestClass;

internal class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        customer.SetFullName("Veronika", "Ihnatova");
        Console.WriteLine(customer.FullName);
        customer.FirstName = "V";
        Console.WriteLine(customer.FullName);
        Console.WriteLine(customer.GetFirstName());
        Order order = new Order();
        order.CreatingOrder(100);
        //Console.WriteLine(order.Price);
        Item item = new Item();
        item.AddingItem("Item1");
        Console.WriteLine(item.Name);
        //readonly
        //item.Name = "item1";

        PremiumCustomer premium = new PremiumCustomer("a", "a");
        Console.WriteLine(premium.CheckPremium());
        Console.WriteLine(premium.UserName);

        PremiumCustomer premium2 = new PremiumCustomer();
        Console.WriteLine(premium2.CheckPremium());
        Console.WriteLine(premium2.UserName);

        Console.WriteLine("Checking order");
        Order order2 = new Order();
        //order.CreatingOrder(100, 50);
        order2.UserBirthDate = DateTime.Now.AddDays(366);
        //order2.UserBirthDate = DateTime.Now;
        Console.WriteLine("Discount: "+order2.Discount);


        Test test = new Test();
        test.DoTest();
    }
}