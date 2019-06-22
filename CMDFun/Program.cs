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
            Console.WriteLine(Kyu6.IsPrime(7919)); // Expect True
            Console.WriteLine(Kyu6.IsPrime(7920)); // Expect False 
            Console.ReadLine();

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
