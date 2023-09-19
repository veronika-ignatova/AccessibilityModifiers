internal class Program
{
    public class MyClass
    {
        private int MyProperty { get; set; }

        public MyClass(int b)
        {
            MyProperty = b;
        }

        public override bool Equals(object? otherInstance)
        {
            return otherInstance is MyClass &&
                    this.MyProperty == (otherInstance as MyClass).MyProperty;
        }
    }

    static void Main(string[] args)
    {
        MyClass a = new MyClass(12);
        MyClass b = new MyClass(11);
        bool test1 = a.Equals(b);
        b = new MyClass(12);
        bool test2 = a.Equals(b);

        Console.ReadLine();
    }
}