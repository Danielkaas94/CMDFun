using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CMDFun
{
    class HtmlColorParser
    {

        // https://stackoverflow.com/questions/2109756/how-do-i-get-the-color-from-a-hexadecimal-color-code-using-net#2109938
        Color col = ColorTranslator.FromHtml("#FFCC66");

        private readonly IDictionary<string, string> presetColors;

        public HtmlColorParser(IDictionary<string, string> presetColors)
        {
            this.presetColors = presetColors;
        }

        public void DisplayColor()
        {
            Console.WriteLine(col);
        }


        public RGB Parse(string color)
        {
            return new RGB(50, 100, 255);
        }

    }


    // RGB struct is defined as follows:
    struct RGB
    {
        public byte r, g, b;
        public RGB(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }

}
