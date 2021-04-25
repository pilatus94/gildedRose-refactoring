using GildedRoseShop.Items;
using NUnit.Framework;

namespace GildedRoseShop.Tests {
    public class ConjuredItemTest : ItemTest<ConjuredItem> {
        [Test]
        [TestCase(10, 20, 9, 18)]
        [TestCase(-1, 20, -2, 16)]
        [TestCase(-1, 1, -2, 0)]
        public override void Item_Update_SellInAndQualityUpdatesCorrectly(int sellIn, int quality, int expectedSellIn,
            int expectedQuality) {
            base.Item_Update_SellInAndQualityUpdatesCorrectly(sellIn, quality, expectedSellIn, expectedQuality);
        }
    }
}