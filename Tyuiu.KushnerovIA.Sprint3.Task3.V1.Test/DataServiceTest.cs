using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint3.Task3.V1.Lib;

namespace Tyuiu.KushnerovIA.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string value = "have a nice time";
            char item = 'a';
            int res = ds.GetCharCount(value, item);
            int wait = 2;

            Assert.AreEqual(res, wait);
        }
    }
}
