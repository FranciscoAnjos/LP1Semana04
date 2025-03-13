using System;

namespace BetterDecorador
{
    /// <summary>
    /// Class containing the program entry point and the string decoration method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program.
        /// This method receives three arguments from the command line: a string, a decorative character, and an integer.
        /// The program decorates the string with the decorative character repeated the specified number of times.
        /// </summary>
        /// <param name="args">Array of strings containing the arguments passed from the command line. 
        /// The first argument is the string to be decorated, 
        /// the second is the decorative character, 
        /// and the third is the number of times the character should be repeated.</param>
        private static void Main(string[] args)
        {
            string inputString = args[0];
            char decorationChar = char.Parse(args[1]);
            int decorationCount = int.Parse(args[2]);

            Console.WriteLine(Decor(inputString, decorationChar, decorationCount));
        }

        private static string Decor(string s, char dec, int num)
        {
            string decoration = new string(dec, num);
            return $"{decoration} {s} {decoration}";
        }
    }
}
