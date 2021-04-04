namespace Gemstone.Definitions.Enums
{
    public enum GemstoneCutEnum
    {
        Uncut,
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
                case GemstoneCutEnum.RoundBrilliant:
                    return "Round Brilliant";
                case GemstoneCutEnum.OvalBrilliant:
                    return "Oval Brilliant";
                case GemstoneCutEnum.PearBrilliant:
                    return "Pear Brilliant";
                case GemstoneCutEnum.RoundRose:
                    return "Round Rose";
                case GemstoneCutEnum.OvalRose:
                    return "Oval Rose";
                case GemstoneCutEnum.DropRose:
                    return "Drop Rose";
                case GemstoneCutEnum.StepCutOctagon:
                    return "Step-Cut Octagon";
                case GemstoneCutEnum.StepCutOblong:
                    return "Step-Cut Oblong";
                default:
                    return value.ToString();
            }
        }
    }
}
