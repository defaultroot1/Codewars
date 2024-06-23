using System;

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here

            Console.WriteLine(Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 })); 
            Console.WriteLine(Kata.FindEvenIndex(new int[] { 1, 100, 50, -51, 1, 1 })); 
            Console.WriteLine(Kata.FindEvenIndex(new int[] { 1, 2, 3, 4, 5, 6 })); 
            Console.WriteLine(Kata.FindEvenIndex(new int[] { 20, 10, 30, 10, 10, 15, 35 })); 
            //Console.WriteLine(Kata.FindEvenIndex(new int[] { 20, 10, -80, 10, 10, 15, 35 })); 
        }

		public class Kata
        {
			public static int FindEvenIndex(int[] arr)
			{
				int target = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    target = i == 0 ? 0 : target + arr[i - 1];
                    Console.WriteLine($"index: {i} - target: {target}");

                    int rightSideSum = 0;

                    for (int j = i + 1; j < arr.Length; j++)
                    {

                        rightSideSum += arr[j];
                    }
                    Console.WriteLine($"RightSide: {rightSideSum}");

                    if (rightSideSum == target) return i;
                }


                return -1;
			}
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
