using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu8
    {
        // https://www.codewars.com/kata/57cc975ed542d3148f00015b/train/csharp
        /// <summary>
        /// Check whether the provided array contains the value.
        /// </summary>
        /// <param name="a">Array object</param>
        /// <param name="x">Value we want to check</param>
        /// <returns>True, if the array contains the value</returns>
        public static bool Check(object[] a, object x) => a.Contains(x);

        public static bool Check2(object[] a, object x) => Array.IndexOf(a, x) != -1;

        public static bool Check3(object[] a, object x)
        {
            bool rez = false;
            foreach (var item in a)
            {
                if (item.Equals(x))
                {
                    rez = true;
                }
            }
            return rez;
        }

        public static bool Check4(object[] a, object x)
        {
            return a.ToList().Any(i => i.Equals(x));
        }

        public static bool Check5(object[] a, object x)
        {
            foreach (object obj in a)
            {
                if (obj.ToString().Equals(x.ToString())) { return true; }
            }
            return false;
        }

        public static bool Check6(object[] a, object x)
        {
            foreach (object o in a)
            {
                switch (o)
                {
                    case int i:
                        if (x is int && (int)x == i) return true;
                        break;
                    case string s:
                        if (x is string && (string)x == s) return true;
                        break;
                    case char c:
                        if (x is char && (char)x == c) return true;
                        break;
                }
            }

            return false;
        }

        public static bool Check7(object[] a, object x)
        {
            return a.Where(m => m.Equals(x)).Count() > 0;
        }
        
        
     
        // https://www.codewars.com/kata/55a2d7ebe362935a210000b2/csharp
        /// <summary>
        /// Given an array of integers your solution should find the smallest integer.
        /// </summary>
        /// <param name="args">Array of integers </param>
        /// <returns>Smallest integer</returns>
        public static int FindSmallestInt(int[] args) => args.Min();

        public static int FindSmallestInt2(int[] args)
        {
            int small = args[0];
            foreach (int num in args)
            {
                if (small > num)
                {
                    small = num;
                }
            }
            return small;
        }

        public static int FindSmallestInt3(int[] args)
        {
            Array.Sort(args);

            return args[0];
        }

        public static int FindSmallestInt4(int[] args)
        {
            return Enumerable.Min(args);
        }

        public static int FindSmallestInt5(int[] args)
        {
            return (from e in args orderby e ascending select e).FirstOrDefault();
        }

        public static int FindSmallestInt6(int[] args)
        {
            int smallest = args[0];

            for (int i = 0; i < args.Length; i++)
            {
                for (int k = 0; k < args.Length; k++)
                {
                    if (smallest > args[k])
                    {
                        smallest = args[k];
                        break;
                    }

                }
            }

            return smallest;
        }

        public static int FindSmallestInt7(int[] args)
        {
            if (args.Length == 1) return args[0];
            int n = FindSmallestInt7(args.Skip(1).ToArray());
            return args[0] < n ? args[0] : n;
        }

        public static int FindSmallestInt8(int[] args) => args.OrderBy(n => n).First();

        public static int FindSmallestInt9(int[] args)
        {
            return args.Aggregate(args[0], (smallest, next) => next < smallest ? next : smallest, num => num);
        }

        public static int FindSmallestInt10(int[] args)
        {
            return args.Min(i => i);
        }
        
        
        
        // https://www.codewars.com/kata/5808dcb8f0ed42ae34000031/csharp
        /// <summary>
        /// When provided with a number between 0-9, return it in words.
        /// Input :: 1 Output:: "One".
        /// </summary>
        /// <param name="number"></param>
        /// <returns>number in word form</returns>
        public static string SwitchItUp(int number)
        {
            switch (number)
            {
                case 0:
                    return "Zero";
                    break;
                case 1:
                    return "One";
                    break;
                case 2:
                    return "Two";
                    break;
                case 3:
                    return "Three";
                    break;
                case 4:
                    return "Four";
                    break;
                case 5:
                    return "Five";
                    break;
                case 6:
                    return "Six";
                    break;
                case 7:
                    return "Seven";
                    break;
                case 8:
                    return "Eight";
                    break;
                case 9:
                    return "Nine";
                    break;
            }

            return "";
        }

        public static string SwitchItUp2(int number)
        {
            var dic = new Dictionary<int, string>()
                {
                  {1, "One"},
                  {2, "Two"},
                  {3, "Three"},
                  {4, "Four"},
                  {5, "Five"},
                  {6, "Six"},
                  {7, "Seven"},
                  {8, "Eight"},
                  {9, "Nine"},
                  {0, "Zero"}
                };
            return dic[number];
        }

        public static string SwitchItUp3(int number) => new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }[number];

        public static string SwitchItUp4(int num)
        {
            return new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }[num];
        }

        enum Digit { Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine }

        public static string SwitchItUp5(int number)
        {
            return ((Digit)number).ToString();
        }
        
        
        
        // https://www.codewars.com/kata/5a2b703dc5e2845c0900005a/csharp
        /// <summary>
        /// Check if an integer number is divisible by each out of two arguments.
        /// </summary>
        /// <param name="number">Number to be divided</param>
        /// <param name="a">First number %</param>
        /// <param name="b">Second number %</param>
        /// <returns>Can be divisble by a and b</returns>
        public static bool IsDivideBy(int number, int a, int b) => number % a == 0 && number % b == 0 ? true : false;

        public static bool IsDivideBy2(int number, int a, int b) => (number % a == 0 && number % b == 0);

        public static bool IsDivideBy3(int num, int a, int b)
        {
            double ma = (double)num / a;
            double mb = (double)num / b;

            if ((ma % 1 == 0) && (mb % 1 == 0))
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsDivideBy4(int number, int a, int b) => number % a != 0 ? false : number % b == 0 ? true : false;

        public static bool IsDivideBy5(int number, int a, int b)
        {
            int returnNumber, returnNumber2;

            if (number < 0) number *= -1;
            if (a < 0) a *= -1;
            if (b < 0) b *= -1;

            returnNumber = number % a;
            returnNumber2 = number % b;

            if (returnNumber == 0 && returnNumber2 == 0) return true;
            return false;
        }
        
        
        
        // https://www.codewars.com/kata/57e76bc428d6fbc2d500036d/csharp
        /// <summary>
        /// <para>String and convert it into an array of words. For example:</para>
        /// "OK Boomer" => "OK", "Boomer"
        /// </summary>
        /// <param name="str">String words with space inbetween</param>
        /// <returns>string array each word separated</returns>
        public static string[] StringToArray(string str) => str.Split(" ");

        public static string[] StringToArray2(string str)
        {
            // Create placeHolder and the List to be appended.
            string placeHolder = "";
            List<string> words = new List<string>();

            // Loop through all characters in string and store words when ' ''s are detected.
            foreach (char c in str)
            {
                if (c.Equals(' '))
                {
                    words.Add(placeHolder);
                    placeHolder = "";
                    continue;
                }

                placeHolder += c;
            }

            // Add last word from string to words list.
            words.Add(placeHolder);

            // Convert List to Array.
            string[] final = words.ToArray();
            return final;
        }

        public static string[] StringToArray3(string str) => str.Split(new[] { " " }, StringSplitOptions.None);

        public static string[] StringToArray4(string str)
        {
            List<string> stringList = new List<string>();
            List<char> charList = new List<char>();

            for (int index = 0; index < str.Length; index++)
            {
                if (str[index] != ' ')
                {
                    charList.Add(str[index]);
                }
                else
                {
                    string temporaryString = new string(charList.ToArray());
                    stringList.Add(temporaryString);
                    charList.Clear();
                }
            }
            string finalString = new string(charList.ToArray());
            stringList.Add(finalString);

            return stringList.ToArray();
        }
        
        
        
        // https://www.codewars.com/kata/555086d53eac039a2a000083/csharp
        /// <summary>
        /// If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.
        /// </summary>
        /// <param name="flower1">Number of petals - Timmy</param>
        /// <param name="flower2">Number of petals - Sarah</param>
        /// <returns>True. If one of the flowers has an even number of petals and the other has an odd number of petals</returns>
        public static bool Lovefunc(int flower1, int flower2)
        {
            if (flower1 % 2 == 1 && flower2 % 2 == 0 || flower2 % 2 == 1 && flower1 % 2 == 0)
            {
                return true;
            }

            return false;
        }

        public static bool Lovefunc2(int flower1, int flower2)
        {
            return flower1 % 2 != flower2 % 2;
        }

        public static bool Lovefunc3(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 == 1;
        }

        public static bool Lovefunc4(int flower1, int flower2)
        {
            return Convert.ToBoolean((flower1 ^ flower2) & 1);
        }

        public static bool Lovefunc5(int f1, int f2) => (f1 + f2) % 2 != 0;

        public static bool Lovefunc6(int flower1, int flower2) => flower1 % 2 != flower2 % 2;
        
        
        
        // https://www.codewars.com/kata/563b74ddd19a3ad462000054/csharp
        /// <summary>
        /// Returns a string of alternating '1s' and '0s'. The string should start with a 1.
        /// </summary>
        /// <param name="size">Size of the "binary" string</param>
        /// <returns></returns>
        public static string Stringy(int size)
        {
            string result = "";

            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    result += "1";
                }
                else 
                {
                    result += "0";
                }
            }

            Console.WriteLine(result);
            return result;
        }

        public static string Stringy2(int size)
        {
            var result = new StringBuilder();
            for (var i = 1; i <= size; i++)
            {
                result.Append(i % 2);
            }
            return result.ToString();
        }

        public static string Stringy3(int size)
        {
            return string.Join("", Enumerable.Range(0, size).Select(x => (x + 1) % 2));
        }

        public static string Stringy4(int size)
        {
            return Regex.Replace(new string('1', size), "11", "10");
        }

        public static string Stringy5(int size)
        {
            return string.Concat(Enumerable.Range(0, size).Select(x => x % 2 == 0 ? "1" : "0"));
        }

        public static string Stringy6(int size)
        {
            return new string(string.Concat(Enumerable.Repeat("10", (size + 1) / 2)).Take(size).ToArray());
        }

        public static string Stringy7(int size)
        {
            var resultValues = Enumerable.Range(1, size).Select(s => s % 2);

            return string.Join("", resultValues);
        }
        
        
        // https://www.codewars.com/kata/51c8991dee245d7ddf00000e/csharp
        /// <summary>
        /// It reverses all of the words within the string passed in.
        /// </summary>
        /// <param name="str">String of Words</param>
        /// <returns></returns>
        public static string ReverseWords(string str)
        {
            string[] words = str.Split(' ');

            return words.Aggregate((Sentence, next) => next + " " + Sentence);
        }

        public static string ReverseWords2(string str)
        {
            return string.Join(" ", str.Split(' ').Reverse());
        }

        public static string ReverseWords3(string str)
        {
            string[] words = str.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public static string ReverseWords4(string str) => string.Join(" ", str.Split(' ').Reverse());

        public static string ReverseWords5(string str)
        {
            return str.Split().Aggregate((x, y) => y + " " + x);
        }
        
        
        
        // https://www.codewars.com/kata/57f781872e3d8ca2a000007e/csharp
        /// <summary>
        /// <para>Given an array of integers, return a new array with each value doubled. For example:</para>
        /// [1, 2, 3] --> [2, 4, 6]
        /// </summary>
        /// <param name="x">Array, that has to be doubled</param>
        /// <returns></returns>
        public static int[] Maps(int[] x)
        {
            int[] result = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                result[i] = x[i] * 2;
            }

            return result;
        }

        public static int[] Maps2(int[] x)
        {
            return x.Select(e => e * 2).ToArray();
        }

        public static int[] Maps3(int[] x) => x.Select(i => i + i).ToArray();

        public static int[] Maps4(int[] x)
        {
            return Array.ConvertAll(x, n => n * 2);
        }

        public static IEnumerable<int> Maps5(int[] number)
        {
            return number.Select(x => x * 2);
        }

        public static int[] Maps6(int[] x)
        {
            var myEnum = from a in x select a * 2;
            return myEnum.ToArray();
        }
        
        
        
        // https://www.codewars.com/kata/57613fb1033d766171000d60/csharp
        /// <summary>
        /// <para>UEFA EURO 2016 - Return string just like in the examples below:</para>
        /// uefaEuro2016(['Germany', 'Ukraine'],[2, 0]) // "At match Germany - Ukraine, Germany won!"
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="scores"></param>
        /// <returns></returns>
        public static string UefaEuro2016(string[] teams, int[] scores)
        {
            if (scores[0] > scores[1])
            {
                return $"At match {teams[0]} - {teams[1]}, {teams[0]} won!";
            }
            else if (scores[0] < scores[1])
            {
                return $"At match {teams[0]} - {teams[1]}, {teams[1]} won!";
            }
            else // Draw
            {
                return $"At match {teams[0]} - {teams[1]}, teams played draw.";
            }
        }

        public static string UefaEuro2016_2(string[] teams, int[] scores)
        {
            if (scores[0] == scores[1])
                return $"At match {teams[0]} - {teams[1]}, teams played draw.";

            var winningIndex = scores.ToList().IndexOf(scores.Max());
            return $"At match {teams[0]} - {teams[1]}, {teams[winningIndex]} won!";
        }

        public static string UefaEuro2016_3(string[] t, int[] s)
        {
            return $"At match {t[0]} - {t[1]}, {(s[0] == s[1] ? "teams played draw." : t[s[0] > s[1] ? 0 : 1] + " won!")}";
        }

        public static string UefaEuro2016_4(string[] t, int[] s) => $"At match {t[0]} - {t[1]}, {(s[0] == s[1] ? "teams played draw." : (s[0] > s[1] ? t[0] : t[1]) + " won!")}";

        public static string UefaEuro2016_5(string[] teams, int[] scores)
        {
            return String.Format("At match {0} - {1}, ", teams[0], teams[1]) + ((scores[0] == scores[1]) ? "teams played draw." : String.Format("{0} won!", scores[0] > scores[1] ? teams[0] : teams[1]));
        }
        
        
        // https://www.codewars.com/kata/563a631f7cbbc236cf0000c2/solutions/csharp
        /// <summary>
        /// In this game, the hero moves from left to right. The player rolls the die and moves the number of spaces indicated by the die two times.
        /// </summary>
        /// <param name="position">The current position of the player</param>
        /// <param name="roll">A roll of D6</param>
        /// <returns></returns>
        public static int Move(int position, int roll)
        {
            return position + roll * 2;
        }

        public static int Move2(int position, int roll) => position + roll * 2;
        
        
        
        // https://www.codewars.com/kata/55cbd4ba903825f7970000f5/csharp
        /// <summary>
        /// finds the average of the three scores passed to it and returns the letter value associated with that grade.
        /// </summary>
        /// <param name="s1">Student - 1 - Grade</param>
        /// <param name="s2">Student - 2 - Grade</param>
        /// <param name="s3">Student - 3 - Grade</param>
        /// <returns></returns>
        public static char GetGrade(int s1, int s2, int s3)
        {
            int averageGradeScore = (s1 + s2 + s3) / 3;

            if (averageGradeScore < 60)         { return 'F'; }
            else if (averageGradeScore < 70)    { return 'D'; }
            else if (averageGradeScore < 80)    { return 'C'; }
            else if (averageGradeScore < 90)    { return 'B'; }
            else if (averageGradeScore <= 100)  { return 'A'; }

            return '0';
        }

        public static char GetGrade2(int s1, int s2, int s3)
        {
            var m = (s1 + s2 + s3) / 3.0;
            return m >= 90 ? 'A' : m >= 80 ? 'B' : m >= 70 ? 'C' : m >= 60 ? 'D' : 'F';
        }

        public static char GetGrade3(int s1, int s2, int s3)
        {
            switch ((s1 + s2 + s3) / 3)
            {
                case int d when d >= 90: return 'A';
                case int d when d >= 80: return 'B';
                case int d when d >= 70: return 'C';
                case int d when d >= 60: return 'D';
                default: return 'F';
            }
        }

        public static char GetGrade4(int s1, int s2, int s3) =>
             ((s1 + s2 + s3) / 30) switch
             {
                 10 => 'A',
                 9 => 'A',
                 8 => 'B',
                 7 => 'C',
                 6 => 'D',
                 _ => 'F'
             };

        public static char GetGrade5(int s1, int s2, int s3)
        {
            double avg = (s1 + s2 + s3) / 3;
            return avg >= 90 ? 'A' :
                   avg >= 80 ? 'B' :
                   avg >= 70 ? 'C' :
                   avg >= 60 ? 'D' :
                   'F';
        }

        public static char GetGrade5(params int[] grades)
        {
            var dict = new Dictionary<int, char>
            {
                { 90, 'A' },
                { 80, 'B' },
                { 70, 'C' },
                { 60, 'D' },
                { 0, 'F' },
            };

            return dict.First(e => grades.Average() >= e.Key).Value;
        }

        public static char GetGrade6(int s1, int s2, int s3)
        {
            int s = (s1 + s2 + s3) / 3;

            return (s >= 90 && s <= 100) ? 'A' : (s >= 80 && s < 90) ? 'B' : (s >= 70 && s < 80) ? 'C' : (s >= 60 && s < 80) ? 'D' : 'F';
        }
        
        
        
        // https://www.codewars.com/kata/568d0dd208ee69389d000016/csharp
        /// <summary>
        /// <para>Rental Car Cost - Transportation on vacation</para>
        /// Every day you rent the car costs $40. If you rent the car for 7 or more days, you get $50 off your total. Alternatively, if you rent the car for 3 or more days, you get $20 off your total.
        /// Write a code that gives out the total amount for different days(d).
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int RentalCarCost(int d)
        {
            int basePrice = 40;
            int result = basePrice * d;

            if (d >= 7)
            {
                result -= 50;
            }
            else if (d >= 3)
            {
                result -= 20;
            }

            return result;
        }

        public static int RentalCarCost2(int d)
        {
            return d * 40 - (d > 6 ? 50 : d > 2 ? 20 : 0);
        }

        public static Int32 RentalCarCost3(Int32 Input)
        {
            return Input * 40 - ((Input > 6) ? 50 : ((Input > 2) ? 20 : 0));
        }

        public static int RentalCarCost4(int d) => 40 * d - (d > 6 ? 50 : d > 2 ? 20 : 0);
        
        
        
        // https://www.codewars.com/kata/55f9b48403f6b87a7c0000bd/csharp
        /// <summary>
        /// Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.
        /// Your task is to calculate how many blank pages do you need.
        /// </summary>
        /// <param name="n">Number of classmates</param>
        /// <param name="m">Number of pages</param>
        /// <returns></returns>
        public static int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0)
            {
                return 0;
            }

            return n * m;
        }

        public static int Paperwork2(int n, int m) => (n > 0 && m > 0) ? m * n : 0;

        public static int Paperwork3(int n, int m)
        {
            return (n < 0 | m < 0) ? 0 : n * m;
        }

        public static int Paperwork4(int n, int m) => Math.Max(n, 0) * Math.Max(m, 0);
        
        // https://www.codewars.com/kata/55685cd7ad70877c23000102/csharp
        /// <summary>
        /// given a number and have to make it negative
        /// </summary>
        /// <param name="number">Number, that has to be negative</param>
        /// <returns></returns>
        public static int MakeNegative(int number)
        {
            return -Math.Abs(number);
        }

        public static int MakeNegative2(int number)
        {
            return number > 0 ? -number : number;
        }

        public static int MakeNegative3(int number)
        {
            return Math.Abs(number) * -1;
        }

        public static int MakeNegative4(int n) => n < 0 ? n : -n;
        
        
        
        // https://www.codewars.com/kata/58cb43f4256836ed95000f97/csharp
        /// <summary>
        /// Take two lists of integers, a and b. Each list will consist of 3 positive integers above 0, representing the dimensions of cuboids a and b.
        /// You must find the difference of the cuboids' volumes regardless of which is bigger.
        /// </summary>
        /// <param name="a">Array with the length of a cube</param>
        /// <param name="b">Array with the length of a cube</param>
        /// <returns></returns>
        public static int FindDifference(int[] a, int[] b)
        {
            int aVolume = 1;
            int bVolume = 1;

            for (int i = 0; i < 3; i++)
            {
                aVolume *= a[i];
                bVolume *= b[i];
            }

            return Math.Abs(aVolume - bVolume);
        }

        public static int FindDifference2(int[] a, int[] b) => Math.Abs(a.Aggregate(1, (x, y) => x * y) - b.Aggregate(1, (x, y) => x * y));

        public static int FindDifference3(int[] a, int[] b) => Math.Abs((a[0] * a[1] * a[2]) - (b[0] * b[1] * b[2]));

        public static int FindDifference4(int[] a, int[] b)
        {
            return (int)Math.Abs(a.Aggregate((vol, x) => vol * x) - b.Aggregate((vol, y) => vol * y));
        }

        public static int FindDifference5(int[] a, int[] b)
        {
            return a[0] * a[1] * a[2] > b[0] * b[1] * b[2] ? a[0] * a[1] * a[2] - b[0] * b[1] * b[2] : b[0] * b[1] * b[2] - a[0] * a[1] * a[2];
        }

        public static int FindDifference6(int[] a, int[] b)
        {
            int limit = 0;
            int maxLength = 3;

            if (a.Length != maxLength | b.Length != maxLength)
                throw new Exception("Arrays must contain length of 3");

            foreach (var num in a)
            {
                if (num <= limit)
                    throw new Exception("Values must be greater than 0");
            }
            foreach (var num in b)
            {
                if (num <= limit)
                    throw new Exception("Values must be greater than 0");
            }

            var testa = a[0] * a[1] * a[2];
            var testb = b[0] * b[1] * b[2];

            return Math.Abs(testa - testb);
        }
        
        
        // https://www.codewars.com/kata/5168bb5dfe9a00b126000018/train/csharp
        /// <summary>
        /// <para>'Hello world'  =>  'dlrow olleH'</para>
        /// reverses the string passed into it.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ReversedString(string str)
        {
            int counter = 1;
            string result = "";

            foreach (char character in str)
            {
                result += str[str.Length - counter];
                counter++;
            }

            return result;
        }

        public static string ReversedString2(string str)
        {
            return new string(str.ToArray().Reverse().ToArray());
        }

        public static string ReversedString3(string str)
        {
            char[] newstr = str.ToCharArray();
            Array.Reverse(newstr);
            return new String(newstr);
        }

        public static string ReversedString4(string str)
        {
            return new String(str.Reverse().ToArray());
        }

        public static string ReversedString5(string str)
        {
            return string.Concat(str.Reverse());
        }

        public static string ReversedString6(string s) => string.Concat(s.Reverse());
        
        
        // https://www.codewars.com/kata/57a0556c7cb1f31ab3000ad7/solutions/csharp
        /// <summary>
        /// Write a function which converts the input string to uppercase.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string MakeUpperCase2(string str) => str.ToUpper();
        
        
        // https://www.codewars.com/kata/59ca8246d751df55cc00014c/csharp
        /// <summary>
        /// <para>Hero</para>
        /// A hero is on his way to the castle to complete his mission.
        /// However, he's been told that the castle is surrounded with a couple of powerful dragons!
        /// Each dragon takes 2 bullets to be defeated, our hero has no idea how many bullets he should carry.. 
        /// </summary>
        /// <param name="bullets">Amount of bullets, it takes 2 bullet foreach dragon</param>
        /// <param name="dragons">Amount of dragons, they need two bullets</param>
        /// <returns></returns>
        public static bool Hero(int bullets, int dragons)
        {
            if (bullets / 2 >= dragons)
            {
                return true;
            }

            return false;
        }

        public static bool Hero2(int bullets, int dragons)
        {
            return bullets / 2 >= dragons;
        }

        public static bool Hero3(int bullets, int dragons) => dragons * 2 <= bullets;
        

        /// <summary>
        /// Given a number n, return the number of positive odd numbers below n
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns></returns>
        public static ulong OddCount(ulong n)
        {
            return n / 2;
        }

        public static ulong OddCount_protype(ulong n)
        {
            ulong counter = 0;

            for (ulong i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    counter++;
                }
            }

            return counter;
        }


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
