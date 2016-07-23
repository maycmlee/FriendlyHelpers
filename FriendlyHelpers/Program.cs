using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyHelpers
{
    /// <summary>
    /// This program allows a user to add their friends to their account.
    /// User will also add tasks that she/he needs help getting done 
    /// (eg. shopping, cooking a meal, babysitting, etc.)
    /// Friends can sign up to do task(s).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = FriendlyHelper.RegisterUser("May", "Lee", "245 Main St, Somewhere, Some State, 34444", "888-8888");
        }
    }
}
