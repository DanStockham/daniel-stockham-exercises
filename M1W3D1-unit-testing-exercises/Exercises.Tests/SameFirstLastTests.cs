using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /// <summary>
    /// Summary description for SameFirstLastTests
    /// </summary>
    [TestClass]
    public class SameFirstLastTests
    {
        public SameFirstLastTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SameFirstLastTest()
        {
            SameFirstLast newStr = new SameFirstLast();

            Assert.AreEqual(true, newStr.IsItTheSame(new int[] { 1, 2, 3, 1}));
            Assert.AreEqual(false, newStr.IsItTheSame(new int[] { 2, 4, 3, 1 }));
            Assert.AreEqual(true, newStr.IsItTheSame(new int[] { 5, 3, 2, 5 }));

        }
    }
}
