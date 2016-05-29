using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTextConverters;

namespace NumberToTextConversionTests
{
    [TestClass]
    public class NumberToTextTest
    {
        [TestMethod]
        public void NumberToText_SingleDigit_Zero()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(0);

            Assert.AreEqual("Zero", numberInText);
        }

        [TestMethod]
        public void NumberToText_SingleDigit_One()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1);

            Assert.AreEqual("One", numberInText);
        }

        [TestMethod]
        public void NumberToText_SingleDigit_Nine()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(9);

            Assert.AreEqual("Nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_10()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10);

            Assert.AreEqual("Ten", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_11()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(11);

            Assert.AreEqual("Eleven", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_20()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(20);

            Assert.AreEqual("Twenty", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_21()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(21);

            Assert.AreEqual("Twenty One", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_29()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(29);

            Assert.AreEqual("Twenty Nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_30()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(30);

            Assert.AreEqual("Thirty", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_31()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(31);

            Assert.AreEqual("Thirty One", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_99()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99);

            Assert.AreEqual("Ninety Nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_100()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(100);

            Assert.AreEqual("One Hundred", numberInText);
        }
    }
}
