namespace GildedRoseShop.Items {
    public class ConjuredItem : Item {
        public override void Update() {
            UpdateSellIn();
            Quality -= SellIn >= 0 ? 2 : 4;
            ClampQuality();
        }
    }
}