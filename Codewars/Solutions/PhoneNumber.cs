//https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp

namespace PhoneNumber
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] numbers)
        {

           string phoneNumber = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        phoneNumber += "(";
                        phoneNumber += numbers[i];
                        break;
                    case 1:
                        phoneNumber += numbers[i];
                        break;
                    case 2:
                        phoneNumber += numbers[i];
                        phoneNumber += ") ";
                        break;
                    case 3: case 4:
                        phoneNumber += numbers[i];
                        break;
                    case 5:
                        phoneNumber += numbers[i];
                        phoneNumber += "-";
                        break;
                    case 6: case 7: case 8: case 9:
                        phoneNumber += numbers[i];
                        break;

                }
            }



            return phoneNumber;
        }
    }
}
