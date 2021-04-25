using System.Collections.Generic;

namespace GildedRoseShop.Items {
    public interface IShopItemBuilder {
        List<IItem> Create();
    }
}