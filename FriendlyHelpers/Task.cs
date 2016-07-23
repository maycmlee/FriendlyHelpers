using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyHelpers
{
    class Task
    {
        /// <summary>
        /// This class creates a task that needs to be done.
        /// </summary>
        #region Properties
        public string TaskName { get; set; }
        public DateTime DateandTime { get; set; }
        public string Category { get; set; }
        public bool Completed { get; set; }
        #endregion


    }
}
