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
        //test method for testing MinuteIntoSeconds
        [TestMethod()]
        public void MinuteIntoSecondsTest()
        {
            //create testing object
            var task = new MinutesIntoSecondsTask();
            //input one
            int x = 5;
            //expected value
            int expected = 300;
            //actual value from object
            int actual = task.ConvertMinutesToSeconds(x);
            //if data is not equal - throw exception
            Assert.AreEqual(actual, expected);


        }
    }
}