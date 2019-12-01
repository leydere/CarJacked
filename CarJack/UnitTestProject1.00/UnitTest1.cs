using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarJack;

namespace UnitTestProject1._00
{
    [TestClass]
    public class UnitTest1 : MainWindow
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
