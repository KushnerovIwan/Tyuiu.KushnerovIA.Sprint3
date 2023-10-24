using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint3.Task0.Lib;
namespace Tyuiu.KushnerovIA.Sprint3.Task0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();


            int startValue = 1;
            int stopValue = 10;
            double wait = 81.083;

            Assert.AreEqual(wait, ds.GetSumSeries(startValue, stopValue));
        }
    }
}
