using EdabitLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sample for using static functions in code
using static System.Console;

namespace EdabitLibrary
{
    /// <summary>
    /// main parent class for task classes
    /// </summary>
    public abstract class EdabitTask : IEdabitTask
    {
        /// <summary>
        /// Name of task
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of task
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Print Name and Description in console
        /// </summary>
        public void DescribeConsole ()
        {
            WriteLine(GetStringDescribe());
        }
        /// <summary>
        /// Get string from Name and Description
        /// </summary>
        /// <returns></returns>
        public string GetStringDescribe()
        {
            return "Name of task: " + Name + "\nDescription: " + Description;
        }        
    }
}
