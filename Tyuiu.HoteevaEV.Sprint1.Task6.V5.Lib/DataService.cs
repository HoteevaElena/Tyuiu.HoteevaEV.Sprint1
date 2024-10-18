using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HoteevaEV.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            char[] s = value.ToArray();
            string value2 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                value2 += s[i];
            }
            if(value == value2)
            {
                return value;
            }
            else
            {
                return "-1";
            }
        }
    }
}
