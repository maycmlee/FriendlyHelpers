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

        public static Task addTask(string taskName, string description, User user)
        {
            var task1 = new Task();
            task1.User = user;
            task1.TaskName = taskName;
            task1.TaskDescription = description;
            task1.Completed = false;

            var db = new FriendlyHelperModel();
            db.Tasks.Add(task1);
            db.SaveChanges();
            db.Dispose();

            return task1;
        }

        public static User GetUserByEmail(string emailAddress)
        {
            var db = new FriendlyHelperModel();
            return db.Users.Where(c => c.EmailAddress.ToLower() == emailAddress.ToLower()).FirstOrDefault();
        }
        public static IEnumerable<Task> GetAllTasksByUserEmail(string emailAddress)
        {
            var db = new FriendlyHelperModel();
            var user = db.Users.Where(u => u.EmailAddress == emailAddress).FirstOrDefault();
            if (user == null)
                return null;

            return db.Tasks.Where(t => t.User.Id == user.Id);
            // One line method:
            //var tasks = db.Tasks.Where(t => t.User.EmailAddress == emailAddress);

        }
        #endregion

    }
}
