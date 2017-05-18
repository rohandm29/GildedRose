using System.Collections.Generic;
using System.Linq;
using GildedRose.Console;
using Xunit;
using Xunit.Sdk;

namespace GildedRose.Tests
{
    public class ItemsProcessor_Should
    {
        private ItemsProcessor itemsProcessor;

        public ItemsProcessor_Should()
        {
            
        }
        public void Ensure_Backwords_Compatabilty_For_The_Item_Dexterity_Vest()
        {
            // Arrange
            var expected = new Item { Name = "+5 Dexterity Vest", SellIn = 9, Quality = 21 };
            var input = new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20};
            this.itemsProcessor = new ItemsProcessor(new List<Item>()
            {
                 input
            });

            // Act
            this.itemsProcessor.UpdateQuality();

            var actual = itemsProcessor.Items.First();

            // Assert
            actual.ShouldBeEquivalentTo(expected);
        }
    }
}