﻿using System.Security.Cryptography.X509Certificates;

namespace _09_1_CommandLineArguments
{
    /// <summary>
    /// Demonstrates the use of command line arguments
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            //When arguments are passed from the command line, such as -> someProgram.exe -c 42 3 hello
            //Main receives these as a string array, the argument string has been split on a space and would generate this
            //array for above {"-c", "42", "3". "hello"}

            //see if arg array is empty
            if (args.Length == 0)
            {
                Console.WriteLine("No command line arguments specified!");
            }
            else
            {
                foreach (string arg in args)
                {
                    //Console.WriteLine($"  {arg}");

                    if (arg.ToLower().Equals("beep"))
                    {
                        Beep();
                        return;
                    }
                    
                    if (arg.ToLower().Equals("poe"))
                    {
                        Poe();
                        return;
                    }
                }
            }
        }
        
        /// <summary>
        /// Makles a beep
        /// </summary>
        public static void Beep()
        {
            Console.Beep();
        }

        /// <summary>
        /// Talks some Poe nonsense
        /// </summary>
        public static void Poe()
        {
            Console.WriteLine("We love with a love that more than love.");
        }
    }
}