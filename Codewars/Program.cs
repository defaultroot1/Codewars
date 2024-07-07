using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.ExceptionServices; //ToTitleCase

namespace Codewars
{
    internal class Program
    {


		static void Main(string[] args)
        {
            // Tests here
            Console.WriteLine(Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 })); // new int[] {2, 2}

            foreach (int val in Kata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }))
            {
                Console.WriteLine(val);
            }
		}

        public class Kata
        {

        public static int[] ArrayDiff(int[] a, int[] b)
		    {
                List<int> tempList = new List<int>();

                foreach (int i in a)
                {
                    if (!b.Contains(i))
                    {
                        tempList.Add(i);
                    }
                }

                return tempList.ToArray();
		    }

			public static int SquareDigits(int n)
			{
                string outputString = "";

                foreach (char charDigit in n.ToString())
                {
                    int intDigit = charDigit - '0';
                    outputString += (intDigit * intDigit).ToString();

                }
                return Int32.Parse(outputString);
			}

			public static string Decode(string morseCode)
			{
                string returnMessage = "";
                string[] lineString = (morseCode.Split("   "));
                foreach (string line in lineString)
                {
                    string[] wordString = line.Split(" ");
                    
                    foreach(string word in wordString)
                    {
                        returnMessage += MorseCode(word);
                    }
                }
                return returnMessage;
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
