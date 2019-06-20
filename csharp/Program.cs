using csharp.Items;
using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] itemNames = new string[]
            {
                "+5 Dexterity Vest",
                "Aged Brie",
                "Elixir of the Mongoose",
                "Sulfuras, Hand of Ragnaros",
                "Backstage passes to a TAFKAL80ETC concert",
                "Conjured Mana Cake"
            };

            Console.WriteLine("OMGHAI!");
            List<GildedRoseItem> gildedRoseItems = new List<GildedRoseItem>();
            ItemsCreator ic = new ItemsCreator(itemNames, 1000);
            List<Item> Items = ic.Create(100000);
            //IList<Item> Items = new List<Item>{
            //    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            //    new Item {Name = "Aged Brie", SellIn = 2  , Quality = 0},
            //    new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            //    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            //    new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            //    new Item
            //    {
            //        Name = "Backstage passes to a TAFKAL80ETC concert",
            //        SellIn = 15,
            //        Quality = 20
            //    },
            //    new Item
            //    {
            //        Name = "Backstage passes to a TAFKAL80ETC concert",
            //        SellIn = 10,
            //        Quality = 49
            //    },
            //    new Item
            //    {
            //        Name = "Backstage passes to a TAFKAL80ETC concert",
            //        SellIn = 5,
            //        Quality = 49
            //    },
            //    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            //};

            for (var i = 0; i < Items.Count; i++)
            {
                gildedRoseItems.Add(ItemFactory.GetItem(Items[i]));
            }

            var app = new GildedRose(gildedRoseItems);

            for (var i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                for (var j = 0; j < Items.Count; j++)
                {
                    System.Console.WriteLine(Items[j]);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }

            //Analizer a = new Analizer(gildedRoseItems);
            //a.Analize();
        }
    }
}
