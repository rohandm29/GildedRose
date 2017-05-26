using GildedRose.Console.Items;
using Xunit;

namespace GildedRose.Tests.Items
{
    public class AgedBrieItemShould
    {
        [Fact]
        public void Reduce_The_Sell_In_When_Updating_Qualilty()
        {
            // Arrange
            var agedBrieItem = new AgedBrieItem()
            {
                SellIn = 2,
                Quality = 0
            };

            // Act
            agedBrieItem.UpdateQuality();

            // Assert
            Assert.Equal(1,agedBrieItem.SellIn);
        }

        [Fact]
        public void Reduce_the_quality_when_updating_quality()
        {
            // arrange
            var agedBrieItem = new AgedBrieItem()
            {
                SellIn = 2,
                Quality = 0
            };

            // act
            agedBrieItem.UpdateQuality();

            // assert
            Assert.Equal(1, agedBrieItem.Quality);
        }
    }
}