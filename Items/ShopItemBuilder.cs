using System.Collections.Generic;

namespace GildedRoseShop.Items {
    public class ShopItemBuilder : IShopItemBuilder {
        private const string SulfurasItemName = "Sulfuras, Hand of Ragnaros";

        public List<IItem> Create() {
            return new List<IItem> {
                new RegularItem {Name           = "+5 Dexterity Vest", SellIn      = 10, Quality = 20},
                new QualityIncreasingItem {Name = "Aged Brie", SellIn              = 2, Quality  = 0},
                new RegularItem {Name           = "Elixir of the Mongoose", SellIn = 5, Quality  = 7},
                new LegendaryItem {Name         = SulfurasItemName, SellIn         = 0},
                new LegendaryItem {Name         = SulfurasItemName, SellIn         = -1},
                new BackstagePasses {SellIn     = 15, Quality                      = 20},
                new BackstagePasses {SellIn     = 10, Quality                      = 49},
                new BackstagePasses {SellIn     = 5, Quality                       = 49},
                new ConjuredItem {Name          = "Conjured Mana Cake", SellIn     = 3, Quality = 6}
            };
        }
    }
}