﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomarovMA.Sprint2.Task2.V27.Lib;
namespace Tyuiu.KomarovMA.Sprint2.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4, y = 4;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
