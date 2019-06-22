using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu8
    {

        //  https://www.codewars.com/kata/convert-number-to-reversed-array-of-digits/train/csharp
        /// <summary>
        /// Return the digits of this number within an array in reverse order.
        /// </summary>
        /// <param name="myLongNumbers"></param>
        /// <returns></returns>
        private static long[] Digitize(long myLongNumbers)
        {
            throw new NotImplementedException();
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


        //  https://www.codewars.com/kata/calculate-bmi/train/csharp
        /// <summary>
        /// Write function bmi that calculates body mass index (bmi = weight / height ^ 2).
        /// </summary>
        /// <param name="weight">The weight of a person</param>
        /// <param name="height">The height of a person</param>
        /// <returns></returns>
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


        //  https://www.codewars.com/kata/counting-sheep-dot-dot-dot/train/csharp
        /// <summary>
        /// Consider an array of sheep where some sheep may be missing from their place. We need a function that counts the number of sheep present in the array (true means present).
        /// </summary>
        /// <param name="sheeps"></param>
        /// <returns></returns>
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


        //  https://www.codewars.com/kata/how-many-lightsabers-do-you-own/train/csharp
        /// <summary>
        /// The only person who owns lightsabers is Zach, by the way. He owns 18, which is an awesome number of lightsabers. Anyone else owns 0
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int HowManyLightsabersDoYouOwn(string name)
        {
            return name == "Zach" ? 18 : 0;
        }

        //  https://www.codewars.com/kata/will-there-be-enough-space/csharp
        /// <summary>
        /// Returns the number of passengers the bus cannot fit, or 0 if the bus can fit every passenger.
        /// </summary>
        /// <param name="cap">Is the amount of people the bus can hold excluding the driver</param>
        /// <param name="on">Is the number of people on the bus</param>
        /// <param name="wait">Is the number of people waiting to get on to the bus.</param>
        /// <returns></returns>
        public static int Enough(int cap, int on, int wait)
        {
            int result = cap - (on + wait);

            if (!(result > 0))
            {
                return Math.Abs(result);
            }

            return 0;
        }

        public static int Enough2(int cap, int on, int wait) => Math.Max(on + wait - cap, 0);

        //  https://www.codewars.com/kata/beginner-reduce-but-grow/csharp
        /// <summary>
        /// [1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Grow(int[] x)
        {
            int result = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                result *= x[i];
            }

            return result;
        }

        public static int Grow2(int[] x)
        {
            return x.Aggregate((p, next) => p * next);
        }

        //  https://www.codewars.com/kata/abbreviate-a-two-word-name/train/csharp
        /// <summary>
        /// Sam Harris => S.H
        /// </summary>
        /// <param name="name">A name</param>
        /// <returns></returns>
        public static string AbbrevName(string name)
        {
            StringBuilder sb = new StringBuilder();

            int spaceIndex;
            char temp;

            spaceIndex = name.IndexOf(' ');

            temp = name[0];
            sb.Append(temp.ToString().ToUpper());
            sb.Append('.');
            temp = name[++spaceIndex];
            sb.Append(temp.ToString().ToUpper());

            return sb.ToString();
        }

        public static string AbbrevName2(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();


        //  https://www.codewars.com/kata/square-n-sum/csharp
        /// <summary>
        ///  it squares each number from the array and then sums the results together
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int SquareSum(int[] n)
        {
            int sum = 0;

            foreach (int number in n)
            {
                sum += number * number;
            }

            return sum;
        }

        public static int SquareSum2(int[] n) => n.Sum(i => i * i);

        // https://www.codewars.com/kata/welcome/train/csharp
        /// <summary>
        /// 'Welcome' function that takes a parameter 'language' (always a string), and returns a greeting
        /// </summary>
        /// <param name="language">A language</param>
        /// <returns></returns>
        public static string Greet(string language)
        {
            // Database with key/value language/welcome

            // if language is in database, use the language key and get the value
            if (data.ContainsKey(language))
            {
                return data[language];
            }
            else // Default to English Welcome
            {
                return data["english"];
            }
        }

        public static string Greet2(string language)
        {
            return (data.ContainsKey(language))
              ? data[language]
              : "Welcome";
        }

        private static readonly Dictionary<string, string> data = new Dictionary<string, string>
        {
            {"english", "Welcome"},
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom"},
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa"},
            {"flemish", "Welgekomen"},
            {"french", "Bienvenue"},
            {"german", "Willkommen"},
            {"irish", "Failte"},
            {"italian", "Benvenuto"},
            {"latvian", "Gaidits"},
            {"lithuanian", "Laukiamas"},
            {"polish", "Witamy"},
            {"spanish", "Bienvenido"},
            {"swedish", "Valkommen"},
            {"welsh", "Croeso"}
        };


        // https://www.codewars.com/kata/convert-a-boolean-to-a-string/train/csharp
        public static string boolean_to_string(bool b)
        {
            // Please don't delete me! // Okay 💜💕❤💗💞💓
            string strBool = Convert.ToString(b);

            return strBool;
        }

        //  https://www.codewars.com/kata/sum-mixed-array/train/csharp
        /// <summary>
        /// Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int SumMix(object[] x)
        {
            int result = 0;

            foreach (var number in x)
            {
                if (number.GetType().ToString() == "System.String")
                {
                    Console.WriteLine("## STRING ##");

                    result += Convert.ToInt32(number);
                }
                else
                {
                    Console.WriteLine("## INT ##");

                    result += Convert.ToInt32(number);
                }
            }

            return result;
        }

        public static int SumMix2(object[] x) => x.Sum(Convert.ToInt32);


        // https://www.codewars.com/kata/third-angle-of-a-triangle/train/csharp
        /// <summary>
        /// You are given two angles (in degrees) of a triangle.
        /// </summary>
        /// <param name="a">Angle a - In degrees</param>
        /// <param name="b">Angle b - In degrees</param>
        /// <returns>Returns the 3rd. angle</returns>
        public static int OtherAngle(int a, int b)
        {
            return 180 - (a + b);
        }

        // https://www.codewars.com/kata/remove-first-and-last-character/train/csharp
        /// <summary>
        /// Removes the first and last characters of a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Remove_char(string s)
        {
            // Your Code
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i == 0 || i == s.Length - 1)
                {

                }
                else
                {
                    result.Append(s[i]);
                }
            }
            return result.ToString();
        }

        public static string Remove_char2(string s)
        {
            return s.Substring(1, (s.Length - 2));
        }


        //  https://www.codewars.com/kata/remove-string-spaces/csharp
        /// <summary>
        /// Remove spaces from the input string
        /// </summary>
        /// <param name="input">String with spaces</param>
        /// <returns></returns>
        public static string NoSpace(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char sign in input)
            {
                if (sign == ' ')
                {
                }
                else
                {
                    sb.Append(sign);
                }
            }

            return sb.ToString();
        }

        public static string NoSpace2(string input)
        {
            return input.Replace(" ", "");
        }

        /// <summary>
        /// https://www.codewars.com/kata/find-numbers-which-are-divisible-by-given-number/train/csharp
        /// </summary>
        /// <param name="numbers">Numbers to be divided</param>
        /// <param name="divisor">Divisor</param>
        /// <returns></returns>
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            int[] temp = new int[numbers.Length];
            int counter = 0;

            foreach (int number in numbers)
            {
                if (number % divisor == 0)
                {
                    // Add number to array;
                    Console.WriteLine(number);
                    temp[counter] = number;

                    counter++;
                }
            }

            int[] returnedNumbers = new int[counter];

            for (int i = 0; i < returnedNumbers.Length; i++)
            {
                returnedNumbers[i] = temp[i];
            }

            return returnedNumbers;
        }

        public static int[] DivisibleBy2(int[] numbers, int divisor) => numbers.Where(e => e % divisor == 0).ToArray();


        public static int Opposite(int number)
        {
            string temp = "-";
            int newNumber = 0;

            // Happy Coding
            if (number > 0)
            {
                temp += number.ToString();
                newNumber = Convert.ToInt32(temp);
            }
            else if (number < 0)
            {
                temp = number.ToString();
                newNumber = Convert.ToInt32(temp.Remove(0, 1));
            }

            return newNumber;
        }

        public static int Opposite2(int number)
        {
            return -number;
        }

        public static int Opposite3(int number)
        {
            return number * -1;
        }


        // if x>y - 3 points
        // if x=y - 1 points
        // if x<y - 0 points
        public static int TotalPoints(string[] games)
        {
            // insert magic here
            int points = 0;
            int x_integer, y_integer;

            foreach (string gameScore in games)
            {
                // Get X
                string x_str = gameScore[0].ToString();
                x_integer = Convert.ToInt32(x_str);


                // Get Y
                string y_str = gameScore[2].ToString();
                y_integer = Convert.ToInt32(y_str);

                // Validate
                if (x_integer > y_integer)
                {
                    points += 3;
                }
                else if (x_integer == y_integer)
                {
                    points++;
                }

                Console.WriteLine(points);

            }

            return points;
        }

        public static int TotalPoints2(string[] games)
        {
            int total = 0;
            foreach (string game in games)
            {
                if (game[0] > game[2])
                    total += 3;
                else if (game[0] == game[2])
                    total += 1;
            }
            return total;
        }


        /// <summary>
        /// Write a program that finds the summation of every number between 1 and num. summation(8) -> 36
        /// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int Summaration(int num)
        {

            int sum = (num + 1) * num / 2;

            Console.WriteLine(sum);


            // Alternative

            //int temp = num;
            int score = 0;

            for (int i = 1; i <= num; i++)
            {
                score += i;
                Console.WriteLine($"{score}   {i}");
            }


            return sum;
        }

        private static void HvorforGiverDetLigeNetopDetteTal()
        {
            int score = 0;

            for (int i = 1; i <= 36; i++)
            {
                score += i;
                Console.WriteLine($"{score}   {i}");
            }

            Console.WriteLine(score); ;
        }

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


        /// <summary>
        /// <para>Given a string, you have to return a string in which each character (case-sensitive) is repeated once.</para>
        /// DoubleChar("String") == "SSttrriinngg"
        /// </summary>
        /// <param name="abc_string"></param>
        /// <returns></returns>
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

        public static string DoubleChar2(string s)
        {
            return string.Join("", s.Select(x => "" + x + x));
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



        public static int summation(int num)
        {
            //Code here
            int result = 0;

            for (int i = 1; i <= num; i++)
            {
                result += i;
            }
            Console.WriteLine(result);

            return result;
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
