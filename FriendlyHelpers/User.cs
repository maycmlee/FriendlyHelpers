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
            Console.Write("Address: ");
            friend1.Address = Console.ReadLine();
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

        public Task addTask(User user)
        {
            var task1 = new Task();
            task1.User = user;
            Console.Write("What kind of help do you need? (Shopping, Cleaning, Cooking, Childcare): ");
            task1.Category = Console.ReadLine();
            determineTaskType(task1, task1.Category);
            Console.Write("Task name (eg. Afterschool for Karen): ");
            task1.TaskName = Console.ReadLine();
            Console.Write("Task Description (eg. Pick Karen up from school.  Give snack.  Help with her homework.): ");
            task1.TaskDescription = Console.ReadLine();
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

        // This method is in the User class, do I have to pass in the user object?
        public IEnumerable<Task> GetAllTasksByUserEmail(string emailAddress)
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
        private void determineTaskType(Task task, string taskType)
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
