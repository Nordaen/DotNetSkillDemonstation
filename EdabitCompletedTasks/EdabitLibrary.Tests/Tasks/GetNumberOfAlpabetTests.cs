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
        /// <summary>
        /// test method for GetNumberAlphabetFromString fuction.
        /// </summary>
        [TestMethod()]
        public void GetNumbersAlphabetFromStringTest()
        {
            //create testable object
            var task = new GetNumberOfAlpabet();
            //argument for function
            string x = "hi";
            //expected output
            string expected = "8 9";
            //actual output from object
            string actual = task.GetNumbersAlphabetFromString(x);
            //throw exception if not equal 
            Assert.AreEqual(expected, actual);
        }
    }
}