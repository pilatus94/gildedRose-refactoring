using NUnit.Framework;

namespace GildedRoseShop.Tests {
    public class ExtensionsTest {
        [Test]
        [TestCase(0, 0, 5, 0)]       
        [TestCase(-1, 0, 5, 0)]
        [TestCase(5, 0, 5, 5)]
        [TestCase(6, 0, 5, 5)]
        public void Clamp_CorrectlyClampProvidedValues(int currentValue, int minValue, int maxValue,
            int expectedValue) {
            var result = currentValue.Clamp(minValue, maxValue);
            Assert.AreEqual(result, expectedValue);
        }
    }
}