﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu6
    {
        // https://www.codewars.com/kata/56a5d994ac971f1ac500003e/train/csharp
        /// <summary>
        /// <para>Consecutive strings</para>
        /// You are given an array(list) strarr of strings and an integer k. 
        /// Your task is to return the first longest string consisting of k consecutive strings taken in the array.
        /// <para>n being the length of the string array, if n = 0 or k > n or k bigger or equal than 0 return "".</para>
        /// </summary>
        /// <param name="strarr">String Array</param>
        /// <param name="k">Consecutive Strings</param>
        /// <returns></returns>
        public static String LongestConsec(string[] strarr, int k)
        {
            // your code
            return "";
        }
        
        
        
        // https://www.codewars.com/kata/515de9ae9dcfc28eb6000001/csharp
        /// <summary>
        /// <para>Split Strings</para>
        /// Splits the string into pairs of two characters.
        /// If the string contains an odd number of characters,
        /// then it should replace the missing second character of the final pair with an underscore ('_').
        /// </summary>
        /// <param name="str">String Text</param>
        /// <returns>Split in pairs, _ if odd number for the final</returns>
        public static string[] SplitString(string str)
        {
            int count = 1;
            int GroupSize = 2;
            bool isOdd = str.Length % 2 == 1 ? true : false;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (count == GroupSize)
                {
                    sb.Append(str[i]);
                    sb.Append(" ");
                    count = 1;
                }
                else
                {
                    sb.Append(str[i]);
                    count++;
                }
            }

            if (isOdd)
            {
                sb.Append("_");
            }

            return sb.ToString().Trim().Split(" ");
        }

        public static string[] SplitString2(string str)
        {
            if (str.Length % 2 == 1)
                str += "_";

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i].ToString() + str[i + 1]);
            }

            return list.ToArray();
        }

        public static string[] SplitString3(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";
            return Enumerable.Range(0, str.Length)
              .Where(x => x % 2 == 0)
              .Select(x => str.Substring(x, 2))
              .ToArray();
        }

        public static string[] SplitString4(string str)
        {
            return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        }

        public static string[] SplitString5(string str) => Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();

        public static string[] SplitString6(string str)
        {
            var paddedString = str + "_";

            return Enumerable.Range(0, (str.Length + 1) / 2).Select(i => paddedString.Substring(2 * i, 2)).ToArray();
        }

        public static string[] SplitString7(string str)
        {
            return Regex.Split((str.Length % 2 != 1 ? str : str + "_"), @"(?<=\G.{2})").Where(x => x != "").ToArray();
        }

        public static string[] SplitString8(string str)
        {
            return str
              .ToCharArray()
              // assign index for each char
              .Select((c, i) => new { Index = i, Value = c })
              // group by indexes
              .GroupBy(o => o.Index / 2)
              // from groups take ony values as array
              .Select(g => g.Select(i => i.Value).ToArray())
              // arrays with single element convert to "x_"
              .Select(v => v.Count() == 2 ? v : new[] { v[0], '_' })
              // convert to array of strings
              .Select(v => new string(v))
              // convert to array
              .ToArray();
        }
        
        
        
        // https://www.codewars.com/kata/5842df8ccbd22792a4000245/csharp
        /// <summary>
        /// You will be given a number and you will need to return it as a string in Expanded Form.
        /// <para>For example: 70304 => "70000 + 300 + 4"</para>
        /// </summary>
        /// <param name="num">Long number</param>
        /// <returns>String number in Expanded Form</returns>
        public static string ExpandedForm(long num)
        {
            int length = num.ToString().Length;
            string numberString = num.ToString();
            string result = "";

            if (length == 1)
            {
                return numberString;
            }

            for (int i = 0; i < length; i++)
            {
                if ('0' != numberString[i])
                {
                    result += numberString[i];

                    for (int x = i + 1; x < length; x++)
                    {
                        result += "0";
                    }

                    if (i + 1 < length)
                    {
                        result += " + ";
                    }
                }
            }

            if ('+' == result[result.Length - 2])
            {
                return result.Remove(result.Length - 3,3);
            }

            return result;
        }

        public static string ExpandedForm2(long num)
        {
            var str = num.ToString();
            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
        }

        public static string ExpandedForm3(long n)
        {
            return string.Join(" + ", $"{n}".Select((c, i) => c + new string('0', $"{n}".Length - i - 1)).Where(x => x[0] != '0'));
        }

        public static string ExpandedForm4(long num)
        {
            Stack<long> parts = new Stack<long>();

            for (long m = 1, n = num; n > 0; n /= 10, m *= 10)
            {
                long digit = n % 10;
                if (digit > 0)
                {
                    parts.Push(m * digit);
                }
            }

            return string.Join(" + ", parts);
        }

        public static string ExpandedForm5(long num)
        {
            return String.Join(" + ", num.ToString()
                                         .ToArray()
                                         .Reverse()
                                         .Select((x, i) => (x - 48) * Math.Pow(10, i))
                                         .Reverse()
                                         .Where(x => x != 0));

        }

        public static string ExpandedForm6(long num)
        {
            var numberAsString = $"{num}";

            var parts = numberAsString
                            .Select((n, i) => (n, i))
                            .Where(_ => _.n != '0')
                            .Select(_ => _.n + new string('0', numberAsString.Length - _.i - 1));

            return string.Join(" + ", parts);
        }

        public static string ExpandedForm7(long num)
        {
            var totalLength = num.ToString().Length;
            var output = string.Empty;

            // 423040
            for (int i = 0; i < totalLength; i++)
            {
                if (num.ToString()[i] == '0')
                {
                    continue;
                }

                else
                {
                    var difference = totalLength - (i + 1);
                    output += num.ToString()[i];
                    while (difference-- > 0)
                    {
                        output += "0";

                        if (difference == 0)
                        {
                            output += " + ";
                        }
                    }

                }

            }

            return output.TrimEnd(' ', '+', ' ');
        }
        
        
        
        // https://www.codewars.com/kata/534d2f5b5371ecf8d2000a08/train/csharp
        /// <summary>
        /// <para>Multiplication Table</para>
        /// Your task, is to create NxN multiplication table, of size provided in parameter.
        /// When given size is 3: the return value should be: [[1,2,3],[2,4,6],[3,6,9]]
        /// </summary>
        /// <param name="size">Size of the Multiplication Table</param>
        /// <returns></returns>
        public static int[,] MultiplicationTable(int size)
        {
            int[,] arrayMultiplicationTable = new int[size, size];

            for (int i = 1; i <= size; i++)
            {
                for (int k = 1; k <= size; k++)
                {
                    arrayMultiplicationTable[i - 1, k - 1] = i * k;
                }
            }

            return arrayMultiplicationTable;
        }

        public static int[,] MultiplicationTable2(int size)
        {
            int[,] Mtable = new int[size, size]; for (int i = 0; i < size; i++) { for (int j = 0; j < size; j++) { Mtable[i, j] = (i + 1) * (j + 1); } } return Mtable;
        }
        

        // https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp
        /// <summary>
        /// <para>Array Difference</para>
        /// It should remove all values from list a, which are present in list b.
        /// If a value is present in b, all of its occurrences must be removed from the other:
        /// </summary>
        /// <param name="a">Array of integers, that should get it's elements removed</param>
        /// <param name="b">Array of integers. If a value is present in b, all of its occurrences must be removed from the other</param>
        /// <returns> Array a minus array b </returns>
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int[] newArray;
            List<int> newList = new List<int>();

            if (b == null || b.Length == 0 ) // Should return a if any of the arrays are empty
            {
                return a;
            }
            else if ( a == null || a.Length == 0)
            {
                return new int[] { };
            }

            foreach (var item in a)
            {
                newList.Add(item);
            }

            foreach (var arrayElement in b)
            {
                newList.RemoveAll(item => item == arrayElement);
            }
            
            newArray = newList.ToArray();
            return newArray;
        }

        public static int[] ArrayDiff2(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }

        public static int[] ArrayDiff3(int[] a, int[] b)
        {
            // With a hashset, we won't have to iterate over b for every item in a.
            // Instead, we can check if an item exists in constant time
            HashSet<int> bSet = new HashSet<int>(b);

            return a.Where(v => !bSet.Contains(v)).ToArray();
        }

        public static int[] ArrayDiff4(int[] a, int[] b)
        {
            var sb = new HashSet<int>(b);
            return Array.FindAll(a, x => !sb.Contains(x));
        }

        public static int[] ArrayDiff5(int[] a, int[] b) => Array.FindAll(a, m => !b.Contains(m));
        
        
        //  https://www.codewars.com/kata/write-number-in-expanded-form/train/csharp
        /// <summary>
        /// You will be given a number and you will need to return it as a string in Expanded Form. For example:
        /// <para>ExpandedForm(70304); # Should return "70000 + 300 + 4"</para>
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ExpandedForm(long num)
        {
            string temp = num.ToString();
            int length = temp.Length;

            throw new NotImplementedException();
        }



        //  https://www.codewars.com/kata/is-a-number-prime/train/csharp
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * 1 <= n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }


        public static bool IsPrime_prototype(int n)
        {
            int number = n;

            if (number <= 1)
            {
                return false;
            }
            if (number <= 3 || number == 5 || number == 7 || number == 11)
            {
                return true;
            }

            if (number % number == 0 && number % 1 == 0)
            {
                return false;
            }

            for (int i = 0; i < 100; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            Console.WriteLine("True");
            return true;
        }


        public Dictionary<double, bool> Drive(double[,] drinks, string finished, string drive_time)
        {
            // Code here https://www.codewars.com/kata/am-i-safe-to-drive/train/csharp
            // double[,] alcohol = new double[,] { { 5.2, 568.0 }, { 5.2, 568.0 }, { 5.2, 568.0 }, { 12.0, 175.0 }, { 12.0, 175.0 }, { 12.0, 175.0 } }; drive(alcohol, "23:00", "08:15"); => { 15.16, false }
            return null;
        }


        //  https://www.codewars.com/kata/sum-consecutives/train/csharp
        /// <summary>
        /// [1,4,4,4,0,4,3,3,1] # should return [1,12,0,4,6,1]
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static List<int> SumConsecutives(List<int> s)
        {
            List<int> result = new List<int>();
            int previousNumber = s[0];
            int counter = 1;
            int tempCounter = counter;

            bool changed = false;

            for (int i = 1; i < s.Count; i++)
            {
                if (previousNumber == s[i])
                {
                    counter++;
                }
                else
                {
                    if (i == 1 && counter == 1)
                    {
                        result.Add(previousNumber);
                    }
                    else if (counter > 1 && tempCounter > 0 || tempCounter == 1 || changed == true)
                    {
                        result.Add(previousNumber * counter);

                        tempCounter = counter;
                        counter = 1;
                        changed = true;
                    }
                }

                previousNumber = s[i];
                if (i + 1 == s.Count && counter > 1)
                {
                    result.Add(previousNumber * counter);
                }
                else if (i + 1 == s.Count)
                {
                    result.Add(previousNumber);
                }
            }

            return result;
        }

        public static List<int> SumConsecutives2(List<int> s) => s.Select((v, i) => (i > 0 && s[i - 1] == v) ? (int?)null : s.Skip(i).TakeWhile(vi => vi == v).Sum()).Where(r => r.HasValue).Select(r => r.Value).ToList();


        public static List<int> SumConsecutives_protoype(List<int> s)
        {
            // your code
            List<int> result = new List<int>();
            int previousNumber = s[0];
            int counter = 0;
            int tempCounter = counter;


            for (int i = 1; i < s.Count; i++)
            {
                if (previousNumber == s[i])
                {
                    // Counter?
                    counter++;
                }
                else
                {

                    // Execute Method n/counter times if n > 0
                    if (counter > 0)
                    {
                        // previous || s[i]
                        result.Add(previousNumber * counter);
                    }
                    else
                    {
                        if (i == 1 && counter == 0)
                        {
                            result.Add(previousNumber);
                        }
                        else
                        {
                            result.Add(s[i]);
                        }
                    }

                }


                previousNumber = s[i];
            }

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(previousNumber); Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(previousNumber); Console.ResetColor();

            foreach (var item in result)
            {
                Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(item); Console.ResetColor();
            }

            //return new List<int>();
            return null;
        }

        // https://www.codewars.com/kata/number-format/train/csharp
        /// <summary>
        /// Format any integer provided into a string with "," (commas) in the correct places. NumberFormat(5678545) => "5,678,545"
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string NumberFormat(int number)
        {
            Console.WriteLine($"{number:F}");
            return "0";
        }


        //  https://www.codewars.com/kata/build-tower


        //1
        //3
        //5
        //7
        //5
        //3
        //1

        //  https://www.codewars.com/kata/give-me-a-diamond/train/csharp
        /// <summary>
        /// <para>♦ Give me a Diamond! ♦</para>
        /// Returns a string that displays a diamond shape on the screen using asterisk * signs
        /// </summary>
        /// <param name="n">Null for even numbers</param>
        /// <returns></returns>
        public static string print(int n)
        {
            string result_diamond = "";
            string temp = "";
            int starCounter = n - 2;
            int spaceCounter = 1;

            if (n % 2 == 0 || n < 0)
            {
                return null;
            }


            // The middle of the diamond ♦
            for (int i = 0; i < n; i++)
            {
                result_diamond += "*";
            }

            result_diamond += "\n";


            for (int i = 1; i < n; i += 2) // Adds two layers each time 
            {
                for (int k = 0; k < spaceCounter; k++) // Amount of spaces to be added
                {
                    temp += " ";
                }

                for (int j = 0; j < starCounter; j++) // Adds asterisks/stars *
                {
                    temp += "*";
                }

                result_diamond = temp + "\n" + result_diamond + temp + "\n";

                temp = "";
                spaceCounter++;
                starCounter -= 2;
            }

            return result_diamond;
        }

        public static string print_prototype(int n)
        {
            StringBuilder sbTop = new StringBuilder();
            StringBuilder sbMiddle = new StringBuilder();
            StringBuilder sbBot = new StringBuilder();

            int rowCounter = n;


            // Create the Middle of the diamon
            for (int i = 0; i < n; i++)
            {
                sbMiddle.Append("*");
            }

            n--; n--;

            Console.WriteLine("Hvad er n: " + n);

            for (int i = 0; i < rowCounter - 2; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    sbTop.Append("*");
                }

            }

            Console.WriteLine();
            //Console.WriteLine(sbTop);
            Console.WriteLine(sbMiddle);
            Console.WriteLine("### END ###");
            Console.WriteLine();
            return "Just Testing";
        }

        /*
         * 
            StringBuilder sb = new StringBuilder();

            int spaceCounter = 0;
            int rowCounter = n;

            for (int i = 1; i <= n; i++, i++)
            {
                Console.WriteLine(i);
                sb.Append("*");
                spaceCounter++;
                Console.WriteLine("spaceCounter: " + spaceCounter);
                Console.WriteLine("rowCounter: " + rowCounter);

            }
            Console.WriteLine();
            Console.WriteLine(sb);

            return "Just Testing";
         * 
         */


        public static void diff()
        {

        }

        //  https://www.codewars.com/kata/count-the-smiley-faces/train/csharp
        /// <summary>
        /// Given an array, it should return the total number of smiling faces.
        /// </summary>
        /// <param name="smileys"></param>
        /// <returns></returns>
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


        /// <summary>
        /// Write a method highestRank(arr) which returns the number which is most frequent in the given input array (or ISeq).
        /// If there is a tie for most frequent number, return the largest number of which is most frequent.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int HighestRank(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            int highestValue = 0;
            int highestKey = 0;

            foreach (int item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var pair in dict.OrderByDescending(key => key.Key))
            {
                if (highestValue < pair.Value)
                {
                    highestValue = pair.Value;
                    highestKey = pair.Key;
                }
                Console.WriteLine($"Key {pair.Key} occurred {pair.Value} times.");
            }

            Console.WriteLine(highestKey);
            return highestKey;
        }

        public static int HighestRank2(int[] arr)
        {
            return arr
              .GroupBy(i => i)
              .OrderByDescending(gr => gr.Count())
              .ThenByDescending(gr => gr.Key)
              .Select(gr => gr.Key)
              .First();
        }

        public static int HighestRank3(int[] arr)
           => arr.GroupBy(e => e).OrderByDescending(g => g.Count()).ThenByDescending(g => g.Key).Select(g => g.Key).First();




        /// <summary>
        /// Converts dash/underscore delimited words into camel casing.
        /// The first word within the output should be capitalized only if the original word was capitalized.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamelCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            string tempStr = str;
            char lastChar = 'a';
            foreach (char character in str)
            {
                if (character == '-' || character == '_')
                {

                }
                else
                {
                    if (lastChar == '_' || lastChar == '-')
                    {
                        sb.Append(character.ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(character);
                    }
                }
                lastChar = character;
            }
            return sb.ToString();
        }

        /// <summary>
        /// Same as ToCamelCase, just in one line.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCamelCase2(string str)
        {
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }

        public static List<string> Wave(string str)
        {
            // https://www.codewars.com/kata/58f5c63f1e26ecda7e000029/train/csharp
            // hello => "Hello", "hEllo", "heLlo", "helLo", "hellO"

            List<string> listWaveString = new List<string>();

            string copy = str;
            int positionCounter = 0;
            foreach (char letter in str)
            {


                positionCounter++;
            }

            for (int i = 0; i < str.Length; i++)
            {
                listWaveString.Add(char.ToUpper(str[i]) + str.Substring(i + 1));
                // Replace
            }

            foreach (var item in listWaveString)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            return new List<string> { };
        }


        /// <summary>
        /// Replace every letter with its position in the alphabet.
        /// If anything in the text isn't a letter, ignore it and don't return it.
        /// A being 1, B being 2, etc.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string AlphabetPosition(string text)
        {
            // "The sunset sets at twelve o' clock." => "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"

            int index;
            StringBuilder sB = new StringBuilder();

            // Replace everything that is not (^) a word character (\w), a digit (\d) or whitespace (\s) with an empty string.
            string stringWithoutSpecialCharacters = Regex.Replace(text, @"[^\w\d\s]", "");
            foreach (char item in stringWithoutSpecialCharacters)
            {
                index = char.ToUpper(item) - 64;
                if (index > 0 && index <= 30)
                {
                    sB.Append(index);
                    sB.Append(" ");
                }
            }
            return sB.ToString().TrimEnd();
        }

        /// <summary>
        /// Same as AlphabetPosition, just in one line.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string AlphabetPosition2(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }


        public partial class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                this.Data = data;
                this.Next = null;
            }

            public static int Length(Node head)
            {
                throw new NotImplementedException();
            }

            public static int Count(Node head, Predicate<int> func)
            {
                throw new NotImplementedException();
            }
        }


        
        public List<string> wave(string str)
        {

            List<string> list = new List<string>();
            int index = 0;

            foreach (char c in str)
            {
                if (c != ' ')
                {
                    StringBuilder sb = new StringBuilder(str);
                    sb.Replace(c, char.ToUpper(c), index, 1);
                    list.Add(sb.ToString());
                }

                index++;
            }

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            return list;
        }


        public List<string> wave2(string str) =>
              str
                .Select((c, i) => str.Substring(0, i) + Char.ToUpper(c) + str.Substring(i + 1))
                .Where(x => x != str)
                .ToList();


        public List<string> wave3(string s)
        {
            return Enumerable.Range(0, s.Length)
                .Select(i => string.Concat(s.Select((x, y) => y == i ? char.ToUpper(x) : x)))
                .Where(x => x != s).ToList();
        }

        public List<string> wave4(string str)
        {
            return str.Select((x, i) => str.Substring(0, i) + char.ToUpper(str[i]) + str.Substring(i + 1)).Where(x => x.Any(char.IsUpper)).ToList();
        }

        public List<string> wave5(string str)
        {
            List<string> mexicanWave = new List<string>();
            for (int i = 0; i < str.Length; i++)
            {
                char[] a = str.ToCharArray();
                if (a[i] != 32)
                {
                    a[i] = char.ToUpper(a[i]);
                    mexicanWave.Add(new string(a));
                }
            }
            return mexicanWave;
        }
        
        
    }
}
