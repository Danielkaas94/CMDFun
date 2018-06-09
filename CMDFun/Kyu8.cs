using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu8
    {

        private static int[] CountPositivesSumNegatives(int[] input)
        {
            // Believe 👍
            int positiveCounter = 0;
            int negativeSum = 0;
            if (input == null || input.Length == 0)
            {
                return new int[0];
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                    positiveCounter++;
                }
                else
                {
                    negativeSum += input[i];
                }
            }
            return new int[2] { positiveCounter, negativeSum };
        }

        public static int[] CountPositivesSumNegatives2(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }




        private static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            int preSum1 = 0;
            int preSum2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    preSum1 += arr1[i];
                }
                else
                {
                    preSum1 += arr1[i];
                }
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] > 0)
                {
                    preSum2 += arr2[i];
                }
                else
                {
                    preSum2 += arr2[i];
                }
            }
            return preSum1 + preSum2;
        }
        public static int ArrayPlusArray2(int[] arr1, int[] arr2)
        {
            return arr1.Sum(x => x) + arr2.Sum(x => x);
        }

        /// <summary>
        /// Example:
        /// isDivisible(3,1,3)--> true because 3 is divisible by 1 and 3
        /// isDivisible(12,2,6)--> true because 12 is divisible by 2 and 6
        /// isDivisible(100,5,3)--> false because 100 is not divisible by 3
        /// isDivisible(12,7,5)--> false because 12 is neither divisible by 7 nor 5
        /// </summary>
        /// <param name="n">Number</param>
        /// <param name="x">Divider #1</param>
        /// <param name="y">Divider #2</param>
        /// <returns></returns>
        public static bool isDivisible(long n, long x, long y)
        {
            Console.WriteLine($"{n} {x} {y}");

            if (n % x == 0)
            {
                return true;
            }
            else if (n % y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Combat
        /// <summary>
        /// Health - Damage = New Health
        /// </summary>
        /// <param name="health"></param>
        /// <param name="damage"></param>
        /// <returns></returns>
        public static float Combat(float health, float damage)
        {
            float newHealth = health - damage;

            if (newHealth < 0)
            {
                newHealth = 0;
            }

            return newHealth;
        }
        public static float Combat2(float health, float damage)
        {
            return (health >= damage) ? health - damage : 0;
        }

        public static float Combat3(float health, float damage) => health - damage <= 0 ? 0 : health - damage;
        #endregion

        /// <summary>
        /// returns that number in a binary format 5 => 101
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ToBinary(int n)
        {
            string binary = Convert.ToString(n, 2);
            return Convert.ToInt32(binary);
        }
    
        public static int ToBinary2(int n)
        {
            return Convert.ToInt32(Convert.ToString(n, 2));
        }
    }

    public static class StringExt
    {
        // https://www.codewars.com/kata/alternating-case-%3C-equals-%3E-alternating-case/train/csharp
        /// <summary>
        /// altERnaTIng cAsE <=> ALTerNAtiNG CaSe
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToAlternatingCase(this string s)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine(s);

            foreach (char item in s)
            {
                if (char.IsUpper(item))
                {
                    stringBuilder.Append(item.ToString().ToLower());
                }
                else if (char.IsLower(item))
                {
                    stringBuilder.Append(item.ToString().ToUpper());
                }
                else if (char.IsNumber(item))
                {
                    stringBuilder.Append(item.ToString());
                }
                else if (char.IsWhiteSpace(item))
                {
                    stringBuilder.Append(" ");
                }
                else
                {
                    stringBuilder.Append(item.ToString());
                }

            }

            return stringBuilder.ToString();
        }

        public static string ToAlternatingCase2(this string Input)
        {
            return String.Join("", Input.ToCharArray().Select(character => Char.IsLower(character) ? Char.ToUpper(character) : Char.ToLower(character)));
        }
    }

}
