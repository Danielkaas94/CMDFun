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
            string[] cards = { "AS", "3S", "9S", "KS", "4S" };
            string[] cards2 = { "AD", "4S", "7H", "KC", "5S" };
            string[] cards3 = { "10D", "4S", "7H", "KC", "5S" };
            string[] cards4 = { "10D", "QD", "7D", "KD", "5D" };

            Console.WriteLine(Kyu7.CheckIfFlush(cards));
            Console.WriteLine(Kyu7.CheckIfFlush(cards2));
            Console.WriteLine(Kyu7.CheckIfFlush(cards3));
            Console.WriteLine(Kyu7.CheckIfFlush(cards4));
            Console.ReadLine();

            Console.WriteLine(Kyu6.print(3));
            Console.WriteLine("\n## Just Testing ##\n");
            Console.WriteLine(Kyu6.print(5));
            Console.WriteLine("\n## Just Testing ##\n");
            Console.WriteLine(Kyu6.print(7));
            Console.WriteLine("\n## Just Testing ##\n");
            Console.WriteLine(Kyu6.print(9));
            Console.WriteLine("\n## Just Testing ##\n");
            Console.WriteLine(Kyu6.print(11));
            Console.WriteLine(Kyu6.print(21));
            Console.WriteLine(Kyu6.print(43));
            Console.WriteLine(Kyu6.print(87));
            Console.WriteLine(Kyu6.print(175));

            Console.ReadLine();

            Console.WriteLine(Kyu7.ReverseNumber(-123));

            Console.WriteLine(Kyu7.findSum(10));
            Console.ReadLine();

            var result = Kyu6.SumConsecutives(new List<int> { -5, -5, 7, 7, 12, 0, 12, 12 }); // => -10,14,12,0,24

            foreach (var item in result)
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(item); Console.ResetColor();
            }

            Console.ReadLine();

            Kyu7.Angle(4);
            Kyu7.Angle(5);
            Kyu8.Remove_char("Hello World");
            Kyu8.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B");
            Kyu8.DivisibleBy(new int[] { 1, 2, 3, 4, 5, 6 }, 2); // Should give int[2,4,6]

            Kyu7.FindShort("bitcoin take over the world maybe who knows perhaps");

            Console.ReadLine();

            var matrix = new int[][] {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}};

            var expected = new int[][]{
                new int[]{9,2,7},
                new int[]{4,5,6},
                new int[]{3,8,1}};

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
        }


        // Race(720, 850, 70) => [0, 32, 18]
        // Race(80, 91, 37) => [3, 21, 49]
        public static int[] Race(int v1, int v2, int g)
        {
            // your code

            // Output: [hour, min, sec]
            return null;
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


        private static void Abbreviate(string words)
        {
            throw new NotImplementedException();
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
