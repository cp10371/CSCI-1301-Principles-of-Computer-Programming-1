//****************************************************************************
//****************************************************************************
//
// Christian Parker
// CSCI 1301CD
// Lab Exercise 1
// 02/05/2020
//
// Sorter.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace Programming_Assignment_1
{
    class Sorter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the sorter exercise.");

            // Creating Variables
            string name = "user";
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int holder = 0;


            // Getting User's Input
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Please enter three numbers.");
            Console.WriteLine("First: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            // Calculating Order of Variables
            if (num1 > num3)
            {
                holder = num1;
                num1 = num3;
                num3 = holder;
            }
            if (num1 > num2)
            {
                holder = num1;
                num1 = num2;
                num2 = holder;
            }
            if (num2 > num3)
            {
                holder = num2;
                num2 = num3;
                num3 = holder;
            }

            //Outputs the user's name and the sorted order of values
            Console.WriteLine("Hello " + name + " your numbers in increasing value are " + num1 + ", " + num2 + ", and " + num3 + ".");

        }
    }
}
