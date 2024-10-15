using Tyuiu.HoteevaEV.Sprint1.Task1.V14.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 5.0;
            double b = 5.0;
            double c = 5.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(5.5, res);
        }
    }
}