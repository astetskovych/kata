using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
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
