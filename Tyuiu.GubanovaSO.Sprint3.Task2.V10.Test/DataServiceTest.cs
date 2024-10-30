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
            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}