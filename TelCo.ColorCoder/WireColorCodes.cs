using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static TelCo.ColorCoder.ColorCodeModel;

namespace TelCo.ColorCoder
{
    internal static class WireColorCodes
    {
        public static int GetPairNumberFromColor(Color major, Color minor)
        {
            InputValidator.ValidateColorPair(major, minor);

            
            Enum.TryParse(major.Name, out MajorColors majorColor);
            Enum.TryParse(minor.Name, out MinorColors minorColor);
            ColorPairModel cp = new ColorPairModel(majorColor, minorColor);

            return ColorCodeModel.ColorCodePairs.FirstOrDefault(kv => kv.Value.Equals(cp)).Key;

        }

        internal static ColorPairModel GetColorFromPairNumber(int pairNumber)
        {
            InputValidator.ValidatePairNumber(pairNumber);
            return ColorCodeModel.ColorCodePairs[pairNumber];
        }
    }
}