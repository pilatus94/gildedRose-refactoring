using GildedRoseShop.Items;
using NUnit.Framework;

namespace GildedRoseShop.Tests {
    public class QualityIncreasingItemTest : ItemTest<QualityIncreasingItem> {
        [Test]
        [TestCase(10, 0, 9, 1)]
        [TestCase(-1, 0, -2, 2)]
        [TestCase(-1, 49, -2, 50)]
        public override void Item_Update_SellInAndQualityUpdatesCorrectly(int sellIn, int quality, int expectedSellIn,
            int expectedQuality) {
            base.Item_Update_SellInAndQualityUpdatesCorrectly(sellIn, quality, expectedSellIn, expectedQuality);
        }
    }
}