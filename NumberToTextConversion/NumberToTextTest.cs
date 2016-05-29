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

    }
}
