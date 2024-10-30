using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GubanovaSO.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int i = startValue;
            int x = value;
            double p = 0;
            while (i <= stopValue)
            {
                p = p + Math.Pow((2 / (6 + Math.Pow(x, i))), i);
                i++;
            }
            return Math.Round(p, 3);
        }
    }
}
