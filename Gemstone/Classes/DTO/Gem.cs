using Gemstone.Classes.Helper;
using Gemstone.Classes.Logic;
using Gemstone.Definitions.Enums;
using System;
using System.Collections.Generic;

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

        private Guid ID { get; set; }

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

        /// <summary>
        /// Returns a string list that can be used in DocumentSaver
        /// Contains GM Specific information
        /// </summary>
        public List<string> GMDocumentStrings()
        {
            return new List<string>
            {
                ToString(),
                "ID      : " + ID,
                "Value   : " + Value,
                string.Empty,
                "Base    : " + BaseValue,
                "Carat   : " + Math.Round(Size, 3),
                "Color   : " + Math.Round(ColorGrade, 3),
                "Clarity : " + Math.Round(ClarityGrade, 3),
                "Cut     : " + Math.Round(CutGrade, 3)
            };
        }

        /// <summary>
        /// Returns a string list that can be used in DocumentSaver
        /// Contains only player accessable information
        /// </summary>
        public List<string> PlayerDocumentStrings()
        {
            return new List<string>
            {
                ToString() + " (" + ID + ")"
            };
        }

        /*-----Constructor-----*/

        /// <summary>
        /// A new gemstone
        /// Any value not provided is randomly generated
        /// </summary>
        public Gem(GemstoneEnum? type = null, GemstoneCutEnum? cut = null, double? clarityGrade = null, double? colorGrade = null, double? cutGrade = null, double? size = null, GemColor? color = null)
        {
            ID = Guid.NewGuid();

            Type = type ?? ValueGenerator.GetRandomGemstoneType();

            if (GemstoneAdditions.UncutStones.Contains(Type))
                Cut = GemstoneCutEnum.Uncut;
            else
                Cut = cut ?? ValueGenerator.GetRandomGemstoneCut();

            Color = color ?? ValueGenerator.GetRandomGemstoneColor(Type);

            ClarityGrade = clarityGrade ?? ValueGenerator.GetCommonRandomVariable();
            ColorGrade = colorGrade ?? ValueGenerator.GetCommonRandomVariable();
            CutGrade = cutGrade ?? ValueGenerator.GetCommonRandomVariable();
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
                case GemstoneEnum.Topaz:
                    if (Color == GemColor.Clear)
                        BaseValue *= 0.8;
                    if (Color == GemColor.Blue)
                        BaseValue *= 1.2;
                    if (Color == GemColor.Red || Color == GemColor.Pink)
                        BaseValue *= 2;
                    break;
                case GemstoneEnum.Garnet:
                    if (Color == GemColor.Red)
                        BaseValue *= 1.25;
                    if (Color == GemColor.Orange || Color == GemColor.Purple)
                        BaseValue *= 1.1;
                    break;
                case GemstoneEnum.Tourmaline:
                    if (Color == GemColor.Yellow || Color == GemColor.Blue || Color == GemColor.Orange || Color == GemColor.Purple || Color == GemColor.Red)
                        BaseValue *= 1.25;
                    break;
                default:
                    break;
            }
        }
    }
}
