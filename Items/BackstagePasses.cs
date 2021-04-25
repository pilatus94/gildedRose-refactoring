namespace GildedRoseShop.Items {
    public class BackstagePasses : Item {
        public BackstagePasses() {
            Name = "Backstage passes to a TAFKAL80ETC concert";
        }

        public override void Update() {
            switch (SellIn) {
                case int si when si > 0 && si <= 5:
                    Quality += 3;
                    break;
                case int si when si > 5 && si <= 10:
                    Quality += 2;
                    break;
                case int si when si > 10:
                    Quality += 1;
                    break;
                default:
                    Quality = MinQuality;
                    break;
            }

            UpdateSellIn();
            ClampQuality();
        }
    }
}