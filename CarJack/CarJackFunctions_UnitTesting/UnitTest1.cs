using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarJack;

namespace CarJackFunctions_UnitTest
{
    [TestClass]
    public class UnitTest1 : CarJackFunctions
    {

        [TestMethod]
        public void CreditValue_ReturnBad()
        {
            string expected = "bad";
            Assert.AreEqual(expected, CreditValue(501));
        }
        [TestMethod]
        public void CreditValue_ReturnBelowAverage()
        {
            string expected = "belowAverage";
            Assert.AreEqual(expected, CreditValue(600));
        }
        [TestMethod]
        public void CreditValue_ReturnOkay()
        {
            string expected = "okay";
            Assert.AreEqual(expected, CreditValue(637));
        }
        [TestMethod]
        public void CreditValue_ReturnFair()
        {
            string expected = "fair";
            Assert.AreEqual(expected, CreditValue(672));
        }
        [TestMethod]
        public void CreditValue_ReturnGood()
        {
            string expected = "good";
            Assert.AreEqual(expected, CreditValue(715));
        }
        [TestMethod]
        public void CreditValue_ReturnGreat()
        {
            string expected = "great";
            Assert.AreEqual(expected, CreditValue(730));
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

    }
}
