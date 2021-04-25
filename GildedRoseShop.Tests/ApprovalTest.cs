using System.Text;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace GildedRoseShop.Tests {
    [UseReporter(typeof(RiderReporter))]
    [TestFixture]
    public class ApprovalTest {
        [Test]
        public void ThirtyDays() {
            var testOutput = new StringBuilder();
            var program    = new Program();

            for (var i = 0; i < 30; i++) {
                program.UpdateDay(i);
                var shopOutput = program.GetShopItemsOutput();
                testOutput.Append(shopOutput);
            }

            Approvals.Verify(testOutput);
        }
    }
}