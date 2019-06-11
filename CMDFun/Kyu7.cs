using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CMDFun
{
    class Kyu7
    {
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
