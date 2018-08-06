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
    }
}
