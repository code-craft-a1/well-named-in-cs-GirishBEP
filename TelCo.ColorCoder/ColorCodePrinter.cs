using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelCo.ColorCoder
{
    internal static class ColorCodePrinter
    {        
        public static void  PrintColorCodes()
        {
            for (int i = 1; i <= ((int)ColorCodeModel.MajorColors.Max - 1) * ((int)ColorCodeModel.MinorColors.Max - 1); i++)
            {
                var colorPair = WireColorCodes.GetColorFromPairNumber(i);
                Console.WriteLine("{0}\t\t{1}\t{2}", i, colorPair.majorColor, colorPair.minorColor);
            }
        }
    }
}
