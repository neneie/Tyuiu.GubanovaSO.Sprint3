﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GubanovaSO.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            do
            {
                MultiplySeries = MultiplySeries * (Math.Pow(value, startValue) + 1 / startValue + 1);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(MultiplySeries, 3);
        }
    }
}
