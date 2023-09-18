using OrderLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public abstract class User : Order
    {
        public string UserName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = _firstName + _lastName;
            }
        }
        private int OrderId 
        { 
            get 
            {
                return OrderId;
            }
            set
            {
                OrderId = value;
            }
        }
        private string password;
        private string email;
        public string _firstName;
        public string _lastName;
        public string _fullName;

        public abstract string SetUserName(string firstName, string lastName);
    }
}
