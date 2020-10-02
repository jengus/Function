using System;

namespace Function
{
    class Program
    {
        static double check(string b)
        {
            if (!Double.TryParse(b, out double a))
            {
                Console.WriteLine("Перезапустите программу и введите данные корректно.");
                return 0;
            }
            else return Double.Parse(b);        
        }
        static double sqr (double x)
        {
            return (x*x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное значение");
            double min = check(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение");
            double max = check(Console.ReadLine());
            Console.WriteLine("Введите шаг построения");
            double step = check(Console.ReadLine());
           
            for (double i = min; i <= max; i+=step)
            {
                Console.WriteLine($"{Math.Round(i, 6)} {Math.Round(sqr(i), 6)}");
            }
        }
    }
}
