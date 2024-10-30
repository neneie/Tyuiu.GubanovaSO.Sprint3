using Tyuiu.GubanovaSO.Sprint3.Task1.V24.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task1.V24.Test
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
            int x = 5;
            int start = 1;
            int end = 12;
            double res = ds.GetSumSeries(x, start, end);
            double wait = 0.186;
            Assert.AreEqual(res, wait);
        }
    }
}