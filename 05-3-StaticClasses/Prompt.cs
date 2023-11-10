﻿// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1010 C# Examples

namespace _05_3_StaticClasses //namespace block, similar to namespace declaration, no difference in functionality
{
    /// <summary>
    /// Provides prompting methods for the console
    /// </summary>
    internal static class Prompt
    {
        /// <summary>
        /// Prompts the user for an int value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as an int</returns>
        public static int ForInt(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToInt32(input);
        }

        /// <summary>
        /// Prompts the user for a float value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a float</returns>
        public static float ForFloat(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToSingle(input);
        }

        /// <summary>
        /// Prompts the user for an double value and returns it
        /// </summary>
        /// <param name="message">message to print with prompt</param>
        /// <returns>user input as a double</returns>
        public static double ForDouble(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            return Convert.ToDouble(input);
        }
    }
}