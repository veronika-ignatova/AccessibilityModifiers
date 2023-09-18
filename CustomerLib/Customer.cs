namespace CustomerLib
{
    public sealed class Customer : User
    {
        public override string SetUserName(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            return $"{firstName} {lastName}";
        }
    }
}