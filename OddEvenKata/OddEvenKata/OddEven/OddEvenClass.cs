using System;
using System.Collections.Generic;
using System.Text;

namespace OddEvenProject
{
    public static class OddEvenClass
    {
        
      public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

       public static string PrimeEvenOrOdd(int num)
        {
            string result = "";
            if (IsPrime(num))
            {
                result = "PRIME";               
            }
            if (IsPrime(num) == false && num % 2 == 0)
            {
                result = "EVEN";
            }
            if (IsPrime(num) == false &&  num % 2 != 0)
            {
                result = "ODD";
            }
            return result;
        }



    }
}
