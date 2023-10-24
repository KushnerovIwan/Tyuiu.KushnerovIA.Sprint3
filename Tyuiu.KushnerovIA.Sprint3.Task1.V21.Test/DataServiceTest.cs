using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint3.Task1.Lib;

namespace Tyuiu.KushnerovIA.Sprint3.Task1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x = 1, start = 1, end = 12;
            double res = ds.GetMultiplySeries(x, start, end);
            double wait = 16947810.881;

            Assert.AreEqual(res, wait);
        }
    }
}
