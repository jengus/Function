using System;

namespace Function
{
    class Program
    {
        static double sqr (double x)
        {
            return (x*x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное значение");
            double min = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение");
            double max = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг построения");
            double step = double.Parse(Console.ReadLine());

            for (double i = min; i <= max; i+=step)
            {
                Console.WriteLine($"{Math.Round(i, 6)} {Math.Round(sqr(i), 6)}");
            }
        }
    }
}
