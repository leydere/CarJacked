﻿using CarJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditFunctions_UnitTest
{
    [TestClass]
    public class Correctness_UT : ActivityCorrectness
    {
        [TestMethod]
        public void CheckForBlankBoxes_BlankFound()
        {
            Assert.IsTrue(CheckForBlankBoxes(""));
        }
        [TestMethod]
        public void CheckForBlankBoxes_BlankNotFound()
        {
            Assert.IsFalse(CheckForBlankBoxes("_"));
        }
        [TestMethod]
        public void CheckForZeroThrough52_InRangeLow()
        {
            Assert.IsFalse(CheckForZeroThrough52("0"));
        }
        [TestMethod]
        public void CheckForZeroThrough52_InRangeHigh()
        {
            Assert.IsFalse(CheckForZeroThrough52("52"));
        }
        [TestMethod]
        public void CheckForZeroThrough52_OutsideOfRangeLow()
        {
            Assert.IsTrue(CheckForZeroThrough52("-1"));
        }
        [TestMethod]
        public void CheckForZeroThrough52_OutsideOfRangeHigh()
        {
            Assert.IsTrue(CheckForZeroThrough52("53"));
        }
        [TestMethod]
        public void CheckForUnreasonablyLargeValue_True()
        {
            Assert.IsTrue(CheckForUnreasonablyLargeValue("1000"));
        }
        [TestMethod]
        public void CheckForUnreasonablyLargeValue_False()
        {
            Assert.IsFalse(CheckForUnreasonablyLargeValue("999"));
        }
        [TestMethod]
        public void CheckForLargeValue_True()
        {
            Assert.IsTrue(CheckForLargeValue("100"));
        }
        [TestMethod]
        public void CheckForLargeValue_False()
        {
            Assert.IsFalse(CheckForLargeValue("99"));
        }
        [TestMethod]
        public void CheckForNegativeValues_NegativeValueFound()
        {
            Assert.IsTrue(CheckForNegativeValues("-1"));
        }
        [TestMethod]
        public void CheckForNegativeValues_NoNegativeValueFound()
        {
            Assert.IsFalse(CheckForNegativeValues("0"));
        }
        [TestMethod]
        public void CheckForWholeNumbers_NonWholeNumberFound()
        {
            Assert.IsTrue(CheckForWholeNumbers("1i"));
        }
        [TestMethod]
        public void CheckForWholeNumbers_WholeNumberFound()
        {
            Assert.IsFalse(CheckForWholeNumbers("1"));
        }
        [TestMethod]
        public void TrimSemiColons_ReturnWithoutSemiColons()
        {
            string expected = "Donatello Leonardo";
            Assert.AreEqual(expected, TrimSemiColons("Donatello; Leonardo;"));
        }
        [TestMethod]
        public void CheckForSemiColons_SemiColonsFound()
        {
            Assert.IsTrue(CheckForSemiColons("Donatello; Leonardo;"));
        }
        [TestMethod]
        public void CheckForSemiColons_NoSemiColonsFound()
        {
            Assert.IsFalse(CheckForSemiColons("Donatello Leonardo"));
        }
    }
}
