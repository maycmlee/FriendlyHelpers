﻿using System;
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
    /// 
    public enum TaskTypes
    {
        Shopping = 1,
        Cleaning = 2,
        Cooking = 3,
        Childcare = 4
    }
    public static class FriendlyHelper
    {
    
        #region Methods

        public static User RegisterUser(string firstName, string lastName, string address, string emailAddresss, string phone)
        {
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                EmailAddress = emailAddresss,
                Phone = phone
            };

            var db = new FriendlyHelperModel();
            db.Users.Add(user);
            db.SaveChanges();
            db.Dispose();
            return user;
        }
        #endregion  

    }
}
