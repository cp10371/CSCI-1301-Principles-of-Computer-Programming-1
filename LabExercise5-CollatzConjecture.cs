//****************************************
//****************************************
//
// Christian Parker
// CSCI 1301-B
// Lab Exercise 5
//
// CollatzConjecture.cs
//
//****************************************
//****************************************
using System;

namespace Lab_Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me your input number: ");
            int n = int.Parse(Console.ReadLine());

            int term = n;
            int counter = 0;
            float ratio = 0;

            // do not change this code above this line

            // if the previous term is even, the next term is one half of the previous term
            // if the previous term is odd, the next term is 3 times the previous term plus 1.
            while (term != 1)
            {
                if ((term % 2) == 0) // Even
                {
                    term = term / 2;
                    counter += 1;
                }
                else
                {
                    term = (term * 3) + 1;
                    counter += 1;
                }
            }
            // do not change this code below this line

            ratio = ((float)counter / (float)n);

            Console.WriteLine($"For the input number {n} we have {counter} loop while iterations which gives the anticipated ratio {ratio}. ");
        }
    }
}