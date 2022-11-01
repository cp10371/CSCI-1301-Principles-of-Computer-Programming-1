//**************************************************
//**************************************************
//
// Christian Parker
// CSCI 1301 AB
// Programming Assignment 6
// Deadline: Friday, April 17th, 2020
//
// HelloPie.cs
//
//**************************************************
//**************************************************

using System;

namespace Programming_Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Please enter the number of n terms you would like to calculate to: ");
            n = int.Parse(Console.ReadLine());

            int counter = 0;
            int multiply = 1;
            int nextNumber = 3;    
            decimal CurrentPi = 1;
            decimal answer = 1;

            decimal Calculate()
            {
                multiply = multiply * -1;
                answer = answer + multiply * (decimal)1 / (nextNumber);
                CurrentPi = answer*4;
                nextNumber += 2;
                counter += 1;
                if (counter == n)
                {
                    return CurrentPi;
                }
                else
                {
                    Calculate();
                }
                return CurrentPi;
            }
            Console.WriteLine($"Your pi number after {n} iterations is: {Calculate()}\n");
        }
    }
}
