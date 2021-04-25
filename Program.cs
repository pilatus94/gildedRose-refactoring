using System;
using ConsoleTables;
using GildedRoseShop.Items;
using GildedRoseShop.Shops;

namespace GildedRoseShop {
    public class Program {
        private static GildedRose _shop;

        public Program() {
            var shopBuilder = new ShopItemBuilder();
            var shopItems   = shopBuilder.Create();
            _shop = new GildedRose(shopItems);
        }

        public static void Main() {
            var program = new Program();
            program.RunMonthSimulation();
        }

        private void RunMonthSimulation() {
            Console.WriteLine("OMGHAI!");

            for (var i = 0; i < 31; i++) {
                UpdateDay(i);
            }
        }

        public void UpdateDay(int day) {
            Console.WriteLine("-------- day " + day + " --------");

            Console.WriteLine(GetShopItemsOutput());
            _shop.OnDayPassed();

            Console.WriteLine("");
        }

        public string GetShopItemsOutput() {
            var table = new ConsoleTable("name", "sellIn", "quality");
            table.Configure(options => options.EnableCount = false);
            _shop.Items.ForEach(item => { table.AddRow(item.Name, item.SellIn, item.Quality); });

            return table.ToMinimalString();
        }
    }
}