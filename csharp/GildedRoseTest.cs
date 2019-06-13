using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "fixme", SellIn = 0, Quality = 0 } };
            IList<GildedRoseItem> gt = new List<GildedRoseItem> { ItemFactory.GetItem(Items[0]) };
            GildedRose app = new GildedRose(gt);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
