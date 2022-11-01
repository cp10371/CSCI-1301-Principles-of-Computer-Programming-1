using System;

namespace Lab_Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.WriteLine("Please enter a number greater than 1");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 1);

            for (int a = 1; a <= n; ++a)
            {
                for (int b =1; b <= n; ++b)
                {
                    if (a < b)
                    {
                        Console.WriteLine($"({a}, {b})");
                    }
                }
            }




        }
    }
}
