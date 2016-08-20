using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyHelpers
{
    public class Task
    {
        /// <summary>
        /// This class creates a task that needs to be done.
        /// </summary>
        #region Properties

        [Key]
        public int Id { get; private set; }

        public string TaskName { get; set; }

        [Display(Name="Category")]
        public TaskTypes TypeOfTask { get; set; }

        public string TaskDescription { get; set; }

        public bool Completed { get; set; }
        public virtual User User { get; set; }
        #endregion

    }
}
