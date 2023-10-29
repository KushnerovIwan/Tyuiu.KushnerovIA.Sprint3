using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint3.Task4.V2.Lib;

namespace Tyuiu.KushnerovIA.Sprint3.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            int start = -1;
            int stop = 1;
            double wait = -0.54;
            Assert.AreEqual(wait, ds.Calculate(start, stop));
        }
    }
}
