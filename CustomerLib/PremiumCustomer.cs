using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib
{
    public sealed class PremiumCustomer : Customer
    {
        private readonly string _userName = "admin";
        private readonly string _password = "admin";

        public PremiumCustomer()
        {
        }
        public PremiumCustomer(string userName, string password)
        {
            _userName = userName;
            _password = password;
        }

        public string UserName { get { return _userName; } }
        public string Password { get { return _password; } }
        public bool CheckPremium()
        {
            if (UserName == "admin" && Password == "admin")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        
    }
}
