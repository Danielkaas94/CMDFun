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
            
            /*
                CK YOURSELF

                C
                K

                Y
                O
                U
                R
                S
                E
                L
                F

                CK YOURSELF
            */
            
            
            
            Kyu7.AdjacentElementsProduct(new int[] { 1, 2, 3 });                                //  6
            Kyu7.AdjacentElementsProduct(new int[] { 9, 5, 10, 2, 24, -1, -48 });               //  50
            Kyu7.AdjacentElementsProduct(new int[] { -23, 4, -5, 99, -27, 329, -2, 7, -921 });  // -14
            Kyu7.AdjacentElementsProduct(new int[] { 0, 1, 0, 1, 0, 1000 });                    //  0
            
            Kyu7.Spoonerize("Reanu Keeves");
            Kyu7.Spoonerize("Nitch Bigger");
            Kyu7.Spoonerize("Pig Benis");

            PrintDiamond();
        }

        private static void PrintDiamond()
        {
            Console.WriteLine(Kyu6.print(3));
            Console.WriteLine(Kyu6.print(5));
            Console.WriteLine(Kyu6.print(7));
            Console.WriteLine(Kyu6.print(9));
            Console.WriteLine(Kyu6.print(11));
            Console.WriteLine(Kyu6.print(21));
            Console.WriteLine(Kyu6.print(43));
            Console.WriteLine(Kyu6.print(87));
            Console.WriteLine(Kyu6.print(175));
        }
    }
}
