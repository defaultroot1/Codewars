using System;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here
            Console.WriteLine(Kata.DivCon(new object[] { 9, 3, "7", "3" }));
		}

        public class Kata
        {
            public static int DivCon(Object[] objArray)
            {
                int result = 0;
                foreach (Object obj in objArray)
                {
                    if (obj is int i)
                    {
                        result += i;
                    }
                    else
                    {
                        result -= Int32.Parse(obj.ToString());
                    }
                }
                return result;
            }
        }

        
    }
}
