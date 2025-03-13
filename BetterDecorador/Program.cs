using System;

namespace BetterDecorador
{
    public class Program
    {
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
