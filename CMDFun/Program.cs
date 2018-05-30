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
            string hello = "Hello World";
            Console.WriteLine(hello.ToAlternatingCase());

            Console.WriteLine(Kyu7.ValidatePin("a234")); // Should be false 
            Console.WriteLine(Kyu7.ValidatePin("123456")); // Should be true 
            Console.WriteLine(Kyu7.ValidatePin("1234")); // Should be true
            Console.WriteLine(Kyu7.ValidatePin("12345")); // Should be false





            //Wave("hello");



            //Dictionary<string, string> presetColors = new Dictionary<string, string>();
            //presetColors.Add("something", "somthing");
            //HtmlColorParser htmlColorParser = new HtmlColorParser(presetColors);
            //htmlColorParser.DisplayColor();


            //CMDTools CmdTools = new CMDTools();

            //Console.ReadLine();

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
            int lastIndex = arr.Length -1;

            for (int i = lastIndex-1; i > 0; i--)
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
                Console.WriteLine("Lal " +  item);
            }

            return arr;
        }



        public static string sumStrings(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(2+2);
            Console.WriteLine(sb);

            Console.WriteLine(a);
            Console.WriteLine(b);
            BigInteger valueA = 0;
            BigInteger valueB = 0;

            if (a == null || a == "" )
            {

            }


            valueA = ulong.Parse(a);
            valueB = ulong.Parse(b);

            return (valueA + valueB).ToString();
        }





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


        // Race(720, 850, 70) => [0, 32, 18]
        // Race(80, 91, 37) => [3, 21, 49]
        public static int[] Race(int v1, int v2, int g)
        {
            // your code

            // Output: [hour, min, sec]
            return null;
        }

        private static void Tests()
        {
            var sheeps = new bool[] { true, false, true, false, true };
            Console.WriteLine(CountSheep(sheeps));
            Console.WriteLine(CountSheep2(sheeps));

            string[] words = { "Telescopes", "Glasses", "Eyes", "Monocles" };
            SortByLenght(words);

            //string words2 = "internationalization";
            //Abbreviate(words2);

            double height = 1.80;
            double weight = 80;

            Console.WriteLine(Bmi(weight, height)); ;

            ////Digitize(35231);
            //string[] smileys = { ":D", ":~)", ";~D", ":)" };
            //CountSmiley(smileys);

            string longWordFromMerryPoppins = "supercalifragilisticexpialidocious";
            string word4 = "super";

            var something = VowelIndices(word4);

            foreach (var some in something)
            {
                Console.WriteLine(some);
            }

            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] sometigng = CountPositivesSumNegatives(input);

            Console.WriteLine("resultat: " + something[0] + " " + something[1]);

            int[] intArray1 = new int[] { 1, 2, 3 };
            int[] intArray2 = new int[] { 4, 5, 6 };

            ArrayPlusArray(intArray1, intArray2);
        }

        /// <summary>
        /// Performs the ROT13 character rotation.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string Rot13(string message)
        {
            char[] array = message.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i]; // Converts char to int.

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number; // Converts number to char.
            }
            return new string(array);
        }

        public static string Rot13ver2(string message)
        {
            return new String(message.Select(u => (Char.IsLetter(u)) ? (char)(u + ((Char.ToLower(u) > 'm') ? -13 : 13)) : u).ToArray());
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
