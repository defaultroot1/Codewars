// https://www.codewars.com/kata/52223df9e8f98c7aa7000062/train/csharp

namespace ROT13
{
    using System;
    using System.Threading.Channels;

    public class Kata
    {
        public static string Rot13(string input)
        {
            string plaintext = "";

            foreach (char c in input)
            {
                plaintext += Convert.ToChar(Convert.ToInt32(c) + 13);
            }

            return plaintext;
        }
    }
}
