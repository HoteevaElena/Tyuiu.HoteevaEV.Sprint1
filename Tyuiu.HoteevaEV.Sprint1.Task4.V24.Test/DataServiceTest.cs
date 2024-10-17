using Tyuiu.HoteevaEV.Sprint1.Task4.V24.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 0.333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}