namespace CustomerLib
{
    public class Customer : User, IUser
    {
        public override void SetFullName(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            Console.WriteLine($"{_firstName} {_lastName}");
        }

        public string GetFirstName()
        {
            return _firstName;
        }
    }
}