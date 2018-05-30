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
    }
}
