namespace GildedRose.Console.Items
{
    public class AgedBrieItem : Item
    {
        public override void UpdateQuality()
        {
            SellIn--;

            Quality ++;
        }
    }
}