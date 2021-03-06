﻿using System;
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

            Assert.AreEqual("Twenty one", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_29()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(29);

            Assert.AreEqual("Twenty nine", numberInText);
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

            Assert.AreEqual("Thirty one", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_99()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99);

            Assert.AreEqual("Ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_100()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(100);

            Assert.AreEqual("One hundred", numberInText);
        }

        [TestMethod]
        public void NumberToText_101()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(101);

            Assert.AreEqual("One hundred one", numberInText);
        }

        [TestMethod]
        public void NumberToText_999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(999);

            Assert.AreEqual("Nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_1000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1000);

            Assert.AreEqual("One thousand", numberInText);
        }

        [TestMethod]
        public void NumberToText_1001()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1001);

            Assert.AreEqual("One thousand one", numberInText);
        }

        [TestMethod]
        public void NumberToText_9999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(9999);

            Assert.AreEqual("Nine thousand nine hundred ninety nine", numberInText);
        }


        [TestMethod]
        public void NumberToText_10000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10000);

            Assert.AreEqual("Ten thousand", numberInText);
        }

        [TestMethod]
        public void NumberToText_10001()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10001);

            Assert.AreEqual("Ten thousand one", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999);

            Assert.AreEqual("Ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_2523()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(2523);

            Assert.AreEqual("Two thousand five hundred twenty three", numberInText);
        }

        [TestMethod]
        public void NumberToText_100000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(100000);

            Assert.AreEqual("One lakh", numberInText);
        }

        [TestMethod]
        public void NumberToText_100001()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(100001);

            Assert.AreEqual("One lakh one", numberInText);
        }

        [TestMethod]
        public void NumberToText_990000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(990000);

            Assert.AreEqual("Nine lakhs ninety thousand", numberInText);
        }

        [TestMethod]
        public void NumberToText_999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(999999);

            Assert.AreEqual("Nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_1000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1000000);

            Assert.AreEqual("One million", numberInText);
        }

        [TestMethod]
        public void NumberToText_1000001()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1000001);

            Assert.AreEqual("One million one", numberInText);
        }

        [TestMethod]
        public void NumberToText_9900000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(9900000);

            Assert.AreEqual("Nine million nine lakhs", numberInText);
        }

        [TestMethod]
        public void NumberToText_DoubleDigit_9999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(9999999);

            Assert.AreEqual("Nine million nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }


        [TestMethod]
        public void NumberToText_10000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10000000);

            Assert.AreEqual("One crore", numberInText);
        }

        [TestMethod]
        public void NumberToText_10000001()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10000001);

            Assert.AreEqual("One crore one", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999);

            Assert.AreEqual("Nine crore ninety nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_100000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(100000000);

            Assert.AreEqual("Ten crore", numberInText);
        }

        [TestMethod]
        public void NumberToText_999999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(999999999);

            Assert.AreEqual("Ninety nine crore ninety nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }


        [TestMethod]
        public void NumberToText_1000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1000000000);

            Assert.AreEqual("One billion", numberInText);
        }

        [TestMethod]
        public void NumberToText_10000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10000000000);

            Assert.AreEqual("Ten billion", numberInText);
        }

        [TestMethod]
        public void NumberToText_99000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99000000000);

            Assert.AreEqual("Ninety nine billion", numberInText);
        }

        [TestMethod]
        public void NumberToText_99900000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99900000000);

            Assert.AreEqual("Ninety nine billion ninety crore", numberInText);
        }

        [TestMethod]
        public void NumberToText_99990000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99990000000);

            Assert.AreEqual("Ninety nine billion ninety nine crore", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999000000);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety lakhs", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999900000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999900000);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999990000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999990000);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs ninety thousand", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999000);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999900()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999900);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999990()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999990);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred ninety", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999919()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999919);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred nineteen", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999999);

            Assert.AreEqual("Ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_999999999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(999999999999);

            Assert.AreEqual("Nine hundred ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_1000000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1000000000000);

            Assert.AreEqual("One trillion", numberInText);
        }

        [TestMethod]
        public void NumberToText_9999999999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(9999999999999);

            Assert.AreEqual("Nine trillion nine hundred ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_10000000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(10000000000000);

            Assert.AreEqual("Ten trillion", numberInText);
        }

        [TestMethod]
        public void NumberToText_99999999999999()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(99999999999999);

            Assert.AreEqual("Ninety nine trillion nine hundred ninety nine billion ninety nine crore ninety nine lakhs ninety nine thousand nine hundred ninety nine", numberInText);
        }

        [TestMethod]
        public void NumberToText_100000000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(100000000000000);

            Assert.AreEqual("One hundred trillion", numberInText);
        }

        [TestMethod]
        public void NumberToText_1000000000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1000000000000000);

            Assert.AreEqual("One thousand trillion", numberInText);
        }
        
        [TestMethod]
        public void NumberToText_Minus_1000000000000000()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(-1000000000000000);

            Assert.AreEqual("Minus one thousand trillion", numberInText);
        }

        [TestMethod]
        public void NumberToText_Minus_10point26()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.CurrencyInWord(-10.26M);

            Assert.AreEqual("Minus ten rupees and twenty six paisa", numberInText);
        }

        [TestMethod]
        public void NumberToText_Minus_10()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.CurrencyInWord(-10M);

            Assert.AreEqual("Minus ten rupees", numberInText);
        }

        [TestMethod]
        public void NumberToText_Minus_Zero()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.CurrencyInWord(-0M);

            Assert.AreEqual("Zero", numberInText);
        }

        [TestMethod]
        public void NumberToText_Plus_Zero()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.CurrencyInWord(0M);

            Assert.AreEqual("Zero", numberInText);
        }

        [TestMethod]
        public void NumberToText_CurrencyType_Dollar_100()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.CurrencyInWord(100M, CurrencyType.Dollar);

            Assert.AreEqual("One hundred dollar", numberInText);
        }
    }
}
