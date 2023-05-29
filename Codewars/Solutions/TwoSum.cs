// https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp

namespace TwoSum
{
    public class Kata
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i =0; i < numbers.Length; i++)
            {
                // The required 2nd digit will be target - i, so return index of that number if it exists
                int requiredNum = target - numbers[i];
                int index = Array.IndexOf(numbers, requiredNum);

                // Pass to next index if index is -1 (target int not found) or index == i (avoid matching same index)
                if (index == -1 || index == i)
                {
                    continue;
                }
                else
                {
                    return new int[] { i, index };
                }

            }

            return new int[0];
        }
    }
}
