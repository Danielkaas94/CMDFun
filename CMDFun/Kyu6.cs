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
            return 0;
        }

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
