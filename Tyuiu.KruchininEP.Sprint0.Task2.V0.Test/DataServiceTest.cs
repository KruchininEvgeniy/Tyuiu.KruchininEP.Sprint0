using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KruchininEP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KruchininEP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Евгений";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Евгений", res);
        }
    }
}
