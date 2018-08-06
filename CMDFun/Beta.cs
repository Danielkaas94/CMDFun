using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Beta
    {

        // https://www.codewars.com/kata/national-bath-safety-month/train/csharp
        /// <summary>
        /// A bath will look like this (for example): |~~~~~~~|
        /// If the string can fit in, it's not safe so return false, otherwise return true
        /// </summary>
        /// <param name="s">Random string</param>
        /// <param name="xBath">Bath</param>
        /// <returns></returns>
        public static bool Bath(string s, string xBath)
        {
            // Happy Coding

            int stringLength = s.Length;
            int bathLength = xBath.Length - 2;

            if (bathLength >= stringLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
