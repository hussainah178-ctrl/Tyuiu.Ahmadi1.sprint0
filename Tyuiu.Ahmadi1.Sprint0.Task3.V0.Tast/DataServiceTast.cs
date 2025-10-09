using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Ahmadi1.Sprint0.Task3.V0.Lib;

namespace Tyuiu.Ahmadi1.Sprint0.Task3.V0.Tast
{
    [TestClass]
    public class DataServiceTast
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
