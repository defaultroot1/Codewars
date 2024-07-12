using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Runtime.ExceptionServices; //ToTitleCase
using System.Linq;

namespace Codewars
{
    internal class Program
    {

		static void Main(string[] args)
        {
            // https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp

            // Tests here
            Console.WriteLine(Kata.XO("ooxx")); // true
            Console.WriteLine(Kata.XO("xooxx")); // false
            Console.WriteLine(Kata.XO("ooxXm")); // true
            Console.WriteLine(Kata.XO("zpzpzpp")); // true none = true
            Console.WriteLine(Kata.XO("zzoo")); // false
		}

        public class Kata
        {

			public static bool XO(string input)
			{
                int xCount = 0;
                int oCount = 0;

                foreach (char c in input)
                {
                    if (c == 'x')
                    {
                        xCount++;
                    }
                    else if (c == 'o')
                    {
                        oCount++;
                    }
                }

                return(xCount == oCount);
            }

			public static int DuplicateCount(string str)
			{

                Dictionary<char,int> charTracker = new();
                int duplicateCount = 0;

                foreach(char c in str.ToLower())
                {
                    if (charTracker.ContainsKey(c))
                    {
                        charTracker[c] += 1;
                    }
                    else
                    {
						charTracker.Add(c, +1);
					}
                    
                }

                foreach(KeyValuePair<char,int> pair in charTracker)
                {
                    if (pair.Value > 1)
                    {
                        duplicateCount++;
                    }
                }

                return duplicateCount;
			}

			public static bool IsIsogram(string str)
			{
				if (str.Length == 0) { return true; }

				string charTracker = "";

                foreach (char c in str.ToLower())
                {
                    if (charTracker.Contains(c))
                    {
                        return false;
                    }
                    charTracker += c;
                }
                return true;
			}

			public class ListFilterer
			{
				public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
				{

                    List<int> returnList = new();

                    foreach (var item in listOfItems)
                    {
                        if (item is int)
                        {
                            returnList.Add((int)item);
                        }
                    }
                    return returnList;
				}
			}


			public static String Accum(string s)
			{
                string returnString = "";

                for(int i = 0; i < s.Length; i++)
                {
					for (int j = 0; j <= i; j++)
                    {
                        if (j == 0) { returnString += s.ToUpper()[i]; }
                        else { returnString += s.ToLower()[i]; }
                        
					}   
                    
                    if (i < s.Length - 1)
                    {
                        returnString += "-";
                    }
                }
                return returnString;
			}

			public static string GetMiddle(string s)
			{
                Console.WriteLine(s.Length);
                Console.WriteLine(s.Length / 2);

                if (s.Length == 1)
                {
                    return s;
                }
                else if (s.Length % 2 != 0)
                {
                    return $"{s[(s.Length / 2)]}";
                }
                else
                {
                    return $"{s[(s.Length / 2) - 1]}{s[(s.Length / 2)]}";
				}
			}

			public static string HighAndLow(string numbers)
			{
                // Set high and low as first value
                int high = Int32.Parse(numbers.Split(' ')[0]);
                int low = Int32.Parse(numbers.Split(' ')[0]);
 

                foreach (string s in numbers.Split(' '))
                {
                    if (Int32.Parse(s) > high)
                    {
                        high = Int32.Parse(s);
                    }

					if (Int32.Parse(s) < low)
					{
						low = Int32.Parse(s);
					}
				}

                return ($"{high} {low}");
			}

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
