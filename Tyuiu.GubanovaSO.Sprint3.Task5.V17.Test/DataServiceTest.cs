using Tyuiu.GubanovaSO.Sprint3.Task5.V17.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task5.V17.Test
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
            int x = 2;
            int i = 1;
            int i2 = 3;
            int j = 1;
            int j2 = 12;
            double wait = 143.624;
            Assert.AreEqual(wait, ds.GetSumSumSeries(x, i, j, i2, j2));
        }
    }
}