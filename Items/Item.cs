namespace GildedRoseShop.Items {
    public abstract class Item : IItem {
        protected const int MinQuality = 0;
        protected const int MaxQuality = 50;

        public string Name    { get; set; }
        public int    SellIn  { get; set; }
        public int    Quality { get; set; }

        public virtual void Update() {
        }

        public void UpdateSellIn() {
            SellIn -= 1;
        }

        public void ClampQuality() {
            Quality = Quality.Clamp(MinQuality, MaxQuality);
        }
    }
}