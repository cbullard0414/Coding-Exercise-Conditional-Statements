namespace Coding_Exercise_Conditional_Statements
{
    using static System.Console;
    internal class Problem1
    {
        static void Main(string[] args)
        {
            int probChoice;
            WriteLine("Which problem would you like to run? 1, 2, or 3?");
            probChoice = int.Parse(ReadLine());

            if (probChoice == 1)
            {
                /*Write a C# Sharp program to check whether 
                a given number is even or odd.*/
                int num;
                WriteLine("Enter a number to find out if it is even or odd.");
                num = int.Parse(ReadLine());
                if (num % 2 == 0)
                {
                    WriteLine(num + " is an even number.");
                    ReadLine();
                }
                else
                {
                    WriteLine(num + " is an odd number.");
                    ReadLine();
                }
            }

            if (probChoice == 2)
            {
                /*Write a C# Sharp program to accept a coordinate
                 * point in an XY coordinate system 
                 * and determine in which quadrant the coordinate point lies.*/
                WriteLine("Enter an X coordinate");
                int xco = int.Parse(ReadLine());
                WriteLine("Enter a Y coordinate");
                int yco = int.Parse(ReadLine());
                
                if (xco >= 0 && yco >= 0)
                {
                    WriteLine("The coordinate " + "(" + xco + "," +  yco + ")" + " is in Quadrant 1.");
                }

                if (xco <= 0 && yco >= 0)
                {
                    WriteLine("The coordinate " + "(" + xco + "," + yco + ")" + " is in Quadrant 2.");
                }

                if (xco <= 0 && yco <= 0)
                {
                    WriteLine("The coordinate " + "(" + xco + "," + yco + ")" + " is in Quadrant 3.");
                }

                if (xco >= 0 && yco <= 0)
                {
                    WriteLine("The coordinate " + "(" + xco + "," + yco + ")" + " is in Quadrant 4.");
                }
            }
        }
    }
}