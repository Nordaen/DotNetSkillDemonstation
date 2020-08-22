using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitLibrary.Interfaces
{
    interface IEdabitTask
    {
        //two main functions for abstract class
        string GetStringDescribe();
        void DescribeConsole();
    }
}
