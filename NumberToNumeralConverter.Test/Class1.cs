using NumberToNumeralConverter.App;
using NUnit.Framework;

namespace NumberToNumeralConverter.Test
{
    [TestFixture]
    public class NumeralConverterTests
    {
        [Test]
        public void Numeral_I_converts_to_number_1()
        {
            var numeral = "I";
            var numeralParser = new NumeralConverter();

            var result = numeralParser.Numberizer(numeral);

            Assert.AreEqual(1, result);
        }
    }
}
