using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdabitLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitLibrary.Tests
{
    [TestClass()]
    public class EdabitTaskTests
    {

       

        [TestMethod()]
        public void GetStringDescribeTest1()
        {
            var TestClass = new TestEdabitObjectTest("str1", "str2");
            string Actual = "Name of task: " + "str1" + "\nDescription: " + "str2";
            Assert.AreEqual(TestClass.GetStringDescribe(), Actual);
        }
    }
    [TestClass()]
     internal sealed class TestEdabitObjectTest : EdabitTask
    {
        public TestEdabitObjectTest(string name,string description)
        {
            Name = name;
            Description = description;
        }
    }
}