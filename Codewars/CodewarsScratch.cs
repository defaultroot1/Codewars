using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {

        int positiveCount = 0;
        int negativeSum = 0;

        if (input == null || input.Length == 0) 
        {
            return new int[] { };
        }

        foreach (int i in input)
        {
            if (i == 0)
            {
                continue;
            }
            else if (i > 0) 
            {
                positiveCount++;
            }
            else
            {
                negativeSum += i;
            }
        }

        return new int[] { positiveCount, negativeSum };
    }
}