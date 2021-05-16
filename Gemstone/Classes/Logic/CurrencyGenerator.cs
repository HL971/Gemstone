using Gemstone.Classes.DTO;
using System;

namespace Gemstone.Classes.Logic
{
    public static class CurrencyGenerator
    {
        private static readonly Random rng = new Random();
        
        public static Currency GenerateForLevel(int level)
        {
            if (level < 5)
                return GenerateForValue(20 * ValueGenerator.GetCommonRandomVariable());
            if (level < 7)
                return GenerateForValue(50 * ValueGenerator.GetCommonRandomVariable());
            if (level < 9)
                return GenerateForValue(100 * ValueGenerator.GetCommonRandomVariable());
            if (level < 11)
                return GenerateForValue(250 * ValueGenerator.GetCommonRandomVariable());
            if (level < 13)
                return GenerateForValue(500 * ValueGenerator.GetCommonRandomVariable());
            if (level < 15)
                return GenerateForValue(1000 * ValueGenerator.GetCommonRandomVariable());
            if (level < 17)
                return GenerateForValue(2500 * ValueGenerator.GetCommonRandomVariable());
            if (level < 19)
                return GenerateForValue(5000 * ValueGenerator.GetCommonRandomVariable());

            return GenerateForValue(8500 * ValueGenerator.GetCommonRandomVariable());
        }

        public static Currency GenerateForValue(double value)
        {
            if (value < 0.0)
                throw new InvalidOperationException("Error Generating Currency: Value cannot be less than zero");

            value = Math.Round(value, 2);

            var currency = new Currency();

            if (rng.NextDouble() < 0.01)
                (value, currency.TenLbGoldBar) = GetRandomQuantity(value, Currency.TenLbGoldBarValue);
            if (rng.NextDouble() < 0.05)
                (value, currency.FiveLbGoldBar) = GetRandomQuantity(value, Currency.FiveLbGoldBarValue);
            if (rng.NextDouble() < 0.1)
                (value, currency.TwoLbGoldBar) = GetRandomQuantity(value, Currency.TwoLbGoldBarValue);
            if (rng.NextDouble() < 0.25)
                (value, currency.OneLbGoldBar) = GetRandomQuantity(value, Currency.OneLbGoldBarValue);

            if (rng.NextDouble() < 0.05)
                (value, currency.TenLbSilverBar) = GetRandomQuantity(value, Currency.TenLbSilverBarValue);
            if (rng.NextDouble() < 0.1)
                (value, currency.FiveLbSilverBar) = GetRandomQuantity(value, Currency.FiveLbSilverBarValue);
            if (rng.NextDouble() < 0.25)
                (value, currency.TwoLbSilverBar) = GetRandomQuantity(value, Currency.TwoLbSilverBarValue);
            if (rng.NextDouble() < 0.5)
                (value, currency.OneLbSilverBar) = GetRandomQuantity(value, Currency.OneLbSilverBarValue);

            if (rng.NextDouble() < 0.5)
            {
                for (int x = 0; x < 5; x++)
                {
                    var gem = new Gem();
                    if (gem.Value < value)
                    {
                        value -= gem.Value;
                        currency.Gems.Add(gem);
                    }
                }
            }

            (value, currency.PlatinumCoins) = GetRandomQuantity(value, Currency.PlatinumCoinValue);

            if (rng.NextDouble() < 0.2)
                (value, currency.ElectrumCoins) = GetRandomQuantity(value, Currency.ElectrumCoinValue);

            (value, currency.GoldCoins) = GetRandomQuantity(value, Currency.GoldCoinValue, true);
            (value, currency.SilverCoins) = GetRemainingQuantity(value, Currency.SilverCoinValue);
            (_, currency.CopperCoins) = GetRemainingQuantity(value, Currency.CopperCoinValue);

            return currency;
        }

        private static (double value, int quantity) GetRandomQuantity(double originalValue, double itemValue, bool highPercent = false)
        {
            double rand;
            do
            {
                rand = rng.NextDouble();
            }
            while ((highPercent && rand < 0.75) || (!highPercent && rand > 0.25));

            var retVal = originalValue * rand;
            var quantity = Math.Floor(retVal / itemValue);
            originalValue -= quantity * itemValue;

            return (originalValue, (int)quantity);
        }

        private static (double value, int quantity) GetRemainingQuantity(double originalValue, double itemValue)
        {
            var quantity = Math.Floor(originalValue / itemValue);
            originalValue -= quantity * itemValue;

            return (originalValue, (int)quantity);
        }
    }
}
