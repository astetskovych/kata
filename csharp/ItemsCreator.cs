using System;
using System.Collections.Generic;

namespace csharp
{
    class ItemsCreator
    {
        private readonly string[] _itemNames;
        private readonly int _maxSellIn;
        private Random r;

        public ItemsCreator(string[] itemNames, int maxSellIn)
        {
            _itemNames = itemNames;
            _maxSellIn = maxSellIn;
            r = new Random();
        }

        public List<Item> Create(int count)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < count; i++)
            {
                items.Add(CreateItem());
            }
            return items;
        }

        private Item CreateItem()
        {
            return new Item
            {
                Name = _itemNames[r.Next(_itemNames.Length)],
                Quality = r.Next(0, 50),
                SellIn = r.Next(0, _maxSellIn)
            };
        }
    }
}
