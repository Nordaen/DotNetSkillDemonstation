using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EdabitLibrary.Tasks
{
   public  class CountBinaryIntegers : EdabitTask
    {
        public CountBinaryIntegers()
        {
            Name = "Count Ones in Binary Representation of Integer";
            Description = "Count the amount of ones in the binary representation of an integer. So for example, since 12 is '1100' in binary, the return value should be 2.";
        }


        public int CountIntBinary(int Number)
        {
            string result = Convert.ToString(Convert.ToInt32(Number.ToString(), 10), 2);
            return  result.Where(x => x == '1').Count();
            //comm
        }
    }
}
