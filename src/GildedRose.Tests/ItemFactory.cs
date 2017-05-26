using GildedRose.Console;
using GildedRose.Console.Items;

namespace GildedRose.Tests
{
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