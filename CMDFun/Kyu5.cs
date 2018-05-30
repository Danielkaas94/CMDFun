using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu5
    {
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
