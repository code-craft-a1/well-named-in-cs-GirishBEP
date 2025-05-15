using System;
using System.Diagnostics;
using System.Drawing;
using static TelCo.ColorCoder.ColorCodeModel;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// The 25-pair color code, originally known as even-count color code, 
    /// is a color code used to identify individual conductors in twisted-pair 
    /// wiring for telecommunications.
    /// This class provides the color coding and 
    /// mapping of pair number to color and color to pair number.
    /// </summary>
    class Program
    {        
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        private static ColorPairModel GetColorFromPairNumber(int pairNumber)
        {
            return WireColorCodes.GetColorFromPairNumber(pairNumber);           
        }
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        private static int GetPairNumberFromColor(ColorPair pair)
        {
            return WireColorCodes.GetPairNumberFromColor(pair.majorColor, pair.minorColor);           
        }

        /// <summary>
        /// Test code for the class
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int pairNumber = 4;
            ColorPairModel testPair1 = Program.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor.ToString() == Color.White.Name);
            Debug.Assert(testPair1.minorColor.ToString() == Color.Brown.Name);

            pairNumber = 5;
            testPair1 = Program.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor.ToString() == Color.White.Name);
            Debug.Assert(testPair1.minorColor.ToString() == Color.SlateGray.Name);

            pairNumber = 23;
            testPair1 = Program.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor.ToString() == Color.Violet.Name);
            Debug.Assert(testPair1.minorColor.ToString() == Color.Green.Name);

            ColorPair testPair2 = new ColorPair(Color.Yellow, Color.Green);
            pairNumber = Program.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair(Color.Red, Color.Blue);
            pairNumber = Program.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);

            ColorCodePrinter.PrintColorCodes();
        }
    }
}
