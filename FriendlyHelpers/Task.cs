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

        public string TaskDescription { get; set; }
        public string Category { get; set; }

        // The task needs to be completed by this date and time.
        public DateTime DateandTime { get; set; }
        public bool Completed { get; set; }
        public virtual User User { get; set; }
        #endregion


    }
}
