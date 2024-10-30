using Tyuiu.GubanovaSO.Sprint3.Task5.V17.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task5.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* X = 2                                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int x = 2;
            int start1 = 1;
            int start2 = 1;
            int end1 = 3;
            int end2 = 12;
            Console.WriteLine(ds.GetSumSumSeries(x, start1, start2, end1, end2));
        }
    }
}
