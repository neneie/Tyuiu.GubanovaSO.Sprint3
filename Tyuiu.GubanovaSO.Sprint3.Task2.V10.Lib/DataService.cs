using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GubanovaSO.Sprint3.Task2.V10.Lib
{
    public class DataService : ISprint3Task2V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            double t = value;
            int k = startValue;
            do
            {
                p = p * ((Math.Pow(t, k) + 1) / (k + 1));
                k++;
            } while (k <= stopValue);
            return Math.Round(p, 3);
        }
    }
}
