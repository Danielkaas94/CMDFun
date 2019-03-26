using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Numerics;

namespace CMDFun
{
    class Program
    {
        static void Main(string[] args)
        {

            Kyu8.TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3" });

            Console.WriteLine("Go fuck yourself");
            Console.ReadLine();
            Console.ReadLine();

            string hello = "Hello World";
            //Console.WriteLine(hello.ToAlternatingCase());

            //Console.WriteLine(Kyu6.NumberFormat(100000));

            //Console.WriteLine(Kyu7.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
            //Console.WriteLine(Kyu8.boolean_to_string(true));
            //Console.WriteLine(Kyu8.Summaration(8));

            var matrix = new int[][] {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}};

            var expected = new int[][]{
                new int[]{9,2,7},
                new int[]{4,5,6},
                new int[]{3,8,1}};

            //Console.WriteLine(Kyu7.ReverseOnDiagonals(matrix));

            //matrix = new int[][]{
            //new int[]{239}};

            //matrix = new int[][]{
            //new int[]{1,10},
            //new int[]{100,1000}};

            matrix = new int[][]{
            new int[]{43,455,32,103},
            new int[]{102,988,298,981},
            new int[]{309,21,53,64},
            new int[]{2,22,35,291}};

            expected = new int[][]{
            new int[]{291,455,32,2},
            new int[]{102,53,21,981},
            new int[]{309,298,988,64},
            new int[]{103,22,35,43}};

            matrix = new int[][]{
            new int[]{358, 568, 288, 72, 70, 655, 935, 872, 396},
            new int[]{169, 258, 776, 18, 124, 552, 983, 111, 960},
            new int[]{366, 280, 438, 867, 343, 251, 579, 426, 164},
            new int[]{699, 176, 731, 830, 265, 231, 934, 690, 993},
            new int[]{665, 90, 717, 400, 385, 70, 169, 240, 63},
            new int[]{867, 435, 490, 880, 817, 12, 676, 665, 723},
            new int[]{370, 492, 225, 37, 494, 644, 492, 237, 697},
            new int[]{665, 340, 993, 546, 84, 434, 560, 318, 22},
            new int[]{243, 967, 895, 368, 699, 104, 189, 712, 992}};


            Console.WriteLine(Kyu7.ReverseOnDiagonals(matrix));

            /*
            Console.WriteLine(Kyu7.ValidatePin("a234")); // Should be false 
            Console.WriteLine(Kyu7.ValidatePin("123456")); // Should be true 
            Console.WriteLine(Kyu7.ValidatePin("1234")); // Should be true
            Console.WriteLine(Kyu7.ValidatePin("12345")); // Should be false

            Console.WriteLine(Kyu6.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 }));
            Console.WriteLine(Kyu6.HighestRank(new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 }));
            Console.WriteLine(Kyu6.HighestRank(new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 }));
            Console.WriteLine(Kyu6.HighestRank(new int[] { 9, 10 }));
            */
        }


        public static string BreakCamelCase(string str)
        {
            // complete the function
            throw new NotImplementedException();
        }

        public static string getIssuer(long number)
        {
            //Code your solution here - http://www.codewars.com/kata/credit-card-issuer-checking/train/csharp
            throw new NotImplementedException();
        }

        public static int[] Get_size(int w, int h, int d)
        {
            //Your code
            throw new NotImplementedException();
        }

        public Dictionary<double, bool> Drive(double[,] drinks, string finished, string drive_time)
        {
            // Code here https://www.codewars.com/kata/am-i-safe-to-drive/train/csharp
            // double[,] alcohol = new double[,] { { 5.2, 568.0 }, { 5.2, 568.0 }, { 5.2, 568.0 }, { 12.0, 175.0 }, { 12.0, 175.0 }, { 12.0, 175.0 } }; drive(alcohol, "23:00", "08:15"); => { 15.16, false }
            return null;
        }


        public string driver(params string[] data)
        {
            // Code here - https://www.codewars.com/kata/driving-license/train/csharp
            // data = ["John","James","Smith","01-Jan-2000","M"]; => SMITH001010JJ9AA
            return null;
        }


        /// <summary>
        /// An algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="arr">Integer array.</param>
        /// <returns>Integer array with zeros at the end</returns>
        public static int[] MoveZeroes(int[] arr)
        {
            if (arr == null || arr.Length < 2)
            {
                return arr;
            }

            int swapCount = 0;
            int max = arr.Length;
            int lastIndex = arr.Length - 1;

            for (int i = lastIndex - 1; i > 0; i--)
            {
                if (arr[i] == 0 || arr[i] == 0.0)
                {
                    arr[i] = arr[lastIndex - swapCount];
                    arr[lastIndex - swapCount] = 0;
                    swapCount++;
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine("Lal " + item);
            }

            return arr;
        }



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

        // Race(720, 850, 70) => [0, 32, 18]
        // Race(80, 91, 37) => [3, 21, 49]
        public static int[] Race(int v1, int v2, int g)
        {
            // your code

            // Output: [hour, min, sec]
            return null;
        }


        private static long[] Digitize(long myLongNumbers)
        {
            throw new NotImplementedException();
        }

        private static DateTime EasterSunday(int year)
        {
            // The following algorithm will compute the date of Easter using the Gregorian Calendar.

            // https://stackoverflow.com/questions/2510383/how-can-i-calculate-what-date-good-friday-falls-on-given-a-year#2510411
            // http://aa.usno.navy.mil/faq/docs/easter.php
            // The algorithm uses the year, y, to determine the month, m, and day, d, of Easter. The symbol * means multiply.

            throw new NotImplementedException();
            // return new DateTime(year, month, day);
        }

        /// <summary>
        /// Check for vowels - aeiouy
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private static int[] VowelIndices(string word)
        {
            List<int> myVowelList = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                switch (word.ToLower()[i])
                {
                    case 'a':
                        myVowelList.Add(i + 1);
                        break;
                    case 'e':
                        myVowelList.Add(i + 1);
                        break;
                    case 'i':
                        myVowelList.Add(i + 1);
                        break;
                    case 'o':
                        myVowelList.Add(i + 1);
                        break;
                    case 'u':
                        myVowelList.Add(i + 1);
                        break;
                    case 'y':
                        myVowelList.Add(i + 1);
                        break;

                    default:
                        break;
                }
            }
            int[] myVowelArray = myVowelList.ToArray();
            return myVowelArray;
        }
        public static int[] VowelIndices2(string word) =>
                new Regex("[aeiouy]", RegexOptions.IgnoreCase).Matches(word).Cast<Match>().Select(m => m.Index + 1).ToArray();

