﻿namespace _07_3_InputLoop
{
    /// <summary>
    /// A program to demonstrate building an input loop
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create program variables
            int numDice, numSides;

            do
            {
                //Prompt the user to enter a number of dice to roll
                Console.Write("Enter num dice: ");
                numDice = Convert.ToInt32(Console.ReadLine());

                //If the user enters a value greater than 0
                if (numDice > 0)
                {
                    //Then prompt the user to enter number of sides on dice
                    Console.Write(" Enter num sides: ");
                    numSides = Convert.ToInt32(Console.ReadLine());

                    //TODO: implement dice roller algorithm here
                }
            } while (numDice > 0); //while the user entered a value greater than 0
        }
    }
}
