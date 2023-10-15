using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint2.Task3.V8.Lib;
namespace Tyuiu.KomarovMA.Sprint2.Task3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-13);
            Assert.AreEqual(-142.615, res, 0.001);

        }
    }
}