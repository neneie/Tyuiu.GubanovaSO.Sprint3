using Tyuiu.GubanovaSO.Sprint3.Task4.V11.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task4.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();    
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int start, end;
            Console.WriteLine("Введите начало цикла: ");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВведите конец цикла: ");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(start, end));
        }
    }
}
