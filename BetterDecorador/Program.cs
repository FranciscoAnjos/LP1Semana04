using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
        }

        private static string Decor(string s, char dec, int num)
        {
            string decoration = new string(dec, num);
            return $"{decoration} {s} {decoration}";
        }
    }
}
