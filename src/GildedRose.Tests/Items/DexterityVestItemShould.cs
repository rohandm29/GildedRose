using GildedRose.Console;
using GildedRose.Console.Items;
using Xunit;

namespace GildedRose.Tests.Items
{
    public class DexterityVestItemShould
    {
        [Fact]
        public void Reduce_The_Sell_In_When_Updating_Quality()
        {
            // Arrange
            var dexterityVest = new DexterityVestItem()
            {
                SellIn = 10,
                Quality = 4
            };

            // Act
            dexterityVest.UpdateQuality();

            //  Assert
            Assert.Equal(dexterityVest.SellIn,9);
        }

        [Fact]
        public void Reduce_The_Update_In_When_Updating_Quality()
        {
            // Arrange
            var dexterityVest = new DexterityVestItem()
            {
                SellIn = 10,
                Quality = 4
            };

            // Act
            dexterityVest.UpdateQuality();

            //  Assert
            Assert.Equal(dexterityVest.Quality, 3);
        }
    }
}