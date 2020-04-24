using CarJack;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditFunctions_UnitTest
{
    [TestClass]
    public class Math_UT : ActivityMath
    {
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
