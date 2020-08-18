using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitLibrary.Tasks
{
    public class SumOfTwoNumbers : EdabitTask
    {
        public SumOfTwoNumbers() 
        {
            Name = "Return the Sum of Two Numbers";
            Description = "Create a function that takes two numbers as arguments and return their sum";
        }
        public int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
