using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        public void ConvertToRomanNumeralTest() {
            KataRomanNumerals testRomanNum = new KataRomanNumerals();

            Assert.AreEqual("A true roman doesn't know the concept of zero", testRomanNum.ConvertToRomanNumeral(0));
            Assert.AreEqual("A true roman never counts past 3000", testRomanNum.ConvertToRomanNumeral(3001));
            Assert.AreEqual("MMM", testRomanNum.ConvertToRomanNumeral(3000));
            Assert.AreEqual("MMDCCLXXXVI", testRomanNum.ConvertToRomanNumeral(2786));
            Assert.AreEqual("MCDXLVIII", testRomanNum.ConvertToRomanNumeral(1448));
            
        }

        [TestMethod]
        public void ConvertToDigitTest()
        {
            KataRomanNumerals testRomanNum = new KataRomanNumerals();

            Assert.AreEqual(891, testRomanNum.ConvertToDigit("DCCCXCI"));
            Assert.AreEqual(448, testRomanNum.ConvertToDigit("CDXLVIII"));
            Assert.AreEqual(3567, testRomanNum.ConvertToDigit("MMMDLXVII"));
            Assert.AreEqual(204, testRomanNum.ConvertToDigit("CCIV"));
            Assert.AreEqual(1990, testRomanNum.ConvertToDigit("MCMXC"));

        }


    }
}
