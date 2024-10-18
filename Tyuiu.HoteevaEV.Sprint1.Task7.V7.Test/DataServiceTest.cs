using Tyuiu.HoteevaEV.Sprint1.Task7.V7.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-9.288 , res);
        }
    }
}