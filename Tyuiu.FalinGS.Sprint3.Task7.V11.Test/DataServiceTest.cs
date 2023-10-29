using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.FalinGS.Sprint3.Task7.V11.Lib;

namespace Tyuiu.FalinGS.Sprint3.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;

            valueWaitArray = new double[len];

            valueWaitArray[0] = 20.36;
            valueWaitArray[1] = 15.42;
            valueWaitArray[2] = 10.99;
            valueWaitArray[3] = 0.1;
            valueWaitArray[4] = 0.1;
            valueWaitArray[5] = 0.1;
            valueWaitArray[6] = 0.1;
            valueWaitArray[7] = 0.1;
            valueWaitArray[8] = 0.1;
            valueWaitArray[9] = 0.1;
            valueWaitArray[10] = 0.1;

            double[] res;

            res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);


        }
    }
}
