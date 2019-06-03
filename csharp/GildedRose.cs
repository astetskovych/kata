using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                switch (Items[i].Name)
                {
                    case "Sulfuras, Hand of Ragnaros":
                        break;
                    case "Aged Brie":
                        UpdateValues(Items[i], -1);
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        UpdateValues(Items[i], -1, new List<Rule> { new Rule(5, 3), new Rule(10, 2) });
                        SetValue(Items[i], new Rule(0, 0));
                        break;
                    case "Conjured Mana Cake":
                        UpdateValues(Items[i], 2);
                        break;
                    default:
                        UpdateValues(Items[i], 1);
                        break;
                }
            }
        }

        public void SetValue(Item item, Rule rule)
        {
            if (item.SellIn < rule.Limit)
            {
                item.Quality = rule.Value;
            }
        }

        public void UpdateValues(Item item, int quantity)
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

        public void UpdateValues(Item item, int quantity, List<Rule> rules)
        {
            rules.Sort(new LimitsComparer());
            foreach (var rule in rules)
            {
                if (item.SellIn <= rule.Limit)
                {
                    UpdateValues(item, rule.Value * quantity);
                    return;
                }
            }
            UpdateValues(item, quantity);
        }
    }

    class LimitsComparer : IComparer<Rule>
    {
        public int Compare(Rule x, Rule y)
        {
            if (x.Limit == 0 || y.Limit == 0)
            {
                return 0;
            } 
            return x.Limit.CompareTo(y.Limit);
        }
    }
}
