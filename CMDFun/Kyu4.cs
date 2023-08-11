using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMDFun
{
    class Kyu4
    {
        // https://www.codewars.com/kata/next-bigger-number-with-the-same-digits/train/csharp
        /// <summary>
        /// 12 ==> 21
        /// 513 ==> 531
        /// 2017 ==> 2071
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static long NextBiggerNumber(long n)
        {
            //code me
            return 0;
        }

        //  https://www.codewars.com/kata/sum-strings-as-numbers/train/csharp
        /// <summary>
        /// Given the string representations of two integers, return the string representation of the sum of those integers.
        /// <para>sumStrings('1','2') // => '3'</para>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string sumStrings(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(2 + 2);
            Console.WriteLine(sb);

            Console.WriteLine(a);
            Console.WriteLine(b);
            BigInteger valueA = 0;
            BigInteger valueB = 0;

            if (a == null || a == "")
            {

            }


            valueA = ulong.Parse(a);
            valueB = ulong.Parse(b);

            return (valueA + valueB).ToString();
        }
    }

    public class Matrix
{

    //  https://www.codewars.com/kata/52a382ee44408cea2500074c/csharp
    public static int Determinant(int[][] matrix)
    {
        int n = matrix.Length;

        // Base case: For a 1x1 matrix, determinant is the single element
        if (n == 1)
        {
            return matrix[0][0];
        }
        // Base case: For a 2x2 matrix, calculate determinant using formula
        else if (n == 2)
        {
            return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
        }
        else
        {
            int determinant = 0;
            
            // Loop through the first row of the matrix
            for (int i = 0; i < n; i++)
            {
                // Calculate the minor matrix by excluding the current column
                int[][] minor = CreateMinor(matrix, i);
            
                // Determine the sign based on the position in the matrix
                int sign = (i % 2 == 0) ? 1 : -1;
            
                // Recursively calculate the determinant of the minor matrix
                determinant += sign * matrix[0][i] * Determinant(minor);
            }
        
            return determinant;
        }
    }

    private static int[][] CreateMinor(int[][] matrix, int colToExclude)
    {
        int n = matrix.Length;
        int[][] minor = new int[n - 1][];

        // Loop through rows of the matrix to create the minor matrix
        for (int i = 1; i < n; i++)
        {
            minor[i - 1] = new int[n - 1];
            for (int j = 0, col = 0; j < n; j++)
            {
                // Exclude the specified column while creating the minor matrix
                if (j != colToExclude)
                {
                    minor[i - 1][col] = matrix[i][j];
                    col++;
                }
            }
        }
    
        return minor;
    }
}




public class Matrix2
{
   public static int Determinant(int[][] m)
   {
       if (m.Length == 1) return m[0][0];
       if (m.Length == 2) return m[0][0]*m[1][1]-m[0][1]*m[1][0];
       if (m.Length == 3) return m[0][0]*m[1][1]*m[2][2]-m[0][0]*m[2][1]*m[1][2]-m[1][0]*m[0][1]*m[2][2]+m[1][0]*m[2][1]*m[0][2]+m[2][0]*m[0][1]*m[1][2]-m[2][0]*m[1][1]*m[0][2];
       var d = 0;
       for (var i=0; i<m.Length; i++) 
       {
           var e = m[0][i];
           d += (int)Math.Pow(-1,i+2) * e * Determinant(Minor(m,i));
       }
       return d;
   }
  
   private static int[][] Minor(int[][] source, int i) 
   {
       int[][] m = new int[source.Length-1][];
       for (var k=0; k<m.Length; k++) 
       {
           var p = 0;
           m[k] = new int[source[k+1].Length-1];
           for (var j=0; j<m[k].Length; j++) 
           {
               if (i==j) p++;
               m[k][j] = source[k+1][j+p];
           }
       }
       return m;
   }
}
}
