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
                int charIntValue = Convert.ToInt32(c);

                if ((charIntValue >= 65 && charIntValue < 78) || (charIntValue >= 97 && charIntValue < 110))
                {
                    plaintext += Convert.ToChar(charIntValue + 13);
                }
                else if ((charIntValue >= 78 && charIntValue <= 90) || (charIntValue >= 110 && charIntValue <= 122))
                {
                    plaintext += Convert.ToChar(charIntValue - 13);
                }
                else
                {
                    plaintext += c;
                }
            
            }

            return plaintext;
        }
    }
}
