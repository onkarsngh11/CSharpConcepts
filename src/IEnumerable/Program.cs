using System;
using System.Collections.Generic;

namespace IEnumerableConcepts
{
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/yield
    public class PowerOf2
    {
        static void Main()
        {
            foreach (int i in Power2(2, 8))
            {
                Console.Write("{0} ", i);
            }

            foreach (int i in Power3(3, 8))
            {
                Console.Write("{0} ", i);
            }
        }

        //Each call to the iterator function proceeds to the next execution of the yield return statement, which occurs during the next iteration of the for loop.
        public static IEnumerable<int> Power2(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        // The other way to write the same logic would be to use List instead of IEnumerable.
        public static List<int> Power3(int number, int exponent)
        {
            List<int> list = new List<int>();
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                list.Add(result);
            }
            return list;
        }
    }
}

