using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HoteevaEV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] str = value.Split(' ');
            foreach (string w in str)
            {
                char[] s = w.ToArray();
                string value2 = "";
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    value2 += s[j];
                }
                if (w == value2)
                {
                    return value2;
                }
            }
            return "0";
        }
    }
}
