using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recursion.Models
{
    public class Factorial
    {
        public int CalculateFactorial(int number)
        {
            if(number == 0 || number == 1)
            {
                return 1;
            }

            return number * CalculateFactorial(number - 1);
        }
    }
}