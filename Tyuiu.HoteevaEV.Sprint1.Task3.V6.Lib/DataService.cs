using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HoteevaEV.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            return ((gasFlow * distance) / 100) * gasPrice * 2;
        }
    }
}
