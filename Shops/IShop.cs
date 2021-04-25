using System.Collections.Generic;
using GildedRoseShop.Items;

namespace GildedRoseShop.Shops {
    public interface IShop {
        List<IItem> Items { get; }
        void OnDayPassed();
    }
}