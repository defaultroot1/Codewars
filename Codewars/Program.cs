using System;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here

            List<int[]> peopleList1 = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
			List<int[]> peopleList2 = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
			List<int[]> peopleList3 = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };

            Console.WriteLine(Kata.Number(peopleList1));
            Console.WriteLine(Kata.Number(peopleList2));
            Console.WriteLine(Kata.Number(peopleList3));




        }

		public class Kata
        {
			public static int Number(List<int[]> peopleListInOut)
			{
                int numOnBus = 0;

                foreach (int[] inOutPair in peopleListInOut)
                {
                    numOnBus = numOnBus + inOutPair[0] - inOutPair[1];
                }

                return numOnBus;
			}

			public static bool IsEven(double n)
			{
                return (n % 2 == 0);
			}
		}

        
    }
}
