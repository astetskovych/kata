namespace csharp.Items
{
    public abstract class GildedRoseItem
    {
        protected int _quantity;
        protected readonly Item _item;

        public GildedRoseItem(Item item)
        {
            _item = item;
        }
        public virtual void UpdateQuality()
        {
            _item.SellIn--;

            if (_item.SellIn >= 0)
            {
                _item.Quality -= _quantity;
            }
            else
            {
                _item.Quality -= 2 * _quantity;
            }

            CheckQualityLimits();
        }

        private void CheckQualityLimits()
        {
            if (_item.Quality < 0)
            {
                _item.Quality = 0;
            }
            if (_item.Quality > 50)
            {
                _item.Quality = 50;
            }
        }
    }
}

