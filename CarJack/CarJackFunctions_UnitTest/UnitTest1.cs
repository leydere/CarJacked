using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarJack;

namespace CarJackFunctions_UnitTest
{
    [TestClass]
    public class UnitTest1
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
        public void CheckForInput()
        {
                 

        }
    }
    [TestClass]

    public class LongevityCalculatorTest
    {
        [TestMethod]

        public void LongevityityCalculate_Scenario_ExpectedBehavior()
        {
                   
        }
    }
}
