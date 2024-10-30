using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GubanovaSO.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double multiplication = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0) continue;
                multiplication *= ((x) / (Math.Sin(x) - x)) + 2;
            }
            return Math.Round(multiplication, 3);
        }
    }
}
