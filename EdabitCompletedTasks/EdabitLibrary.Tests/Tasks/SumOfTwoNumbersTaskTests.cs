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
    public class SumOfTwoNumbersTaskTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            var task = new SumOfTwoNumbersTask();
            int actual = task.Sum(x, y);
            Assert.AreEqual(actual, expected);
            
        }
    }
}