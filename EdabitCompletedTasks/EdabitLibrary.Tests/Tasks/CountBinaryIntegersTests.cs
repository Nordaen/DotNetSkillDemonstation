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
        /// <summary>
        /// Test method for ToBinary function
        /// </summary>
        [TestMethod()]
        public void ToBinaryTest()
        {
            //create testable object
            var task = new CountBinaryIntegers();
            //create argument
            int x = 12;
            //expected value
            int expected = 2;
            //actual value from object
            int actual = task.CountIntBinary(x);
            //throw exception if values are not equal
            Assert.AreEqual(actual, expected);
        }
    }
}