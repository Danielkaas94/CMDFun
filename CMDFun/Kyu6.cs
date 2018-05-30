using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu6
    {
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
