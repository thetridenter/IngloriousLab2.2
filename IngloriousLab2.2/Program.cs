using System;

namespace IngloriousLab2._2
{
    class Program
    {
        static void Main()
        {
            double y, x, dx;
            int a, b;

            Console.WriteLine("Задана функція — у^3");

            Console.WriteLine("Введіть значення а");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть значення dx");
            dx = double.Parse(Console.ReadLine());

            x = a;
            Console.WriteLine("\t x \t y = f(x)");

            do
            {
                y = x * x * x;
                Console.WriteLine("\t" + x + "\t" + y);
                x += dx;
            }
            while (x <= b);
        }
    }
}
