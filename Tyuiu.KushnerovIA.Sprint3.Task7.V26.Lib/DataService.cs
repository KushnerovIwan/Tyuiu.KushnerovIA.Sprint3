using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KushnerovIA.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res;
            res = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2*x - 0.5 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = 5 - 3*x + (1+Math.Sin(x))/((double)(2*x-0.5));
                }
                res[cnt] = Math.Round(y, 2);
                cnt++;
            }
            return res;
        }
    }
}
