using System.Collections.Generic;
using System.Linq;

namespace Gemstone.Classes.DTO
{
    public class Currency
    {
        private static double SilverBarValuePerLb => 5;
        private static double GoldBarValuePerLb => 50;

        public static double OneLbSilverBarValue => SilverBarValuePerLb;
        public static double TwoLbSilverBarValue => SilverBarValuePerLb * 2;
        public static double FiveLbSilverBarValue => SilverBarValuePerLb * 5;
        public static double TenLbSilverBarValue => SilverBarValuePerLb * 10;

        public static double OneLbGoldBarValue => GoldBarValuePerLb;
        public static double TwoLbGoldBarValue => GoldBarValuePerLb * 2;
        public static double FiveLbGoldBarValue => GoldBarValuePerLb * 5;
        public static double TenLbGoldBarValue => GoldBarValuePerLb * 10;

        public static double CopperCoinValue => 0.01;
        public static double SilverCoinValue => 0.1;
        public static double ElectrumCoinValue => 0.5;
        public static double GoldCoinValue => 1.0;
        public static double PlatinumCoinValue => 10.0;

        public List<Gem> Gems { get; set; } = new List<Gem>();

        public int CopperCoins { get; set; }
        public int SilverCoins { get; set; }
        public int ElectrumCoins { get; set; }
        public int GoldCoins { get; set; }
        public int PlatinumCoins { get; set; }

        public int OneLbSilverBar { get; set; }
        public int TwoLbSilverBar { get; set; }
        public int FiveLbSilverBar { get; set; }
        public int TenLbSilverBar { get; set; }

        public int OneLbGoldBar { get; set; }
        public int TwoLbGoldBar { get; set; }
        public int FiveLbGoldBar { get; set; }
        public int TenLbGoldBar { get; set; }

        public double Value
        {
            get
            {
                return CopperCoins * CopperCoinValue
                    + SilverCoins * SilverCoinValue
                    + ElectrumCoins * ElectrumCoinValue
                    + GoldCoins * GoldCoinValue
                    + PlatinumCoins * PlatinumCoinValue
                    + OneLbSilverBar * OneLbSilverBarValue
                    + TwoLbSilverBar * TwoLbSilverBarValue
                    + FiveLbSilverBar * FiveLbSilverBarValue
                    + TenLbSilverBar * TenLbSilverBarValue
                    + OneLbGoldBar * OneLbGoldBarValue
                    + TwoLbGoldBar * TwoLbGoldBarValue
                    + FiveLbGoldBar * FiveLbGoldBarValue
                    + TenLbGoldBar * TenLbGoldBarValue
                    + Gems.Sum(x => x.Value);
            }
        }

        public override string ToString()
        {
            return Value.ToString() + " GP";
        }

        public List<string> GMDocumentStrings()
        {
            var list = new List<string>
            {
                "Currency Total Value : " + ToString(),
                string.Empty,
                "Gold Bar - 10 lb     : " + TenLbGoldBar,
                "Gold Bar - 5 lb      : " + FiveLbGoldBar,
                "Gold Bar - 2 lb      : " + TwoLbGoldBar,
                "Gold Bar - 1 lb      : " + OneLbGoldBar,
                string.Empty,
                "Silver Bar - 10 lb   : " + TenLbSilverBar,
                "Silver Bar - 5 lb    : " + FiveLbSilverBar,
                "Silver Bar - 2 lb    : " + TwoLbSilverBar,
                "Silver Bar - 1 lb    : " + OneLbSilverBar,
                string.Empty,
                "Platinum Coins       : " + PlatinumCoins,
                "Gold Coins           : " + GoldCoins,
                "Electrum Coins       : " + ElectrumCoins,
                "Silver Coins         : " + SilverCoins,
                "Copper Coins         : " + CopperCoins
            };

            if (Gems.Count > 0)
            {
                list.Add(string.Empty);
                list.Add("----- Gems -----");
                list.Add(string.Empty);
                foreach (var gem in Gems)
                {
                    list.AddRange(gem.GMDocumentStrings());
                    list.Add(string.Empty);
                }
            }

            return list;
        }

        public List<string> DocumentStrings()
        {
            var list = new List<string>
            {
                "Currency Total Value : " + ToString(),
                string.Empty,
                "Gold Bar - 10 lb     : " + TenLbGoldBar,
                "Gold Bar - 5 lb      : " + FiveLbGoldBar,
                "Gold Bar - 2 lb      : " + TwoLbGoldBar,
                "Gold Bar - 1 lb      : " + OneLbGoldBar,
                string.Empty,
                "Silver Bar - 10 lb   : " + TenLbSilverBar,
                "Silver Bar - 5 lb    : " + FiveLbSilverBar,
                "Silver Bar - 2 lb    : " + TwoLbSilverBar,
                "Silver Bar - 1 lb    : " + OneLbSilverBar,
                string.Empty,
                "Platinum Coins       : " + PlatinumCoins,
                "Gold Coins           : " + GoldCoins,
                "Electrum Coins       : " + ElectrumCoins,
                "Silver Coins         : " + SilverCoins,
                "Copper Coins         : " + CopperCoins
            };

            if (Gems.Count > 0)
            {
                list.Add(string.Empty);
                list.Add("----- Gems -----");
                list.Add(string.Empty);
                foreach (var gem in Gems)
                {
                    list.AddRange(gem.PlayerDocumentStrings());
                }
            }

            return list;
        }

        public void Merge(Currency addition)
        {
            TenLbGoldBar += addition.TenLbGoldBar;
            FiveLbGoldBar += addition.FiveLbGoldBar;
            TwoLbGoldBar += addition.TwoLbGoldBar;
            OneLbGoldBar += addition.OneLbGoldBar;

            TenLbSilverBar += addition.TenLbSilverBar;
            FiveLbSilverBar += addition.FiveLbSilverBar;
            TwoLbSilverBar += addition.TwoLbSilverBar;
            OneLbSilverBar += addition.OneLbSilverBar;

            PlatinumCoins += addition.PlatinumCoins;
            GoldCoins += addition.GoldCoins;
            ElectrumCoins += addition.ElectrumCoins;
            SilverCoins += addition.SilverCoins;
            CopperCoins += addition.CopperCoins;

            Gems.AddRange(addition.Gems);
        }
    }
}