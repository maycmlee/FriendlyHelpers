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

        public static Task addTask(string category, string taskName, string description)
        {
            var task1 = new Task();
            // task1.User = user;
            // Console.Write("What kind of help do you need? (Shopping, Cleaning, Cooking, Childcare): ");
            task1.Category = category;
            DetermineTaskType(task1, task1.Category);
            // Console.Write("Task name (eg. Katie Afterschool): ");
            task1.TaskName = taskName;
            //Console.Write("Task Description (eg. Pick Katie up from school.  Give snack.  Help with her homework.): ");
            task1.TaskDescription = description;
            //Console.Write("Date and Time you need it completed (eg. ..format?): ");
            //task1.DateandTime = Console.ReadLine();
            // Have to figure out format for date and time
            task1.Completed = false;

            var db = new FriendlyHelperModel();
            db.Tasks.Add(task1);
            db.SaveChanges();
            db.Dispose();

            return task1;
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

        #region Helper Methods
        /// <summary>
        /// Sets the correct task type entered by user to the TaskType enum
        /// </summary>
        /// <param name="task">Task object being created</param>
        /// <param name="taskType">Task type entered by user</param>
        private static void DetermineTaskType(Task task, string taskType)
        {
            switch (taskType)
            {
                case "Shopping":
                    task.TypeOfTask = TaskTypes.Shopping;
                    break;

                case "Cleaning":
                    task.TypeOfTask = TaskTypes.Cleaning;
                    break;

                case "Cooking":
                    task.TypeOfTask = TaskTypes.Cooking;
                    break;

                case "Childcare":
                    task.TypeOfTask = TaskTypes.Childcare;
                    break;
            }
        }
        #endregion

    }
}
