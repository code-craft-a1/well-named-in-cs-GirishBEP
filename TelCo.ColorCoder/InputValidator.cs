using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TelCo.ColorCoder.ColorCodeModel;

namespace TelCo.ColorCoder
{
    internal static class InputValidator
    {  
        private const int maxPairs = (ColorCodeModel.PairStartNumber - 1 ) + 
            (int)(ColorCodeModel.MajorColors.Max - 1) * (int)(ColorCodeModel.MinorColors.Max - 1);
        /// <summary>
        /// Vaidate the Pair Number based on a set of implicit rules
        /// </summary>
        /// <param name="pairNumber"></param>
        public static void ValidatePairNumber(int pairNumber)
        {
            RuleEngine pairNumberRuleEngine = new RuleEngine(
                new List<IRule> {   
                    new Rule("Equal or Greater than " + ColorCodeModel.PairStartNumber, () => pairNumber >= ColorCodeModel.PairStartNumber),
                    new Rule("Equal or Lesser than " + maxPairs, () => pairNumber <= maxPairs) }
                );
            pairNumberRuleEngine.ExecuteAll();
        }

        public static void ValidateColorPair(Color majorColorName, Color minorColorName)
        {
            RuleEngine colorPairRuleEngine = new RuleEngine(
                new List<IRule> {
                    new Rule("Major color should be known " + majorColorName, () => Enum.TryParse(majorColorName.Name, out MajorColors color) == true),
                    new Rule("Minor color should be known " + minorColorName, () => Enum.TryParse(minorColorName.Name, out MinorColors color) == true) }                  
                );

            colorPairRuleEngine.ExecuteAll();
        }
    }
}
