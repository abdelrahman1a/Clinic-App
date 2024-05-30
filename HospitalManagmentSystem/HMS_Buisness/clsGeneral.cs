using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Buisness
{
    public class clsGeneral
    {
       public static bool IsPositiveNumber(string input)
        {
            if (int.TryParse(input, out int number))
            {
                return number > 0; // Check if the parsed number is greater than zero
            }
            else
            {
                return false; // Input cannot be parsed as an integer
            }
        }

       
    }
}
