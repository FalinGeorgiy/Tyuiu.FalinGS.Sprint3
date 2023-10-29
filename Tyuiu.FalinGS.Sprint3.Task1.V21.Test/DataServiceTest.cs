using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.FalinGS.Sprint3.Task1.V21.Lib;

namespace Tyuiu.FalinGS.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultService()
        {
            DataService ds = new DataService();

            double value = 1;

            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);


        }
    }
}
