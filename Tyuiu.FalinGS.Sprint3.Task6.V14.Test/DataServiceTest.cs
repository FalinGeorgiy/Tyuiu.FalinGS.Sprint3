using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint3.Task6.V14.Lib;


namespace Tyuiu.FalinGS.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisiors()
        {
            DataService ds = new DataService();

            int startValue = 7;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 13;
            Assert.AreEqual(wait, res);


        }
    }
}
