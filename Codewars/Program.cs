using System;
using System.Globalization; //ToTitleCase

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here

            Console.WriteLine(Kata.AlphabetPosition("The sunset sets at twelve o' clock.")); //20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11
			Console.WriteLine(Kata.AlphabetPosition("The narwhal bacons at midnight.")); // 20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20

		}

		public class Kata
        {
			public static string AlphabetPosition(string text)
			{
                int asciiOffset = 96;
                string returnString = "";
                foreach (char c in text.ToLower())
                {
                    if(Char.IsLetter(c))
                    {
						returnString += $"{Convert.ToInt32(c) - asciiOffset} ";
					}
                    
                    //returnString += Convert.ToInt32(c) - asciiOffset;
                }
                return returnString.Trim();
			}

			public static int[] humanYearsCatYearsDogYears(int humanYears)
			{
				if (humanYears == 1)
                {
					return new int[] { humanYears, 15, 15 };
				}
                if (humanYears == 2)
                {
					return new int[] { humanYears, 24, 24 };
				}
                else
                {
					return new int[] { humanYears, 24 + (4 * (humanYears - 2)), 24 + (5 * (humanYears - 2)) };
				}

            }

			public static string AddBinary(int a, int b)
			{
                return Convert.ToString(a + b, 2);
			}

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
