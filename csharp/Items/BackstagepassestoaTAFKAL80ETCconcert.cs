namespace csharp.Items
{
    public class BackstagepassestoaTAFKAL80ETCconcert : GildedRoseItem
    {
        public BackstagepassestoaTAFKAL80ETCconcert(Item item) : base(item)
        {
            _quantity = -1;
        }

        public override void UpdateQuality()
        {
            if (_item.SellIn <= 0)
            {
                _item.Quality = 0;
                _item.SellIn--;
                return;
            }

            if (_item.SellIn <= 5)
            {
                _quantity = -3;
            }
            else if (_item.SellIn <= 10 && _item.SellIn > 5)
            {
                _quantity = -2;
            }          
            base.UpdateQuality();
        }
    }
}
