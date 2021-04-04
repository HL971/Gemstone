namespace Gemstone.Definitions.Enums
{
    public enum GemstoneCutEnum
    {
        RoundBrilliant,
        OvalBrilliant,
        PearBrilliant,
        RoundRose,
        OvalRose,
        DropRose,
        Cushion,
        StepCutOctagon,
        StepCutOblong,
        Cabochon,
        Lentil,
        Briolette,
        Ceylon,
        Barion
    }

    public static class GemstoneCutMethods
    {
        public static string CutString(this GemstoneCutEnum value)
        {
            switch (value)
            {
                default:
                    return value.ToString();
            }
        }
    }
}
