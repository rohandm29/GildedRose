using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using FluentAssertions;
using GildedRose.Console;
using GildedRose.Console.Items;
using Xunit;
using Xunit.Sdk;

namespace GildedRose.Tests
{
    public class ItemsProcessorShould
    {
        [Theory]
        [InlineData("+5 Dexterity Vest", 10, 9, 20, 19)]
        [InlineData("Aged Brie", 2, 1, 0, 1)]
        [InlineData("Elixir of the Mongoose", 5, 4, 7, 6)]
        [InlineData("Sulfuras, Hand of Ragnaros", 0, 0, 80, 80)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert", 15, 14, 20, 21)]
        [InlineData("Conjured Mana Cake", 3, 2, 6, 5)]
        public void Ensure_Backwards_Compatability_For_The_Items(string itemName, int sellInInput, int sellInExpected, int qualityInput, int qualityExpected)
        {
            //Arrange
            var expected = new Item() {Name = itemName, SellIn = sellInExpected, Quality = qualityExpected};

            var input = new List<Item>
            {
                new Item {Name = itemName, SellIn = sellInInput, Quality = qualityInput}
            };

            //Act
            var sut = new ItemsProcessor(input);

            sut.UpdateQuality();

            //Assert
            sut.Items.Single().ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void Support_Dexterity_Vest_Items()
        {
            //Arrange
            var expected = new DexterityVestItem() { SellIn = 9, Quality = 19 };

            var input = new List<Item>
            {
                new DexterityVestItem() { SellIn = 10, Quality = 20 }
            };

            //Act
            var sut = new ItemsProcessor(input);

            sut.UpdateQuality();

            //Assert
            sut.Items.Single().ShouldBeEquivalentTo(expected);
        }

        [Fact]
        public void Support_AgedBrie_Items()
        {
            //Arrange
            var expected = new AgedBrieItem() { SellIn = 1, Quality = 1 };

            var input = new List<Item>
            {
                new AgedBrieItem() { SellIn = 2, Quality = 0 }
            };

            //Act
            var sut = new ItemsProcessor(input);

            sut.UpdateQuality();

            //Assert
            sut.Items.Single().ShouldBeEquivalentTo(expected);
        }
    }
}
