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
            string word = "шалаш";
            var res = ds.CheckSymmetricalWords(word);
            Assert.AreEqual(word, res);

        }
    }
}