using Gemstone.Classes.Helper;
using Gemstone.Classes.Logic;
using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gemstone.Classes.DTO
{
    /// <summary>
    /// Gem Object
    /// </summary>
    public class Gem
    {
        /*-----Public Variables-----*/

        /// <summary>
        /// The clarity of the gem - I.E. how many imperfections it has
        /// Larger numbers mean fewer imperfections
        /// Range ~0.25 - ~1.71
        /// </summary>
        public double ClarityGrade { get; private set; }

        /// <summary>
        /// How close the color is to desirable.
        /// Larger numbers are more desireable to the general public.
        /// Range ~0.25 - ~1.71
        /// </summary>
        public double ColorGrade { get; private set; }

        /// <summary>
        /// The quality of the cut of the gem.
        /// Larger numbers are higher quality.
        /// Range ~0.25 - ~1.71
        /// </summary>
        public double CutGrade { get; private set; }

        /// <summary>
        /// The size of the gem in carats
        /// Range ~0.25 - ~555
        /// </summary>
        public double Size { get; private set; }

        public double Value => Math.Round(BaseValue * Size * CutGrade * ColorGrade * ClarityGrade, 2);

        public GemstoneEnum Type { get; private set; }

        public GemstoneCutEnum Cut { get; private set; }

        public GemColor Color { get; private set; }

        /*-----Private Variables-----*/

        private double BaseValue { get; set; }

        private string SizeString => Size.SizeString();
        private string CutString => Cut.CutString();
        private string GemString => Type.GemString();
        private string ColorString => Color.ColorString();

        /*-----Public Methods-----*/

        public override string ToString()
        {
            return ColorString != null
                ? SizeString + " " + CutString + " " + ColorString + " " + GemString
                : SizeString + " " + CutString + " " + GemString;
        }

        /*-----Constructor-----*/

        /// <summary>
        /// A new gemstone
        /// Any value not provided is randomly generated
        /// </summary>
        public Gem(GemstoneEnum? type = null, GemstoneCutEnum? cut = null, double? clarityGrade = null, double? colorGrade = null, double? cutGrade = null, double? size = null, GemColor? color = null)
        {
            Type = type ?? ValueGenerator.GetRandomGemstoneType();
            Cut = cut ?? ValueGenerator.GetRandomGemstoneCut();
            Color = color ?? ValueGenerator.GetRandomGemstoneColor(Type);

            ClarityGrade = clarityGrade ?? ValueGenerator.GetRandomClarityCutorColorValue();
            ColorGrade = colorGrade ?? ValueGenerator.GetRandomClarityCutorColorValue();
            CutGrade = cutGrade ?? ValueGenerator.GetRandomClarityCutorColorValue();
            Size = size ?? ValueGenerator.GetRandomSizeValue();

            SetGemTypeValues();
        }

        /*-----Private Methods-----*/

        /// <summary>
        /// Uses the GemstoneEnum to determine BaseValue and GemString
        /// </summary>
        private void SetGemTypeValues()
        {
            BaseValue = Type.GetGemBaseValue();
            CheckForValueMultiplier();
        }

        /// <summary>
        /// Increases BaseValue for certain gemstones
        /// </summary>
        private void CheckForValueMultiplier()
        {
            switch (Type)
            {
                case GemstoneEnum.Diamond:
                    if (Color == GemColor.Clear)
                        BaseValue *= 2;
                    if (Color == GemColor.Yellow || Color == GemColor.Brown)
                        BaseValue *= 1.25;
                    break;
                case GemstoneEnum.Sapphire:
                    if (Color != GemColor.Blue)
                        BaseValue *= 1.1;
                    break;
                default:
                    break;
            }
        }
    }
}
