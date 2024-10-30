using Tyuiu.GubanovaSO.Sprint3.Task0.V22.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            double a = 0.25;
            int startValue = 1;
            int stopValue = 8;

            Console.WriteLine("Переменная а = " + a);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Сумму ряда = " + ds.GetMultiplySeries(a, startValue, stopValue));
        }
    }
}
