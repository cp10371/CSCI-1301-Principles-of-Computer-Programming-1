using System;

namespace Lab_Exercise_4
{

    class Square // the definition of the Square class
    {
        private int CornerX;
        private int CornerY;
        private int Side;

        public Square(int valueX, int valueY, int valueS) // the constructor allowing initialisation
        {
            CornerX = valueX;
            CornerY = valueY;
            Side = valueS;
        }

        public int X // the three properties allowing access to the specs
        {
            get
            {
                return CornerX;
            }
        }
        public int Y
        {
            get
            {
                return CornerY;
            }
        }
        public int S
        {
            get
            {
                return Side;
            }
        }
    }

    // The main part of the program
    // Please make sure all values "unknown" are replaced by the correct numerical answers

    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random(); // initialisation of the random number generator

            string unknown = "unknown"; // declaration of "unknown"

            Square square1 = new Square(1, 1, 6); // creation of an object square1
            Square square2 = new Square(3, 2, 2); // creation of an object square2

            // Report the specificatons of both squares

            Console.WriteLine($"The bottom left corner of square 1 is: ({square1.X},{square1.Y}) and its side is: {square1.S}");
            Console.WriteLine($"The bottom left corner of square 2 is: ({square2.X},{square2.Y}) and its side is: {square2.S}");


            // Compute and report the top right corners of both squares

            Console.WriteLine($"The top right corner of square 1 is: ({square1.X + square1.S},{square1.Y + square1.S})");
            Console.WriteLine($"The top right corner of square 2 is: ({square2.X + square2.S},{square2.Y + square2.S})");

            // Projections on the X axis of both squares

            Console.WriteLine($"The projection of square 1 on X axis is: ({square1.X},{square1.X + square1.S})");
            Console.WriteLine($"The projection of square 2 on X axis is: ({square2.X},{square2.X + square2.S})");

            // Compute and report the size/length of the overlap of X axis projections
            int overlapX = 0;

            if (square1.X > square2.X)
            {
                if ((square1.X + square1.S) > (square2.X + square2.S))
                {
                    overlapX = (square2.X + square2.S) - (square1.X);
                }
                else
                {
                    overlapX = (square1.X + square1.S) - (square1.X);
                }
            }
            else
            {
                if ((square1.X + square1.S) > (square2.X + square2.S))
                {
                    overlapX = (square2.X + square2.S) - (square2.X);
                }
                else
                {
                    overlapX = (square1.X + square1.S) - (square2.X);
                }
            }


            if (overlapX < 0) { overlapX = 0; }
            Console.WriteLine($"The size of the overlap on X axis is: ({overlapX})");

            // Compute and report projections on the Y axis of both squares

            Console.WriteLine($"The projection of square 1 on Y axis is: ({square1.Y},{square1.Y + square1.S})");
            Console.WriteLine($"The projection of square 2 on Y axis is: ({square2.Y},{square2.Y + square2.S})");

            // Compute and report the size/length of the overlap of Y axis projections
            int overlapY = 0;

            if (square1.Y > square2.Y)
            {
                if ((square1.Y + square1.S) > (square2.Y + square2.S))
                {
                    overlapY = (square2.Y + square2.S) - (square1.Y);
                }
                else
                {
                    overlapY = (square1.Y + square1.S) - (square1.Y);
                }
            }
            else
            {
                if ((square1.Y + square1.S) > (square2.Y + square2.S))
                {
                    overlapY = (square2.Y + square2.S) - (square2.Y);
                }
                else
                {
                    overlapY = (square1.Y + square1.S) - (square2.Y);
                }
            }


            if (overlapY < 0) { overlapY = 0; }
            Console.WriteLine($"The size of the overlap on Y axis is: ({overlapY})");

            // Compute and report the size of the area of the overlap
            int area = overlapX * overlapY;

            Console.WriteLine($"The size/area of the overlap is: ({area})");

        }
    }
}