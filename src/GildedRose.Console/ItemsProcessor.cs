using System.Collections.Generic;

namespace GildedRose.Console
{
    public class ItemsProcessor
    {
        public List<Item> Items { get; }

        public ItemsProcessor(List<Item> items)
        {
            Items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.UpdateQuality();
            }

        }
    }
}