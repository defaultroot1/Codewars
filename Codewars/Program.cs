using System;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here
            Console.WriteLine(Kata.IsEven(20));
			Console.WriteLine(Kata.IsEven(23));
			Console.WriteLine(Kata.IsEven(0.5));
			Console.WriteLine(Kata.IsEven(-4));
		}

        public class Kata
        {
			public static bool IsEven(double n)
			{
                return (n % 2 == 0);
			}
		}

        
    }
}
