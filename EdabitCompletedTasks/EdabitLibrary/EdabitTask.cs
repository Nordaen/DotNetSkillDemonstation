using EdabitLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EdabitLibrary
{
    public abstract class EdabitTask : IEdabitTask
    {
        public string Name { get; set; }

        public string Description { get; set; }
        public void DescribeConsole ()
        {
            WriteLine(GetStringDescribe());
        }
        public string GetStringDescribe()
        {
            return "Name of task: " + Name + "\nDescription: " + Description;
        }        
    }
}
