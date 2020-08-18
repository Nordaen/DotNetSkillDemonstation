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
    public class GetNumberOfAlpabetTests
    {
        [TestMethod()]
        public void GetNumbersAlphabetFromStringTest()
        {
            var task = new GetNumberOfAlpabet();
            string x = "hi";
            string expected = "8 9";
            string actual = task.GetNumbersAlphabetFromString(x);
            Assert.AreEqual(expected, actual);
        }
    }
}