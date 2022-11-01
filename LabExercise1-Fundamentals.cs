//****************************************************************************
//****************************************************************************
//
// Christian Parker
// CSCI 1301CD
// Lab Exercise 1
// 01/22/2020
//
// Fundamentals.cs
//
//***************************************************************************
//***************************************************************************


using System;

namespace Lab_Exercise_1
{
    class Fundamentals
    {
        static void Main(string[] args)
        {
            //*************************************************************************************
            //Task 1
            //Variable Declarations
            //Task 1.1. Declare and initialize user name variable
            //Place your code below

            var userName = "name";

            //Task 1.2. Declare and initialize two number (integer) variables
            //Place your code below

            int num1 = 0;
            int num2 = 0;

            //*************************************************************************************

            //SGW Code
            Console.WriteLine("*** Welcome to Lab Exercise 1 ***");
            Console.WriteLine();

            //*************************************************************************************
            //Task 2
            //Get User Name
            //Task 2.1. Prompt user for name
            //Place your code below

            Console.WriteLine("What is your name?");

            //Task 2.2. Bring the name in and write it into the variable name local variable
            //Place your code below.

            userName = Console.ReadLine();


            //Task 2.3. Thank the user for entering their name
            //Write your code below.

            Console.WriteLine("Thank you for entering your name.");

            //*************************************************************************************

            Console.WriteLine("\n");

            //*************************************************************************************
            //Task 3
            //Get User Numbers

            //Task 3.1 - Notify user of intent to get two numbers(integers)
            //Place your code below

            Console.WriteLine("Please enter two numbers.");

            //Task 3.2 - Prompt user for their first number (integer)
            //Place your code below

            Console.WriteLine("First Number: ");

            //Task 3.3. Bring the first integer in and write it into the first number variable
            //Place your code below

            num1 = Convert.ToInt32(Console.ReadLine());

            //Task 3.4 - Prompt user for their second number (integer)
            //Place your code below

            Console.WriteLine("Second Number: ");

            //Task 3.3. Bring the second integer in and write it into the second number variable
            //Place your code below

            num2 = Convert.ToInt32(Console.ReadLine());

            //*************************************************************************************

            Console.WriteLine();

            //*************************************************************************************

            //Task 4. Thank the user for entering name and numbers
            //Ensure you write the user's name and both numbers back out to the screen
            //Write your code below.

            Console.WriteLine("Thank you for all of your input " + userName + "." + "You're two numbers are " + num1 + " and " + num2);


            //*************************************************************************************

            Console.WriteLine();

            //*************************************************************************************
            //Task 5 - this is a supplementary material, feel free to play with it
            //For Funsies
            //Experimenting with data types and variables

            //Task 5.1
            //See what happens when you,...
            //Remember the name variable you declared? 
            //What data type is it? 
            //A string, right?
            //Try to assign an integer value to be the value of the string variable.
            //Your code should look something like:
            //userName = 5; (as an example)
            //Place your code here. Then save all and try to build.


            //Task 5.2
            //What happened when you tried to build? 
            //Didn't work well, did it? 
            //Why? 
            //Place your answer, commented out, below.
            //
            //

            //Now save all and build to ensure you're Task 5 Code and Answer are commented out

            //*************************************************************************************

            //End Lab Exercise 1

        }//End Main()

    }//End class

}//End namespace

///////////////////////////////////////////////////////////////////////////////////////

using System;

namespace Programming_Assignment_1
{
    class Sorter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            // Creating Variables
            string name = "user";
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int low = 0;
            int med = 0;
            int high = 0;
            // Getting User's Input
            Console.WriteLine("What is your name?");
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
                num1 = high;
            }
            else if (num1 > num2)
            {
                num1 = med;
            }
            //
            if (num2 < num1)
            {
                num2 = low;
            }
            else if (num2 > num3)
            {
                num2 = high;
            }
            //
            if (num3 < num2)
            {
                num3 = low;
            }
            else if (num3 > num2)
            {
                num3 = med;
            }
        }
    }
}
