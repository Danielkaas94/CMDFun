using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu5
    {
        //  https://www.codewars.com/kata/moving-zeros-to-the-end/train/csharp
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



        public class JosephusSurvivor
        {

            /*
                josephus_survivor(7,3) => means 7 people in a circle;
                one every 3 is eliminated until one remains
                [1,2,3,4,5,6,7] - initial sequence
                [1,2,4,5,6,7] => 3 is counted out
                [1,2,4,5,7] => 6 is counted out
                [1,4,5,7] => 2 is counted out
                [1,4,5] => 7 is counted out
                [1,4] => 5 is counted out
                [4] => 1 counted out, 4 is the last element - the survivor!
            */


            /// <summary>
            /// 
            /// </summary>
            /// <param name="n"></param>
            /// <param name="k"></param>
            /// <returns></returns>
            public static int JosSurvivor(int n, int k)
            {
                // your code
                return 0;
            }
        }
    }
}
