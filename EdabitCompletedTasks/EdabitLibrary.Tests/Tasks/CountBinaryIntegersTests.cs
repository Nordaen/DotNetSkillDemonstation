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
    public class CountBinaryIntegersTests
    {
        [TestMethod()]
        public void ToBinaryTest()
        {
            var task = new CountBinaryIntegers();
            int x = 12;
            int expected = 2;
            int actual = task.CountIntBinary(x);
            Assert.AreEqual(actual, expected);
        }
    }
}