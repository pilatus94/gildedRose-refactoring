using GildedRoseShop.Items;
using NUnit.Framework;

namespace GildedRoseShop.Tests {
    public class LegendaryItemTest : ItemTest<LegendaryItem> {
        [Test]
        [TestCase(10, 80, 10, 80)]
        public override void Item_Update_SellInAndQualityUpdatesCorrectly(int sellIn, int quality, int expectedSellIn,
            int expectedQuality) {
            base.Item_Update_SellInAndQualityUpdatesCorrectly(sellIn, quality, expectedSellIn, expectedQuality);
        }
    }
}