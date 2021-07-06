using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathBase.CalcMethods
{
    public class MathMethods
    {
        public static (string toLeft, string toRight) SumPowerBase10(long num)
        {
            string toLeft = "";
            string toRight = "";
            string number = Convert.ToString(num);

            bool isFirst = true;
            int counter = number.Length - 1;
            for (int i = 0; i < number.Length; i++)
            {
                if (!isFirst)
                    toRight += " + ";
                isFirst = false;

                toRight += number[i] + ".10^" + counter;
                counter--;
            }

            isFirst = true;
            counter = 0;
            for (int i = (number.Length - 1); i >= 0; i--)
            {
                if (!isFirst)
                    toLeft += " + ";
                isFirst = false;

                toLeft += number[i] + ".10^" + counter;
                counter++;
            }

            return (toLeft, toRight);
        }

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

        public static (string primesList, long numberOfPrimes) ListPrime(long begin, long end)
        {
            string primesList = "";
            long numberOfPrimes = 0;

            int tam = (Convert.ToString(begin)).Length + 2;
            for (long num = begin; num < end; num++)
            {
                if (IsPrime(num))
                {
                    primesList += String.Format("{0," + tam + "}\t", num);
                    numberOfPrimes++;
                }
            }
            return (primesList, numberOfPrimes);
        }


        public static string ProductPrime(int num)
        {
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
                            if (isFirst)
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

        public static List<long> ProductPrime(long num)
        {
            var result = new List<long>();
            while (num != 1)
            {
                int i = 2;
                while (i <= num)
                {
                    if (IsPrime(i))
                    {
                        if (num % i == 0)
                        {
                            num /= i;
                            result.Add(i);
                            break;
                        }
                        else
                            i++;
                    }
                    else
                        i++;
                }
            }

            return result; // retorna uma lista dos primos que multiplicados se tornam o numero
        }

        public static (List<long> primes, List<long> powers) ProductPrimeWithPower(long num)
        {
            var lista = ProductPrime(num);
            var primes = new List<long>();
            var powers = new List<long>();

            while (lista.Count != 0)
            {
                long element = lista[0];
                primes.Add(element);

                int numberOfElements = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i] == element)
                    {
                        numberOfElements++;
                    }
                }
                powers.Add(numberOfElements);

                for (int i = 0; i < numberOfElements; i++)
                    lista.Remove(element);
            }

            return (primes, powers); // retorna duas listas, uma com primos e outra com a potencia desses primos
        }

        public static string ProductPrimeToString(long num)
        {
            var list = ProductPrimeWithPower(num);
            string result = "";
            bool isFirst = true;
            for(int i = 0; i < list.primes.Count; i++)
            {
                if (!isFirst)
                    result += " . ";
                isFirst = false;
                result += "" + list.primes[i];
                if (list.powers[i] > 1)
                    result += "^" + list.powers[i];
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

        public static double ApproximatePiX(long x)
        {
            double result = 0;

            result = (x / Math.Log(x)) ;


            return result;
        }

        public static long RealPiX(long x)
        {
            var result = ListPrime(2, x);

            return result.numberOfPrimes;
        }

        public static double AcuratePiX(long x)
        {
            double result = 0;

            result = ApproximatePiX(x) / RealPiX(x) * 100;

            return result;
        }

        public static long TauN(long n) // 𝛕(n)  Mostra o número de divisores positivos de n.
        {
            
            var lista = ProductPrimeWithPower(n);
            long result = (lista.powers[0] + 1);

            for (int i = 1; i < lista.primes.Count; i++)
            {
                result *= (lista.powers[i] + 1);
            }

            return result;
        }

        public static double SigmaN(long n) // σ(n) Mostra a soma dos divisores positivos de n.
        {
            var lista = ProductPrimeWithPower(n);
            double result = (Math.Pow(lista.primes[0], (lista.powers[0] + 1)) - 1) / (lista.primes[0] - 1);

            for (int i = 1; i < lista.primes.Count; i++)
            {
                
                result *= (Math.Pow(lista.primes[i], (lista.powers[i] + 1)) - 1) / (lista.primes[i] - 1);
            }

            return result;
        }

        public static double PhiN(long n) // φ(n) Mostra a quantidade de números menores que n e coprimos com n. São os números invertíveis mod(n).
        {
            var lista = ProductPrimeWithPower(n);
            double result = n;
            for (int i = 0; i < lista.primes.Count; i++)
            {
                result *= ((Convert.ToDouble(lista.primes[i]) - 1) / (Convert.ToDouble(lista.primes[i])));
            }
            

            return result;
        }

    }
}
