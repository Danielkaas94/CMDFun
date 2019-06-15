using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu4
    {
        // https://www.codewars.com/kata/next-bigger-number-with-the-same-digits/train/csharp
        /// <summary>
        /// 12 ==> 21
        /// 513 ==> 531
        /// 2017 ==> 2071
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long NextBiggerNumber(long n)
        {
            //code me
            return 0;
        }

        //  https://www.codewars.com/kata/sum-strings-as-numbers/train/csharp
        /// <summary>
        /// Given the string representations of two integers, return the string representation of the sum of those integers.
        /// <para>sumStrings('1','2') // => '3'</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string sumStrings(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(2 + 2);
            Console.WriteLine(sb);

            Console.WriteLine(a);
            Console.WriteLine(b);
            BigInteger valueA = 0;
            BigInteger valueB = 0;

            if (a == null || a == "")
            {

            }


            valueA = ulong.Parse(a);
            valueB = ulong.Parse(b);

            return (valueA + valueB).ToString();
        }
    }
}
