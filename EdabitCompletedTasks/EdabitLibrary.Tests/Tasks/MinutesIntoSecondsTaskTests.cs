using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdabitLibrary.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitLibrary.Tasks.Tests
{
    [TestClass()]
    public class MinutesIntoSecondsTaskTests
    {
        [TestMethod()]
        public void MinuteIntoSecondsTest()
        {
            var task = new MinutesIntoSecondsTask();
            int x = 5;
            int expected = 300;
            int actual = task.ConvertMinutesToSeconds(x);
            Assert.AreEqual(actual, expected);


        }
    }
}