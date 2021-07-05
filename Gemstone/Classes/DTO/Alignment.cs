using Gemstone.Definitions.Enums;

namespace Gemstone.Classes.DTO
{
    public class Alignment
    {
        public LawChaos LawChaos { get; private set; }
        public GoodEvil GoodEvil { get; private set; }

        public Alignment(LawChaos lc, GoodEvil ge)
        {
            LawChaos = lc;
            GoodEvil = ge;
        }

        public override string ToString()
        {
            if (LawChaos == LawChaos.Neutral && GoodEvil == GoodEvil.Neutral)
                return "True Neutral";
            else
                return LawChaos.ToString() + " " + GoodEvil.ToString();
        }
    }
}
