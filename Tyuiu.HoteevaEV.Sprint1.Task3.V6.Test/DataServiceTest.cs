using Tyuiu.HoteevaEV.Sprint1.Task3.V6.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 67; 
            double y = 8.5; 
            double z = 6.5; 
            var res = Math.Round(ds.TravelCost(x, y, z), 3);
            Assert.AreEqual(74.035, res);

        }
    }
}