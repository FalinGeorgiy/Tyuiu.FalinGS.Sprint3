using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FalinGS.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multseries = 1;

            while (startValue <= stopValue)
            {
                
                multseries = multseries + (((0.5 / (startValue / 5)))/ (Math.Cos(value) + 0.5));
                multseries = Math.Pow(multseries, 3);
                startValue++;
            }
            return Math.Round(multseries, 3);
        }
    }
}
