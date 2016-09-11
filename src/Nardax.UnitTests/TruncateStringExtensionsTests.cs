using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nardax.Tests
{
    [TestClass]
    public class TruncateStringExtensionsTests
    {
        private string _value;

        [TestInitialize]
        public void TestInitialize()
        {
            _value = "123456789";
        }

        [TestMethod]
        public void TruncateLeft_ValueIsLarger_TruncateRemovesLeftSide()
        {
            var expected = "9";

            var result = _value.TruncateLeft(1);
            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateLeft_ValueIsSmaller_TruncateRemovesLeftSide()
        {
            var expected = "123456789";

            var result = _value.TruncateLeft(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsLarger_TruncateRemovesRightSide()
        {
            var expected = "1";

            var result = _value.TruncateRight(1);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TruncateRight_ValueIsSmaller_TruncateRemovesRightSide()
        {
            var expected = "123456789";

            var result = _value.TruncateRight(20);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RepeatMe()
        {
            var result = "käbbel".RepeatMe(3);
            var expected = "käbbelkäbbelkäbbel";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RepeatMe_DefaultValue()
        {
            var result = "NyanCat".RepeatMe(5);
            var expected = "NyanCatNyanCatNyanCatNyanCatNyanCat";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RemoveWhiteChar()
        {
            var testString = "i\twill \tsurvive\t";

            var result = testString.RemoveWhiteChars();
            var expected = "iwillsurvive";

            Assert.AreEqual(expected, result);
        }
    }
}
