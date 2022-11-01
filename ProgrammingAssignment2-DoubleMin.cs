//****************************************************************************
//****************************************************************************
//
// Christian Parker
// CSCI 1301-B
// Programming Assignment 2
// Deadline: 02/17/2020
//
// DoubleMin.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace Programming_Assignment_2
{
    class DoubleMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the DoubleMin exercise.");

            // Creating Variables
            string name = "user";
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int holder = 0;

            // Getting User's Input
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Please enter five numbers.");
            Console.WriteLine("First: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Third: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fourth: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fifth: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            // Calculating Order of Variables
            for (int x = 0; x < 5; x++)
            {
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
                if (num3 > num4)
                {
                    holder = num3;
                    num3 = num4;
                    num4 = holder;
                }
                if (num4 > num5)
                {
                    holder = num4;
                    num4 = num5;
                    num5 = holder;
                }
            }
            
            //Outputs the user's name and the sorted order of values
            if (num1 == num2)
            {
                Console.WriteLine("Hello " + name + ". Your two smallest number were both " + num1 + ".");
            } else
            {
                Console.WriteLine("Hello " + name + ". Your two lowest numbers are " + num1 + " and " + num2 + ".");
            }
        }
    }
}
