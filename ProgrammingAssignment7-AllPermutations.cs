//****************************************************************************
//****************************************************************************
//
// Christian Parker
// CSCI 1301A/B
// Programming Assignment 7
// Deadline: Friday, April 24th, 2020.
//
// AllPermutations.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace AllPermutations
{
    class Program
    {
        static int LIMIT = 3;
        static void Main(string[] args)
        {
            int[] Permutation = new int[LIMIT];

            // Initalisation of the permutation vector
            for (int i = 0; i < LIMIT; ++i)
            {
                Permutation[i] = i + 1;
            }

            Permutations(LIMIT, ref Permutation); // You are asked to implement this method

        }
        static void Permutations(int n, ref int[] Permutation)
        {
            // DO NOT change any code above this line
            // write your code below this line, make sure you report all permutations here
            if (n > 1)
            {
                for (int x = 0; x<LIMIT; x++)
                {
                    Swap((n - 1), (n-2), ref Permutation);
                    Console.Write("Random Permutation is ["); // Final printout of elemnts in Permutation[0..LIMIT-1]
                    for (int i = 0; i < LIMIT; ++i)
                    {
                        Console.Write(Permutation[i]);
                        if (i + 1 < LIMIT) Console.Write(",");
                    }
                    Console.WriteLine("]");
                    Permutations((n - 1), ref Permutation);

                }

            }



            // write yuor code above this line
            // DO NOT change any code below this line
        }

        static void Swap(int i, int j, ref int[] Array)
        {
            int temp = Array[i];
            Array[i] = Array[j];
            Array[j] = temp;
        }
    }
}