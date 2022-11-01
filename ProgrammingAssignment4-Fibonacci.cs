using System;

namespace ConsoleApp12
{
    class Fibonacci
    {
        static void Main(string[] args)
        {

            int n = 0;

            Console.Write("Please give me an index n of a Fibonacci word and number: ");
            n = int.Parse(Console.ReadLine());

            string unknown = "unknown";

            // do not change anyhting above this line
            // write your code below and replace value "unknown" with the correct answer

            int numAns = -1;

            if (n > 1)
            {
                numAns = (n - 1) + (n - 2);     // Creates the fibonacci number from the sum of the two previous numbers
            }
            else if (n == 1) { numAns = 1; }    // Special case for n = 1
            else if (n == 0) { numAns = 0; }    // Special case for n = 2

            Console.WriteLine($"Fibonacci number f({n})= {numAns}\n");

            int z = 2;                          // Used in the while loop condition

            int A1 = 0;                         //
            int A2 = 1;                         // Variables used in tracking the number of "a"s
            int A3 = 1;                         //

            int B1 = 1;                         //
            int B2 = 0;                         // Variables used in tracking the number of "b"s
            int B3 = 1;                         //

            string a = "a";                     //
            string b = "b";                     // Variables used to create the fibonacci word
            string wordAns = "";                //

            while (z < (n))                
            {
                    wordAns = b + a;            //
                    a = b;                      // Updates the word
                    b = wordAns;                //

                    A3 = A1 + A2;               //
                    A2 = A1;                    // Updates the number of "a"s
                    A1 = A3;                    //

                    B3 = B1 + B2;               //
                    B2 = B1;                    // Updates the number of "b"s
                    B1 = B3;                    //
                    
                    z += 1;                     // Updates the varible z so that the while loop isn't continuous
            }
            if (n == 1)
            {
                wordAns = "a";
                A3 = 1;
                B3 = 0;
            }                                   // Special case for n = 1
            else if (n == 2)
            {
                wordAns = "b";
                B3 = 1;
                A3 = 0;
            }                                   // Special case for n =2
            Console.WriteLine($"Fibonacci word fw({n})= {wordAns}\n");

            int counterWord = A3 + B3;         // Totals the "a"s and "b"s to make the length

            Console.WriteLine($"The length of the fibonacci word fw({n})= {counterWord}\n");
            Console.WriteLine($"The number of \"b\"s in fw({n})= {B3}");
            Console.WriteLine($"The number of \"a\"s in fw({n})= {A3}");
        }
    }
}
