using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyHelpers
{
    public class User
    {
        #region Properties
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        #endregion

        #region Methods
        public Friend addFriend(User user)
        {
            var friend1 = new Friend();
            friend1.User = user;
            Console.WriteLine("Please enter your friend's information: ");
            Console.Write("First Name: ");
            friend1.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            friend1.LastName = Console.ReadLine();
            Console.Write("Email Address: ");
            friend1.EmailAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            friend1.Phone = Console.ReadLine();

            var db = new FriendlyHelperModel();
            db.Friends.Add(friend1);
            db.SaveChanges();
            db.Dispose();
            return friend1;
        }

        #endregion

    }
}
