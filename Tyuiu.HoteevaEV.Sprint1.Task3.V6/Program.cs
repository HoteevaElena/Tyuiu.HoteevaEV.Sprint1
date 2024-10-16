using Tyuiu.HoteevaEV.Sprint1.Task3.V6.Lib;


namespace Tyuiu.HoteevaEV.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Хотеева Е. В. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки                         *");
            Console.WriteLine("* на автомобиле на дачу (туда и обратно).                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y, z;

            Console.WriteLine("Расстояние до дачи: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Расход бензина: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Цена литра бензина: ");
            z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Стоимость поездки на автомобиле на дачу: " + Math.Round(ds.TravelCost(x, y, z), 3));

            Console.ReadKey();
        }
    }
}
