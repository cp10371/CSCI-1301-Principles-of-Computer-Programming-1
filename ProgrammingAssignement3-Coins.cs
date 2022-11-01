//**************************************
//
// Christian Parker
// CSCI 1310 B
// Deadline: 02/24/2020
//
// Coins.cs
//
//**************************************

using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {

            // all coins are initialised as 9973
            int c1 = 9973;
            int c2 = 9973;
            int c3 = 9973;
            int c4 = 9973;
            int c5 = 9973;
            int c6 = 9973;
            int c7 = 9973;
            int c8 = 9973;
            int c9 = 9973;
            int c10 = 9973;
            int c11 = 9973;
            int c12 = 9973;


            // default out of range initialisation of the index of cfCoin
            int cfCoin = -1;

            // the index randIndex of a random coin (one out of twelve) gets picked 
            Random rnd = new Random();
            int randIndex = rnd.Next(12) + 1;

            // decide whether the coin with the index randIndex gets lighter (9967) or heavier (10007)
            int heavier = rnd.Next(2);

            // setting weight of the counterfeit coin
            if (randIndex == 1) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c1 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c1 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 2) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c2 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c2 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 3) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c3 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c3 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 4) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c4 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c4 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 5) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c5 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c5 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 6) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c6 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c6 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 7) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c7 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c7 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 8) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c8 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c8 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 9) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c9 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c9 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 10) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c10 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c10 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 11) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c11 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c11 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            if (randIndex == 12) //if the index of the counterfeit coin is 0
            {
                if (heavier > 0) //if the counterfeit coin is heavier
                {
                    c12 = 10007;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is heavier");
                }
                else
                {
                    c12 = 9967;
                    Console.WriteLine($"The index of the counterfeit coin is: {randIndex} and the coin is lighter");
                }
            }

            // do not change the code above this line
            //
            // Report the counterfeit coin on variable cfCoin.
            // If the counterfeit coin is c7 and the coin is heavier, your code should return cfCoin =7, 
            // and cfCoin =-7 if this coin is lighter than all other coins. 
            //
            // The only operations you are allowed to use are nested if-else-statements which use 
            // - operators <,>,==
            // - sums of coin variables on both sides of theses operators
            //
            // The code below refers to the leftmost branch of the tree on the diagram
            //
            //if (c1+c2+c3+c4 > c5+c6+c7+c8)
            //{ 
            //    if (c1+c2+c3+c5 > c4+c9+c9+c9)
            //    {
            //       if (c1>c2)
            //       {
            //          cfCoin = 1;
            //       }
            //    }
            // }
            //
            // You can also adopt the the following format
            //
            // if ((c1+c2+c3+c4 > c5+c6+c7+c8) && (c1+c2+c3+c5 > c4+c9+c9+c9) && (c1 > c2))
            // { 
            //    cfCoin = 1;
            // }
            //
            // Make sure you cover all branches (root to leaves) of the tree and you report the correct value!
            //
            // YOU CANNOT make any use of variables: randIndex and heavier in your code!
            // you need to report the index of the counterfeit coin on cfCoin
            //
            // your part of the code goes below this line

                //The if-statements below compares the weight between coins 1-4, 5-8, and 9-12 against each other to discover which group the fake coin belongs too                  
            if (((c1 + c2 + c3 + c4) > (c9 + c10 + c11 + c12)) || ((c1 + c2 + c3 + c4) < (c9 + c10 + c11 + c12)))
            {
                //Since I am 100% positive that the fake coin is in the range of [c1, c4] U [c9, c12], I compare each coin to the weight of a coin not in the range
                if (c1 > c8)
                {
                    cfCoin = 1;
                }
                else if (c1 < c8) { cfCoin = -1; }
                if (c2 > c8)
                {
                    cfCoin = 2;
                }
                else if (c2 < c8) { cfCoin = -2; }
                if (c3 > c8)
                {
                    cfCoin = 3;
                }
                else if (c3 < c8) { cfCoin = -3; }
                if (c4 > c8)
                {
                    cfCoin = 4;
                }
                else if (c4 < c8) { cfCoin = -4; }
                if (c9 > c8)
                {
                    cfCoin = 9;
                }
                else if (c9 < c8) { cfCoin = -9; }
                if (c10 > c8)
                {
                    cfCoin = 10;
                }
                else if (c10 < c8) { cfCoin = -10; }
                if (c11 > c8)
                {
                    cfCoin = 11;
                }
                else if (c11 < c8) { cfCoin = -11; }
                if (c12 > c8)
                {
                    cfCoin = 12;
                }
                else if (c12 < c8) { cfCoin = -12; }

            }
            if (((c1 + c2 + c3 + c4) > (c5 + c6 + c7 + c8)) || ((c1 + c2 + c3 + c4) < (c5 + c6 + c7 + c8)))
            {
                //Since I am 100% positive that the fake coin is in the range of [c1, c8], I compare each coin to the weight of a coin not in the range
                if (c1 > c12)
                {
                    cfCoin = 1;
                }
                else if (c1 < c12) { cfCoin = -1; }
                if (c2 > c12)
                {
                    cfCoin = 2;
                }
                else if (c2 < c12) { cfCoin = -2; }
                if (c3 > c12)
                {
                    cfCoin = 3;
                }
                else if (c3 < c12) { cfCoin = -3; }
                if (c4 > c12)
                {
                    cfCoin = 4;
                }
                else if (c4 < c12) { cfCoin = -4; }
                if (c5 > c12)
                {
                    cfCoin = 5;
                }
                else if (c5 < c12) { cfCoin = -5; }
                if (c6 > c12)
                {
                    cfCoin = 6;
                }
                else if (c6 < c12) { cfCoin = -6; }
                if (c7 > c12)
                {
                    cfCoin = 7;
                }
                else if (c7 < c12) { cfCoin = -7; }
                if (c8 > c12)
                {
                    cfCoin = 8;
                }
                else if (c8 < c12) { cfCoin = -8; }
            }
            if (((c5 + c6 + c7 + c8) > (c9 + c10 + c11 + c12)) || ((c5 + c6 + c7 + c8) < (c9 + c10 + c11 + c12)))
            {
                //Since I am 100% positive that the fake coin is in the range of [c5, c12], I compare each coin to the weight of a coin not in the range
                if (c5 > c4)
                {
                    cfCoin = 5;
                }
                else if (c5 < c4) { cfCoin = -5; }
                if (c6 > c4)
                {
                    cfCoin = 6;
                }
                else if (c6 < c4) { cfCoin = -6; }
                if (c7 > c4)
                {
                    cfCoin = 7;
                }
                else if (c7 < c4) { cfCoin = -7; }
                if (c8 > c4)
                {
                    cfCoin = 8;
                }
                else if (c8 < c4) { cfCoin = -8; }
                if (c9 > c4)
                {
                    cfCoin = 9;
                }
                else if (c9 < c4) { cfCoin = -9; }
                if (c10 > c4)
                {
                    cfCoin = 10;
                }
                else if (c10 < c4) { cfCoin = -10; }
                if (c11 > c4)
                {
                    cfCoin = 11;
                }
                else if (c11 < c4) { cfCoin = -11; }
                if (c12 > c4)
                {
                    cfCoin = 12;
                }
                else if (c12 < c4) { cfCoin = -12; }
            }


            // your part of the code goes above this line
            // do not change the code below this line

            if (cfCoin > 0)
            {
                Console.WriteLine($"You reported that the coin with index {cfCoin} is heavier.");
            }
            else
            {
                Console.WriteLine($"You reported that the coin with index {-cfCoin} is lighter.");
            }

            int answer = randIndex;

            if (heavier == 0)
            {
                answer = -randIndex;
            }

            if (answer == cfCoin)
            {
                Console.WriteLine($"Your answer is correct.");
            }
            else
            {
                Console.WriteLine($"Your answer is NOT correct");
            }

        }
    }
}