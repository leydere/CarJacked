using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarJack;

namespace CarJackFunctions_UnitTest
{
    [TestClass]
    public class UnitTest1 : CarJackFunctions
    {

        [TestMethod]
        public void CreditValue_ReturnBad_LowerEdge()
        {
            string expected = "bad";
            Assert.AreEqual(expected, CreditValue(500));
        }
        [TestMethod]
        public void CreditValue_ReturnBad_UpperEdge()
        {
            string expected = "bad";
            Assert.AreEqual(expected, CreditValue(589));
        }
        [TestMethod]
        public void CreditValue_ReturnBelowAverage_LowerEdge()
        {
            string expected = "belowAverage";
            Assert.AreEqual(expected, CreditValue(590));
        }
        [TestMethod]
        public void CreditValue_ReturnBelowAverage_UpperEdge()
        {
            string expected = "belowAverage";
            Assert.AreEqual(expected, CreditValue(619));
        }
        [TestMethod]
        public void CreditValue_ReturnOkay_LowerEdge()
        {
            string expected = "okay";
            Assert.AreEqual(expected, CreditValue(620));
        }
        [TestMethod]
        public void CreditValue_ReturnOkay_UpperEdge()
        {
            string expected = "okay";
            Assert.AreEqual(expected, CreditValue(659));
        }
        [TestMethod]
        public void CreditValue_ReturnFair_LowerEdge()
        {
            string expected = "fair";
            Assert.AreEqual(expected, CreditValue(660));
        }
        [TestMethod]
        public void CreditValue_ReturnFair_UpperEdge()
        {
            string expected = "fair";
            Assert.AreEqual(expected, CreditValue(689));
        }
        [TestMethod]
        public void CreditValue_ReturnGood_LowerEdge()
        {
            string expected = "good";
            Assert.AreEqual(expected, CreditValue(690));
        }
        [TestMethod]
        public void CreditValue_ReturnGood_UpperEdge()
        {
            string expected = "good";
            Assert.AreEqual(expected, CreditValue(719));
        }
        [TestMethod]
        public void CreditValue_ReturnGreat()
        {
            string expected = "great";
            Assert.AreEqual(expected, CreditValue(720));
        }
        [TestMethod]
        public void CalculateInterest_ReturnThreeHunTwentyEight()
        {
            double expected = 328.1025;
            Assert.AreEqual(expected, CalculateInterest("bad", 35000));
        }
        [TestMethod]
        public void CalculateInterest_ReturnThreeHunTwenty()
        {
            double expected = 321.1185;
            Assert.AreEqual(expected, CalculateInterest("belowAverage", 35000));
        }
        [TestMethod]
        public void CalculateInterest_ReturnThreeHunNineteen()
        {
            double expected = 319.3725;
            Assert.AreEqual(expected, CalculateInterest("okay", 35000));
        }
        [TestMethod]
        public void CalculateInterest_ReturnThreeHunFift()
        {
            double expected = 315.7932;
            Assert.AreEqual(expected, CalculateInterest("fair", 35000));
        }
        [TestMethod]
        public void CalculateInterest_ReturnThreeHunThirt()
        {
            double expected = 312.4176;

            Assert.AreEqual(expected, CalculateInterest("good",35000));
        }
        [TestMethod]
        public void CalculateInterest_ReturnThreeHunNine()
        {
            double expected = 309.9732;
            Assert.AreEqual(expected, CalculateInterest("great", 35000));
        }

        [TestMethod]
        public void CheckIfFree_VehicleData1_ReturnFalse()
        {
            bool expected = false;
            Assert.AreEqual(expected, CheckIfFree(1));
        }
        [TestMethod]
        public void CheckIfFree_VehicleData2_ReturnFalse()
        {
            bool expected = false;
            Assert.AreEqual(expected, CheckIfFree(2));
        }
        [TestMethod]
        public void CheckIfFree_VehicleData3_ReturnTrue()
        {
            bool expected = true;
            Assert.AreEqual(expected, CheckIfFree(3));
        }

        // Unit tests copied from UnitTesting_MasterBranch -ERL

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
        [TestMethod]
        public void MultiplyActivityBoxes_AllBlankInputs_ReturnZero()
        {
            int expected = 0;
            Assert.AreEqual(expected, MultiplyActivityBoxes("", "", ""));
        }
        [TestMethod]
        public void MultiplyActivityBoxes_PositiveIntegerInputs_ReturnSix()
        {
            int expected = 6;
            Assert.AreEqual(expected, MultiplyActivityBoxes("1", "2", "3"));
        }
    }
}
