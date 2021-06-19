using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathBase.CalcMethods
{
    public class Primes
    {
        public static bool IsPrime(long num)
        {
            for (int a = 2; a <= num / 2; a++)
            {
                if (num % a == 0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
