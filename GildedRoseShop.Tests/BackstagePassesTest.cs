using GildedRoseShop.Items;
using NUnit.Framework;

namespace GildedRoseShop.Tests {
    public class BackstagePassesTest : ItemTest<BackstagePasses> {
        [Test]
        [TestCase(1, 5, 0, 8)]
        [TestCase(2, 5, 1, 8)]
        [TestCase(5, 5, 4, 8)]
        [TestCase(6, 5, 5, 7)]
        [TestCase(10, 5, 9, 7)]
        [TestCase(11, 5, 10, 6)]
        [TestCase(0, 5, -1, 0)]
        public override void Item_Update_SellInAndQualityUpdatesCorrectly(int sellIn, int quality, int expectedSellIn,
            int expectedQuality) {
            base.Item_Update_SellInAndQualityUpdatesCorrectly(sellIn, quality, expectedSellIn, expectedQuality);
        }
    }
}