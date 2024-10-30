using Tyuiu.GubanovaSO.Sprint3.Task2.V10.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double a = 7.5;

            Console.WriteLine("Переменная t = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение ряда = " + a);
        }
    }
}
