﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HoteevaEV.Sprint1.Task4.V24.Lib
{
    public class DataService : ISprint1Task4V24
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Log(x) * y) / (x + Math.Sqrt(2 * (Math.Pow(y, 2))));
            return Math.Round(res, 3);
        }
    }
}
