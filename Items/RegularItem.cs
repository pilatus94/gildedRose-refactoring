namespace GildedRoseShop.Items {
    public class RegularItem : Item {
        public override void Update() {
            UpdateSellIn();
            Quality -= SellIn >= 0 ? 1 : 2;
            ClampQuality();
        }
    }
}