using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp
{
   public  class Analizer
    {
        private readonly IList<GildedRoseItem> _items;
        private DateTime _startTime;

        public Analizer(IList<GildedRoseItem> items )
        {
            _items = items;
        }

        public void Analize()
        {
            var app = new GildedRose(_items);
            _startTime = DateTime.Now;
            app.Update();
            Console.WriteLine("Single");
            Console.WriteLine(DateTime.Now.Subtract(_startTime));
            Console.ReadKey();
            _startTime = DateTime.Now;
            app.UpdateParallel();
            Console.WriteLine("Parallel");
            Console.WriteLine(DateTime.Now.Subtract(_startTime));
            Console.ReadKey();
        }
    }
}
