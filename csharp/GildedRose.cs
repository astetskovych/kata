using csharp.Items;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace csharp
{
    public class GildedRose
    {
        private IList<GildedRoseItem> _gildedRoseItems;

        public GildedRose(IList<GildedRoseItem> items)
        {
            _gildedRoseItems = items;
        }

        public void UpdateQuality()
        {
            if (_gildedRoseItems.Count < 300000)
            {
                Update();
            }
            else
            {
                UpdateParallel();
            }      
        }

        public void Update()
        {
            for (var i = 0; i < _gildedRoseItems.Count; i++)
            {
                _gildedRoseItems[i].UpdateQuality();
            }
        }

        public void UpdateParallel()
        {
            Parallel.ForEach(_gildedRoseItems, (item) =>
            {
                item.UpdateQuality();
            });
        }
    }  
}
