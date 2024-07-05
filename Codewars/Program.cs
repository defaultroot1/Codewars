using System;
using System.Globalization;
using System.Runtime.ExceptionServices; //ToTitleCase

// https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp
// https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/train/csharphttps://www.codewars.com/kata/54521e9ec8e60bc4de000d6c/train/csharp
// https://www.codewars.com/kata/decode-the-morse-code

namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests here
            Console.WriteLine(Kata.Decode(".... . -.--   .--- ..- -.. .")); // "HEY JUDE"

		}


		public class Kata
        {
			public static string Decode(string morseCode)
			{
                string[] newSring = (morseCode.Split("   "));
                foreach (string line in newSring)
                {
                    Console.WriteLine(MorseCode(line));
                }
                return "test";
            }

            public static string MorseCode(string code)
            {
                return "ConvertedString";
            }

			public static int MaxSequence(int[] arr)
			{
                int maxSum = 0;

                for(int i =0; i < arr.Length; i++)
                {
                    int currentSum = 0;

                    for (int j = i; j < arr.Length; j++)
                    {
                        currentSum += arr[j];
                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                        }
                    }
                }
                return maxSum;
			}


			public static string HowMuchILoveYou(int nb_petals)
			{
                string[] phrases = { "I love you", "a little", "a lot", "passionately", "madly", "not at all" };

                return phrases[(nb_petals - 1) % 6];
			}
			public static List<string> Number(List<string> lines)
			{
                List<string> returnList = new();

                for (int line =  0; line < lines.Count; line++)
                {
                    returnList.Add($"{line+1}: {lines[line]}");
                }


                return returnList;
			}
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
