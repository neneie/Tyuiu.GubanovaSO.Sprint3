using Tyuiu.GubanovaSO.Sprint3.Task1.V24.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task1.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int start = 1;
            int end = 12;
            Console.WriteLine("Переменная x: " + x);
            Console.WriteLine("Старт шага: " + start);
            Console.WriteLine("Конец шага: " + end);


            double res = ds.GetSumSeries(x, start, end);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведения ряда: " + res);
        }
    }
}
