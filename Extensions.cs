namespace GildedRoseShop {
    public static class Extensions {
        public static int Clamp(this int value, int min, int max) {
            return value < min ? min : value > max ? max : value;
        }
    }
}