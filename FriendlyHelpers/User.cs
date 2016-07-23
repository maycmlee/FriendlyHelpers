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
        public string Phone { get; set; }
        #endregion

        #region Methods
        public Friend addFriend()
        {
            var friend1 = new Friend();
            Console.WriteLine("Please enter your friend's information: ");
            Console.Write("First Name: ");
            friend1.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            friend1.LastName = Console.ReadLine();
            Console.Write("Address: ");
            friend1.Address = Console.ReadLine();
            Console.Write("Phone number: ");
            friend1.Phone = Console.ReadLine();

            return friend1;
        }

        public Task addTask()
        {
            var task1 = new Task();
            Console.WriteLine("Please enter the details of what kind of help you need: );

        }
        #endregion
    }
}
