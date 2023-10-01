using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShunanovKE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 3;
            int y = 4;
            int z = 7;

            Assert.AreEqual(70, DataService.Calc(x, y, z));
        }
    }
}
