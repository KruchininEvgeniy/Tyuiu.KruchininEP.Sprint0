using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KruchininEP.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KruchininEP.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDidisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
