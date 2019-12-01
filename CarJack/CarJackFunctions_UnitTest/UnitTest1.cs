using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarJack;

namespace CarJackFunctions_UnitTest
{
    [TestClass]
    public class UnitTest1 : CarJackFunctions
    {
        [TestMethod]
        public void CheckForBlankBoxes_BlankFound()
        {
            // line 574 private static bool CheckForBlankBoxes(string inputText)
            Assert.IsTrue(CheckForBlankBoxes(""));
        }
        [TestMethod]
        public void CheckForBlankBoxes_BlankNotFound()
        {
            Assert.IsFalse(CheckForBlankBoxes("_"));
        }
    }
}
