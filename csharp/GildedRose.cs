using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        IList<GildedRoseItem> gildedRoseItems;
        public GildedRose(IList<GildedRoseItem> Items)
        {
            gildedRoseItems = Items;
        }

        public void UpdateQuality()
        {

            for (var i = 0; i < gildedRoseItems.Count; i++)
            {
                gildedRoseItems[i].UpdateQuality();
              
            }
        }
    }

    public abstract class GildedRoseItem
    {
        protected int quantity;
        protected Item item {get; set;}
        public GildedRoseItem(Item item)
        {
            this.item = item;
        }
        public virtual void UpdateQuality()
        {
            item.SellIn--;

            if (item.SellIn >= 0)
            {
                item.Quality -= quantity;
            }
            else
            {
                item.Quality -= 2 * quantity;
            }

            if (item.Quality < 0)
            {
                item.Quality = 0;
            }
            if (item.Quality > 50)
            {
                item.Quality = 50;
            }
        }
    }

    public class OrdinaryItem: GildedRoseItem
    {
        public OrdinaryItem(Item item) : base(item)
        {
            quantity = 1;
        }
        public override void UpdateQuality()
        {
            base.UpdateQuality();
        }
    }
    public class SulfurasHandofRagnaros: GildedRoseItem
    {
        public SulfurasHandofRagnaros(Item item) : base(item) { }
        public override void UpdateQuality()
        {
            return;
        }
    }
    public class AgedBrie: GildedRoseItem
    {
        public AgedBrie(Item item) : base(item)
        {
            quantity = -1;
        }
        public override void UpdateQuality()
        {
            base.UpdateQuality();
        }
    }

    public class BackstagepassestoaTAFKAL80ETCconcert: GildedRoseItem
    {
        public BackstagepassestoaTAFKAL80ETCconcert(Item item) : base(item)
        {
            quantity = -1;
        }
    
        public override void UpdateQuality()
        {
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
                item.SellIn--;
                return;
            }

            if (item.SellIn <= 10)
            {
                quantity = -2;
            }
            if (item.SellIn <= 5)
            {
                quantity = -3;
            }
            base.UpdateQuality();
        }
    }
    public class ConjuredManaCake: GildedRoseItem
    {
        public ConjuredManaCake(Item item) : base(item)
        {
            quantity = 2;
        }
        public override void UpdateQuality()
        {
            base.UpdateQuality();
        }
    }

    public class ItemFactory
    {
        public static GildedRoseItem GetItem(Item item)
        {
            switch (item.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasHandofRagnaros(item);
                case "Aged Brie":
                    return new AgedBrie(item);
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackstagepassestoaTAFKAL80ETCconcert(item);
                case "Conjured Mana Cake":
                    return new ConjuredManaCake(item);
                default:
                    return new OrdinaryItem(item);
            }
        }
    } 
}
