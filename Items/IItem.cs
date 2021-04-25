namespace GildedRoseShop.Items {
    public interface IItem {
        string Name    { get; set; }
        int    SellIn  { get; set; }
        int    Quality { get; set; }
        void Update();
        void UpdateSellIn();
        void ClampQuality();
    }
}