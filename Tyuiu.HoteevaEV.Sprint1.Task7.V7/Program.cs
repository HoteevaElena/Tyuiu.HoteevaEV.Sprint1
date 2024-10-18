using Tyuiu.HoteevaEV.Sprint1.Task7.V7.Lib;

namespace Tyuiu.HoteevaEV.Sprint1.Task7.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Хотеева Е. В. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Хотеева Елена Вячеславовна | ИИПб-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*          cos(x)                                                         *");
            Console.WriteLine("* z = ---------------- + 16 * x * cos(x * y) - 2                          *");
            Console.WriteLine("*      pi - 2 * y ^ x                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("        cos(x)");
            Console.WriteLine("z = ---------------- + 16 * x * cos(x * y) - 2 = " + ds.Calculate(x, y));
            Console.WriteLine("    pi - 2 * y ^ x");


            Console.ReadKey();
        }
    }
}
