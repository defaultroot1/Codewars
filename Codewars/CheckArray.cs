using System.Linq;

namespace CheckArray
{
    public class Kata
    {
        //https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
    }
}
