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
                return GenerateForValue(4.52 * ValueGenerator.GetCommonRandomVariable());
            if (level < 11)
                return GenerateForValue(92.5 * ValueGenerator.GetCommonRandomVariable());
            if (level < 17)
                return GenerateForValue(946.75 * ValueGenerator.GetCommonRandomVariable());

            return GenerateForValue(8470 * ValueGenerator.GetCommonRandomVariable());
        }

        public static Currency GenerateForValue(double value)
        {
            if (value < 0.0)
                throw new InvalidOperationException("Error Generating Currency: Value cannot be less than zero");

            value = Math.Round(value, 2);

            var currency = new Currency();

            if (rng.NextDouble() < 0.2)
                (value, currency.TenLbGoldBar) = GetRandomQuantity(value, Currency.TenLbGoldBarValue);
            if (rng.NextDouble() < 0.3)
                (value, currency.FiveLbGoldBar) = GetRandomQuantity(value, Currency.FiveLbGoldBarValue);
            if (rng.NextDouble() < 0.4)
                (value, currency.TwoLbGoldBar) = GetRandomQuantity(value, Currency.TwoLbGoldBarValue);
            if (rng.NextDouble() < 0.5)
                (value, currency.OneLbGoldBar) = GetRandomQuantity(value, Currency.OneLbGoldBarValue);

            if (rng.NextDouble() < 0.2)
                (value, currency.TenLbSilverBar) = GetRandomQuantity(value, Currency.TenLbSilverBarValue);
            if (rng.NextDouble() < 0.3)
                (value, currency.FiveLbSilverBar) = GetRandomQuantity(value, Currency.FiveLbSilverBarValue);
            if (rng.NextDouble() < 0.4)
                (value, currency.TwoLbSilverBar) = GetRandomQuantity(value, Currency.TwoLbSilverBarValue);
            if (rng.NextDouble() < 0.5)
                (value, currency.OneLbSilverBar) = GetRandomQuantity(value, Currency.OneLbSilverBarValue);

            (value, currency.PlatinumCoins) = GetRandomQuantity(value, Currency.PlatinumCoinValue);
            (value, currency.GoldCoins) = GetRandomQuantity(value, Currency.GoldCoinValue);

            if (rng.NextDouble() < 0.2)
                (value, currency.ElectrumCoins) = GetRandomQuantity(value, Currency.ElectrumCoinValue);

            (value, currency.SilverCoins) = GetRandomQuantity(value, Currency.SilverCoinValue);
            (_, currency.CopperCoins) = GetRandomQuantity(value, Currency.CopperCoinValue);

            return currency;
        }

        private static (double value, int quantity) GetRandomQuantity(double originalValue, double itemValue)
        {
            var retVal = originalValue * rng.NextDouble();
            var quantity = Math.Floor(retVal / itemValue);
            originalValue -= quantity * itemValue;

            return (originalValue, (int)quantity);
        }
    }
}
