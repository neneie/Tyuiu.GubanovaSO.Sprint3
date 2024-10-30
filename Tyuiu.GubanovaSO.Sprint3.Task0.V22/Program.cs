using Tyuiu.GubanovaSO.Sprint3.Task0.V22.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine(" Написать программу используя цикл for, которая вычисляет произведение   ");
            Console.WriteLine("ряда по формуле, при a=0,25                                              ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");

            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            Console.WriteLine("Переменная а = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага = " + stopValue);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
