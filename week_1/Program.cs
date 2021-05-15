using System;

namespace week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            double x = (Math.Pow(6, 2) - 1) / 2;
            Console.WriteLine($"Результат вычисления: {x}");
        }
    }
}
