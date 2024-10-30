using Tyuiu.GubanovaSO.Sprint3.Task7.V7.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task7.V7.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait;

            wait = new double[len];
            wait[0] = 15.19;
            wait[1] = 11.67;
            wait[2] = 9;
            wait[3] = 0;
            wait[4] = 4.08;
            wait[5] = 1.5;
            wait[6] = -2.28;
            wait[7] = -6.52;
            wait[8] = -10.19;
            wait[9] = -12.76;
            wait[10] = -14.68;
            double[] res = new double[len];

            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}