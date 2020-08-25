using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetTasksTest()
        {
            Service1 serv = new Service1();
            var list = serv.GetTasks();
            if (list == null && list.Count < 0)
                Assert.Fail();

        }
    }
}