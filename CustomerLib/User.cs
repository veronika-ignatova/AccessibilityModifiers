using OrderLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public abstract class User
    {
        protected string _firstName;
        protected string _lastName;
        protected string password;
        protected string email;
        public string FullName
        {
            get
            {
                return _firstName + " " + _lastName;
            }
        }
        protected int OrderId {  get; set; }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public abstract void SetFullName(string firstName, string lastName);
    }
}
