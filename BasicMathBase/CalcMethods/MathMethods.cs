using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathBase.CalcMethods
{
    public class MathMethods
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
        
        public static string ProductPrime(int num)
        {
            var lista = new List<int>();

            string result = "";
            bool isFirst = true;
            while (num != 1)
            {
                int i = 2;
                while(i <= num)
                {
                    if (IsPrime(i))
                    {
                        if (num % i == 0)
                        {
                            num /= i;
                            if(isFirst)
                                result += Convert.ToString(i);
                            else
                                result += "." + Convert.ToString(i);
                            isFirst = false;
                            break;
                        }else
                            i++;
                    }else
                        i++;
                }
            }
            return result;
        }

        public static int Mmc(int num1, int num2)
        {
            int x, y, mmc;
            x = num1;
            y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            mmc = (x * y) / num1;

            return mmc;
        }

        public static int Mdc(int num1, int num2)
        {
            int Resto;
            while (num2 != 0)
            {
                Resto = num1 % num2;
                num1 = num2;
                num2 = Resto;
            }
            return num1;
        }

        public static string resultStringEuclides { get; set; }
        public static long euclides_r(long m, long n, long counter)
        {
            if (n == 0) return m;
            if(counter != 0)
            {
                resultStringEuclides += $" k{counter} = {m % n}";
                resultStringEuclides += $"\t a{counter} = {m / n}";
                resultStringEuclides += Environment.NewLine;
            }
            else
            {
                resultStringEuclides += $" k{counter} = {m % n}";
                resultStringEuclides += $"\t a{counter} = {m / n}";
                resultStringEuclides += Environment.NewLine;
            }
            
            counter++;
            return euclides_r(n, m % n, counter);
        }

        public static string MdcAlgoritmoEuclides(int num1, int num2)
        {
            if( num2 > num1)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp;
            }

            string result = " Mdc = " + Convert.ToString(euclides_r(num1, num2, 0)) + Environment.NewLine + " Processo: " + Environment.NewLine + resultStringEuclides;

            return result;
        }
    }
}
