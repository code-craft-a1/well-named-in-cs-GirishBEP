using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Original ColorPair class with Drawing.Color reference
    /// </summary>
    internal class ColorPair
    {
        public Color majorColor;
        public Color minorColor;

        public ColorPair(Color major, Color minor)
        {
            this.majorColor = major;
            this.minorColor = minor;
        }
    }
}