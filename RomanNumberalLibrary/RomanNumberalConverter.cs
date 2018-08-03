using System;

namespace RomanNumberalLibrary
{
    public class RomanNumberalConverter
    {
        public static string GetValue(int number)
        {
            string romanString = "";                    
           
            
            while (number > 0)
            {
                if (number >= 50)
                {
                    romanString += "L";
                    number -= 50;
                }
                else if (number >= 10)
                {
                    romanString += "X";
                    number -= 10;
                }
                else if (number == 9)
                {
                    romanString = "IX";
                    number -= 9;
                }
                else if (number >= 5)
                {
                    romanString += "V";
                    number -= 5;
                }
                else if (number >= 4)
                {
                    romanString += "IV";
                    number -= 4;
                }
                else if (number >= 1)
                {
                    romanString += "I";
                    number--;
                }
            }
            



            return romanString;
        }
    }
}
