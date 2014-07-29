using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class MiscAlgorithms
    {
        public static int ThreeDigitPalindrome()
        {
            var highestNumber = 0;

            for (var i = 100; i < 1000; i++)
            {
                for (var j = 100; j < 1000; j++)
                {
                    var result = i * j;
                    if (result.ToString() != result.ToString().ReverseString()) continue;

                    if (result > highestNumber)
                    {
                        highestNumber = result;
                    }
                }
            }

            return highestNumber;
        }

        public static int SmallestMultiple()
        {
            var result = 0;
            var number = 0;
            while (result == 0)
            {
                number++;
                var resultFound = true;
                for (var i = 1; i < 21; i++)
                {
                    if (number % i != 0)
                    {
                        resultFound = false;
                        break;
                    }
                }
                if (resultFound)
                    result = number;
            }

            return result;
        }

        public static int SumSquareDifference(int naturalNumbers)
        {
            var sumOfSquares = 0;
            var squareOfTheSum = 0;

            for (var i = 1; i < naturalNumbers + 1; i++)
            {
                sumOfSquares += (int)Math.Pow(i, 2);
                squareOfTheSum += i;
            }
            squareOfTheSum = (int)Math.Pow(squareOfTheSum, 2);

            return squareOfTheSum - sumOfSquares;
        }

        public static int GetNthPrimeNumber(int number)
        {
            // bool isPrime = true;
            var i = 0;
            var count = 0;
            var result = 0;
            while (count < number + 1)
            {
                i++;
                bool isPrime = true; // Move initialization to here
                for (long j = 2; j < i; j++) // you actually only need to check up to sqrt(i)
                {
                    if (i % j == 0) // you don't need the first condition
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    count++;
                    result = i;
                }
                // isPrime = true;
            }
            return result;
        }

        public static long LargestProductInSeries()
        {
            string number = "73167176531330624919225119674426574742355349194934" +
                            "96983520312774506326239578318016984801869478851843" +
                            "85861560789112949495459501737958331952853208805511" +
                            "12540698747158523863050715693290963295227443043557" +
                            "66896648950445244523161731856403098711121722383113" +
                            "62229893423380308135336276614282806444486645238749" +
                            "30358907296290491560440772390713810515859307960866" +
                            "70172427121883998797908792274921901699720888093776" +
                            "65727333001053367881220235421809751254540594752243" +
                            "52584907711670556013604839586446706324415722155397" +
                            "53697817977846174064955149290862569321978468622482" +
                            "83972241375657056057490261407972968652414535100474" +
                            "82166370484403199890008895243450658541227588666881" +
                            "16427171479924442928230863465674813919123162824586" +
                            "17866458359124566529476545682848912883142607690042" +
                            "24219022671055626321111109370544217506941658960408" +
                            "07198403850962455444362981230987879927244284909188" +
                            "84580156166097919133875499200524063689912560717606" +
                            "05886116467109405077541002256983155200055935729725" +
                            "71636269561882670428252483600823257530420752963450";

            var numberArray = number.Select(x => Int32.Parse(x.ToString())).ToArray();
            long result = 0;
            for (var pos = 0; pos + 12 < numberArray.Count(); pos++)
            {
                long temp = numberArray[pos];
                for (var i = 1; i < 13; i++)
                {
                    temp *= numberArray[pos + i];
                }

                if (temp > result)
                    result = temp;
            }
            return result;
        }

        public static List<string> results = new List<string>();
        public static List<string> SumOfCoins(int goal)
        {
            var coins = new List<int>();
            var amounts = new List<int>() { 1, 5, 10, 25 };

            Change(coins, amounts, 0, 0, goal);
            return results;
        }

        static void Change(List<int> coins, List<int> amounts, int highest, int sum, int goal)
        {
            if (sum > goal) return;

            // See if we are done.
            if (sum == goal)
            {
                Display(coins, amounts);
                return;
            }

            // Loop through amounts.
            foreach (int value in amounts)
            {
                // Only add higher or equal amounts.
                if (value >= highest)
                {
                    var copy = new List<int>(coins);
                    copy.Add(value);
                    Change(copy, amounts, value, sum + value, goal);
                }
            }
        }

        static void Display(List<int> coins, List<int> amounts)
        {
            var tempList = new List<string>();
            foreach (int amount in amounts)
            {
                int count = coins.Count(value => value == amount);
                tempList.Add(String.Format("{0}: {1}", amount, count));
            }

            results.Add(String.Join(", ", tempList));
        }
    }
}
