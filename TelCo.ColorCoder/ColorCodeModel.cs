using System;
using System.Collections.Generic;

namespace TelCo.ColorCoder
{
    internal static class ColorCodeModel
    {
        /// <summary>
        /// MajorColors
        /// enums are used instead of Color class to reduce memory foot print 
        /// </summary>
        public enum MajorColors
        {
            Min = 0,
            White,
            Red,
            Black,
            Yellow,
            Violet,
            Max
        }

        public enum MinorColors
        {
            Min = 0,
            Blue,
            Orange,
            Green,
            Brown,
            SlateGray,
            Max
        }

        public const int PairStartNumber = 1;

        internal class ColorPairModel:IEquatable<ColorPairModel>
        {
            public readonly MajorColors majorColor;
            public readonly MinorColors minorColor;
            public ColorPairModel (MajorColors major, MinorColors minor)
            {
                majorColor = major;
                minorColor = minor;
            }

            public bool Equals(ColorPairModel other)
            {
                return other.majorColor == majorColor && other.minorColor == minorColor;
            }

            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.ToString(), minorColor.ToString());
            }
        }

        // Dictionary is maintained readonly, populated in code to increase readability
        // Populating via code is not advised to avoid errors
        public static readonly Dictionary<int, ColorPairModel> ColorCodePairs = new Dictionary<int, ColorPairModel>();

        static ColorCodeModel()
        {
            for (int i = PairStartNumber; i <= ((int)MajorColors.Max - 1) * ((int)MinorColors.Max - 1); i++)
            {
                ColorCodePairs.Add(i, new ColorPairModel(
                    (MajorColors)(((i - 1) / ((int)MajorColors.Max - 1)) + MajorColors.Min + 1),
                    (MinorColors)(((i - 1) % ((int)MinorColors.Max - 1)) + MinorColors.Min + 1)
                    )
                    );
            }
            ColorCodePrinter.PrintColorCodes();
        }
    }
}
