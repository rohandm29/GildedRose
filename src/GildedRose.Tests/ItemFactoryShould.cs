using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;
using GildedRose.Console.Items;
using Xunit;

namespace GildedRose.Tests
{
    public class ItemFactoryShould
    {
        [Fact]
        public void Return_dexterity_vest_item()
        {
            // arrange
            var itemFactory = new ItemFactory();

            // act
            var dexterityItem = itemFactory.Create("Dexterity vest", 10, 20);

            // assert
            Assert.IsType<DexterityVestItem>(dexterityItem);
        }
    }

    public class ItemFactory
    {
        public Item Create(string itemName, int itemSellIn, int itemQuality)
        {
            switch (itemName.ToLower())
            {
                case "dexterity vest": return new DexterityVestItem();

                default: return new Item();
            }
        }
    }
}


