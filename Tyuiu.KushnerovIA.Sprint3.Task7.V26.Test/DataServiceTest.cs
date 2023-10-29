using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint3.Task7.V26.Lib;

namespace Tyuiu.KushnerovIA.Sprint3.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -2, end = 2;
            int len = end - start + 1;
            double[] wait = new double[len];
            wait[0] = 10.98;
            wait[1] = 7.94;
            wait[2] = 3;
            wait[3] = 3.23;
            wait[4] = -0.45;
            double[] res = ds.GetMassFunction(start, end);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
