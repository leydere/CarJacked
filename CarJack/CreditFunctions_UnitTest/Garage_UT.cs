using CarJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditFunctions_UnitTest
{
    [TestClass]
    public class Garage_UT : GarageFunctions
    {
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
