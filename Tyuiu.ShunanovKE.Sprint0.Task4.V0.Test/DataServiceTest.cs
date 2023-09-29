using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanivKE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.ShunanivKE.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(17, DataService.Addition(10, 7));
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(45, DataService.Subtraction(54, 9));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(46, DataService.Multiplication(23, 2));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
