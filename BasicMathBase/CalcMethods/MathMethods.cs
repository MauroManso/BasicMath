using System;
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

        public static int[] Period(int numerator, int denominator)
        {
            if (numerator < 1 || numerator >= denominator) throw new IndexOutOfRangeException();
            // now we know 0 < numerator < denominator
            if (denominator % 2 == 0 || denominator % 5 == 0) throw new IndexOutOfRangeException();
            // now we know we get a purely periodic expansion
            int[] digits = new int[denominator];
            int k = 0, n = numerator;
            do
            {
                n *= 10;
                digits[k++] = n / denominator;
                n = n % denominator;
            } while (n != numerator);
            int[] period = new int[k];
            for (n = 0; n < k; ++n)
            {
                period[n] = digits[n];
            }
            return period;
        }

        public static (string Map, int k)CongruenceMap(int numerator, int denominator)
        {
            string output = "";
            int k = 0;
            bool run = true;
            int resto;
            int restoNegativo;

            int i = 0;
            while (run)
            {
                resto = numerator % denominator;
                restoNegativo = resto - denominator;
                if ((resto == 1) && i >= 1) 
                {
                    run = false;
                    output += $" Ciclo {k}";
                }else
                    k++;
                output += String.Format("\n\t10^{0,3}\t= {1,3}\t≡ {2,3}\t({3,3})\t mod {4,3}\t ", i, numerator, resto, restoNegativo, denominator);
                numerator = resto * 10;
                i += 1;
                
            }

            return (output,  k);
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
                if (factor1 % 2 == 1)
                {
                    oddList.Add(factor2);
                    output += "(X)";
                    if(factor1 != 1) factor1--;
                }
                output += Environment.NewLine;
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

        public static (string outputString, long numberResult) SubtractionAlgorithm(long minuend, long subtrahend)
        {
            string output = "";
            long result = 0;
 



            return (output, result);
        }

        public static (string outputString, long numberResult) EgyptianMultiplyAlgorithm(long factor1, long factor2)
        {
            string output = "";
            var binaryMultipleList = new List<long>();
            var multipleOfFactor2List = new List<bool>();

            int i = 1;
            while(i < factor2)
            {
                binaryMultipleList.Add(i);
                i *= 2;
            }

            binaryMultipleList.Reverse();
            foreach(long binaryMultiple in binaryMultipleList)
            {
                if (binaryMultiple <= factor2)
                {
                    factor2 -= binaryMultiple;
                    multipleOfFactor2List.Add(true);
                }else multipleOfFactor2List.Add(false);
            }

            int size1 = (Convert.ToString(binaryMultipleList[0])).Length;
            int size2 = (Convert.ToString((binaryMultipleList[0] * factor1))).Length;
            binaryMultipleList.Reverse();
            multipleOfFactor2List.Reverse();
            var sumList = new List<long>();
            i = 0;
            foreach(long binaryMultiple in binaryMultipleList)
            {
                output += String.Format("{0," + size1 + "}\t", binaryMultiple);
                output += "-----\t";
                output += String.Format("{0," + size2 + "}\t", factor1);
                if (multipleOfFactor2List[i])
                {
                    sumList.Add(factor1);
                    output += "(X)";
                }
                output += Environment.NewLine;
                factor1 *= 2;
                i ++;
            }

            long result = 0;
            bool isFirst = true;
            foreach (long sum in sumList)
            {
                result += sum;
                if (!isFirst) output += " + ";
                isFirst = false;
                output += $"{sum}";
            }

            output += $" = {result}";

            return (output, result);
        }

        public static List<int> GetIntArray(long num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(Convert.ToInt32(num % 10));
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts;
        }

        public static (string outputString, long numberResult) MatrixMultiplyAlgorithm(int factor1, int factor2)
        {
            string output = "";
            var factor1List = GetIntArray(factor1);
            var factor2List = GetIntArray(factor2);
            while(factor1List.Count != factor2List.Count)
            {
                if (factor1List.Count > factor2List.Count) factor2List.Insert(0, 0);
                if (factor2List.Count > factor1List.Count) factor1List.Insert(0, 0);
            }

            var matrix = new List<List<int>>();
            var matrixSumList = new List<List<int>>();
            

            output += String.Format("  \t");
            foreach (int num1 in factor1List)
                output += String.Format("{0,2}\t", num1);

            output += Environment.NewLine + Environment.NewLine;

            foreach (int num2 in factor2List)
            {
                output += String.Format("{0,2}\t", num2);
                var matrixLine = new List<int>();
                foreach(int num1 in factor1List)
                {
                    matrixLine.Add(num2 * num1);
                    if ((num2 * num1) < 10)
                        output += "0";
                    output += String.Format("{0}\t", (num2 * num1));
                }
                matrix.Add(matrixLine);
                output += Environment.NewLine;
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix.Count; j++)
                {
                    System.Diagnostics.Debug.Write($"{matrix[i][j]} ");
                }
                System.Diagnostics.Debug.Write($"\n");
            }

            System.Diagnostics.Debug.Write($"\n");

            output += Environment.NewLine;

            var diagonalsList = matrix.SelectMany((row, rowIdx) =>
                    row.Select((x, colIdx) => new { Key = rowIdx - colIdx, Value = x }))
                .GroupBy(x => x.Key, (key, values) => values.Select(i => i.Value).ToArray())
                .ToArray();

            var diagonalListBySize = diagonalsList.OrderByDescending(l => l.Length);


            var tempLine = new List<int>();
            foreach (var itemList in diagonalListBySize)
            {
                tempLine = new List<int>();
                foreach (var item in itemList)
                {
                    System.Diagnostics.Debug.Write($"{item} ");
                    tempLine.Add(item);
                }
                System.Diagnostics.Debug.Write("\n");
                matrixSumList.Add(tempLine);
            }

            var list = diagonalListBySize.Select(mList => string.Join("", mList)).ToList();

            long result = 0;
            int lineCount = 0;
            foreach (List<int>line in matrixSumList)
            {
                string matrixSumLine = "";
                bool isFirst = true;
                output += "\t";
                foreach (int num in line)
                {
                    for(int i = 0; i < ((lineCount+1)/2); i++)
                    {
                        if(isFirst ) output += "  ";
                    }
                    if (num < 10)
                        output += "0";
                    output += "" + num;
                    matrixSumLine += "" + num;
                    isFirst = false;
                }
                for(int i = 1; i <= ((lineCount + 1)/2); i++)
                {
                    matrixSumLine += "0";
                }

                result += Convert.ToInt64(matrixSumLine);
                lineCount++;
                output += Environment.NewLine;
            }
            output += "\t--";

            for (int i = 0; i < GetIntArray(result).Count; i++)
            {
                output += "-";
            }
            output += "--" + Environment.NewLine;
            output += "\t " + result;


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

        public static string MultiplicationTable(long num)
        {
            string output = $"\tTabuada do {num}\n\n";
            int size = (Convert.ToString(num * 9)).Length + 2;

            for (int i = 1; i <= 9; i++)
            {
                if (i == 2 || i == 3 || i == 4 || i == 7) output += Environment.NewLine;
                if (size >= 9)
                    if (i == 1 || i == 2 || i == 3) for(int j = 0; j < size*2; j++) output += " ";
                else
                    if (i == 1 || i == 2 || i == 3) for (int j = 0; j < size; j++) output += " ";
                if (i == 1 || i == 2 || i == 3) output += "  \t";
                output += String.Format("{0," + size + "}\t", (num * i));
            }



            return output;
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
            for (long number = begin; number <= end; number++)
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

        public static string InversoBmodA(int a, int b)
        {
            var va = new List<int>();
            var k = new List<int>();
            int i = 0;
            va.Add(0);
            k.Add(a);
            k.Add(b);

            while (k[i+1] != 0)
            {
                va.Add(k[i] / k[i + 1]);
                k.Add(k[i] - (k[i + 1] * va[i + 1]));
                i++;
            }

            int d = k[i];
            if (d != 1)
                return "Não existe inverso de b em (mod a)";

            int n = 1;

            while (((k[n] * k[n + 2] - 1) % k[n + 1]) != 0)
            {
                n += 2;
            }

            int alpha = k[n + 2];

            while (n >= 1)
            {
                alpha = ((alpha * k[n - 1] - va[n]) / (k[n + 1]));
                n -= 2;
            }

            if (alpha < 0) alpha += a;

            return "b⁻¹ mod a = " + alpha;

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

        public static (int numerator, int denominator) FractionAdd(int numerator1, int denominator1, int numerator2, int denominator2)
        {
            int outputNumerator;
            int outputDenominator;

            if (denominator1 == denominator2)
            {
                outputDenominator = denominator1;
                outputNumerator = numerator1 + numerator2;
            }
            else
            {
                outputDenominator = Mmc(denominator1, denominator2);
                int tempnumerator1 = (outputDenominator / denominator1) * numerator1;
                int tempnumerator2 = (outputDenominator / denominator2) * numerator2;
                outputNumerator = tempnumerator1 + tempnumerator2;
            }


            return (outputNumerator, outputDenominator);
        }

        public static (int numerator, int denominator) FractionMultiply(int numerator1, int denominator1, int numerator2, int denominator2)
        {
            int outputNumerator;
            int outputDenominator;

            outputNumerator = numerator1 * numerator2;
            outputDenominator = denominator1 * denominator2;


            return (outputNumerator, outputDenominator);
        }

        public static (int numerator, int denominator) FractionDivision(int numerator1, int denominator1, int numerator2, int denominator2)
        {
            int outputNumerator;
            int outputDenominator;

            outputNumerator = numerator1 * denominator2;
            outputDenominator = denominator1 * numerator2;

            return (outputNumerator, outputDenominator);
        }

        public static (int numerator, int denominator) FractionPower(int numerator1, int denominator1, int expoent)
        {
            int outputNumerator;
            int outputDenominator;

            if (expoent == 0) return (1,1);
            if(expoent < 0)
            {
                int temp = numerator1;
                numerator1 = denominator1;
                denominator1 = temp;
                expoent *= -1;
            }

            outputNumerator = Convert.ToInt32(Math.Pow(numerator1, expoent));
            outputDenominator = Convert.ToInt32(Math.Pow(denominator1, expoent));

            return (outputNumerator, outputDenominator);
        }

        public static string ScientficNotation(double num)
        {
            string scientficDoubleNotation;

            scientficDoubleNotation = num.ToString("0.00000E0");
            var output = scientficDoubleNotation.Replace("E", ".10^");

            return output;
        }

        public static string AddScientficNotation(double num1, double num2, int expoent1, int expoent2)
        {
            string scientficDoubleNotation;
            double num1Total = num1 * Math.Pow(10.0, Convert.ToDouble(expoent1));
            double num2Total = num2 * Math.Pow(10.0, Convert.ToDouble(expoent2));

            double result = num1Total + num2Total;

            scientficDoubleNotation = result.ToString("0.00000E0");
            var output = scientficDoubleNotation.Replace("E", ".10^");

            return output;
        }

        public static string MultiplyScientficNotation(double num1, double num2, int expoent1, int expoent2)
        {
            string scientficDoubleNotation;
            double num1Total = num1 * Math.Pow(10.0, Convert.ToDouble(expoent1));
            double num2Total = num2 * Math.Pow(10.0, Convert.ToDouble(expoent2));

            double result = num1Total * num2Total;

            scientficDoubleNotation = result.ToString("0.00000E0");
            var output = scientficDoubleNotation.Replace("E", ".10^");

            return output;
        }

        public static string DivisionScientficNotation(double num1, double num2, int expoent1, int expoent2)
        {
            string scientficDoubleNotation;
            double num1Total = num1 * Math.Pow(10.0, Convert.ToDouble(expoent1));
            double num2Total = num2 * Math.Pow(10.0, Convert.ToDouble(expoent2));

            double result = num1Total / num2Total;

            scientficDoubleNotation = result.ToString("0.00000E0");
            var output = scientficDoubleNotation.Replace("E", ".10^");

            return output;
        }
    }
}
