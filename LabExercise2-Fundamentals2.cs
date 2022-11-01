//****************************************************************************
//****************************************************************************
//
// Christian Parker
// CSCI 1301CD
// Lab Exercise 2
// 02/10/2020
//
// Fundamentals2.cs
//
//***************************************************************************
//***************************************************************************
using System;

namespace Lab_Exercise_2
{
    class Fundamentals2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please Enter 2 Numbers");
            Console.WriteLine("Numer one: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numer two: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int absdiff = 0;

            //Calculates the absolute difference between number1 and number2
            if (number1 > number2)
            {
                absdiff = number1 - number2;
            }
            else
            {
                absdiff = number2 - number1;
            }

            //Performs desired calculations
            int x = number1 % 5;
            int y = number2 % 5;
            int z = absdiff % 5;

            //Output to user
            Console.WriteLine("Number one modulo 5: " + x);
            Console.WriteLine("Number two modulo 5: " + y);
            Console.WriteLine("Absolute Value: " + absdiff);
            Console.WriteLine("Absdiff modulo 5: " + z);

        }
    }
}
