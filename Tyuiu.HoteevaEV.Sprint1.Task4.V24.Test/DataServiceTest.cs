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
            double wait = 0.287;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);
        }
    }
}