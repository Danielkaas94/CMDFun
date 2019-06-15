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
    }
}
