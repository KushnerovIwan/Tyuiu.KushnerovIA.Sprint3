﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KushnerovIA.Sprint3.Task0.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Pow(1 / Math.Sin(i), 2);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
