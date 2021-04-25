namespace GildedRoseShop.Items {
    public class QualityIncreasingItem : Item {
        public override void Update() {
            UpdateSellIn();
            Quality += SellIn >= 0 ? 1 : 2;
            ClampQuality();
        }
    }
}