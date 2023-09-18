using OrderLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public abstract class User
    {
        public string UserName
        {
            get
            {
                return _fullName;
            }
            set
            {
                _fullName = _firstName + " " + _lastName;
            }
        }
        protected int OrderId {  get; set; }
        private string password;
        private string email;
        public string _firstName;
        public string _lastName;
        public string _fullName;

        public abstract string SetUserName(string firstName, string lastName);
    }
}
