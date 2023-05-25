//https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp

namespace ROT13
{
    using System;
    using System.Threading.Channels;

    public class Kata
    {
        public static string Rot13(string input)
        {
            char[] splitString = input.Split(',').io;

            foreach (string c in splitString)
            {
                Console.WriteLine(c);
            }

            return "";
        }
    }
}
