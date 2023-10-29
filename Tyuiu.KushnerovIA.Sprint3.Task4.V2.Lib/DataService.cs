using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KushnerovIA.Sprint3.Task4.V2.Lib
{
    public class DataService : ISprint3Task4V2
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1.0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                res = res * Math.Cos(x) / (double)(x);
            }
            return Math.Round(res, 3);
        }
    }
}
