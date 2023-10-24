using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KushnerovIA.Sprint3.Task1.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            int k = startValue;
            while (k <= stopValue)
            {
                res *= Math.Pow((0.5 + ((double) k / 5)) / (Math.Cos(value) + 0.5), 3);
                k++;
            }
            return Math.Round(res, 3);
        }
    }
}
