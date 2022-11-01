//**************************************************
//**************************************************
//
// Christian Parker
// CSCI 1301 AB
// Lab Exercise 8
// Deadline April 15, 2020
//
// LE8.cs
//
//**************************************************
//**************************************************
using System;

namespace RandomPermutation
{
    class Program
    {
        static int LIMIT = 10; // You can manipulate this size if you want to
        static void Main(string[] args) // the Main method
        {
            int[] Permutation = new int[LIMIT]; // Creation of array Permutation[0..LIMIT-1]

            Console.Write("Initial Permutation is ["); // Initialization of Permutation[0..LIMIT-1]
            for (int i = 0; i < LIMIT; ++i)
            {
                Permutation[i] = i + 1;
                Console.Write(Permutation[i]);
                if (i + 1 < LIMIT) Console.Write(",");
            }
            Console.WriteLine("]");

            RPermute(LIMIT, ref Permutation); // You are asked to implement this method recursively, see the pseudocode

            Console.Write("Random Permutation is ["); // Final printout of elemnts in Permutation[0..LIMIT-1]
            for (int i = 0; i < LIMIT; ++i)
            {
                Console.Write(Permutation[i]);
                if (i + 1 < LIMIT) Console.Write(",");
            }
            Console.WriteLine("]");

        }
        static void RPermute(int n, ref int[] Permutation)
        {

            if (n > 1)
            {
                Random random = new Random();
                int r = random.Next(0, (n - 2));
                Swap((n - 1), r, ref Permutation);
                RPermute((n - 1), ref Permutation);
            }
        }

        static void Swap(int i, int j, ref int[] Permutation) // Swap method, feel free to use it
        {
            int temp = Permutation[i];
            Permutation[i] = Permutation[j];
            Permutation[i] = Permutation[j];
            Permutation[j] = temp;
        }
    }
}