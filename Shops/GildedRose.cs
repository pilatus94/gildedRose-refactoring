using System.Collections.Generic;
using GildedRoseShop.Items;

namespace GildedRoseShop.Shops {
    public class GildedRose : IShop {
        public GildedRose(List<IItem> items) {
            Items = items;
        }

        public List<IItem> Items { get; }

        public void OnDayPassed() {
            Items.ForEach(i => i.Update());
        }
    }
}