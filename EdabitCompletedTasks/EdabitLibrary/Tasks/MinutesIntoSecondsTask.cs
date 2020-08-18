using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitLibrary.Tasks
{
    public class MinutesIntoSecondsTask : EdabitTask
    {
        public MinutesIntoSecondsTask()
        {
            Name = "Convert Minutes into Seconds";
            Description = "Write a function that takes an integer minutes and converts it to seconds.";
        }
        public int ConvertMinutesToSeconds(int Minute)
        {
            TimeSpan span = TimeSpan.FromMinutes(Minute);
            return Convert.ToInt32(span.TotalSeconds);
        }
    }
}
