using FluentAssertions;
using Gemstone.Classes.DTO;
using Gemstone.Classes.Logic;
using Gemstone.Classes.Saving;
using Gemstone.Classes.Functional;
using Gemstone.Definitions.Enums;
using Xunit;
using System.Collections.Generic;
using FluentAssertions.Execution;
using System;
using System.Linq;

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

        [Fact]
        public void Test3()
        {
            var damage = new DamageDice(new Die(1, 1), DamageType.Bludgeoning, false);

            var result = damage.RollDamage();

            result.Total.Should().Be(1);
        }

        [Fact]
        public void Test4()
        {
            var die = new Die(200, 6);

            var result = die.Roll();

            result.Should().BeGreaterOrEqualTo(200).And.BeLessOrEqualTo(1200);
        }

        [Fact]
        public void Test5()
        {
            var die = new Die(1, 12);

            var result = new List<int>();

            for(int x = 0; x < 200; x++)
            {
                result.Add(die.Roll());
            }

            result.Sort();

            using (new AssertionScope())
            {
                result[0].Should().Be(1);
                result[199].Should().Be(12);
            }
        }

        [Fact]
        public void Test6()
        {
            var test = new List<Gem>();

            for (int x = 0; x < 500; x++)
            {
                test.Add(new Gem());
            }

            var av = test.Average(x => x.Value);

            test.Sort((gem1, gem2)=>gem1.Value.CompareTo(gem2.Value));
            var mode = test[250];

        }
    }
}
