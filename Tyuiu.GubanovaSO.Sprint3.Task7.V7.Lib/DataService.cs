﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GubanovaSO.Sprint3.Task7.V7.Lib
{
    public class DataService : ISprint3Task7V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double del = (x + 2);
                y = Math.Round(((Math.Cos(x) + Math.Cos(x) / del) - (3 * x)), 2);
                if (del == 0)
                {
                    y = 0;
                }
                else
                    valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
