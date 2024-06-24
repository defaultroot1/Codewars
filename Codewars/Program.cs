using System;
using System.Globalization; //ToTitleCase

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here

            Console.WriteLine(Kata.IsSquare(-1));
            Console.WriteLine(Kata.IsSquare(0));
            Console.WriteLine(Kata.IsSquare(3));
            Console.WriteLine(Kata.IsSquare(4));
            Console.WriteLine(Kata.IsSquare(25));
            Console.WriteLine(Kata.IsSquare(26));
        }

		public class Kata
        {
			public static bool IsSquare(int n)
			{

                if (n == 0) return true;

				for(int i = 0; i <= n; i++)
                {
                    if (i*i == n) return true;
                }

                return false;
			}
			public static string ToJadenCase(string phrase)
			{
                TextInfo myTI = new CultureInfo("en-US").TextInfo;
                return myTI.ToTitleCase(phrase);
			}
			public static int FindEvenIndex(int[] arr)
			{
				int target = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    target = i == 0 ? 0 : target + arr[i - 1];
                    //Console.WriteLine($"index: {i} - target: {target}");

                    int rightSideSum = 0;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        rightSideSum += arr[j];
                    }
                    //Console.WriteLine($"RightSide: {rightSideSum}");
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
