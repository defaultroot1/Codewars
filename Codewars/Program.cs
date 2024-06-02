using System;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] check = TwoSum.Kata.TwoSum(new[] { 1, 2, 3 }, 4).OrderBy(a => a).ToArray();

            foreach (int i in check)
            {
                Console.WriteLine(i + " - test");
            }
        }

        
    }
}
