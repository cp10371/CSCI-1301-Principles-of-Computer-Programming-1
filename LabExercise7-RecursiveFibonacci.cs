//**************************************************
//**************************************************
//
// Christian Parker
// CSCI 1301 AB
// Lab Exercise #7
// Deadline April 15, 2020
//
// RecursiveFibonacci.cs
//
//**************************************************
//**************************************************
using System;

namespace Lab_Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            int answer= -1;
            string answer1 = "-1";

            Console.Write("Please give me an index n of a Fibonacci word and number: ");
            n = int.Parse(Console.ReadLine());

            string unknown = "unknown";

            // do not change anyhting above this line
            // write your code below and replace value "unknown" with the correct answer
            
            int FibNum(int x, int prv, int pre, int trm)
            {
                if (x == 1 && trm != 0)
                {
                    return trm;
                }
                if (x == 0)
                {
                    answer = 0;
                    return answer;
                }
                else if (x == 1)
                {
                    answer = 1;
                    return answer;
                }
                else
                {
                        trm = prv + pre;
                        prv = pre;
                        pre = trm;
                        answer = trm;
                    FibNum(x-1, prv, pre, trm);
                    return answer;
                }
            }

            Console.WriteLine($"Fibonacci number f({n})= {FibNum(n, 0, 1, 0)}\n");

            string FibWord(int x, string a, string b, string wordAns)
            {
                if (x == 2 && wordAns != "")
                {
                    return wordAns;
                }
                if (x == 1)
                {
                    answer1 = "a";
                    return answer1;
                }
                else if (x == 2)
                {
                    answer1 = "b";
                    return answer1;
                }
                else
                {
                        wordAns = b + a;
                        a = b;
                        b = wordAns;
                        answer1 = wordAns;
                    FibWord(x - 1, a, b, wordAns);
                    return answer1;
                }
            }

            Console.WriteLine($"Fibonacci word fw({n})= {FibWord(n, "a", "b", "")}\n");

            int FibWordLength(int x, int length1, int length2, int length3)
            {
                if (x==2 && length3 != -1)
                {
                    return length3;
                }

                if (x == 0)
                {
                    answer = 0;
                    return answer;
                }
                else if (x == 1 || x == 2)
                {
                    answer = 1;
                    return answer;
                }
                else
                {
                    length3 = length2 + length1;
                    length1 = length2;
                    length2 = length3;
                    FibWordLength((x - 1), length1, length2, length3);
                    return answer;
                }
            }

            Console.WriteLine($"The length of the fibonacci word fw({n})= {FibWordLength(n, 1, 1, -1)}\n");

            int FibBLength(int n, int B1, int B2, int B3)
            {
                if (n == 2 && B3 != -1)
                {
                    return B3;
                }
                else if (n == 1)
                {
                    return B1;
                }
                else if (n == 2)
                {
                    return B2;
                }
                else
                {
                    B3 = B1 + B2;
                    B1 = B2;
                    B2 = B3;
                    n -= 1;
                    FibBLength(n, B1, B2, B3);
                    return answer;
                }
            }

            Console.WriteLine($"The number of \"b\"s in fw({n})= {FibBLength(n, 0, 1, -1)}");

            int FibALength(int x, int A1, int A2, int A3)
            {
                if (x == 2 && A3 != -1)
                {
                    return A3;
                }
                else if (x == 1)
                {
                    return A1;
                }
                else if (x == 2)
                {
                    return A2;
                }
                else
                {
                        A3 = A1 + A2;
                        A1 = A2;
                        A2 = A3;
                        x -= 1;
                    FibALength(x, A1, A2, A3);
                    return answer;
                }
            }

            Console.WriteLine($"The number of \"a\"s in fw({n})= {FibALength(n, 1, 0, -1)}");
        }
    }
}