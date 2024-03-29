﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMDFun
{
    class Kyu7
    {
        // https://www.codewars.com/kata/5a4138acf28b82aa43000117/csharp
        /// <summary>
        /// Find the maximum product obtained from multiplying 2 adjacent numbers in the array.
        /// </summary>
        /// <param name="array">Array with numbers, that could be a mixture of positives, negatives, but also zeroes .</param>
        /// <returns>maximum product obtained from multiplying 2 adjacent numbers</returns>
        public static int AdjacentElementsProduct(int[] array)
        {
            int tempHighestProduct;
            int highestProduct = array[0] * array[1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                tempHighestProduct = array[i] * array[i + 1];

                if (tempHighestProduct > highestProduct)
                {
                    highestProduct = tempHighestProduct;
                }
            }

            return highestProduct;
        }

        public static int AdjacentElementsProduct2(int[] array)
        {
            return array.Skip(1).Select((x, i) => x * array[i]).Max();
        }

        public static int AdjacentElementsProduct3(int[] array)
        {
            return array.Skip(1).Zip(array, (x, y) => x * y).Max();
        }

        public static int AdjacentElementsProduct4(int[] array)
        {
            int max = Int32.MinValue;
            for (int i = 0, j = 1; j < array.Length; i++, j++)
            {
                max = Math.Max(array[i] * array[j], max);
            }
            return max;
        }

        public static int AdjacentElementsProduct5(int[] a) => Enumerable.Range(0, a.Length - 1).Aggregate(int.MinValue, (s, n) => Math.Max(s, a[n] * a[n + 1]));

        public static int AdjacentElementsProduct6(int[] array) => Enumerable.Range(0, array.Length - 1).Select(x => array[x] * array[x + 1]).Max();

        public static int AdjacentElementsProduct7(int[] array)
        {
            return Enumerable.Range(1, array.Length - 1).Select(a => array[a - 1] * array[a]).ToArray().Max();
        }

        public static int AdjacentElementsProduct8(int[] array)
        {
            List<int> newArray = new List<int>();

            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray.Add(array[i] * array[i + 1]);
            }

            return newArray.Max();
        }

        public static int AdjacentElementsProduct9(int[] array)
        {
            int l = 0;
            int r = 1;
            int max = array[l] * array[r];
            for (int i = 0; i < array.Length - 1; i++)
            {
                int cur = array[l] * array[r];
                if (cur > max)
                {
                    max = cur;
                }
                l++;
                r++;
            }
            return max;
        }
        
        
        
        //https://www.codewars.com/kata/539ee3b6757843632d00026b/csharp
        /// <summary>
        /// Returns an ordered list containing the indexes of all capital letters in the string.
        /// </summary>
        /// <param name="word">A word with random letters in uppercases</param>
        /// <returns>The position of the word, where the letter is in uppercase</returns>
        public static int[] Capitals(string word)
        {
            List<int> listOfCapitalPositions = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == word[i].ToString().ToUpper())
                {
                    listOfCapitalPositions.Add(i);
                }
            }

            return listOfCapitalPositions.ToArray();
        }

        public static int[] Capitals2(string word)
        {
            return word.ToCharArray()
              .Select((c, index) => new { CharAtIndex = c, Idx = index })  // Select word and project to array "char with Index"
              .Where(indexedList => Char.IsUpper(indexedList.CharAtIndex))   // Filter where char is upp
              .Select(selected => selected.Idx) // return what is required: list of indices
              .ToArray();
        }

        public static int[] Capitals3(string word)
        {
            return word.Select((c, i) => Char.IsUpper(c) ? i : -1).Where(i => i >= 0).ToArray();
        }

        public static int[] Capitals4(string word)
        {
            return Regex.Matches(word, "[A-Z]").Select(m => m.Index).ToArray();
        }

        public static int[] Capitals5(string word)
        {
            return Enumerable.Range(0, word.Length).Where(i => char.IsUpper(word, i)).ToArray();
        }

        public static int[] Capitals6(string word)
        {
            return word.Select((x, n) => n).Where((x, i) => char.IsUpper(word, i)).ToArray();
        }

        public static int[] Capitals7(string word)
        {
            return (from Match m in Regex.Matches(word, @"[A-Z]")
                    select m.Index
                    ).ToArray<int>();
        }
        
        
        
        // https://www.codewars.com/kata/56b8903933dbe5831e000c76/csharp
        /// <summary>
        /// Basic Spoonerize
        /// </summary>
        /// <param name="str">String with two words</param>
        /// <returns>"not picking" --> "pot nicking"</returns>
        public static string Spoonerize(string str)
        {
            string result = "";
            string tempString;
            string[] tempStringArray = str.Split(" ");
            string[] tempAlphaAndBravo = new string[2];
            string tempA = tempStringArray[0].Substring(0, 1);
            string tempB = tempStringArray[1].Substring(0, 1);
            tempAlphaAndBravo[0] = tempB;
            tempAlphaAndBravo[1] = tempA;

            for (int i = 0; i < tempStringArray.Length; i++)
            {

                for (int x = 0; x < tempStringArray[i].Length; x++)
                {
                    tempString = tempStringArray[i];

                    if (i == 0 && x == 0 || i == 1 && x == 0)
                    {
                        result += tempAlphaAndBravo[i];
                    }
                    else
                    {
                        result += tempString[x];
                    }

                    if (i == 0 && x == tempString.Length - 1)
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }

        public static string Spoonerize2(string input)
        {
            string[] words = input.Split(' ');
            return words[1][0] + words[0][1..] + ' ' + words[0][0] + words[1][1..];
        }

        public static string Spoonerize3(string str)
        {
            char[] chars = str.ToCharArray();
            chars[0] = str[str.IndexOf(' ') + 1];
            chars[str.IndexOf(' ') + 1] = str[0];
            return new string(chars);
        }

        public static string Spoonerize4(string str)
        {
            return Regex.Replace(str, @"(.)(.* )(.)(.*)", "$3$2$1$4");
        }

        public static string Spoonerize5(string str)
        {
            var w = str.Split();
            return $"{w[1][0]}{w[0][1..]} {w[0][0]}{w[1][1..]}";
        }

        public static string Spoonerize6(string str) => str.Substring(str.IndexOf(' ') + 1, 1) + str.Substring(1, str.IndexOf(' ') - 1) + " " + str[0..1] + str.Substring(str.IndexOf(' ') + 2);

        public static string Spoonerize7(string str)
        {
            return str.Split(' ')[1][0] + str.Split(' ')[0].Substring(1) + " " + str.Split(' ')[0][0] + str.Split(' ')[1].Substring(1);
        }

        public static string Spoonerize8(string str)
        {
            var split = str.Split(' ');
            var firstSymbol = split.First().First();
            var lastSymbol = split.Last().First();

            var firstWord = split.First();
            var lastWord = split.Last();

            var firstRemove = firstWord.Substring(1, firstWord.Length - 1);
            var lastRemove = lastWord.Substring(1, lastWord.Length - 1);

            return string.Join(" ", lastSymbol + firstRemove, firstSymbol + lastRemove);
        }

        public static string Spoonerize9(string str)
        {
            return $"{str.Substring(str.IndexOf(' ') + 1)[0]}" +
              $"{str.Substring(1, str.IndexOf(' '))}" +
              $"{str.Substring(0, str.IndexOf(' '))[0]}" +
              $"{str.Substring(str.IndexOf(' ') + 2)}";
        }
        
        
        
        // https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/csharp
        /// <summary>
        /// Your task is to find the sum of minimum value in each row.
        /// </summary>
        /// <param name="numbers">2D array with numbers</param>
        /// <returns>Returns the sum of the 2D array</returns>
        public static int SumOfMinimums(int[,] numbers)
        {
            int result = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                List<int> tempList = new List<int>();

                for (int x = 0; x < numbers.GetLength(1); x++)
                {
                    tempList.Add(numbers[i, x]);
                }

                result += tempList.Min();
            }

            return result;
        }

        public static int SumOfMinimums2(int[,] n)
        {
            return Enumerable.Range(0, n.GetLength(0))
                             .Select(x => Enumerable.Range(0, n.GetLength(1)).Select(y => n[x, y]))
                             .Sum(x => x.Min());
        }

        public static int SumOfMinimums3(int[,] n)
        {
            return Enumerable.Range(0, n.GetLength(0)).Select(x => Enumerable.Range(0, n.GetLength(1)).Select(y => n[x, y])).Sum(s => s.Min());
        }

        public static int SumOfMinimums4(int[,] n) => Enumerable.Range(0, n.GetUpperBound(0) + 1).Sum(i => Enumerable.Range(0, n.GetUpperBound(1) + 1).Min(j => n[i, j]));

        public static int SumOfMinimums5(int[,] numbers)
        {
            int sum = 0;
            int min = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                min = numbers[i, 0];
                for (int j = 1; j < numbers.GetLength(1); j++)
                {
                    if (min > numbers[i, j])
                        min = numbers[i, j];
                }
                sum += min;
            }

            return sum;
        }

        public static int SumOfMinimums6(int[,] numbers)
        {
            int[] min = new int[numbers.GetLength(0)];
            for (int i = 0; i < min.Length; i++)
            {
                min[i] = 2000000000;
            }
            int sum = 0;
            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                for (int i = 0; i < numbers.GetLength(1); i++)
                {
                    if (min[j] > numbers[j, i])
                    {
                        min[j] = numbers[j, i];
                    }
                }
            }
            foreach (int i in min)
            {
                sum += i;
            }
            return sum;
        }

        public static int SumOfMinimums7(int[,] numbers)
        {
            var rows = numbers.GetUpperBound(0) + 1;
            var columns = numbers.Length / rows;
            var result = 0;

            for (int i = 0; i < rows; i++)
            {
                var min = numbers[i, 0];
                for (var j = 1; j < columns; j++)
                {
                    if (numbers[i, j] < min) min = numbers[i, j];
                }

                result += min;
            }
            return result;
        }
        
        
        
        // https://www.codewars.com/kata/54ff3102c1bad923760001f3/csharp
        /// <summary>
        /// Return the number (count) of vowels(a, e, i, o, u) in the given string.
        /// </summary>
        /// <param name="str">Something String word</param>
        /// <returns>Count of vowels</returns>
        public static int GetVowelCount_Prototype(string str)
        {
            //int vowelCount = 0;

            //vowelCount = str.Select(x => "aeiou".Contains(x)).Count();

            //vowelCount = str.Select(x => x).Count(x => "aeiou".Contains(x));
            //vowelCount = str.Count(x => "aeiou".Contains(x));
            int vowelCount = str.Count(x => "aeiou".Contains(x));

            Console.WriteLine(vowelCount);

            return vowelCount;
        }

        // https://www.codewars.com/kata/54ff3102c1bad923760001f3/csharp
        /// <summary>
        /// Return the number (count) of vowels(a, e, i, o, u) in the given string.
        /// </summary>
        /// <param name="str">Something String word</param>
        /// <returns>Count of vowels</returns>
        public static int GetVowelCount(string str) => str.Count(x => "aeiou".Contains(x));

        public static int GetVowelCount2(string str)
        {
            return str.ToLower().Count(c => "aeiou".IndexOf(c) != -1);
        }

        public static int GetVowelCount3(string str)
        {
            return (Regex.Matches(str, @"[aeiouAEIOU]")).Count;
        }

        public static int GetVowelCount4(string str)
        {
            int vowelCount = 0;
            string vowels = "aeiou";

            foreach (char letter in str)
            {
                if (vowels.IndexOf(letter) != -1)
                    vowelCount++;
            }

            return vowelCount;
        }

        public static int GetVowelCount5(string str)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            return str
              .ToCharArray()
              .Where(c => vowels.Contains(c))
              .Count();
        }

        public static int GetVowelCount6(string str) => str.Split("aeiou".ToCharArray()).Length - 1;

        public static int GetVowelCount7(string str)
        {
            int vowelCount = 0;

            for (int i = 0; i < str.Length; i++)
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    vowelCount++;

            return vowelCount;
        }
        
        
        
        // https://www.codewars.com/kata/57e8fba2f11c647abc000944/csharp
        /// <summary>
        /// <para>Disaster!! The boat has caught fire!!</para>
        /// Change any instance of "Fire" into "~~". Then return the string.
        /// </summary>
        /// <param name="s">String with boaty McBoat words</param>
        /// <returns>Fire => ~~</returns>
        public static string FireFight(string s)
        {
            StringBuilder stringBuilder = new StringBuilder(s);
            stringBuilder.Replace("Fire","~~");

            return stringBuilder.ToString();
        }

        public static string FireFight2(string s)
        {
            return s.Replace("Fire", "~~");
        }

        public static string FireFight3(string s) => s.Replace("Fire", "~~");

        public static string FireFight4(string s)
        {
            string target = "~~";
            Regex regex = new Regex(@"Fire\w*");
            string result = regex.Replace(s, target);
            return result;
        }

        public static string FireFight5(string s)
        {
            string output = "";
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word == "Fire" || word == "fire")
                {
                    output += "~~ ";
                }
                else
                {
                    output += word + " ";
                }
            }
            return output.Substring(0, output.Length - 1);
        }

        public static string FireFight6(string s)
        {
            string[] splited = s.Split(" ");
            string item = "Fire";
            string newStr = null;
            for (int i = 0; i < splited.Length; i++)
            {
                if (splited[i] == item)
                {
                    newStr += "~~";
                }
                else
                {
                    newStr += splited[i];
                }
                if (i < splited.Length - 1)
                {
                    newStr += " ";
                }
            }
            return newStr;
        }

        public static string FireFight7(string str)
        {
            List<string> list = new List<string>();
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "Fire")
                {
                    list.Add("~~");
                }
                else
                {
                    list.Add(arr[i]);
                }
            }
            string CS = string.Join(" ", list);
            return CS;
        }
        
        
        
        // https://www.codewars.com/kata/5299413901337c637e000004/csharp
        /// <summary>
        /// <para>Return the Missing Element</para>
        /// Sequence of unique integers between 0 and 9 (inclusive), and returns the missing element.
        /// </summary>
        /// <param name="superImportantArray">unique integers from 0 to 9 </param>
        /// <returns>The Missing Number</returns>
        public static int GetMissingElement(int[] superImportantArray)
        {
            for (int i = 0; i <= superImportantArray.Length; i++)
            {
               bool hasNumber = superImportantArray.Contains(i);

                if (hasNumber == false)
                {
                    return i;
                }
            }

            return -1337;
        }

        public static int GetMissingElement2(int[] superImportantArray)
        {
            return (int)Enumerable.Range(0, 9).Except(superImportantArray).FirstOrDefault();
        }

        public static int GetMissingElement3(int[] superImportantArray)
        {
            return 45 - superImportantArray.Sum();
        }

        public static int GetMissingElement4(int[] superImportantArray)
        {
            return Enumerable.Range(0, 10).First(i => !superImportantArray.Contains(i));
        }

        public static int GetMissingElement5(int[] superImportantArray)
        {
            return Enumerable.Range(0, superImportantArray.Count()).Except(superImportantArray).First();
        }

        public static int GetMissingElement6(int[] superImportantArray)
        {
            return Enumerable.Range(1, 9).Except(superImportantArray).FirstOrDefault();
        }

        public static int GetMissingElement7(int[] superImportantArray) => 45 - superImportantArray.Sum();

        public static int GetMissingElement8(int[] superImportantArray) => Enumerable.Range(0, 10).Except(superImportantArray).Single();
        
        
        
        // https://www.codewars.com/kata/563d54a7329a7af8f4000059/csharp
        /// <summary>
        /// <para>Put a Letter in a Column</para>
        /// Takes index [0, 8] and a character. It returns a string with a column. Put character in column marked with index.
        /// <para>2, 'A' => "| | |A| | | | | | |"</para>
        /// </summary>
        /// <param name="index">Index of the letter</param>
        /// <param name="character">The symbol, that should be inserted into the Column</param>
        /// <returns></returns>
        public static string BuildRowText(int index, char character)
        {
            string result = "";

            for (int i = 0; i <= 8; i++)
            {
                if (i == index)
                {
                    result += "|";
                    result += character;
                }
                else 
                {
                    result += "|";
                    result += " ";
                }
            }

            result += "|";

            return result;
        }

        public static string BuildRowText2(int index, char character)
        {
            return "|" + string.Join("|", Enumerable.Range(0, 9).Select(i => i == index ? character : ' ')) + "|";
        }

        public static string BuildRowText3(int index, char character)
        {
            return new StringBuilder("| | | | | | | | | |") { [index * 2 + 1] = character }.ToString();
        }

        public static string BuildRowText4(int i, char c)
        {
            return string.Join("|", Enumerable.Range(0, 11).Select((x, j) => j == i + 1 ? c : ' ')).Trim();
        }

        public static string BuildRowText5(int index, char character) => string.Concat("| | | | | | | | | |".Select((c, i) => i == index * 2 + 1 ? character : c));

        public static string BuildRowText6(int index, char character)
        {
            switch (index)
            {
                case 0:
                    return "|" + character + "| | | | | | | | |";
                case 1:
                    return "| |" + character + "| | | | | | | |";
                case 2:
                    return "| | |" + character + "| | | | | | |";
                case 3:
                    return "| | | |" + character + "| | | | | |";
                case 4:
                    return "| | | | |" + character + "| | | | |";
                case 5:
                    return "| | | | | |" + character + "| | | |";
                case 6:
                    return "| | | | | | |" + character + "| | |";
                case 7:
                    return "| | | | | | | |" + character + "| |";
                case 8:
                    return "| | | | | | | | |" + character + "|";
                default:
                    return "| | | | | | | | | |";
            }
        }

        public static string BuildRowText7(int index, char character)
        {
            char[] columns = "| | | | | | | | | |".ToCharArray();
            columns[index * 2 + 1] = character;
            return new String(columns);
        }
        
        
        
        // https://www.codewars.com/kata/554b4ac871d6813a03000035/csharp
        /// <summary>
        ///  given a string of space separated numbers,
        ///  and have to return the highest and lowest number.
        ///  <para>"1 2 3 4 5" => "5 1"</para>
        /// </summary>
        /// <param name="numbers">String numbers</param>
        /// <returns>Highest and Lowest number</returns>
        public static string HighAndLow(string numbers)
        {
            string result = "";
            string[] stringNumbers = numbers.Split(' ');
            List<int> ListInt = new List<int>();

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                ListInt.Add(Convert.ToInt32(stringNumbers[i]));
            }

            result += ListInt.Max();
            result += " ";
            result += ListInt.Min();

            return result;
        }

        public static string HighAndLow2(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }

        public static string HighAndLow3(string numbers)
        {
            var numbersList = numbers.Split(' ').Select(x => Convert.ToInt32(x));
            return string.Format("{0} {1}", numbersList.Max(), numbersList.Min());
        }

        public static string HighAndLow4(string numbers)
        {
            var nums = numbers.Split(' ').Select(Int32.Parse).ToArray();
            return $"{nums.Max()} {nums.Min()}";
        }

        public static string HighAndLow5(string numbers)
        {
            var array = numbers.Split(' ').Select(int.Parse).OrderByDescending(p => p);
            return $"{array.First()} {array.Last()}";
        }
        
        
     
        // https://www.codewars.com/kata/57d1f36705c186d018000813/csharp
        /// <summary>
        /// THIS CODE IS RAW!!!!
        /// </summary>
        /// <param name="a">Gordon Ramsey quote</param>
        /// <returns>"What feck damn cake" => "WH@T!!!! F*CK!!!! D@MN!!!! C@K*!!!!"</returns>
        public static string Gordon(string a)
        {
            string result = "";
            string[] splitQuote = a.Split(' ');

            foreach (var word in splitQuote)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    switch (word[i].ToString().ToUpper())
                    {
                        case "A":
                            result += "@";
                            break;
                        case "E":
                            result += "*";
                            break;
                        case "I":
                            result += "*";
                            break;
                        case "O":
                            result += "*";
                            break;
                        case "U":
                            result += "*";
                            break;
                        default:
                            result += word[i].ToString().ToUpper();
                            break;
                    }

                    if (i == word.Length - 1)
                    {
                        result += "!!!! ";
                    }
                }
            }

            return result.Trim();
        }

        public static string Gordon2(string a)
        {
            StringBuilder sb = new StringBuilder(a);

            sb.Replace("a", "@")
             .Replace("e", "*")
             .Replace("i", "*")
             .Replace("o", "*")
             .Replace("u", "*")
             .Replace(" ", "!!!! ")
             ;

            string now = string.Format("{0}!!!!", sb).ToUpper();
            return now;
        }

        public static string Gordon3(string a)
        {
            return Regex.Replace(Regex.Replace(a.ToUpper(), @"[EIOU]", "*"), @"\s|$", "!!!!$0").Replace("A", "@");
        }

        public static string Gordon4(string a)
        {
            return a.ToUpper().Replace("A", "@").Replace("E", "*").Replace("O", "*").Replace("U", "*").Replace("I", "*").Replace(" ", "!!!! ") + "!!!!";
        }

        public static string Gordon5(string a)
        {
            return Regex.Replace(Regex.Replace(a.ToUpper(), @"\b(?<=\w)", "!!!!"),
                @"[AEIOU]", t => "" + t == "A" ? "@" : "*");
        }

        public static string Gordon6(string a) => string.Concat(a.Select(c => "eouiu".Contains(c) ? "*" : c == ' ' ? "!!!! " : c == 'a' ? "@" : $"{c}")).ToUpper() + "!!!!";

        public static string Gordon7(string a)
        {
            string b = a.ToUpper();
            string c = b.Replace("A", "@");
            string d = c.Replace("E", "*");
            string e = d.Replace("I", "*");
            string f = e.Replace("O", "*");
            string g = f.Replace("U", "*");
            string h = g.Replace(" ", "!!!! ");
            return h + "!!!!";
        }
        
        
        
        /// <summary>
        /// The values of an array that are not odd.
        /// Return the good values in the order they are given.
        /// </summary>
        /// <param name="values">int array with even and odd numbers</param>
        /// <returns>the values of an array that are not odd</returns>
        public static int[] NoOdds(int[] values)
        {
            List<int> noOddsList = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    noOddsList.Add(values[i]);
                }
            }

            return noOddsList.ToArray();
        }

        public static int[] NoOdds2(int[] values) => values.Where(v => v % 2 == 0).ToArray();

        public static int[] NoOdds3(int[] values)
        {
            return values.Where(x => x % 2 == 0).ToArray();
        }

        public static int[] NoOdds4(int[] values)
        {
            return Array.FindAll(values, x => x % 2 == 0);
        }
        
        
        
        // https://www.codewars.com/kata/57f759bb664021a30300007d
        /// <summary>
        /// Given a string made up of letters a, b, and/or c,
        /// switch the position of letters a and b (change a to b and vice versa). Leave any incidence of c untouched.
        /// <para>'acb' --> 'bca'</para>
        /// </summary>
        /// <param name="x">string with abc letters</param>
        /// <returns>returns x with 'a' and 'b' switching positions</returns>
        public static string Switcheroo(string x)
        {
            string switcherooResult = "";

            for (int i = 0; i < x.Length; i++)
            {
                switch (x[i])
                {

                    case 'a':
                        switcherooResult += 'b';
                        break;
                    case 'b':
                        switcherooResult += 'a';
                        break;
                    case 'c':
                        switcherooResult += x[i];
                        break;
                }
            }

            return switcherooResult;
        }

        public static string Switcheroo2(string x)
        {
            return x.Replace("a", "d").Replace("b", "a").Replace("d", "b");
        }

        public static string Switcheroo3(string x)
        {
            return Regex.Replace(x, "[ab]", m => m.Value == "a" ? "b" : "a");
        }

        public static string Switcheroo4(string x)
        {
            return string.Concat(x.Select(c => c == 'a' ? 'b' : c == 'b' ? 'a' : c));
        }

        public static string Switcheroo5(string x)
        {
            return x.Replace("a", "B").Replace("b", "a").ToLower();
        }
        
        
        
        // https://www.codewars.com/kata/598057c8d95a04f33f00004e/csharp
        /// <summary>
        /// <para>Get the integers between two numbers</para>
        /// </summary>
        /// <param name="startNum">The starting number</param>
        /// <param name="endNum">The ending number</param>
        /// <returns>Array with numbers in between startNum and endNum</returns>
        public static int[] Range(int startNum, int endNum)
        {
            List<int> listOfNumbers = new List<int>();

            for (int i = startNum; i < endNum; ++i)
            {
                listOfNumbers.Add(i);
            }

            return listOfNumbers.ToArray();
        }

        public static int[] Range2(int startNum, int endNum)
        {
            return Enumerable.Range(startNum + 1, Math.Max(endNum - startNum - 1, 0)).ToArray();
        }

        public static int[] Range3(int s, int e) => e > s ? Enumerable.Range(s + 1, e - s - 1).ToArray() : new int[0];

        public static int[] Range4(int s, int e) => Enumerable.Range(s + 1, Math.Max(e - s - 1, 0)).ToArray();
        
        
        
        // https://www.codewars.com/kata/5467e4d82edf8bbf40000155/csharp
        /// <summary>
        /// <para>Descending Order</para>
        /// take any non-negative integer as an argument and return it with its digits in descending order.
        /// Essentially, rearrange the digits to create the highest possible number.
        /// <para>Input: 42145 Output: 54421</para>
        /// </summary>
        /// <param name="num">Number that needs to be descending</param>
        /// <returns>input as descending</returns>
        public static int DescendingOrder(int num)
        {
            string strNumber = num.ToString();
            string tempStringNumber = "";
            List<int> singleNumberList = new List<int>();

            for (int i = 0; i < strNumber.Length; i++)
            {
                singleNumberList.Add(Int32.Parse(strNumber[i].ToString()));
            }

            IEnumerable<int> query = singleNumberList.OrderByDescending(x => x);

            foreach (var item in query)
            {
                tempStringNumber += item.ToString();
            }

            return Int32.Parse(tempStringNumber);
        }

        public static int DescendingOrder2(int num)
        {
            return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
        }

        public static int DescendingOrder3(int num)
        {
            char[] arr = num.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            return Convert.ToInt32(new string(arr));
        }

        public static int DescendingOrder4(int num)
        {
            return int.Parse(new String(num.ToString().ToCharArray().OrderByDescending(x => x).ToArray()));
        }

        public static int DescendingOrder5(int num) => Int32.Parse(String.Join("", num.ToString().ToCharArray().OrderByDescending(x => x)));

        public static int DescendingOrder6(int num) => int.Parse(string.Concat($"{num}".OrderByDescending(c => c)));
        
        
        
        // https://www.codewars.com/kata/55f2b110f61eb01779000053/csharp
        /// <summary>
        /// Given two integers a and b, which can be positive or negative,
        /// find the sum of all the integers between including them too and return it.
        /// If the two numbers are equal return a or b.
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <returns>The difference between number a and b inclusive the number itself</returns>
        public static int GetSum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }

            int sum = 0;

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    sum += i; 
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public int GetSum2(int a, int b)
        {
            return (a + b) * (Math.Abs(a - b) + 1) / 2;
        }

        public int GetSum3(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            int result = 0;
            for (int i = min; i <= max; i++)
            {
                result += i;
            }
            return result;
        }

        public int GetSum4(int a, int b)
        {
            return Enumerable.Range(Math.Min(a, b), Math.Max(b, a) - Math.Min(b, a) + 1).Sum();
        }

        public int GetSum5(int a, int b)
        {
            return Enumerable.Range(a < b ? a : b, Math.Abs(a - b) + 1).Sum();
        }

        public int GetSum6(int a, int b) => (Math.Abs(a - b) + 1) * (a + b) / 2;
        
        
        
        // https://www.codewars.com/kata/5783d8f3202c0e486c001d23/train/csharp
        /// <summary>
        /// Convert an array of strings to array of numbers
        /// </summary>
        /// <param name="stringArray">Array of string numbers</param>
        /// <returns>Array of numbers</returns>
        public static double[] ToDoubleArray(string[] stringArray)
        {
            double[] numberArray = new double[stringArray.Length];
            
            for (int i = 0; i < stringArray.Length; i++)
            {
                numberArray[i] = double.Parse(stringArray[i]);
            }

            return numberArray;
        }

        public static double[] ToDoubleArray2(string[] stringArray)
        {
            return stringArray.Select(x => Double.Parse(x)).ToArray();
        }

        public static double[] ToDoubleArray3(string[] stringArray)
        {
            return stringArray.Select(double.Parse).ToArray();
        }

        public static double[] ToDoubleArray4(string[] stringArray) => stringArray.Select(Convert.ToDouble).ToArray();

        public static double[] ToDoubleArray5(string[] stringArray)
        {
            return Array.ConvertAll(stringArray, Double.Parse);
        }

        public static double[] ToDoubleArray6(string[] stringArray) => stringArray.Select(x => double.Parse(x)).ToArray();
        
        
        
        // https://www.codewars.com/kata/563b662a59afc2b5120000c6/csharp
        /// <summary>
        /// Return n number of entire years needed to get a population greater or equal to p.
        /// <para>Examples: nb_year(1500, 5, 100, 5000) -> 15</para>
        /// </summary>
        /// <param name="p0">Starting Population Number</param>
        /// <param name="percent">Growth of the Population</param>
        /// <param name="aug">Additional newcomers</param>
        /// <param name="p">The wanted population</param>
        /// <returns>Amount of Years to hit the wanted population</returns>
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int currentPopulation = p0;
            int yearCounter = 0;

            while (currentPopulation < p)
            {
                currentPopulation = currentPopulation + (int)((currentPopulation * (percent/100))) + aug;
                yearCounter++;
            }

            return yearCounter;
        }

        public static int NbYear2(int p0, double percent, int aug, int p)
        {
            return p0 >= p ? 0 : 1 + NbYear2((int)(p0 + p0 * percent / 100 + aug), percent, aug, p);
        }

        public static int NbYear3(int p0, double percent, int aug, int p, int years = 0) => p0 >= p ? years : NbYear3(p0 + (int)(p0 * percent / 100) + aug, percent, aug, p, years + 1);

        
        
        /// <summary>
        /// <para>Limit</para>
        /// The function must return the truncated version of the given string up to the given limit followed by "..."
        /// <para>if the result is shorter than the original. Return the same string if nothing was truncated.</para>
        /// </summary>
        /// <param name="text">Text, send amount based on 'limit'.If limit is >= than text.Length, just send the whole text</param>
        /// <param name="limit">Amount of characters</param>
        /// <returns>text with less chars</returns>
        public static string Limit(string text, int limit)
        {
            if (limit >= text.Length)
            {
                return text;
            }

            string newString = "";

            for (int i = 0; i < limit; i++)
            {
                newString += text[i];
            }

            newString += "...";
            return newString;
        }
        
        public static string Limit2(string text, int limit)
        {
            return limit < text.Length ? text[..limit] + "..." : text;
        }

        public static string Limit3(string s, int n)
        {
            return n < s.Length ? s.Substring(0, n) + "..." : s;
        }

        public static string Limit4(string text, int limit)
        {
            return text == null || text.Length <= limit ? text : text.Substring(0, limit) + "...";
        }

        public static string Limit5(string text, int limit)
        {
            if (limit >= text.Length)
                return text;
            return text.Substring(0, limit) + "...";
        }

        public static string Limit6(string text, int limit) => $"{string.Concat(text.Take(limit))}{(limit < text.Length ? "..." : "")}";
        
        
        
        //  https://www.codewars.com/kata/substituting-variables-into-strings-padded-numbers/train/csharp
        /// <summary>
        /// The return value should equal "Value is VALUE" where value is a 5 digit padded number.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Solution(int value)
        {
            if (value <= 9)
            {
                return "Value is 0000" + value.ToString(); ;
            }
            else if (value <= 99)
            {
                return "Value is 000" + value.ToString(); ;
            }
            else if (value <= 999)
            {
                return "Value is 00" + value.ToString(); ;
            }
            else if (value <= 9999)
            {
                return "Value is 0" + value.ToString(); ;
            }
            else if (value <= 99999)
            {
                return "Value is " + value.ToString(); ;
            }

            return "Error";
        }

        public static string Solution2(int value)
        {
            return $"Value is {value:D5}";
        }

        public static string Solution3(int value) => "Value is " + value.ToString("00000");

        //  https://www.codewars.com/kata/odd-or-even/train/csharp
        /// <summary>
        /// Given an array of numbers, determine whether the sum of all of the numbers is odd or even.
        /// </summary>
        /// <param name="array">Array with numbers</param>
        /// <returns></returns>
        public static string OddOrEven(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (sum % 2 == 0)
            {
                return "even";
            }

            return "odd";
        }

        public static string OddOrEven2(int[] array)
        {
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }

        /// <summary>
        /// Creates squares with "+" based on n
        /// </summary>
        /// <param name="n">Size of the square</param>
        /// <returns></returns>
        public static string GenerateShape(int n)
        {
            string line = "";
            string result = "";

            if (n == 0)
            {
                return "";
            }
            else if (n == 1)
            {
                return "+";
            }

            for (int i = 0; i < n; i++)
            {
                line += "+";
            }

            line += "\n";

            for (int i = 0; i < n; i++)
            {
                result += line;
            }

            return result.Remove(result.Length - 1);
        }

        public static string GenerateShape2(int n) => string.Join("\n", Enumerable.Repeat(new string('+', n), n));

        /// <summary>
        /// Creates complementary side of a DNA string
        /// </summary>
        /// <param name="dna"><para>Deoxyribonucleic acid (DNA)</para>
        /// Is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.</param>
        /// <returns></returns>
        public static string MakeComplement(string dna)
        {
            string result = "";
            char currentCharacter;

            for (int i = 0; i < dna.Length; i++)
            {
                currentCharacter = dna[i];

                switch (currentCharacter)
                {
                    case 'A':
                        result += "T";
                        break;

                    case 'T':
                        result += "A";
                        break;

                    case 'G':
                        result += "C";
                        break;

                    case 'C':
                        result += "G";
                        break;

                    default:
                        break;
                }
            }

            return result;
        }

        public static string MakeComplement2(string dna)
        {
            return dna.Replace('T', '?').Replace('A', 'T').Replace('?', 'A').Replace('G', '?').Replace('C', 'G').Replace('?', 'C');
        }


        //Code your solution here - http://www.codewars.com/kata/credit-card-issuer-checking/train/csharp
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string getIssuer(long number)
        {
            /*
                | Card Type  | Begins With          | Number Length |
                |------------|----------------------|---------------|
                | AMEX       | 34 or 37             | 15            |
                | Discover   | 6011                 | 16            |
                | Mastercard | 51, 52, 53, 54 or 55 | 16            |
                | VISA       | 4                    | 13 or 16      |
             */
            throw new NotImplementedException();
        }

        //  https://www.codewars.com/kata/sort-array-by-string-length/train/csharp
        /// <summary>
        /// Takes an array of strings as an argument and returns a sorted array containing the same strings, ordered from shortest to longest.
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        private static string[] SortByLenght(string[] words)
        {
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            return words;
        }


        //  https://www.codewars.com/kata/reverse-a-number/train/csharp
        /// <summary>
        /// Reverse digits. 1337 => 7331
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int ReverseNumber(int n)
        {
            StringBuilder sb = new StringBuilder();
            string number = Math.Abs(n).ToString();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sb.Append(number[i]);
            }

            // If n is negative, add minus '-'
            if (n < 0)
            {
                sb.Insert(0, '-');
            }

            int result = Convert.ToInt32(sb.ToString());

            return result;
        }

        public static int ReverseNumber2(int n) => int.Parse(String.Join("", Math.Abs(n).ToString().Reverse())) * (n < 0 ? -1 : 1);


        //  https://www.codewars.com/kata/sum-of-all-the-multiples-of-3-or-5/csharp
        /// <summary>
        /// This function will return the sum of all multiples of 3 and 5.
        /// 5 => 8,
        /// 10 => 33
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int findSum(int n)
        {
            int result = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        public static int findSum2(int n) => Enumerable.Range(1, n).Where(x => x % 5 == 0 || x % 3 == 0).Sum();

        //  https://www.codewars.com/kata/determine-if-the-poker-hand-is-flush/train/csharp
        /// <summary>
        /// Determine if the poker hand is flush
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool CheckIfFlush(string[] cards)
        {
            //Write your code here

            int hearthCounter = 0;
            int spadesCounter = 0;
            int diamonsCounter = 0;
            int clubsCounter = 0;


            char type;

            foreach (string card in cards)
            {
                if (card.Length == 3)
                {
                    type = card[2];

                    switch (type)
                    {

                        case 'H':
                            hearthCounter++;
                            break;

                        case 'S':
                            spadesCounter++;
                            break;

                        case 'D':
                            diamonsCounter++;
                            break;

                        case 'C':
                            clubsCounter++;
                            break;
                    }

                    if (hearthCounter >= 5 || spadesCounter >= 5 || diamonsCounter >= 5 || clubsCounter >= 5)
                    {
                        return true;
                    }
                }
                else
                {
                    type = card[1];

                    switch (type)
                    {

                        case 'H':
                            hearthCounter++;
                            break;

                        case 'S':
                            spadesCounter++;
                            break;

                        case 'D':
                            diamonsCounter++;
                            break;

                        case 'C':
                            clubsCounter++;
                            break;
                    }

                    if (hearthCounter >= 5 || spadesCounter >= 5 || diamonsCounter >= 5 || clubsCounter >= 5)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool CheckIfFlush2(string[] cards) => cards.All(x => x.Last() == cards.First().Last());

        // https://www.codewars.com/kata/sum-of-angles/train/csharp
        /// <summary>
        /// Find the total sum of angles in an n sided shape. N will be greater than 2
        /// </summary>
        /// <param name="n_sides"></param>
        /// <returns></returns>
        public static int Angle(int n_sides)
        {
            // Your code here
            int result_Angle = 180;

            for (int i = 3; i < n_sides; i++)
            {
                result_Angle += 180;
            }

            return result_Angle;
        }

        public static int Angle2(int n) => (n - 2) * 180;


        // https://www.codewars.com/kata/shortest-word/train/csharp
        /// <summary>
        /// Given a string of words, return the length of the shortest word(s).
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int FindShort(string s)
        {
            string[] words = s.Split(' ');

            int[] arrayWithNumberLength = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                arrayWithNumberLength[i] = words[i].Length;
            }

            return arrayWithNumberLength.Min();
        }


        public static int FindShort2(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }


        // https://www.codewars.com/kata/going-to-the-cinema/train/csharp
        /// <summary>
        /// movie(500, 15, 0.9) should return 43
        /// </summary>
        /// <param name="card"></param>
        /// <param name="ticket"></param>
        /// <param name="percent"></param>
        /// <returns></returns>
        public static int Movie(int card, int ticket, double percent)
        {
            return 0;
        }

        // https://www.codewars.com/kata/google-interview-question-easy/train/csharp
        public static string GetStringsAsterisk(string city)
        {
            string stringNameInAsterisk = "";


            return stringNameInAsterisk;
        }


        // https://www.codewars.com/kata/form-the-largest/train/csharp
        public static int MaxNumber(int n)
        {
            //Do Some Magic

            return int.MaxValue;
        }



        // https://www.codewars.com/kata/predict-your-age/train/csharp
        /// <summary>
        /// Take a list of ages when each of your great-grandparent died.
        /// Multiply each number by itself. ✅
        /// Add them all together. ✅
        /// Take the square root of the result. ✅
        /// Divide by two. ✅
        /// </summary>
        /// <param name="age1"></param>
        /// <param name="age2"></param>
        /// <param name="age3"></param>
        /// <param name="age4"></param>
        /// <param name="age5"></param>
        /// <param name="age6"></param>
        /// <param name="age7"></param>
        /// <param name="age8"></param>
        /// <returns></returns>
        public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            age1 *= age1;
            age2 *= age2;
            age3 *= age3;
            age4 *= age4;

            age5 *= age5;
            age6 *= age6;
            age7 *= age7;
            age8 *= age8;

            int AddedTogether = age1 + age2 + age3 + age4 + age5 + age6 + age7 + age8;

            double temp = (Math.Sqrt(AddedTogether));
            Console.WriteLine(temp);
            double finalValueAge = temp / 2;
            Console.WriteLine(finalValueAge);

            Console.WriteLine("Age: {0}  {1}", age1, finalValueAge);

            return Convert.ToInt32(Math.Floor(finalValueAge));
        }


        public static int PredictAge2(params int[] ages) => (int)Math.Sqrt(ages.Select(e => e * e).ToArray().Sum()) / 2;


        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            // Believe 👍
            List<int> integerList = new List<int>();
            int content;
            foreach (var item in listOfItems)
            {
                if (item is int)
                {
                    int.TryParse(item.ToString(), out content);
                    integerList.Add(content);
                }
            }
            return integerList;
        }

        public static IEnumerable<int> GetIntegersFromList2(List<object> listOfItems)
        {
            return listOfItems.OfType<int>();
        }


        // https://www.codewars.com/kata/regex-validate-pin-code/train/csharp
        /// <summary>
        /// ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public static bool ValidatePin(string pin)
        {
            Regex regexNumber = new Regex("^[0-9]+$");

            if (pin.Length == 4 || pin.Length == 6)
            {
                if (regexNumber.IsMatch(pin))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ValidatePin2(string pin)
        {
            return Regex.IsMatch(pin, @"^\d{4}$|^\d{6}$");
        }


        //  https://www.codewars.com/kata/find-the-vowels/train/csharp
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


        /// <summary>
        /// Check to see if a string has the same amount of 'x's and 'o's.
        /// The method must return a boolean and be case insensitive.
        /// </summary>
        /// <param name="input">The string can contain any char.</param>
        /// <returns></returns>
        public static bool XO(string input)
        {
            int xCounter = 0;
            int oCounter = 0;

            foreach (char item in input)
            {
                if ("x" == item.ToString().ToLower())
                {
                    xCounter++;
                }
                else if ("o" == item.ToString().ToLower())
                {
                    oCounter++;
                }
            }
            if (xCounter == oCounter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Same as XO, just in one line.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool XO2(string input)
        {
            return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        }


        #region matrix example

        /*

        var matrix = new int[][] {
                new int[] {1,2,3},
                new int[] {4,5,6},
                new int[] {7,8,9}};

        var expected = new int[][]{
                new int[]{9,2,7},
                new int[]{4,5,6},
                new int[]{3,8,1}};

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

         */

        #endregion


        public static int[][] ReverseOnDiagonals(int[][] matrix)
        {
            // Noget smart der kan regne ud, hvor diagonalen er...
            // matrix.length kan bruges hvad ellers?
            // temp variabel bliver nok nødvendigt.



            return matrix;
        }



        public static int[][] ReverseOnDiagonals_Prototype2(int[][] matrix)
        {
            /*
                {43,455,32,103}
                {102,988,298,981}
                {309,21,53,64}
                {2,22,35,291}

            int leftTop = matrix[0][0];
            int rightTop = matrix[0][lenght -1];
            int innerTopLeft = matrix[1][1];
            int innerTopRight = matrix[1][2];
            int innerBotLeft = matrix[2][1];
            int innerBotRight = matrix[2][2];
            int leftTop = matrix[lenght -1][0];
            int rightTop = matrix[lenght -1][lenght -1];

                {291,455,32,2}
                {102,53,21,981}
                {309,298,988,64}
                {103,22,35,43}
            */

            int length = matrix.Length;

            Console.WriteLine($"Matrix.Length: {matrix.Length}\n");

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] innerArray = matrix[i];
                //Console.WriteLine($"InnerArray.Length: {innerArray.Length}");

                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }


            int leftTop = matrix[0][0];
            int rightTop = matrix[0][length - 1];
            int innerTopLeft = matrix[1][1];
            int innerTopRight = matrix[1][2];
            int innerBotLeft = matrix[2][1];
            int innerBotRight = matrix[2][2];
            int leftBot = matrix[length - 1][0];
            int rightBot = matrix[length - 1][length - 1];

            Console.WriteLine($"\n\nleftTop: {leftTop}"); // 43      - Skal byttes med rightBot
            Console.WriteLine($"rightTop: {rightTop}"); // 103    - Skal byttes med leftBot

            Console.WriteLine($"innerTopLeft: {innerTopLeft}"); // 988    - Skal byttes med innerBotRight
            Console.WriteLine($"innerTopRight: {innerTopRight}"); // 298    - Skal byttes med innerBotLeft

            Console.WriteLine($"innerBotLeft: {innerBotLeft}"); // 21    - Skal byttes med innerTopRight
            Console.WriteLine($"innerBotRight: {innerBotRight}"); // 53    - Skal byttes med innerTopLeft

            Console.WriteLine($"leftBot: {leftBot}"); // 2      - Skal byttes med rightTop
            Console.WriteLine($"rightBot: {rightBot}"); // 291    - Skal byttes med leftTop

            matrix[0][0] = rightBot;
            matrix[0][length - 1] = leftBot;

            matrix[1][1] = innerBotRight;
            matrix[1][2] = innerBotLeft;

            matrix[2][1] = innerTopRight;
            matrix[2][2] = innerTopLeft;

            matrix[length - 1][0] = rightTop;
            matrix[length - 1][length - 1] = leftTop;


            for (int i = 0; i < matrix.Length; i++)
            {
                int[] innerArray = matrix[i];
                //Console.WriteLine($"InnerArray.Length: {innerArray.Length}");

                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }





            Console.WriteLine();
            return matrix;
        }


        public static int[][] ReverseOnDiagonals_Prototype(int[][] matrix)
        {
            /*
                {1,2,3}  
                {4,5,6}  
                {7,8,9} 

                {9,2,7}
                {4,5,6}
                {3,8,1}
            */


            int length = matrix.Length;

            Console.WriteLine($"Matrix.Length: {matrix.Length}\n");

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] innerArray = matrix[i];
                //Console.WriteLine($"InnerArray.Length: {innerArray.Length}");

                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }

            int leftTop = matrix[0][0];
            int rightTop = matrix[0][length - 1];
            int leftBot = matrix[length - 1][0];
            int rightBot = matrix[length - 1][length - 1];
            Console.WriteLine($"\nleftTop: {leftTop}"); // 1      - Skal byttes med rightBot
            Console.WriteLine($"rightTop: {rightTop}"); // 3    - Skal byttes med leftBot
            Console.WriteLine($"leftBot: {leftBot}"); // 7      - Skal byttes med rightTop
            Console.WriteLine($"rightBot: {rightBot}"); // 9    - Skal byttes med leftTop

            matrix[0][0] = rightBot;
            matrix[0][length - 1] = leftBot;
            matrix[length - 1][0] = rightTop;
            matrix[length - 1][length - 1] = leftTop;

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] innerArray = matrix[i];
                //Console.WriteLine($"InnerArray.Length: {innerArray.Length}");

                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }

            return matrix;
        }
    }
}
