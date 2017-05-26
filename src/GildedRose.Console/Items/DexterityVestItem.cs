namespace GildedRose.Console.Items
{
    public class DexterityVestItem : Item
    {
        public override void UpdateQuality()
        {
            SellIn--;

            Quality--;
        }
    }
}