using FluentAssertions;
using Gemstone.Classes.DTO;
using Gemstone.Classes.Logic;
using Gemstone.Classes.Saving;
using Xunit;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double value = 0;

            for(int x = 0; x < 50000; x++)
            {
                var gem = new Gem();
                value += gem.Value;
            }

            value /= 50000;

            value.Should().BeGreaterThan(0.0);
        }

        [Fact]
        public void Test2()
        {
            var documentSaver = new DocumentSaver();
            var currency = CurrencyGenerator.GenerateForLevel(15);

            for (int x = 0; x < 25; x++)
            {
                var currency2 = CurrencyGenerator.GenerateForLevel(20);
                currency.Merge(currency2);
            }

            documentSaver.SaveCurrency("test.txt", currency);
        }
    }
}
