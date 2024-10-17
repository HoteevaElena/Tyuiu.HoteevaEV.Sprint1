using Tyuiu.HoteevaEV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 4;
            double y1 = 6;
            double x2 = -3;
            double y2 = -5;
            var d = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(13, d);
        }
    }
}