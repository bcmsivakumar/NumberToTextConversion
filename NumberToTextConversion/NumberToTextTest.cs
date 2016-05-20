using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberTextConvertors;

namespace NumberToTextConversionTests
{
    [TestClass]
    public class NumberToTextTest
    {
        [TestMethod]
        public void NumberToText_SingleDigit_One()
        {
            NumberTextConverter converter = new NumberTextConverter();
            string numberInText = converter.ConvertToText(1);

            Assert.AreEqual("One", numberInText);
        }
    }
}
