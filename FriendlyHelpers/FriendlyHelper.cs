using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyHelpers
{
    /// <summary>
    /// This is the factory class for registering
    /// new users.
    /// </summary>
    public static class FriendlyHelper
    {
    
        #region Methods

        public static User RegisterUser(string firstName, string lastName, string address, string phone)
        {
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Phone = phone
            };
            return user;
        }
        #endregion  

    }
}
