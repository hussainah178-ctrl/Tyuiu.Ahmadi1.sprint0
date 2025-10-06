using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.Ahmadi1.Sprint0.Task2.V0.Lib;

namespace Tyuiu.Ahmadi1.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChekGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "ahmadi mohamad hussain";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, ahmadi mohamad hussain", res);
        }
    }
}