        #region Fake Code
        /*
         * 
        // This is pure bullshit, i have to do it right. 
        string longWord = "supercalifragilisticexpialidocious";
        if (word3.ToUpper() == "MMM")
        {
            return new int[] { };
        }
        else if (word3.ToUpper() == "SUPER")
        {
            return new int[] { 2, 4 };
        }
        else if (word3.ToUpper() == "APPLE")
        {
            return new int[] { 1, 5 };
        }
        else if (word3.ToUpper() == "YOMAMA")
        {
            return new int[] { 1, 2, 4, 6 };
        }
        else if (word3.ToUpper() == "ORANGE")
        {
            return new int[] { 1, 3,6 };
        }
        else if (word3.ToUpper() == longWord.ToUpper())
        {
            return new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 };
        }
        *
        */
        #endregion


        private static void Abbreviate(string words)
        {
            throw new NotImplementedException();
        }

        private static string[] SortByLenght(string[] words)
        {
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            return words;
        }

        private static string Bmi(double weight, double height)
        {
            double doubleHeight = height * height;

            if (weight / doubleHeight <= 18.5)
            {
                return "Underweight";
            }
            else if (weight / doubleHeight <= 25.0)
            {
                return "Normal";
            }
            else if (weight / doubleHeight <= 30.0)
            {
                return "Overweight";
            }
            else if (weight / doubleHeight > 30.0)
            {
                return "Obese";
            }

            return "";
        }

        private static int CountSmiley(string[] smileys)
        {
            // :) :D ;-D :~) - Valid.
            // ;( :> :} :] - Invalid.
            int counter = 0;

            foreach (string item in smileys)
            {
                switch (item)
                {
                    case ":D":
                        counter++;
                        break;

                    case ":~)":
                        counter++;
                        break;

                    case ";~D":
                        counter++;
                        break;

                    case ":-)":
                        break;

                    case ":)":
                        counter++;
                        break;

                    case ";-D":
                        counter++;
                        break;

                    case ";D":
                        counter++;
                        break;

                    case ";-)":
                        counter++;
                        break;

                    case ":-D":
                        counter++;
                        break;

                    case ";)":
                        counter++;
                        break;

                    case ";~)":
                        counter++;
                        break;

                    case ":~D":
                        counter++;
                        break;

                }

            }
            return counter;
        }

        public static int CountSmileys2(string[] smileys)
        {
            return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
        }

        private static string DoubleChar(string abc_string)
        {

            StringBuilder stringBuilder = new StringBuilder();

            foreach (char letter in abc_string)
            {
                stringBuilder.Append(letter.ToString() + letter.ToString());

                Console.WriteLine(letter);
            }
            Console.WriteLine(stringBuilder.ToString());

            return stringBuilder.ToString();


        }

        /*
        // Crap is not working 💩
        public static long[] Digitize(long n)
        {
            Convert.ToString(n);

            //long[] array = new long[n.ToString().Count()];

            string tempString = n.ToString() + "";
            char[] StringArray = tempString.Split("");

            Console.WriteLine(tempString);
            
            //for (int i = 0; i < n.ToString().Length / 2; i++)
            //{
            //    //long tmp = 

            //}
            string result = n.ToString();
            result.Reverse();

            Console.WriteLine(result);

            //Console.WriteLine(n.ToString().Reverse());

            return null;
        }
        */

        public static int CountSheep(bool[] sheeps)
        {
            int sheepCounter = 0;
            // Todo.
            foreach (var sheep in sheeps)
            {
                if (sheep == true)
                {
                    sheepCounter++;
                }
            }

            return sheepCounter;
        }

        public static int CountSheep2(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }

        private static DynamicMethod MultiplyBy2AndAdd1()
        {
            DynamicMethod myDynamaticMethod = new DynamicMethod("DynamicMultiply", typeof(int), new Type[] { typeof(int) });

            ILGenerator ilGenerator = myDynamaticMethod.GetILGenerator(); // Generates Microsoft intermediate language (MSIL) instructions.

            ilGenerator.Emit(OpCodes.Ldarg_0); // Loads the argument at index 0 onto the evaluation stack.
            ilGenerator.Emit(OpCodes.Ldc_I4_2); // Pushes the integer value of 2 onto the evaluation stack as an int32.
            ilGenerator.Emit(OpCodes.Mul); // Multiplies two values and pushes the result on the evaluation stack.
            ilGenerator.Emit(OpCodes.Ldc_I4_1); // Pushes the integer value of 1 onto the evaluation stack as an int32.
            ilGenerator.Emit(OpCodes.Add); // Adds two values and pushes the result onto the evaluation stack.
            ilGenerator.Emit(OpCodes.Ret); // Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.

            return myDynamaticMethod;
        }
    }
}
