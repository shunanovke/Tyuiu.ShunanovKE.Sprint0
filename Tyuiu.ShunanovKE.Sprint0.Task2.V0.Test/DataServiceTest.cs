using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckgetMessageValid()
        {
            var name = "Кирилл";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Кирилл!", res);
        }
    }
}
