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
        public Friend addFriend(User user)
        {
            var friend1 = new Friend();
            friend1.User = user;
            Console.WriteLine("Please enter your friend's information: ");
            Console.Write("First Name: ");
            friend1.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            friend1.LastName = Console.ReadLine();
            Console.Write("Address: ");
            friend1.Address = Console.ReadLine();
            Console.Write("Phone number: ");
            friend1.Phone = Console.ReadLine();

            var db = new FriendlyHelperModel();
            db.Friends.Add(friend1);
            db.SaveChanges();
            db.Dispose();
            return friend1;
        }

        public Task addTask()
        {
            var task1 = new Task();
            Console.WriteLine("Please enter the details of what kind of help you need:");
            Console.Write("What kind kind of help is it? (Shopping, Cleaning, Coooking, Childcare");
            task1.Category = Console.ReadLine();
            Console.Write("Please give a task name: ");
            task1.TaskName = Console.ReadLine();
            Console.Write("Task Description: ");
            task1.TaskDescription = Console.ReadLine();
            //Console.Write("Date and Time you need it completed (eg. ..format?): ");
            //task1.DateandTime = Console.ReadLine();
            // Have to figure out format for date and time

            task1.Completed = false;
            return task1;
        }
        #endregion
    }
}
