using Tyuiu.HoteevaEV.Sprint1.Task6.V5.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string word = "хороший шалаш";
            var res = ds.CheckSymmetricalWords(word);
            Assert.AreEqual("шалаш", res);

        }
    }
}