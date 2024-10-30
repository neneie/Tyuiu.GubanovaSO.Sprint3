using Tyuiu.GubanovaSO.Sprint3.Task4.V11.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task4.V11.Test
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
            int start = -5;
            int end = 5;
            double wait = 0.84;
            Assert.AreEqual(wait, ds.Calculate(start, end));
        }
    }
}