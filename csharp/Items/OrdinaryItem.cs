namespace csharp.Items
{
    public class OrdinaryItem : GildedRoseItem
    {
        public OrdinaryItem(Item item) : base(item)
        {
            _quantity = 1;
        }
    }
}
