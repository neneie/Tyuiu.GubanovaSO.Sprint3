using Tyuiu.GubanovaSO.Sprint3.Task0.V22.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task0.V22.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 31.328;
            Assert.AreEqual(wait, res);
        }
    }
}