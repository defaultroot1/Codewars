//https://www.codewars.com/kata/541c8630095125aba6000c00

using System.Linq;

namespace DigitalRoot
{
    public class Number
    {
        public static int DigitalRoot(long n)
        {
            do
            {
                n = addDigits(n);
            } while (n > 9);

            return (int)n;
            
        }

        private static long addDigits(long n)
        {
            string numString = n.ToString();

            long result = 0;

            foreach (char c in numString)
            {
                result += long.Parse(c.ToString());
            }

            return result;

        }

    }
}
