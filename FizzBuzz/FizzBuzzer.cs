using System;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public static string GetValue(int i)
        {
            string output = String.Empty;

            
            if(i % 3 == 0)
            {
                output += "Fizz";
            }
            if(i % 5 == 0)
            {
                output += "Buzz";
            }
            if (string.IsNullOrEmpty(output))
                output = i.ToString();
            return output;
        }
    }
}
