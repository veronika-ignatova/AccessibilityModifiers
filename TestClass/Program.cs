

using TestClass;

internal class Program
{
    static void Main(string[] args)
    {
        Test test = new Test();
        test.Id = 1;
        test.DoTest();
        Console.WriteLine(test.Id);
    }
}