using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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


        private static DynamicMethod MultiplyBy2AndAdd1()
        {
            DynamicMethod myDynamaticMethod = new DynamicMethod("DynamicMultiply", typeof(int), new Type[] { typeof(int) });

            ILGenerator ilGenerator = myDynamaticMethod.GetILGenerator(); // Generates Microsoft intermediate language (MSIL) instructions.

            ilGenerator.Emit(OpCodes.Ldarg_0); // Loads the argument at index 0 onto the evaluation stack.
            ilGenerator.Emit(OpCodes.Ldc_I4_2); // Pushes the integer value of 2 onto the evaluation stack as an int32.
            ilGenerator.Emit(OpCodes.Mul); // Multiplies two values and pushes the result on the evaluation stack.
            ilGenerator.Emit(OpCodes.Ldc_I4_1); // Pushes the integer value of 1 onto the evaluation stack as an int32.
            ilGenerator.Emit(OpCodes.Add); // Adds two values and pushes the result onto the evaluation stack.
            ilGenerator.Emit(OpCodes.Ret); // Returns from the current method, pushing a return value (if present) from the callee's evaluation stack onto the caller's evaluation stack.

            return myDynamaticMethod;
        }
    }
}
