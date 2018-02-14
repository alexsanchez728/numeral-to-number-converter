using NumberToNumeralConverter.App;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToNumealTests.cs
{
    public class Class1
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
            [Test]
            public void Numeral_V_converts_to_number_5()
            {
                var numeral = "V";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(5, result);
            }
            [Test]
            public void Numeral_IX_converts_to_number_9()
            {
                var numeral = "IX";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(9, result);
            }
            [Test]
            public void Numeral_XII_converts_to_number_12()
            {
                var numeral = "XII";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(12, result);
            }
            [Test]
            public void Numeral_XVI_converts_to_number_16()
            {
                var numeral = "XVI";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(16, result);
            }
            [Test]
            public void Numeral_XXIX_converts_to_number_29()
            {
                var numeral = "XXIX";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(29, result);
            }
            [Test]
            public void Numeral_XLIV_converts_to_number_44()
            {
                var numeral = "XLIV";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(44, result);
            }
            [Test]
            public void Numeral_XLV_converts_to_number_45()
            {
                var numeral = "XLV";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(45, result);
            }
            [Test]
            public void Numeral_LXVIII_converts_to_number_29()
            {
                var numeral = "LXVIII";
                var numeralParser = new NumeralConverter();

                var result = numeralParser.Numberizer(numeral);

                Assert.AreEqual(68, result);
            }
        }
    }
}
