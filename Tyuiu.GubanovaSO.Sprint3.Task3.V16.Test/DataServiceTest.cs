using Tyuiu.GubanovaSO.Sprint3.Task3.V16.Lib;
namespace Tyuiu.GubanovaSO.Sprint3.Task3.V16.Test
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
            string str = "ice nice ice creamcc";
            char chr = 'c';

            int res = ds.GetCharCount(str, chr);
            int wait = 6;
            Assert.AreEqual(wait, res);
        }
    }
}