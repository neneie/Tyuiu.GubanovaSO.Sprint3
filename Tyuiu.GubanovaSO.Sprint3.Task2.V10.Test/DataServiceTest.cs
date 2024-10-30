using Tyuiu.GubanovaSO.Sprint3.Task2.V10.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task2.V10.Test
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
            double res = ds.GetMultiplySeries(1, 1, 13);
            double wait = 7.5;
            Assert.AreEqual(wait, res);
        }
    }
}