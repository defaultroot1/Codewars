//https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp
using System.Linq;

namespace SumMixedArray
{
    public class Kata
    {
        public static int SumMix(object[] x)
        {

            int sum = 0;

            foreach (object o in x)
            {
                sum += Convert.ToInt32(o);
            }

            return sum;
        }
    }
}
