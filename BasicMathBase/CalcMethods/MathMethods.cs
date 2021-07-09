﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathBase.CalcMethods
{
    public class MathMethods
    {
        public static bool Correction(string userAnswer, string sistemAnswer)
        {
            if (userAnswer == sistemAnswer) return true;
            else return false;
        }

        public static string ToPower(long powerBase, long expoent)
        {
            string output = "";
            if (expoent == 0) return "1";
            if (powerBase == 1) return "1";
            if (expoent < 0)
            {
                expoent *= -1;
                output += "1/";
            }

            long result = powerBase;
            for (int i = 0; i < (expoent - 1); i++)
                result *= powerBase;

            output += $"{result}";
            return output;
        }

        public static (string outputString, long numberResult)RussianMultiplyAlgorithm(long factor1, long factor2)
        {
            string output = "";
            var oddList = new List<long>();

            int size = (Convert.ToString(factor1)).Length + 2;
            if (((Convert.ToString(factor2)).Length + 2) > size)
                size = (Convert.ToString(factor2)).Length + 2;

            while (factor1 >= 1)
            {
                output += String.Format("{0," + size + "}\t", factor1);
                output += "-----\t";
                output += String.Format("{0," + size + "}\t", factor2);
                output += Environment.NewLine;
                if (factor1 % 2 == 1)
                {
                    oddList.Add(factor2);
                    if(factor1 != 1) factor1--;
                }
                factor1 /= 2;
                factor2 *= 2;
            }

            long result = 0;
            bool isFirst = true;
            foreach(long odd in oddList)
            {
                result += odd;
                if(!isFirst) output += " + ";
                isFirst = false;
                output += $"{odd}";
            }

            output += $" = {result}";

            return (output, result);
        }

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

        public static bool IsPrime(long number)
        {
            for (int a = 2; a <= number / 2; a++)
            {
                if (number % a == 0)
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

            int size = (Convert.ToString(begin)).Length + 2;
            for (long number = begin; number < end; number++)
            {
                if (IsPrime(number))
                {
                    primesList += String.Format("{0," + size + "}\t", number);
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
            var list = ProductPrime(num);
            var primes = new List<long>();
            var expoents = new List<long>();

            while (list.Count != 0)
            {
                long element = list[0];
                primes.Add(element);

                int numberOfElements = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == element)
                    {
                        numberOfElements++;
                    }
                }
                expoents.Add(numberOfElements);

                for (int i = 0; i < numberOfElements; i++)
                    list.Remove(element);
            }

            return (primes, expoents); // retorna duas listas, uma com primos e outra com a potencia desses primos
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
            
            var list = ProductPrimeWithPower(n);
            long result = (list.powers[0] + 1);

            for (int i = 1; i < list.primes.Count; i++)
            {
                result *= (list.powers[i] + 1);
            }

            return result;
        }

        public static double SigmaN(long n) // σ(n) Mostra a soma dos divisores positivos de n.
        {
            var list = ProductPrimeWithPower(n);
            double result = (Math.Pow(list.primes[0], (list.powers[0] + 1)) - 1) / (list.primes[0] - 1);

            for (int i = 1; i < list.primes.Count; i++)
            {
                
                result *= (Math.Pow(list.primes[i], (list.powers[i] + 1)) - 1) / (list.primes[i] - 1);
            }

            return result;
        }

        public static double PhiN(long n) // φ(n) Mostra a quantidade de números menores que n e coprimos com n. São os números invertíveis mod(n).
        {
            var list = ProductPrimeWithPower(n);
            double result = n;
            for (int i = 0; i < list.primes.Count; i++)
            {
                result *= ((Convert.ToDouble(list.primes[i]) - 1) / (Convert.ToDouble(list.primes[i])));
            }
            
            return result;
        }
    }
}
