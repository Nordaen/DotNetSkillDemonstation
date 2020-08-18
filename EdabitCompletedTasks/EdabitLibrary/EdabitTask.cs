using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EdabitLibrary
{
    public abstract class EdabitTask
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
        public EdabitTask(string name,string description)
        {
            if (!string.IsNullOrEmpty(name)|| !string.IsNullOrEmpty(description))
            {
                Name = name;
                Description = description;

            }
            else
            {
                throw new Exception("Some of argument strings null or empty.");
            }
        }
    }
}
