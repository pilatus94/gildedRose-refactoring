using System;
using GildedRoseShop.Items;
using NUnit.Framework;

namespace GildedRoseShop.Tests {
    public abstract class ItemTest<T> where T : IItem {
        public virtual void Item_Update_SellInAndQualityUpdatesCorrectly(int sellIn, int quality, int expectedSellIn,
            int expectedQuality) {
            var item = Activator.CreateInstance<T>();
            item.SellIn  = sellIn;
            item.Quality = quality;

            item.Update();

            Assert.AreEqual(expectedSellIn, item.SellIn);
            Assert.AreEqual(expectedQuality, item.Quality);
        }
    }
}