using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ShunanovKE.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckAdditionSubtractionValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionSubtraction(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckAdditionMultiplyValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionMultiply(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
