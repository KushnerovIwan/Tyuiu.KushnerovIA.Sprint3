using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint3.Task2.V9.Lib;

namespace Tyuiu.KushnerovIA.Sprint3.Task2.V9.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int n = 5, start = 1, end = 10;
            double res = ds.GetSumSeries(n, start, end);
            double wait = 0.042;

            Assert.AreEqual(res, wait);
        }
    }
}
