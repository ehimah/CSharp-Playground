using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Playground.Code_Katas.Function
{
    public static class FizzBuzz
    {
        public static IEnumerable<string> Run(int target)
        {
            for (int i = 1; i <= target; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    var result = i % 3 == 0 ? "Fizz": string.Empty;
                    result += i % 5 == 0 ? "Buzz": string.Empty;
                    yield return result;
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }
    }
}
